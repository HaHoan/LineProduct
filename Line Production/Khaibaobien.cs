using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic

namespace Line_Production
{
    public partial class Control
    {
        // bien quy dinh duong dan file
        public static string PathApplication = Application.StartupPath;
        public static string PathSetup = PathApplication + @"\Setup";
        public static string PathPassrate = PathApplication + @"\Passrate";
        public static string PathSetupComport = PathSetup + @"\Setting Comport.ini";
        public static string PathModelList = PathSetup + @"\List model.ini";
        public static string PathPassList = PathSetup + @"\SetupListPass.ini";
        public static bool waitWipConfirm = true;
        // Public PathSetupPath As String = PathSetup & "\Setup Path.ini"
        // Public PathStatus As String = ""
        public static string PathReport = PathApplication + @"\Report";
        public static string PathConfig = @"SOFTWARE\CANON_SUPPORT\Configs";
        // Public dirWip As String = ""
        public static string pathBackup = string.Empty;
        public static string pathWip = string.Empty;
        public static bool unlock = false;
        // cac bien cai dat den line san xuat---------------------------------------------------------------
        public static string IdLine = "";
        public static int NoPeople = 0; // bien lua gia tri so nguoi can cua 1 model
        public static bool BarcodeEnable = false; // bien cho phep model co su dung chuc nang barcode hay khong
        public static double CycleTimeModel = 30.6d;
        public static double CycleTimeActual = 0.0d;
        public static bool Shiftcheck = true; // true la ca dem, False la ca dem
        public static string Datecheck = "";
        public static bool StartProduct = false; // bien quy dinh ve line chay hay dung
        public static DateTime[] TimeLine = new DateTime[22]; // bien quy dinh khung gio 
        public static int TimePauseLine; // bien ghi gio tam dung line
        public static int CountProduct = 0; // dem san luong cua line model
        public static int[] CountProductPerHour = new int[22]; // dem san luong cua tung gio
        public static string[] notePerHour = new string[11];
        public static int ProductPlan = 0; // dem san luong tu dong theo cycle time cua model
        public static int ProductPlanBegin = 0; // dem san luong tu dong theo cycle time cua model
        public static int BalanceProduction = 0; // chenh lech san luong thuc te
        public static int BalanceAlarmSetup; // gia tri dat bat dau canh bao san luong
        public static int BalanceErrorSetup; // gia tri dat bat dau canh bao san luong
        public static bool BitPress = false; // bien xac nhan chong nhieu cho nut an tang qu cong com
        public static bool PauseProduct = false; // bien xac nhan trang thai line dang tam dung
        public static int TimeCountPlan = 0; // bien dem thoi gian cua cycle time theo line
        public static int TimeCycleActual = 0; // bien dem thoi gian cycle time thuc te ma line dang chay
        public static bool[] TimeUse = new bool[10]; // moc thoi gian ma line da chay va su dung
        public static int StatusLine = 0; // bien luu trang thai line, 0: chua hoat dong, 1: bat dau hoat dong, 2: Bao dong san luong  3:Bat thuong
        public static int TimeCycleActual2 = 0;
        public static string FilePassrate; // ten file passrate
        public static bool CheckServer = false;
        public static int PCBBOX = 10;
        public static string MacCurrent = "";
        public static int IDCount = 0;
        public static int IDCount_box = 0;
        public static bool ConfirmModel = false;
        // Public MacLe As Boolean = False
        // QuyetPham add 26.11
        public static string pathConfirm = PathApplication + @"\Confirm";
        public static string STATION = "";
        public static string STATION_BEFORE = "";
        // ///////////////////////////////////////////////////////////////////////
        public static string Box_curent = "";
        // //////////////////////////////////////////////////////////////////////////////////
        // cac bien lien quan den may chuc nang--------------------------------------------------------------
        public static string PathModelCurrent = ""; // duong dan file cai dat model hien tai
                                                    // Public PathLogMachine As String = "" ' duong dan ma log may chuc nang sinh ra khi can su dung 
                                                    // Public PathLogWip As String = "" ' duong dan sinh file log cho WIP
                                                    // Public NoLinePass As Integer = 3 ' dong co ki tu pass khi may chuc nang sinh log
                                                    // Public KiHieuPass As String = "P" ' ki tu thong bao la pass trong log
                                                    // Public SetProcess As String = "ICT_MUR" ' cong doan tren WIP
                                                    // Public setfilenamereport As String ' cai dat ten lien quan den file name của file report may chuc nang
        public static int CountLabel;
        public static string ModelRev = "";
        // Public ModelRev2 As String = ""
        public static int ModelRevPosition = 0;
        public static string ModelCurrent = "";
        public static string Idcode = "";
        // Public Idcode2 As String = ""
        public static short IdCodeLenght = 0;
        // Public IdCodeLenght2 As Int16 = 0
        // //////////////////////////////////////////////////////////////////////
        public static bool confirmCode_emp = false;

