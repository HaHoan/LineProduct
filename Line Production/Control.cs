using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Line_Production.Database;
using Line_Production.Entities;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic
namespace Line_Production
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        private PVSReference.PVSWebServiceSoapClient pvsservice;
        private USAPReference.USAPWebServiceSoapClient usapservice = new USAPReference.USAPWebServiceSoapClient();
        private LineProductWebServiceReference.LineProductRealtimeWebServiceSoapClient _lineproduct_service = new LineProductWebServiceReference.LineProductRealtimeWebServiceSoapClient();
        private LineProductWebServiceReference.tbl_Product_RealtimeEntity _entity = new LineProductWebServiceReference.tbl_Product_RealtimeEntity();
        private DateTime time_scanBarcode;
        private int bien_dem = 0;
        private bool useWip = true;
        private int _index = 0;

        public void FormatNgayCasx()
        {
            CheckCaSX();
            if (Shiftcheck == true)
            {
                Datecheck = DateAndTime.Now.Date.ToString("dd-MM-yyyy");
            }
            else if (DateAndTime.Now.Hour >= 0 & DateAndTime.Now.Hour <= 7)
            {
                if (DateAndTime.Now.Day > 1)
                {
                    Datecheck = (DateAndTime.Now.Day - 1).ToString().PadLeft(2, '0') + "-" + DateAndTime.Now.Month.ToString().PadLeft(2, '0') + "-" + DateAndTime.Now.Year;
                }
                else
                {
                    switch (DateAndTime.Now.Month - 1)
                    {
                        case 1:
                            {
                                Datecheck = DateAndTime.Now.Year - 1 + "1231";
                                break;
                            }

                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            {
                                Datecheck = "31-" + (DateAndTime.Now.Month - 1).ToString().PadLeft(2, '0') + "-" + DateAndTime.Now.Year;
                                break;
                            }

                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            {
                                Datecheck = "30-" + (DateAndTime.Now.Month - 1).ToString().PadLeft(2, '0') + "-" + DateAndTime.Now.Year;
                                break;
                            }

                        case 2:
                            {
                                if (DateAndTime.Now.Year % 4 == 0 & DateAndTime.Now.Year % 100 != 0 | DateAndTime.Now.Year % 400 == 0)
                                {
                                    Datecheck = "29-02" + DateAndTime.Now.Year;
                                }
                                else
                                {
                                    Datecheck = "28-02" + DateAndTime.Now.Year;
                                }

                                break;
                            }
                    }
                }
            }
            else
            {
                Datecheck = DateAndTime.Now.Date.ToString("dd-MM-yyyy");
            }

            txtDate.Text = Datecheck;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loadsetting();
            // Me.Height = 885

        }

        public void SetupDisplay()
        {
            if (ComControlPort.IsOpen == true)
            {
                if (ComControlPort.IsOpen == true)
                    ComControlPort.WriteLine("S0000000000000R");
                if (ComControlPort.IsOpen == true)
                    ComControlPort.Write("C");
            }

            cbbModel.Enabled = true;
            cbbModel.Text = "";
            for (int index = 1; index <= 10; index++)
            {
                Table1.Controls.Find("TextTime" + index, true)[0].Text = "";
                Table1.Controls.Find("TextPlan" + index, true)[0].Text = "";
                Table1.Controls.Find("TextActual" + index, true)[0].Text = "";
                Table1.Controls.Find("TextBalance" + index, true)[0].Text = "";
                Table1.Controls.Find("TextComment" + index, true)[0].Text = "";
                notePerHour[index] = "";
            }

            lblComcontrol.Text = ComControlPort.PortName;
            lblState.Text = ComControlPort.IsOpen ? "Open" : "Close";
            // lblUser.Text = Environment.UserName
            chkNG.Enabled = false;
            // Copyright.Text = My.Application.Info.Copyright.ToString
            // Me.Text = My.Application.Info.Title.ToString & "_" & My.Application.Info.Version.ToString
            lblVersion.Text = GetRunningVersion();
            TextCycleTimeCurrent.Text = "0";
            TextCycleTimeModel.Text = "0";
            txtShift.Clear();
            txtDate.Clear();
            PauseProduct = false;
            StartProduct = false;
            StatusLine = 0;
            CountProduct = 0;
            ProductPlan = 0;
            TimeCycleActual = 0;
            LabelPCBA.Text = "0";
            LabelSoThung.Text = "0";
            LabelPCS1BOX.Text = "0";
            IDCount = 0;
            IDCount_box = 0;
            MacCurrent = "";
            for (int index = 1; index <= 9; index++)
                CountProductPerHour[index] = 0;
            NoPeople = 0;
            ModelCurrent = "";
            btDTle.Visible = false;
            Shape2.Visible = false;
            Shape1.Visible = false;
            Shape3.Visible = false;
            LabelShapeOnline.Visible = false;
            LabelShapeOffLine.Visible = false;
            LabelShapeError.Visible = false;
            Timer1.Enabled = true;
            TextMacBox.Text = "";
            txtSerial.Text = "";
            TextMacBox.Enabled = false;
            txtSerial.Enabled = false;
            TextCycleTimeCurrent.Text = "0";
            txtPeople.Text = "0";
            txtPlan.Text = "0";
            txtActual.Text = "0";
            TextBalance.Text = "0";
            CountProduct = 0;
            lblQuantity.Text = CountProduct.ToString();
            txtShift.Text = "";
            BtStart.Enabled = false;
            BtStop.Enabled = false;
            BtStart.Text = "Bắt đầu";
            BtStart.Image = Properties.Resources.play;
            try
            {
                useWip = bool.Parse(Common.GetValueRegistryKey(PathConfig, "useWip"));
            }
            catch { }

            // quyetpham add 16/9
            CheckBox1.Enabled = false;
            txtConfirm.Text = "";
            txtConfirm.Enabled = false;
            chkOK.Checked = true;
        }

        private void Loadsetting()
        {
            if (CheckComControlPort() == true)
            {
                if (CheckModelList() == true)
                {
                    SaveInit();
                    Init();
                    SetupDisplay();
                }
                else
                {
                    MessageBox.Show("File Setup List Model Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }

        }

        public void LoadProduction()
        {
            string fileload = PathPassrate + @"\" + ModelCurrent + @"\" + Datecheck + "_" + Shiftcheck + ".txt";
            string FolderLoad = PathPassrate + @"\" + ModelCurrent;
            if (Directory.Exists(FolderLoad) == false)
                Directory.CreateDirectory(FolderLoad);
            if (File.Exists(fileload) == true)
            {
                ProductPlanBegin = int.Parse(ReadTextFile(fileload, 2));
                ProductPlan = int.Parse(ReadTextFile(fileload, 2));
                CountProduct = int.Parse(ReadTextFile(fileload, 4));
                IDCount = 0;
                IDCount_box = 0;
                Box_curent = "";
                TimeCycleActual = int.Parse(ReadTextFile(fileload, 32));
                for (int index = 1; index <= 10; index++)
                {
                    CountProductPerHour[index] = int.Parse(ReadTextFile(fileload, 2 * (index + 2)));
                    notePerHour[index] = ReadTextFile(fileload, 32 + index);
                }
            }
            else
            {
                FilePassrate = fileload;
                for (int index = 1; index <= 10; index++)
                {
                    CountProductPerHour[index] = 0;
                    notePerHour[index] = "";
                }

                var text_passrate = new StreamWriter(FilePassrate);
                text_passrate.WriteLine("# 1 Plan");
                text_passrate.WriteLine(ProductPlan);
                text_passrate.WriteLine("#2 Actual");
                text_passrate.WriteLine(CountProduct);
                text_passrate.WriteLine("# 3 Production In Time 1 8>9");
                text_passrate.WriteLine(0);
                text_passrate.WriteLine("# 4 Production In Time 2 9>10");
                text_passrate.WriteLine(0);
                text_passrate.WriteLine("# 5 Production In Time 3	10>11");
                text_passrate.WriteLine(0);
                text_passrate.WriteLine("# 6 Production In Time 4	11>12");
                text_passrate.WriteLine(0);
                text_passrate.WriteLine("# 7 Production In Time 5	12>13");
                text_passrate.WriteLine(0);
                text_passrate.WriteLine("# 8 Production In Time 6	13>14");
                text_passrate.WriteLine(0);
                text_passrate.WriteLine("# 9 Production In Time 7	14>15");
                text_passrate.WriteLine(0);
                text_passrate.WriteLine("# 10 Production In Time 8	15>16");
                text_passrate.WriteLine(0);
                text_passrate.WriteLine("# 11 Production In Time 9	16>17");
                text_passrate.WriteLine(0);
                text_passrate.WriteLine("# 12 Production In Time 10	17>20");
                text_passrate.WriteLine(0);
                text_passrate.WriteLine("# 13 so luong mach hien tai");
                text_passrate.WriteLine(IDCount);
                text_passrate.WriteLine("# 14 so luong thung hien tai");
                text_passrate.WriteLine(IDCount_box);
                text_passrate.WriteLine("# 15 ma thung hien tai");
                text_passrate.WriteLine(Box_curent);
                text_passrate.WriteLine("# 16 CycleTime hien tai");
                text_passrate.WriteLine(TimeCycleActual);
                for (int i = 1; i <= 10; i++)
                    text_passrate.WriteLine("");
                text_passrate.Close();
            }

            string FileReport = PathReport + @"\" + ModelCurrent + @"\" + Datecheck + ".csv";
            if (Directory.Exists(PathReport + @"\" + ModelCurrent) == false)
                Directory.CreateDirectory(PathReport + @"\" + ModelCurrent);
            if (File.Exists(FileReport) == false)
            {
                var file = new StreamWriter(FileReport, true); // append enable
                file.WriteLine("No,Time,NoPCBA,MAC Box,Id PCBA,User");
                file.Close();
            }
            // RecordDatabase()
        }

        public void RecordProduction()
        {
            if (ModelCurrent != "")
            {
                string fileload = PathPassrate + @"\" + ModelCurrent + @"\" + Datecheck + "_" + Shiftcheck + ".txt";
                if (File.Exists(fileload) == true)
                {
                    ReplaceLine(fileload, 2, ProductPlan.ToString());
                    ReplaceLine(fileload, 4, CountProduct.ToString());
                    ReplaceLine(fileload, 26, IDCount.ToString());
                    ReplaceLine(fileload, 28, IDCount_box.ToString());
                    ReplaceLine(fileload, 30, Box_curent);
                    ReplaceLine(fileload, 32, TimeCycleActual.ToString());
                    for (int index = 1; index <= 10; index++)
                    {
                        ReplaceLine(fileload, 2 * (index + 2), CountProductPerHour[index].ToString());
                        ReplaceLine(fileload, 32 + index, Table1.Controls.Find("TextComment" + index, true)[0].Text);
                    }
                }
                else
                {
                    FilePassrate = fileload;
                    var text_passrate = new StreamWriter(FilePassrate);
                    text_passrate.WriteLine("# 1 Plan");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("#2 Actual");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("# 3 Production In Time 1 8>9");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("# 4 Production In Time 2 9>10");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("# 5 Production In Time 3	10>11");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("# 6 Production In Time 4	11>12");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("# 7 Production In Time 5	12>13");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("# 8 Production In Time 6	13>14");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("# 9 Production In Time 7	14>15");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("# 10 Production In Time 8	15>16");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("# 11 Production In Time 9	16>17");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("# 12 Production In Time 10	17>20");
                    text_passrate.WriteLine(0);
                    text_passrate.WriteLine("# 13 so luong mach hien tai");
                    text_passrate.WriteLine(IDCount);
                    text_passrate.WriteLine("# 14 so luong thung hien tai");
                    text_passrate.WriteLine(IDCount_box);
                    text_passrate.WriteLine("# 15 ma thung hien tai");
                    text_passrate.WriteLine(Box_curent);
                    text_passrate.WriteLine("# 16 CycleTime hien tai");
                    text_passrate.WriteLine(TimeCycleActual);
                    for (int i = 1; i <= 10; i++)
                        text_passrate.WriteLine("");
                    text_passrate.Close();
                }
            }
        }

        private void ComboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbModel.Text != "")
            {
                Schedule schedule = new Schedule();
                schedule.ShowInTaskbar = false;
                schedule.updateTotal = new Action<string>(m =>
                {
                    lblTotal.Text = m;
                });
                schedule.ShowDialog();

                LabelPCBA.Text = "0";
                ModelCurrent = cbbModel.Text;
                if (LoadModelCurrent(ModelCurrent) == true)
                {
                    cbbModel.Enabled = false;
                    TextCycleTimeModel.Text = CycleTimeModel.ToString();
                    TextCycleTimeCurrent.Text = "";
                    txtPeople.Text = NoPeople.ToString();

                    FormatNgayCasx();
                    BtStart.Enabled = true;
                    BtStop.Enabled = true;
                    // quyetpham add 16/9

                    CheckBox1.Enabled = false;
                    CheckBox1.Checked = true;
                    LoadProduction();
                    txtPlan.Text = Math.Round(TimeCycleActual / CycleTimeModel, 0, MidpointRounding.AwayFromZero).ToString(); // ProductPlanBegin.ToString()
                    txtActual.Text = CountProduct.ToString();
                    TextBalance.Text = Math.Abs(CountProduct - ProductPlanBegin).ToString();
                    lblQuantity.Text = CountProduct.ToString();
                    TextCycleTimeCurrent.Text = Math.Round((double)TimeCycleActual / CountProduct, 1, MidpointRounding.AwayFromZero).ToString();
                    if (CheckCaSX() == true)
                    {
                        txtShift.Text = "Ca Ngày";
                        for (int index = 1; index <= 10; index++)
                        {
                            Table1.Controls.Find("TextComment" + index, true)[0].Text = notePerHour[index];
                            Table1.Controls.Find("TextTime" + index, true)[0].Text = TimeLine[1 + 2 * (index - 1)].Hour + ":" + TimeLine[1 + 2 * (index - 1)].Minute + ":" + TimeLine[1 + 2 * (index - 1)].Second + ">" + TimeLine[2 + 2 * (index - 1)].Hour + ":" + TimeLine[2 + 2 * (index - 1)].Minute + ":" + TimeLine[2 + 2 * (index - 1)].Second;
                            Table1.Controls.Find("TextPlan" + index, true)[0].Text = Strings.Format(((TimeLine[2 + 2 * (index - 1)].Hour - TimeLine[1 + 2 * (index - 1)].Hour) * 3600 + (TimeLine[2 + 2 * (index - 1)].Minute - TimeLine[1 + 2 * (index - 1)].Minute) * 60 + (TimeLine[2 + 2 * (index - 1)].Second - TimeLine[1 + 2 * (index - 1)].Second)) / CycleTimeModel, "0");
                            if (CountProductPerHour[index] > 0)
                            {
                                Table1.Controls.Find("TextActual" + index, true)[0].Text = CountProductPerHour[index].ToString();
                                Table1.Controls.Find("TextBalance" + index, true)[0].Text = (int.Parse(Table1.Controls.Find("TextActual" + index, true)[0].Text) - int.Parse(Table1.Controls.Find("TextPlan" + index, true)[0].Text)).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtShift.Text = "Ca Đêm";
                        for (int index = 1; index <= 10; index++)
                        {
                            Table1.Controls.Find("TextComment" + index, true)[0].Text = notePerHour[index];
                            Table1.Controls.Find("TextTime" + index, true)[0].Text = TimeLine[1 + 2 * (index - 1)].Hour + ":" + TimeLine[1 + 2 * (index - 1)].Minute + ":" + TimeLine[1 + 2 * (index - 1)].Second + ">" + TimeLine[2 + 2 * (index - 1)].Hour + ":" + TimeLine[2 + 2 * (index - 1)].Minute + ":" + TimeLine[2 + 2 * (index - 1)].Second;
                            Table1.Controls.Find("TextPlan" + index, true)[0].Text = Strings.Format(((TimeLine[2 + 2 * (index - 1)].Hour - TimeLine[1 + 2 * (index - 1)].Hour) * 3600 + (TimeLine[2 + 2 * (index - 1)].Minute - TimeLine[1 + 2 * (index - 1)].Minute) * 60 + (TimeLine[2 + 2 * (index - 1)].Second - TimeLine[1 + 2 * (index - 1)].Second)) / CycleTimeModel, "0");
                            if (CountProductPerHour[index] > 0)
                            {
                                Table1.Controls.Find("TextActual" + index, true)[0].Text = CountProductPerHour[index].ToString();
                                Table1.Controls.Find("TextBalance" + index, true)[0].Text = Strings.Format(((TimeLine[2 + 2 * (index - 1)].Hour - TimeLine[1 + 2 * (index - 1)].Hour) * 3600 + (TimeLine[2 + 2 * (index - 1)].Minute - TimeLine[1 + 2 * (index - 1)].Minute) * 60 + (TimeLine[2 + 2 * (index - 1)].Second - TimeLine[1 + 2 * (index - 1)].Second)) / CycleTimeModel, "0");
                            }
                        }
                    }
                }
            }
        }

        public void ShowStatus(int value, bool VisibleShow)
        {
            switch (value)
            {
                case 0:
                    {

                        // LabelStatus.Text = "Tình trạng Line:       "
                        LabelShapeOnline.Visible = false;
                        LabelShapeOffLine.Visible = false;
                        LabelShapeError.Visible = false;
                        Shape1.Visible = false;
                        Shape2.Visible = false;
                        Shape3.Visible = false;
                        break;
                    }

                case 1:
                    {
                        // LabelStatus.Text = "Tình trạng Line:Online"
                        LabelShapeOnline.Visible = VisibleShow;
                        LabelShapeOffLine.Visible = false;
                        LabelShapeError.Visible = false;
                        Shape1.Visible = VisibleShow;
                        if (VisibleShow == false)
                        {
                            if (ComControlPort.IsOpen == true)
                                ComControlPort.Write("R");
                        }
                        else if (ComControlPort.IsOpen == true)
                            ComControlPort.Write("X");
                        Shape2.Visible = false;
                        Shape3.Visible = false;
                        break;
                    }

                case 2:
                    {
                        // LabelStatus.Text = "Tình trạng Line: Bao Dong"
                        LabelShapeOnline.Visible = false;
                        LabelShapeOffLine.Visible = VisibleShow;
                        LabelShapeError.Visible = false;
                        Shape1.Visible = false;
                        Shape2.Visible = VisibleShow;
                        if (VisibleShow == false)
                        {
                            if (ComControlPort.IsOpen == true)
                                ComControlPort.Write("R");
                        }
                        else if (ComControlPort.IsOpen == true)
                            ComControlPort.Write("V");
                        Shape3.Visible = false;
                        break;
                    }

                case 3:
                    {
                        // LabelStatus.Text = "Tình trạng Line: Bat Thuong"
                        LabelShapeOnline.Visible = false;
                        LabelShapeOffLine.Visible = false;
                        LabelShapeError.Visible = VisibleShow;
                        Shape1.Visible = false;
                        Shape2.Visible = false;
                        Shape3.Visible = VisibleShow;
                        if (VisibleShow == false)
                        {
                            if (ComControlPort.IsOpen == true)
                                ComControlPort.Write("R");
                        }
                        else if (ComControlPort.IsOpen == true)
                            ComControlPort.Write("D");
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            cbbModel.Enabled = false;
            LabelShapeOnline.Visible = true;
            LabelShapeOffLine.Visible = false;
            LabelShapeError.Visible = false;
            btDTle.Visible = false;
            Shape1.Visible = false;
            Shape2.Visible = false;
            Shape3.Visible = false;
            // quyetpham add 16/9
            CheckBox1.Enabled = true;
            chkNG.Enabled = true;
            if (BtStart.Text == "Bắt đầu")
            {
                PauseProduct = false;
                StartProduct = true;
                TextMacBox.Enabled = true;
                // GroupBox3.Controls("Shape" & StatusLine).Visible = True
                BtStart.Text = "Online";
                BtStart.Image = Properties.Resources.pause;
                int sumtime = DateAndTime.Now.Hour * 100 + DateAndTime.Now.Minute;
                if (StatusLine == 0)
                {
                    StatusLine = 1;
                    // LabelStatus.Text = "Tình trạng Line: Online"
                    ShowStatus(StatusLine, true);
                    for (int index = 1; index <= 20; index++)
                    {
                        if (index % 2 != 0 & sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                        {
                            time_scanBarcode = DateAndTime.Now;
                            TimeLine[index] = new DateTime(DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, DateAndTime.Now.Hour, DateAndTime.Now.Minute, DateAndTime.Now.Second);
                            Table1.Controls.Find("TextTime" + (index / 2 + 1), true)[0].Text = TimeLine[index].Hour + ":" + TimeLine[index].Minute + ":" + TimeLine[index].Second + ">" + TimeLine[index + 1].Hour + ":" + TimeLine[index + 1].Minute + ":" + TimeLine[index + 1].Second;
                            Table1.Controls.Find("TextPlan" + (index / 2 + 1), true)[0].Text = Strings.Format(((TimeLine[index + 1].Hour - TimeLine[index].Hour) * 3600 + (TimeLine[index + 1].Minute - TimeLine[index].Minute) * 60 + (TimeLine[index + 1].Second - TimeLine[index].Second)) / CycleTimeModel + CountProductPerHour[index / 2 + 1], "0");
                            // TextPlan.Text = Table1.Controls("TextPlan" & (index \ 2) + 1).Text
                            // TextPlan.Text = ProductPlanBegin.ToString()
                            txtActual.Text = CountProduct.ToString();
                            break;
                        }
                    }
                }
                else
                {
                    // LabelStatus.Text = "Tình trạng Line: Online"
                    PauseProduct = false;
                    StartProduct = true;
                    ShowStatus(StatusLine, true);
                    for (int index = 1; index <= 20; index++)
                    {
                        if (index % 2 != 0 & sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                        {
                            Table1.Controls.Find("TextTime" + (index / 2 + 1), true)[0].Text = TimeLine[index].Hour + ":" + TimeLine[index].Minute + ":" + TimeLine[index].Second + ">" + TimeLine[index + 1].Hour + ":" + TimeLine[index + 1].Minute + ":" + TimeLine[index + 1].Second;
                            Table1.Controls.Find("TextPlan" + (index / 2 + 1), true)[0].Text = Strings.Format(((TimeLine[index + 1].Hour - TimeLine[index].Hour) * 3600 + (TimeLine[index + 1].Minute - TimeLine[index].Minute) * 60 + (TimeLine[index + 1].Second - TimeLine[index].Second)) / CycleTimeModel + CountProductPerHour[index / 2 + 1], "0");
                            break;
                        }
                    }

                    TimePauseLine = 0;
                }

                time_scanBarcode = DateAndTime.Now;
                ProductPlan = (int)Math.Round(TimeCycleActual / CycleTimeModel, 0, MidpointRounding.AwayFromZero);
                txtPlan.Text = ProductPlan.ToString();
            }
            TextMacBox.Enabled = true;
            TextMacBox.Focus();

        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            var ett = new LineProductWebServiceReference.tbl_Product_RealtimeEntity()
            {
                CUSTOMER = "CANON",
                LINE_NO = IdLine,
                MODEL = cbbModel.Text,
                QTY_PLAN = ProductPlan,
                QTY_ACTUAL = CountProduct,
                UPDATE_TIME = DateTime.Now.Date,
                PEOPLE = NoPeople,
                CYRCLETIME_PLAN = (decimal)CycleTimeModel,
                CYRCLETIME_ACTUAL = (decimal)CycleTimeActual,
                DIFF = BalanceProduction,
                ALARM = StatusLine,
                STATUS = "STOP"
            };
            _lineproduct_service.UpdateRealtime(ett);
            // Repository.UpdatateData(entities)
            SetupDisplay();
        }


        public void IncreaseProduct()
        {
            if (StartProduct == true)
            {
                for (int i = 1; i <= 10; i++)
                    notePerHour[i] = Table1.Controls.Find("TextComment" + i, true)[0].Text;
                int sumtime = DateAndTime.Now.Hour * 100 + DateAndTime.Now.Minute;
                for (int index = 1; index <= 20; index++)
                {
                    if (index % 2 != 0 & sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                    {
                        // CountProduct = CountProduct + 1
                        bien_dem = bien_dem + 1;
                        // If CountProduct = 1 Then
                        // CycleTimeActual = CalTimeWork(time_scanBarcode, Now)
                        // Else
                        // TimeCycleActual = TimeCycleActual + CalTimeWork(time_scanBarcode, Now)
                        // CycleTimeActual = Math.Round(TimeCycleActual / CountProduct, 1, MidpointRounding.AwayFromZero)
                        // End If
                        // time_scanBarcode = Now
                        // TextCycleTimeCurrent.Text = CycleTimeActual
                        // LabelCountProduct.Text = CountProduct
                        // ProductPlan = Math.Round(TimeCycleActual / CycleTimeModel, 0, MidpointRounding.AwayFromZero)
                        // TextPlan.Text = ProductPlan
                        CountProductPerHour[index / 2 + 1] = CountProductPerHour[index / 2 + 1] + 1;
                        Table1.Controls.Find("TextActual" + (index / 2 + 1), true)[0].Text = CountProductPerHour[index / 2 + 1].ToString();
                        Table1.Controls.Find("TextBalance" + (index / 2 + 1), true)[0].Text = (CountProductPerHour[index / 2 + 1] - int.Parse(Table1.Controls.Find("TextPlan" + (index / 2 + 1), true)[0].Text)).ToString();
                        _index = (int)((index + 1) / 2d);
                        break;
                    }
                    else
                    {
                        bien_dem = 0;
                    }
                }

                if (bien_dem != 0)
                {
                    CountProduct = CountProduct + 1;
                    if (CountProduct == 1)
                    {
                        CycleTimeActual = (DateAndTime.Now - time_scanBarcode).TotalSeconds; // CalTimeWork(time_scanBarcode, Now) 
                    }
                    else
                    {
                        TimeCycleActual = (int)(TimeCycleActual + (DateAndTime.Now - time_scanBarcode).TotalSeconds); // CalTimeWork(time_scanBarcode, Now)
                        CycleTimeActual = Math.Round((double)TimeCycleActual / CountProduct, 1, MidpointRounding.AwayFromZero);
                    }

                    time_scanBarcode = DateAndTime.Now;
                    TextCycleTimeCurrent.Text = CycleTimeActual.ToString();
                    lblQuantity.Text = CountProduct.ToString();
                    ProductPlan = (int)Math.Round((double)TimeCycleActual / CycleTimeModel, 0, MidpointRounding.AwayFromZero);
                    txtPlan.Text = ProductPlan.ToString();
                    time_scanBarcode = DateAndTime.Now;
                }

                RecordProduction();
            }
        }

        public void ReduceProduct()
        {
            if (StartProduct == true & CountProduct > 0)
            {
                int sumtime = DateAndTime.Now.Hour * 100 + DateAndTime.Now.Minute;
                for (int index = 1; index <= 20; index++)
                {
                    if (index % 2 != 0 & sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                    {
                        CountProduct = CountProduct - 1;
                        lblQuantity.Text = CountProduct.ToString();
                        CountProductPerHour[index / 2 + 1] = CountProductPerHour[index / 2 + 1] - 1;
                        Table1.Controls.Find("TextActual" + (index / 2 + 1), true)[0].Text = CountProductPerHour[index / 2 + 1].ToString();
                        Table1.Controls.Find("TextBalance" + (index / 2 + 1), true)[0].Text = (CountProductPerHour[index / 2 + 1] - int.Parse(Table1.Controls.Find("TextPlan" + (index / 2 + 1), true)[0].Text)).ToString();
                        break;
                    }
                }

                RecordProduction();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabelTimeDate.Text = DateAndTime.Now.ToString("HH:mm:ss  dd/MM/yyyy");
            lblDate.Text = DateAndTime.Now.ToLongTimeString();
            // TimerPress.Enabled = True
            if (BtStart.Text != "Bắt đầu")
            {
                int sumtime = DateAndTime.Now.Hour * 100 + DateAndTime.Now.Minute;
                for (int index = 1; index <= 20; index++)
                {
                    if (index % 2 != 0)
                    {
                        if (sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                        {
                            // ProductPlan = Int(((Val(Now.Hour - TimeLine(index).Hour)) * 3600 + (Val(Now.Minute - TimeLine(index).Minute)) * 60 + (Val(Now.Second - TimeLine(index).Second))) / CycleTimeModel) + ProductPlanBegin
                            bien_dem = bien_dem + 1;
                            PauseProduct = false;
                            break;
                        }
                        else
                        {
                            bien_dem = 0;
                        }
                    }
                    else if (index == 20)
                    {
                        // ProductPlanBegin = ProductPlan
                        PauseProduct = true;
                    }
                }

                if (bien_dem == 0)
                {
                    time_scanBarcode = DateAndTime.Now;
                }


                // If BarcodeEnable = True Then TextSerial.Focus()
                BalanceProduction = CountProduct - ProductPlan;
                //int perBalanceProduction = 0;
                //if (ProductPlan != 0)
                //{
                //    perBalanceProduction = ProductPlan == 0 ? 0 : BalanceProduction / ProductPlan * 100;
                //}
                var perBalanceProduction = ProductPlan == 0 ? 0 : BalanceProduction * 100 / ProductPlan;
                // Console.WriteLine("perBanlanceProduction: {0}, BalanceErrorSetup: {1}, BalanceAlarmSetup: {2}", perBalanceProduction, BalanceErrorSetup, BalanceAlarmSetup)
                if (perBalanceProduction < BalanceErrorSetup)
                {
                    StatusLine = 3;
                    ShowStatus(StatusLine, true);
                }
                else if (perBalanceProduction < BalanceAlarmSetup)
                {
                    StatusLine = 2;
                    ShowStatus(StatusLine, true);
                }
                else
                {
                    StatusLine = 1;
                    ShowStatus(StatusLine, true);
                }

                if (PauseProduct == true)
                {
                    // TimePauseLine = TimePauseLine + 1
                    // If TimePauseLine Mod 2 = 0 Then
                    // ShowStatus(StatusLine, True)
                    // TimePauseLine = 0
                    // Else
                    // ShowStatus(StatusLine, False)
                    // End If
                    Timer2.Enabled = true;
                }
                else
                {
                    Timer2.Enabled = false;
                }

                txtPlan.Text = ProductPlan.ToString();
                txtActual.Text = CountProduct.ToString();
                TextBalance.Text = BalanceProduction.ToString();
                // MsgBox(Format(BalanceProduction, "0000"))

                // If BalanceProduction < 0 Then
                // If Math.Abs(BalanceProduction) >= 1000 Then
                // ArraySend = "S-" & Format(999, "000") & Format(CountProduct, "0000") & Format(ProductPlan, "0000") & Format(NoPeople, "00") & "*"
                // Else
                // ArraySend = "S" & Format(BalanceProduction, "000") & Format(CountProduct, "0000") & Format(ProductPlan, "0000") & Format(NoPeople, "00") & "*"
                // End If

                // Else
                // ArraySend = "S+" & Format(BalanceProduction, "000") & Format(CountProduct, "0000") & Format(ProductPlan, "0000") & Format(NoPeople, "00") & "*"
                // End If
                int total = 0;
                try
                {
                    total = int.Parse(lblTotal.Text);
                }
                catch { }
                if (BalanceProduction < 0)
                {
                    if (Math.Abs(BalanceProduction) >= 1000)
                    {
                        ArraySend = "S-" + Strings.Format(999, "000") + Strings.Format(CountProduct, "0000") + Strings.Format(total, "0000") + Strings.Format(NoPeople, "00") + "*";
                    }
                    else
                    {
                        ArraySend = "S" + Strings.Format(BalanceProduction, "000") + Strings.Format(CountProduct, "0000") + Strings.Format(total, "0000") + Strings.Format(NoPeople, "00") + "*";
                    }
                }
                else
                {
                    ArraySend = "S+" + Strings.Format(BalanceProduction, "000") + Strings.Format(CountProduct, "0000") + Strings.Format(total, "0000") + Strings.Format(NoPeople, "00") + "*";
                }
                // Console.WriteLine(ArraySend)
                var entity = new Online()
                {
                    LineID = IdLine,
                    ModelID = cbbModel.Text,
                    Plan = ProductPlan,
                    Actual = CountProduct,
                    _Date = DateTime.Now.Date
                };
                var entities = new LineProductWebServiceReference.tbl_Product_RealtimeEntity()
                {
                    CUSTOMER = "CANON",
                    LINE_NO = IdLine,
                    MODEL = cbbModel.Text,
                    QTY_PLAN = ProductPlan,
                    QTY_ACTUAL = CountProduct,
                    UPDATE_TIME = DateTime.Now.Date,
                    PEOPLE = NoPeople,
                    CYRCLETIME_PLAN = (decimal)CycleTimeModel,
                    CYRCLETIME_ACTUAL = (decimal)CycleTimeActual,
                    DIFF = BalanceProduction,
                    ALARM = StatusLine,
                    STATUS = "RUNNING"
                };
                // Repository.UpdatateData(entities)
                _lineproduct_service.UpdateRealtime(entities);
                if (ComControlPort.IsOpen == true)
                    ComControlPort.WriteLine(ArraySend);
                // RecordDatabase()
            }
        }

        private void BtIncrease_Click(object sender, EventArgs e)
        {
            IncreaseProduct();
        }

        private void BtReduce_Click(object sender, EventArgs e)
        {
            ReduceProduct();
        }

        private void Control_FormClosed(object sender, FormClosedEventArgs e)
        {
            RecordProduction();
            SetupDisplay();
            Application.Exit();
        }

        public bool CheckIDExistEx(string Idcheck)
        {
            string FileReport = PathReport + @"\" + ModelCurrent + @"\" + Datecheck + ".csv";
            if (Directory.Exists(PathReport + @"\" + ModelCurrent) == false)
                Directory.CreateDirectory(PathReport + @"\" + ModelCurrent);
            string astring = ReadAllLine(FileReport);
            if (!string.IsNullOrEmpty(astring))
            {
                if (astring.Contains(Idcheck) == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        // Kiểm tra xem thùng đã đầy chưa

        public bool CheckMacBox(string Idcheck)
        {
            string FileReport = PathReport + @"\" + ModelCurrent + @"\" + Datecheck + ".csv";
            if (Directory.Exists(PathReport + @"\" + ModelCurrent) == false)
                Directory.CreateDirectory(PathReport + @"\" + ModelCurrent);
            string astring = ReadAllLine(FileReport);
            if (!string.IsNullOrEmpty(astring))
            {
                if (astring.Contains(Idcheck) == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private void TextSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Repository = New Repository
            pvsservice = new PVSReference.PVSWebServiceSoapClient();
            if (e.KeyChar == 13)
            {
                // txtSerial.Text = txtSerial.Text.TrimStart.TrimEnd()
                if (txtSerial.TextLength == IdCodeLenght)
                {
                    if (Strings.Mid(txtSerial.Text, ModelRevPosition, ModelRev.Length) == ModelRev)
                    {
                        if (PauseProduct == false)
                        {
                            if (chkNG.Checked)
                            {
                                var content = new StringBuilder();
                                // Dim sTime As String = DateTime.Now.ToString("yyMMddHHmmss")
                                string sTime = pvsservice.GetDateTime().ToString("yyMMddHHmmss");
                                content.AppendLine(string.Join("|", cbbModel.Text, txtSerial.Text, sTime, State.F.ToString(), STATION));
                                Common.WriteLog(Path.Combine(pathWip, $"{sTime}_{txtSerial.Text.Trim()}.txt"), content);
                                Common.WriteLog(Path.Combine(pathBackup, "NG", $"{sTime}_{txtSerial.Text.Trim()}.txt"), content);

                            }
                            /* TODO ERROR: Skipped RegionDirectiveTrivia */
                            else if (chkLinkWip.Checked)
                            {
                                string nameSoft = Common.FindApplication("Board Inspector");
                                int wipHandle = 0;
                                wipHandle = NativeWin32.FindWindow(null, nameSoft);
                                bool temp = Common.IsRunning(nameSoft);
                                if (!temp)
                                {
                                    MessageBox.Show("Chương trình Wip chưa bật", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                else
                                {
                                    NativeWin32.SetForegroundWindow(wipHandle);
                                    Thread.Sleep(200);
                                    SendKeys.SendWait(txtSerial.Text);
                                    Thread.Sleep(300);
                                    SendKeys.SendWait("{Enter}");
                                    Thread.Sleep(200);
                                    bool IsWipSuccess = false;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        if (pvsservice.GetWorkOrderItem(txtSerial.Text, STATION) != null)
                                        {
                                            IsWipSuccess = true;
                                            break;
                                        }
                                        Thread.Sleep(500);
                                    }
                                    SendKeys.SendWait("%{TAB}");
                                    if (!IsWipSuccess)
                                    {
                                        txtSerial.SelectAll();
                                        txtSerial.Focus();
                                        return;
                                    }
                                    
                                    string FileReport = PathReport + @"\" + ModelCurrent + @"\" + Datecheck + ".csv";
                                    var content = new StringBuilder();
                                    if (File.Exists(FileReport) == false)
                                    {
                                        content.AppendLine("No,Time,NoPCBA,MAC Box,Id PCBA,User");
                                    }

                                    content.AppendLine(string.Join(",", CountProduct, DateAndTime.Now.Hour + ":" + DateAndTime.Now.Minute, IDCount, MacCurrent, txtSerial.Text, lblCode.Text));
                                    Common.WriteLog(FileReport, content);
                                    KiemTraTrenHondaLock(() =>
                                    {
                                        IDCount += 1;
                                        if (IDCount == PCBBOX)
                                        {
                                            if (CheckBox1.Checked)
                                            {
                                                TextMacBox.Enabled = true;
                                                TextMacBox.Focus();
                                                txtSerial.Enabled = false;
                                                TextMacBox.Clear();
                                            }
                                            else
                                            {
                                                txtSerial.Focus();
                                            }

                                            IDCount = 0;
                                            IDCount_box += 1;
                                            Box_curent = "";
                                        }

                                        LabelPCBA.Text = IDCount.ToString();
                                        LabelSoThung.Text = IDCount_box.ToString();
                                        IncreaseProduct();
                                        if (ConfirmModel & IDCount != 0)
                                        {
                                            txtConfirm.Enabled = true;
                                            txtConfirm.SelectAll();
                                            txtConfirm.Focus();
                                            txtSerial.Enabled = false;
                                        }

                                    }, () =>
                                    {
                                        txtSerial.Focus();
                                    });

                                }
                            }
                            else if (useWip == false)
                            {
                                string FileReport = PathReport + @"\" + ModelCurrent + @"\" + Datecheck + ".csv";

                                KiemTraTrenHondaLock(() =>
                                {
                                    /* TODO ERROR: Skipped RegionDirectiveTrivia */
                                    var content = new StringBuilder();
                                    if (File.Exists(FileReport) == false)
                                    {
                                        content.AppendLine("No,Time,NoPCBA,MAC Box,Id PCBA,User");
                                    }

                                    content.AppendLine(string.Join(",", CountProduct, DateAndTime.Now.Hour + ":" + DateAndTime.Now.Minute, IDCount, MacCurrent, txtSerial.Text, lblCode.Text));
                                    Common.WriteLog(FileReport, content);
                                    /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
                                    IDCount += 1;
                                    if (IDCount == PCBBOX)
                                    {
                                        if (CheckBox1.Checked)
                                        {
                                            TextMacBox.Enabled = true;
                                            TextMacBox.Focus();
                                            txtSerial.Enabled = false;
                                            TextMacBox.Clear();
                                        }
                                        else
                                        {
                                            txtSerial.Focus();
                                        }

                                        IDCount = 0;
                                        IDCount_box += 1;
                                        Box_curent = "";
                                    }

                                    LabelPCBA.Text = IDCount.ToString();
                                    LabelSoThung.Text = IDCount_box.ToString();
                                    IncreaseProduct();
                                    if (ConfirmModel & IDCount != 0)
                                    {
                                        txtConfirm.Enabled = true;
                                        txtConfirm.SelectAll();
                                        txtConfirm.Focus();
                                        txtSerial.Enabled = false;
                                    }
                                }, () => { });

                                //}
                            }
                            else
                            {
                                try
                                {
                                    string FileReport = PathReport + @"\" + ModelCurrent + @"\" + Datecheck + ".csv";

                                    /* TODO ERROR: Skipped RegionDirectiveTrivia */
                                    var _content = new StringBuilder();
                                    if (File.Exists(FileReport) == false)
                                    {
                                        _content.AppendLine("No,Time,NoPCBA,MAC Box,Id PCBA,User");
                                    }

                                    _content.AppendLine(string.Join(",", CountProduct, DateAndTime.Now.Hour + ":" + DateAndTime.Now.Minute, IDCount, MacCurrent, txtSerial.Text, lblCode.Text));
                                    Common.WriteLog(FileReport, _content);

                                    var contentWip = new StringBuilder();
                                    string sTime = pvsservice.GetDateTime().ToString("yyMMddHHmmss");
                                    if (Directory.Exists(PathReport + @"\" + ModelCurrent) == false)
                                        Directory.CreateDirectory(PathReport + @"\" + ModelCurrent);
                                    contentWip.AppendLine(string.Join("|", cbbModel.Text, txtSerial.Text, sTime, State.P.ToString(), STATION));
                                    Common.WriteLog(Path.Combine(pathWip, $"{sTime}_{txtSerial.Text.Trim()}.txt"), contentWip);
                                    Common.WriteLog(Path.Combine(pathBackup, "OK", $"{sTime}_{txtSerial.Text.Trim()}.txt"), contentWip);

                                    KiemTraTrenHondaLock(() =>
                                    {
                                        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
                                        IDCount += 1;
                                        if (IDCount == PCBBOX)
                                        {
                                            if (CheckBox1.Checked)
                                            {
                                                TextMacBox.Enabled = true;
                                                TextMacBox.Focus();
                                                txtSerial.Enabled = false;
                                                TextMacBox.Clear();
                                            }
                                            else
                                            {
                                                txtSerial.Focus();
                                            }

                                            IDCount = 0;
                                            IDCount_box += 1;
                                            Box_curent = "";
                                        }

                                        LabelPCBA.Text = IDCount.ToString();
                                        LabelSoThung.Text = IDCount_box.ToString();
                                        IncreaseProduct();
                                        if (ConfirmModel & IDCount != 0)
                                        {
                                            txtConfirm.Enabled = true;
                                            txtConfirm.SelectAll();
                                            txtConfirm.Focus();
                                            txtSerial.Enabled = false;
                                        }

                                    }, () => { });

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Kết nối đến server thất bại !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
                            }

                        }
                        else
                        {
                            NG_FORM NG_FORM = new NG_FORM();
                            NG_FORM.Lb_inform_NG.Text = "Đang thời gian nghỉ!";
                            NG_FORM.ControlBox = true;
                            NG_FORM.GroupBox3.Visible = false;
                            NG_FORM.ShowDialog();
                        }
                    }
                    else
                    {
                        NG_FORM NG_FORM = new NG_FORM();
                        NG_FORM.Lb_inform_NG.Text = txtSerial.Text + " sai ma quy dinh model: " + ModelRev;
                        NG_FORM.GroupBox3.Visible = false;
                        // NG_FORM.ControlBox = False
                        // NG_FORM.ShowInTaskbar = False
                        NG_FORM.ShowDialog();
                    }
                }
                else
                {
                    NG_FORM NG_FORM = new NG_FORM();
                    NG_FORM.Lb_inform_NG.Text = txtSerial.Text + " khong dung do dai label la:" + IdCodeLenght;
                    // NG_FORM.ControlBox = False
                    // NG_FORM.ShowInTaskbar = False
                    NG_FORM.GroupBox3.Visible = false;
                    NG_FORM.ShowDialog();
                }

                txtSerial.SelectAll();
            }
        }

        private void KiemTraTrenHondaLock(Action ChuaTonTai, Action DaTonTai)
        {
            // Check trên HondaLock
            if (DataProvider.Instance.HondaLocks.KiemTraBanMachDaBan(TextMacBox.Text.ToString(), txtSerial.Text.ToString()))
            {
                DaTonTai();
                NG_FORM NG_FORM = new NG_FORM();
                NG_FORM.Lb_inform_NG.Text = "Đã tồn tại bản mạch " + txtSerial.Text;
                NG_FORM.GroupBox3.Visible = false;
                NG_FORM.ShowDialog();
            }
            else
            {
                DataProvider.Instance.HondaLocks.Insert(new HondaLock()
                {
                    ProductionID = cbbModel.Text.ToString(),
                    BoxID = TextMacBox.Text,
                    BoardNo = txtSerial.Text,
                    UpdateTime = pvsservice.GetDateTime(),
                    Status = chkOK.Checked ? "1" : "0",
                    Update_Code = lblCode.Text,
                    Update_Name = lUser.Text
                });

                ChuaTonTai();
            }
        }

        private int LaySoThung(string mathung)
        {
            var bc = usapservice.GetByBcNo(TextMacBox.Text.ToString());
            if (bc != null)
            {
                try
                {
                    return (int)bc.OS_QTY;
                }
                catch
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
        private void TextMacBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {

                MacCurrent = TextMacBox.Text.Trim().TrimEnd().TrimStart();
                IDCount = DataProvider.Instance.HondaLocks.SoLuongBanMachDaDem(MacCurrent, cbbModel.Text);
                PCBBOX = LaySoThung(TextMacBox.Text);
                if (PCBBOX < 0)
                {
                    NG_FORM NG_FORM = new NG_FORM();
                    NG_FORM.Show();
                    NG_FORM.Lb_inform_NG.Text = "Mã thùng không tồn tại";
                    NG_FORM.GroupBox3.Visible = false;
                    NG_FORM.GroupBox3.Enabled = false;
                    NG_FORM.ControlBox = true;
                    TextMacBox.SelectAll();
                    return;
                }
                else if (IDCount == PCBBOX)
                {
                    NG_FORM NG_FORM = new NG_FORM();
                    NG_FORM.Show();
                    NG_FORM.Lb_inform_NG.Text = "Thùng đã kiểm tra xong";
                    NG_FORM.GroupBox3.Visible = false;
                    NG_FORM.GroupBox3.Enabled = false;
                    NG_FORM.ControlBox = true;
                    TextMacBox.SelectAll();
                    return;
                }
                else
                {
                    LabelPCS1BOX.Text = PCBBOX.ToString();
                }

                TextMacBox.Enabled = false;
                if (ConfirmModel)
                {
                    txtConfirm.Enabled = true;
                    txtConfirm.SelectAll();
                    txtConfirm.Focus();
                }
                else
                {
                    txtSerial.Enabled = true;
                    txtSerial.Focus();
                }

                CheckBox1.Enabled = false;
                LabelPCBA.Text = IDCount.ToString();
                //Box_curent = TextMacBox.Text;



            }
        }

        private void btDTle_Click(object sender, EventArgs e)
        {
            var resuflt = MessageBox.Show("Bạn có chắc muốn đóng thùng lẻ?", "Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resuflt == DialogResult.Yes)
            {
                if (IDCount != 0)
                    IDCount_box += 1;
                IDCount = 0;
                Box_curent = "";
                txtSerial.Enabled = false;
                TextMacBox.Enabled = true;
                TextMacBox.Focus();
                TextMacBox.SelectAll();
                LabelSoThung.Text = IDCount_box.ToString();
                LabelPCBA.Text = IDCount.ToString();
                RecordProduction();
            }
            else
            {
                txtSerial.Focus();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            TimePauseLine = TimePauseLine + 1;
            if (TimePauseLine % 2 == 0)
            {
                ShowStatus(StatusLine, true);
                TimePauseLine = 0;
            }
            else
            {
                ShowStatus(StatusLine, false);
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == false)
            {
                TextMacBox.Enabled = false;
                txtSerial.Enabled = true;
                txtSerial.Focus();
                CheckBox1.Enabled = false;
            }
            else
            {
                // TextMacBox.Enabled = True
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var listReport = new List<ObjReport>();
            if (e.KeyChar == 13)
            {
                if (Strings.Mid(txtSearch.Text.Trim().ToUpper(), 1, 1) == "F")
                {
                    string FileReport = PathReport + @"\" + ModelCurrent + @"\" + Datecheck + ".csv";
                    if (File.Exists(FileReport))
                    {
                        var lst = File.ReadAllLines(FileReport).ToList();
                        foreach (var item in lst)
                        {
                            if (item.Contains(txtSearch.Text.Trim()))
                            {
                                var temp = item.Split(',').ToList();
                                var obj = new ObjReport(temp.ElementAt(1), temp.ElementAt(2), temp.ElementAt(3));
                                listReport.Add(obj);
                            }
                        }

                        var res = new ResultForm();
                        res.Show();
                        res.StartPosition = FormStartPosition.CenterScreen;
                        res.dgv.DataSource = listReport;
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    txtSearch.SelectAll();
                    MessageBox.Show("Sai mã thùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Private Sub Control_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        // ' QuyetPham add 20.7.2018
        // Try
        // Dim production = New ProductionEntity() With
        // {
        // .Barcode = txtSerial.Text,
        // .LineID = txtLine.Text,
        // .ModelID = cbbModel.Text,
        // .LineState = state(2),
        // .Message = "",
        // .Quantity = 0,
        // .ShiftID = If(txtShift.Text = "Ca Ngày", shift(0), shift(1)),
        // .Plan = 0,
        // .Actual = 0,
        // .Difference = 0,
        // .People = txtPeople.Text,
        // .CycleTime = TextCycleTimeModel.Text
        // }
        // 'PostProduction(production)
        // Catch ex As Exception

        // End Try
        // ' End
        // End Sub

        private void lblConfig_Click(object sender, EventArgs e)
        {
            new frmConfig().ShowDialog();
            // useWip = My.Settings.useWip
            useWip = bool.Parse(Common.GetValueRegistryKey(PathConfig, "useWip"));
            pathWip = Common.GetValueRegistryKey(PathConfig, "pathWip");
            txtLine.Text = Common.GetValueRegistryKey(PathConfig, "nameLine");
            Init();
            // dirWipMachine = My.Settings.pathWip
        }

        private void chkNG_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNG.Checked)
            {
                chkOK.Checked = false;
                TextMacBox.Enabled = false;
                txtSerial.Enabled = true;
                txtSerial.Focus();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            BtStop_Click(null, null);
            fmLogin frmLogin = new fmLogin();
            frmLogin.txtUsername.Clear();
            frmLogin.txtPassword.Clear();
            frmLogin.txtUsername.Select();
            frmLogin.Show();
            // Appac
            // Control.ActiveForm
            // Me.Close()
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (BtStart.Text != "Bắt đầu")
            {
                int sumtime = DateAndTime.Now.Hour * 100 + DateAndTime.Now.Minute;
                for (int index = 1; index <= 20; index++)
                {
                    if (index % 2 != 0)
                    {
                        if (sumtime >= TimeLine[index].Hour * 100 + TimeLine[index].Minute & sumtime <= TimeLine[index + 1].Hour * 100 + TimeLine[index + 1].Minute)
                        {
                            bien_dem = bien_dem + 1;
                            break;
                        }
                        else
                        {
                            bien_dem = 0;
                        }
                    }
                    else
                    {
                    }
                }

                if (bien_dem == 0)
                {
                    time_scanBarcode = DateAndTime.Now;
                }
                else
                {
                    TimeCycleActual = (int)(TimeCycleActual + (DateAndTime.Now - time_scanBarcode).TotalSeconds);
                    time_scanBarcode = DateAndTime.Now;
                    ProductPlan = (int)Math.Round(TimeCycleActual / CycleTimeModel, 0, MidpointRounding.AwayFromZero);
                    txtPlan.Text = ProductPlan.ToString();
                    RecordProduction();
                }
            }
        }

        private void txtConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtConfirm.Text == cbbModel.Text)
                {
                    txtSerial.Enabled = true;
                    txtSerial.Focus();
                    txtConfirm.Enabled = false;
                }
                else
                {
                    NG_FORM NG_FORM = new NG_FORM();
                    NG_FORM.Show();
                    NG_FORM.Lb_inform_NG.Text = "Sai Model";
                    NG_FORM.GroupBox3.Visible = false;
                    NG_FORM.GroupBox3.Enabled = false;
                    NG_FORM.ControlBox = true;
                    txtConfirm.SelectAll();
                }
            }
        }

        private void chkOK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOK.Checked)
            {
                chkNG.Checked = false;
                TextMacBox.Enabled = false;
                txtSerial.Enabled = true;
                txtSerial.Focus();
            }
        }
    }
}