        // cac bien lien quan den com port
        public static string ComControl = "COM7";
        public static int SetBaudRateComControl = 9600;
        public static int SetDataBitsComControl = 8;
        public static int SetStopBitsComControl = 1;
        public static string SetParityComControl = "None";
        public static string ComPress = "COM6";
        public static int SetBaudRateComPress = 9600;
        public static int SetDataBitsComPress = 8;
        public static int SetStopBitsComPress = 1;
        public static string SetParityComPress = "None";
        public static string ArraySend = "S00000000000000B";
        // ///////////////////////////////////////////////////////////////////////////////////////////////

        public bool CheckComControlPort()
        {
            string com = Common.GetValueRegistryKey(Constants.PathConfig, "COM");
            if (com == null || SerialPort.GetPortNames() == null || SerialPort.GetPortNames().Length == 0)
            {
                MessageBox.Show("Chưa kết nối cổng COM");
                return false;
            }
            ComControl = com;
            string baudRate = Common.GetValueRegistryKey(Constants.PathConfig, "BaudRate");
            if (baudRate == null)
            {
                baudRate = Constants.BaudRate;
                Common.WriteRegistry(Constants.PathConfig, "BaudRate", baudRate);
            }
            SetBaudRateComControl = (int)Conversion.Val(baudRate);
            string dataBits = Common.GetValueRegistryKey(Constants.PathConfig, "DataBits");
            if (dataBits == null)
            {
                dataBits = Constants.DataBits;
                Common.WriteRegistry(Constants.PathConfig, "DataBits", dataBits);
            }
            SetDataBitsComControl = (int)Conversion.Val(dataBits); //8
            string Parity = Common.GetValueRegistryKey(Constants.PathConfig, "Parity");
            if (Parity == null)
            {
                Parity = Constants.Parity;
                Common.WriteRegistry(Constants.PathConfig, "Parity", dataBits);
            }
            SetParityComControl = Parity; // None
            string StopBits = Common.GetValueRegistryKey(Constants.PathConfig, "StopBits");
            if (StopBits == null)
            {
                StopBits = Constants.StopBits;
                Common.WriteRegistry(Constants.PathConfig, "StopBits", StopBits);
            }
            SetStopBitsComControl = (int)Conversion.Val(StopBits); //1

            try
            {

                if (ComControlPort.IsOpen == true)
                {
                    return false;
                }
                else
                {
                    ComControlPort.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("COM Control: " + ComControl + " not connect. Please check connect the device !", "Error device", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        public bool Init()
        {
            try
            {
                IdLine = Common.GetValueRegistryKey(PathConfig, "id");
                STATION = Common.GetValueRegistryKey(PathConfig, "station");
                pathBackup = Path.Combine(Common.GetValueRegistryKey(PathConfig, "pathWip"), "backup", DateTime.Now.ToString("yyyyMMdd"));
                pathWip = Common.GetValueRegistryKey(PathConfig, "pathWip");

                if (!Directory.Exists(pathBackup))
                    Directory.CreateDirectory(pathBackup);
                if (!Directory.Exists(Path.Combine(pathBackup, "OK")))
                    Directory.CreateDirectory(Path.Combine(pathBackup, "OK"));
                if (!Directory.Exists(Path.Combine(pathBackup, "NG")))
                    Directory.CreateDirectory(Path.Combine(pathBackup, "NG"));
                if (Directory.Exists(PathReport) == false)
                    Directory.CreateDirectory(PathReport);
                if (Directory.Exists(pathConfirm) == false)
                    Directory.CreateDirectory(pathConfirm);
                txtLine.Text = Common.GetValueRegistryKey(PathConfig, "nameLine");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }

            return true;
        }

        public static bool SaveInit()
        {
            if (Common.GetValueRegistryKey(PathConfig, "id") is null)
            {
                Common.WriteRegistry(PathConfig, "id", "CA-Default");
                Common.WriteRegistry(PathConfig, "nameLine", "Line-Default");
                Common.WriteRegistry(PathConfig, "pathWip", @"C:\LOGPROCESS");
                Common.WriteRegistry(PathConfig, "station", "VI2_CAN");
                Common.WriteRegistry(PathConfig, "stationBefore", "CAMERA_CAN");
                Common.WriteRegistry(PathConfig, "useWip", true.ToString());
                return true;
            }

            return false;
        }

        public bool CheckModelList()
        {
            if (File.Exists(PathModelList) == true)
            {
                for (int index = 1, loopTo = CounterlineTextFile(PathModelList); index <= loopTo; index++)
                    cbbModel.Items.Add(ReadTextFile(PathModelList, index));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoadModelCurrent(string ModelLoad)
        {
            string Strcheck = ModelLoad;
            PathModelCurrent = "";
            if (Strcheck.Length != 0)
            {
                PathModelCurrent = PathSetup + @"\" + ModelLoad + ".ini";
                if (File.Exists(PathModelCurrent) == true)
                {
                    try
                    {
                        NoPeople = int.Parse(ReadTextFile(PathModelCurrent, 2));
                        CycleTimeModel = double.Parse(ReadTextFile(PathModelCurrent, 4));
                        BarcodeEnable = ReadTextFile(PathModelCurrent, 6) == "1" ? true : false;
                        BalanceAlarmSetup = int.Parse(ReadTextFile(PathModelCurrent, 8));
                        BalanceErrorSetup = int.Parse(ReadTextFile(PathModelCurrent, 10));
                        IdCodeLenght = short.Parse(ReadTextFile(PathModelCurrent, 12));
                        ModelRevPosition = int.Parse(ReadTextFile(PathModelCurrent, 14));
                        ModelRev = ReadTextFile(PathModelCurrent, 16);
                        //  PCBBOX = int.Parse(ReadTextFile(PathModelCurrent, 18));
                        ConfirmModel = ReadTextFile(PathModelCurrent, 20) == "1" ? true : false;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message.ToString());
                        return false;
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static int CheckTotalLabel(string Id)
        {
            string Strcheck = Id;
            string Linecheck = "";
            PathModelCurrent = "";
            if (Strcheck.Length != 0)
            {
                int CountLine = CounterlineTextFile(PathModelList);
                while (CountLine > 0)
                {
                    Linecheck = ReadTextFile(PathModelList, CountLine);
                    if (Strcheck.Contains(Linecheck) == true)
                    {
                        ModelCurrent = Linecheck;
                        PathModelCurrent = PathSetup + @"\" + Linecheck + ".ini";
                        return CountLabel;
                    }

                    CountLine = CountLine - 1;
                }

                return 0;
            }
            else
            {
                return 0;
            }
        }

        public static bool CheckCaSX()
        {
            if (DateAndTime.Now.Hour >= 8 & DateAndTime.Now.Hour <= 19)
            {
                Shiftcheck = true;
                string PathTimeLine = PathSetup + @"\Setup Time Line Day.ini";
                string ReadTime = ReadTextFile(PathTimeLine, 2);
                TimeLine[1] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[2] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 4);
                TimeLine[3] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[4] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 6);
                TimeLine[5] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[6] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 8);
                TimeLine[7] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[8] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 10);
                TimeLine[9] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[10] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 12);
                TimeLine[11] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[12] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 14);
                TimeLine[13] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[14] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 16);
                TimeLine[15] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[16] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 18);
                TimeLine[17] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[18] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 20);
                TimeLine[19] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[20] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
            }
            else
            {
                Shiftcheck = false;
                string PathTimeLine = PathSetup + @"\Setup Time Line Night.ini";
                string ReadTime = ReadTextFile(PathTimeLine, 2);
                TimeLine[1] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[2] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 4);
                TimeLine[3] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[4] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 6);
                TimeLine[5] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[6] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 8);
                TimeLine[7] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[8] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 10);
                TimeLine[9] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[10] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 12);
                TimeLine[11] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[12] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 14);
                TimeLine[13] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[14] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 16);
                TimeLine[15] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[16] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 18);
                TimeLine[17] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[18] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
                ReadTime = ReadTextFile(PathTimeLine, 20);
                TimeLine[19] = Convert.ToDateTime(Strings.Mid(ReadTime, 1, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) - 1));
                TimeLine[20] = Convert.ToDateTime(Strings.Mid(ReadTime, Strings.InStr(1, ReadTime, ",", CompareMethod.Text) + 1, ReadTime.Length));
            }

            return Shiftcheck;
        }

        public static double CalTimeWork(DateTime t1, DateTime t2)
        {
            double kq;
            var span = t2.Subtract(t1);
            kq = span.Hours * 3600 + span.Minutes * 60 + span.Seconds;
            return kq;
        }
    }
}


