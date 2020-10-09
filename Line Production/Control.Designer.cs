using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
namespace Line_Production
{
    partial class Control
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.chkOK = new System.Windows.Forms.CheckBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.chkNG = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.LabelSoThung = new System.Windows.Forms.Label();
            this.LabelPCS1BOX = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.LabelPCBA = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.TextMacBox = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.btDTle = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.TextCycleTimeCurrent = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.TextCycleTimeModel = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TextBalance = new System.Windows.Forms.TextBox();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbbModel = new System.Windows.Forms.ComboBox();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.BtStop = new System.Windows.Forms.Button();
            this.BtStart = new System.Windows.Forms.Button();
            this.Table1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextTime10 = new System.Windows.Forms.TextBox();
            this.TextTime9 = new System.Windows.Forms.TextBox();
            this.TextTime8 = new System.Windows.Forms.TextBox();
            this.TextTime7 = new System.Windows.Forms.TextBox();
            this.TextTime6 = new System.Windows.Forms.TextBox();
            this.TextTime5 = new System.Windows.Forms.TextBox();
            this.TextTime4 = new System.Windows.Forms.TextBox();
            this.TextTime3 = new System.Windows.Forms.TextBox();
            this.TextTime2 = new System.Windows.Forms.TextBox();
            this.TextComment9 = new System.Windows.Forms.TextBox();
            this.TextBalance9 = new System.Windows.Forms.TextBox();
            this.TextComment8 = new System.Windows.Forms.TextBox();
            this.TextBalance8 = new System.Windows.Forms.TextBox();
            this.TextComment7 = new System.Windows.Forms.TextBox();
            this.TextBalance7 = new System.Windows.Forms.TextBox();
            this.TextComment6 = new System.Windows.Forms.TextBox();
            this.TextBalance6 = new System.Windows.Forms.TextBox();
            this.TextComment5 = new System.Windows.Forms.TextBox();
            this.TextComment4 = new System.Windows.Forms.TextBox();
            this.TextBalance4 = new System.Windows.Forms.TextBox();
            this.TextComment3 = new System.Windows.Forms.TextBox();
            this.TextComment2 = new System.Windows.Forms.TextBox();
            this.TextComment1 = new System.Windows.Forms.TextBox();
            this.TextActual9 = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.TextActual1 = new System.Windows.Forms.TextBox();
            this.TextPlan1 = new System.Windows.Forms.TextBox();
            this.TextBalance1 = new System.Windows.Forms.TextBox();
            this.TextPlan2 = new System.Windows.Forms.TextBox();
            this.TextPlan3 = new System.Windows.Forms.TextBox();
            this.TextPlan4 = new System.Windows.Forms.TextBox();
            this.TextPlan6 = new System.Windows.Forms.TextBox();
            this.TextPlan5 = new System.Windows.Forms.TextBox();
            this.TextPlan7 = new System.Windows.Forms.TextBox();
            this.TextPlan8 = new System.Windows.Forms.TextBox();
            this.TextPlan9 = new System.Windows.Forms.TextBox();
            this.TextActual2 = new System.Windows.Forms.TextBox();
            this.TextBalance2 = new System.Windows.Forms.TextBox();
            this.TextActual3 = new System.Windows.Forms.TextBox();
            this.TextBalance3 = new System.Windows.Forms.TextBox();
            this.TextActual4 = new System.Windows.Forms.TextBox();
            this.TextActual5 = new System.Windows.Forms.TextBox();
            this.TextBalance5 = new System.Windows.Forms.TextBox();
            this.TextActual6 = new System.Windows.Forms.TextBox();
            this.TextActual7 = new System.Windows.Forms.TextBox();
            this.TextActual8 = new System.Windows.Forms.TextBox();
            this.TextTime1 = new System.Windows.Forms.TextBox();
            this.TextComment10 = new System.Windows.Forms.TextBox();
            this.TextBalance10 = new System.Windows.Forms.TextBox();
            this.TextActual10 = new System.Windows.Forms.TextBox();
            this.TextPlan10 = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Shape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.BtReduce = new System.Windows.Forms.Button();
            this.BtIncrease = new System.Windows.Forms.Button();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.LabelShapeError = new System.Windows.Forms.Label();
            this.LabelShapeOffLine = new System.Windows.Forms.Label();
            this.LabelShapeOnline = new System.Windows.Forms.Label();
            this.ShapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Shape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Shape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ComControlPort = new System.IO.Ports.SerialPort(this.components);
            this.ComPressPort = new System.IO.Ports.SerialPort(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblComcontrol = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelTimeDate = new System.Windows.Forms.Label();
            this.chkLinkWip = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lUser = new System.Windows.Forms.Label();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblConfig = new System.Windows.Forms.LinkLabel();
            this.GroupBox1.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.Table1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(566, 65);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Bảng Quản Lý Sản Lượng";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(5, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 19);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Line:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.GroupBox5);
            this.GroupBox1.Controls.Add(this.GroupBox4);
            this.GroupBox1.Controls.Add(this.TextCycleTimeCurrent);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.txtPeople);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txtShift);
            this.GroupBox1.Controls.Add(this.txtDate);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.TextCycleTimeModel);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.TextBalance);
            this.GroupBox1.Controls.Add(this.txtActual);
            this.GroupBox1.Controls.Add(this.txtPlan);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.cbbModel);
            this.GroupBox1.Controls.Add(this.txtLine);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.BtStop);
            this.GroupBox1.Controls.Add(this.BtStart);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 59);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1236, 229);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.chkOK);
            this.GroupBox5.Controls.Add(this.txtConfirm);
            this.GroupBox5.Controls.Add(this.Label20);
            this.GroupBox5.Controls.Add(this.chkNG);
            this.GroupBox5.Controls.Add(this.CheckBox1);
            this.GroupBox5.Controls.Add(this.GroupBox6);
            this.GroupBox5.Controls.Add(this.LabelPCS1BOX);
            this.GroupBox5.Controls.Add(this.Label23);
            this.GroupBox5.Controls.Add(this.txtSerial);
            this.GroupBox5.Controls.Add(this.LabelPCBA);
            this.GroupBox5.Controls.Add(this.Label17);
            this.GroupBox5.Controls.Add(this.Label22);
            this.GroupBox5.Controls.Add(this.TextMacBox);
            this.GroupBox5.Controls.Add(this.Label24);
            this.GroupBox5.Controls.Add(this.btDTle);
            this.GroupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(756, 11);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(466, 212);
            this.GroupBox5.TabIndex = 16;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Quản lý bản mạch";
            // 
            // chkOK
            // 
            this.chkOK.AutoSize = true;
            this.chkOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkOK.Location = new System.Drawing.Point(295, 141);
            this.chkOK.Name = "chkOK";
            this.chkOK.Size = new System.Drawing.Size(52, 24);
            this.chkOK.TabIndex = 20;
            this.chkOK.Text = "OK";
            this.chkOK.UseVisualStyleBackColor = true;
            this.chkOK.CheckedChanged += new System.EventHandler(this.chkOK_CheckedChanged);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(10, 114);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(224, 26);
            this.txtConfirm.TabIndex = 18;
            this.txtConfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirm_KeyPress);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.BackColor = System.Drawing.Color.Transparent;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(12, 86);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(155, 24);
            this.Label20.TabIndex = 19;
            this.Label20.Text = "Xác nhận Model:";
            // 
            // chkNG
            // 
            this.chkNG.AutoSize = true;
            this.chkNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkNG.Location = new System.Drawing.Point(380, 141);
            this.chkNG.Name = "chkNG";
            this.chkNG.Size = new System.Drawing.Size(54, 24);
            this.chkNG.TabIndex = 17;
            this.chkNG.Text = "NG";
            this.chkNG.UseVisualStyleBackColor = true;
            this.chkNG.CheckedChanged += new System.EventHandler(this.chkNG_CheckedChanged);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1.Location = new System.Drawing.Point(245, 64);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(15, 14);
            this.CheckBox1.TabIndex = 16;
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.Visible = false;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.LabelSoThung);
            this.GroupBox6.Location = new System.Drawing.Point(259, 77);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(204, 63);
            this.GroupBox6.TabIndex = 15;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Số thùng";
            // 
            // LabelSoThung
            // 
            this.LabelSoThung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSoThung.AutoSize = true;
            this.LabelSoThung.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSoThung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LabelSoThung.Location = new System.Drawing.Point(83, 13);
            this.LabelSoThung.Name = "LabelSoThung";
            this.LabelSoThung.Size = new System.Drawing.Size(44, 49);
            this.LabelSoThung.TabIndex = 11;
            this.LabelSoThung.Text = "0";
            // 
            // LabelPCS1BOX
            // 
            this.LabelPCS1BOX.AutoSize = true;
            this.LabelPCS1BOX.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPCS1BOX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LabelPCS1BOX.Location = new System.Drawing.Point(386, 12);
            this.LabelPCS1BOX.Name = "LabelPCS1BOX";
            this.LabelPCS1BOX.Size = new System.Drawing.Size(66, 49);
            this.LabelPCS1BOX.TabIndex = 11;
            this.LabelPCS1BOX.Text = "10";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label23.Location = new System.Drawing.Point(351, 33);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(16, 22);
            this.Label23.TabIndex = 11;
            this.Label23.Text = "/";
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(10, 172);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(224, 26);
            this.txtSerial.TabIndex = 4;
            this.txtSerial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSerial_KeyPress);
            // 
            // LabelPCBA
            // 
            this.LabelPCBA.AutoSize = true;
            this.LabelPCBA.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPCBA.ForeColor = System.Drawing.Color.Red;
            this.LabelPCBA.Location = new System.Drawing.Point(283, 12);
            this.LabelPCBA.Name = "LabelPCBA";
            this.LabelPCBA.Size = new System.Drawing.Size(66, 49);
            this.LabelPCBA.TabIndex = 11;
            this.LabelPCBA.Text = "10";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(12, 145);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(169, 24);
            this.Label17.TabIndex = 5;
            this.Label17.Text = "Mã Barcode mạch:";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.Location = new System.Drawing.Point(324, 59);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(79, 19);
            this.Label22.TabIndex = 10;
            this.Label22.Text = "PCS/Thùng";
            // 
            // TextMacBox
            // 
            this.TextMacBox.Enabled = false;
            this.TextMacBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMacBox.Location = new System.Drawing.Point(10, 52);
            this.TextMacBox.Name = "TextMacBox";
            this.TextMacBox.Size = new System.Drawing.Size(224, 26);
            this.TextMacBox.TabIndex = 12;
            this.TextMacBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextMacBox_KeyPress);
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.Transparent;
            this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.Location = new System.Drawing.Point(12, 24);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(109, 24);
            this.Label24.TabIndex = 5;
            this.Label24.Text = "Nhãn thùng";
            // 
            // btDTle
            // 
            this.btDTle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDTle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.btDTle.Image = global::Line_Production.Properties.Resources.stop;
            this.btDTle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDTle.Location = new System.Drawing.Point(239, 164);
            this.btDTle.Name = "btDTle";
            this.btDTle.Size = new System.Drawing.Size(224, 42);
            this.btDTle.TabIndex = 0;
            this.btDTle.Text = "Đóng thùng lẻ     ";
            this.btDTle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDTle.UseVisualStyleBackColor = true;
            this.btDTle.Visible = false;
            this.btDTle.Click += new System.EventHandler(this.btDTle_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.lblQuantity);
            this.GroupBox4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(471, 66);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(277, 157);
            this.GroupBox4.TabIndex = 15;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Sản lượng";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Green;
            this.lblQuantity.Location = new System.Drawing.Point(6, 22);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(265, 132);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "200";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextCycleTimeCurrent
            // 
            this.TextCycleTimeCurrent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCycleTimeCurrent.Location = new System.Drawing.Point(366, 193);
            this.TextCycleTimeCurrent.Name = "TextCycleTimeCurrent";
            this.TextCycleTimeCurrent.ReadOnly = true;
            this.TextCycleTimeCurrent.Size = new System.Drawing.Size(96, 26);
            this.TextCycleTimeCurrent.TabIndex = 5;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(264, 185);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(81, 38);
            this.Label8.TabIndex = 5;
            this.Label8.Text = "Cycle Time \r\nthực tế (s)";
            // 
            // txtPeople
            // 
            this.txtPeople.BackColor = System.Drawing.Color.White;
            this.txtPeople.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeople.Location = new System.Drawing.Point(127, 107);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.ReadOnly = true;
            this.txtPeople.Size = new System.Drawing.Size(97, 26);
            this.txtPeople.TabIndex = 8;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(5, 201);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(86, 19);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Ca Sản xuất:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(5, 156);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(101, 19);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Ngày Sản xuất:";
            // 
            // txtShift
            // 
            this.txtShift.BackColor = System.Drawing.Color.White;
            this.txtShift.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShift.Location = new System.Drawing.Point(127, 195);
            this.txtShift.Name = "txtShift";
            this.txtShift.ReadOnly = true;
            this.txtShift.Size = new System.Drawing.Size(97, 26);
            this.txtShift.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(127, 151);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(97, 26);
            this.txtDate.TabIndex = 4;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(264, 105);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(82, 19);
            this.Label11.TabIndex = 7;
            this.Label11.Text = "Chênh Lệch";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(264, 151);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(97, 19);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Cycle Time (s)\r\n";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(264, 64);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(56, 19);
            this.Label10.TabIndex = 7;
            this.Label10.Text = "Thực tế";
            // 
            // TextCycleTimeModel
            // 
            this.TextCycleTimeModel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCycleTimeModel.Location = new System.Drawing.Point(366, 150);
            this.TextCycleTimeModel.Name = "TextCycleTimeModel";
            this.TextCycleTimeModel.ReadOnly = true;
            this.TextCycleTimeModel.Size = new System.Drawing.Size(96, 26);
            this.TextCycleTimeModel.TabIndex = 6;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(264, 25);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(68, 19);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "Kế hoạch";
            // 
            // TextBalance
            // 
            this.TextBalance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance.Location = new System.Drawing.Point(366, 107);
            this.TextBalance.Name = "TextBalance";
            this.TextBalance.ReadOnly = true;
            this.TextBalance.Size = new System.Drawing.Size(96, 26);
            this.TextBalance.TabIndex = 3;
            // 
            // txtActual
            // 
            this.txtActual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActual.Location = new System.Drawing.Point(366, 64);
            this.txtActual.Name = "txtActual";
            this.txtActual.ReadOnly = true;
            this.txtActual.Size = new System.Drawing.Size(96, 26);
            this.txtActual.TabIndex = 3;
            // 
            // txtPlan
            // 
            this.txtPlan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlan.Location = new System.Drawing.Point(366, 21);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.ReadOnly = true;
            this.txtPlan.Size = new System.Drawing.Size(96, 26);
            this.txtPlan.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(5, 66);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 19);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Model:";
            // 
            // cbbModel
            // 
            this.cbbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbModel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbModel.FormattingEnabled = true;
            this.cbbModel.Location = new System.Drawing.Point(75, 62);
            this.cbbModel.Name = "cbbModel";
            this.cbbModel.Size = new System.Drawing.Size(149, 27);
            this.cbbModel.TabIndex = 4;
            this.cbbModel.SelectedIndexChanged += new System.EventHandler(this.ComboModel_SelectedIndexChanged);
            // 
            // txtLine
            // 
            this.txtLine.BackColor = System.Drawing.Color.White;
            this.txtLine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLine.Location = new System.Drawing.Point(75, 18);
            this.txtLine.Name = "txtLine";
            this.txtLine.ReadOnly = true;
            this.txtLine.Size = new System.Drawing.Size(149, 26);
            this.txtLine.TabIndex = 3;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(5, 111);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(92, 19);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Số người cần:";
            // 
            // BtStop
            // 
            this.BtStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtStop.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BtStop.Image = global::Line_Production.Properties.Resources.stop;
            this.BtStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtStop.Location = new System.Drawing.Point(623, 23);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(125, 40);
            this.BtStop.TabIndex = 0;
            this.BtStop.Text = "Kết thúc";
            this.BtStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtStop.UseVisualStyleBackColor = true;
            this.BtStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // BtStart
            // 
            this.BtStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtStart.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.BtStart.Image = global::Line_Production.Properties.Resources.play;
            this.BtStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtStart.Location = new System.Drawing.Point(471, 23);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(125, 40);
            this.BtStart.TabIndex = 0;
            this.BtStart.Text = "Bắt đầu";
            this.BtStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // Table1
            // 
            this.Table1.BackColor = System.Drawing.Color.LightGray;
            this.Table1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table1.ColumnCount = 5;
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 608F));
            this.Table1.Controls.Add(this.TextTime10, 0, 10);
            this.Table1.Controls.Add(this.TextTime9, 0, 9);
            this.Table1.Controls.Add(this.TextTime8, 0, 8);
            this.Table1.Controls.Add(this.TextTime7, 0, 7);
            this.Table1.Controls.Add(this.TextTime6, 0, 6);
            this.Table1.Controls.Add(this.TextTime5, 0, 5);
            this.Table1.Controls.Add(this.TextTime4, 0, 4);
            this.Table1.Controls.Add(this.TextTime3, 0, 3);
            this.Table1.Controls.Add(this.TextTime2, 0, 2);
            this.Table1.Controls.Add(this.TextComment9, 4, 9);
            this.Table1.Controls.Add(this.TextBalance9, 3, 9);
            this.Table1.Controls.Add(this.TextComment8, 4, 8);
            this.Table1.Controls.Add(this.TextBalance8, 3, 8);
            this.Table1.Controls.Add(this.TextComment7, 4, 7);
            this.Table1.Controls.Add(this.TextBalance7, 3, 7);
            this.Table1.Controls.Add(this.TextComment6, 4, 6);
            this.Table1.Controls.Add(this.TextBalance6, 3, 6);
            this.Table1.Controls.Add(this.TextComment5, 4, 5);
            this.Table1.Controls.Add(this.TextComment4, 4, 4);
            this.Table1.Controls.Add(this.TextBalance4, 3, 4);
            this.Table1.Controls.Add(this.TextComment3, 4, 3);
            this.Table1.Controls.Add(this.TextComment2, 4, 2);
            this.Table1.Controls.Add(this.TextComment1, 4, 1);
            this.Table1.Controls.Add(this.TextActual9, 2, 9);
            this.Table1.Controls.Add(this.Label16, 4, 0);
            this.Table1.Controls.Add(this.Label15, 3, 0);
            this.Table1.Controls.Add(this.Label14, 2, 0);
            this.Table1.Controls.Add(this.Label12, 0, 0);
            this.Table1.Controls.Add(this.TextActual1, 2, 1);
            this.Table1.Controls.Add(this.TextPlan1, 1, 1);
            this.Table1.Controls.Add(this.TextBalance1, 3, 1);
            this.Table1.Controls.Add(this.TextPlan2, 1, 2);
            this.Table1.Controls.Add(this.TextPlan3, 1, 3);
            this.Table1.Controls.Add(this.TextPlan4, 1, 4);
            this.Table1.Controls.Add(this.TextPlan6, 1, 6);
            this.Table1.Controls.Add(this.TextPlan5, 1, 5);
            this.Table1.Controls.Add(this.TextPlan7, 1, 7);
            this.Table1.Controls.Add(this.TextPlan8, 1, 8);
            this.Table1.Controls.Add(this.TextPlan9, 1, 9);
            this.Table1.Controls.Add(this.TextActual2, 2, 2);
            this.Table1.Controls.Add(this.TextBalance2, 3, 2);
            this.Table1.Controls.Add(this.TextActual3, 2, 3);
            this.Table1.Controls.Add(this.TextBalance3, 3, 3);
            this.Table1.Controls.Add(this.TextActual4, 2, 4);
            this.Table1.Controls.Add(this.TextActual5, 2, 5);
            this.Table1.Controls.Add(this.TextBalance5, 3, 5);
            this.Table1.Controls.Add(this.TextActual6, 2, 6);
            this.Table1.Controls.Add(this.TextActual7, 2, 7);
            this.Table1.Controls.Add(this.TextActual8, 2, 8);
            this.Table1.Controls.Add(this.TextTime1, 0, 1);
            this.Table1.Controls.Add(this.TextComment10, 4, 10);
            this.Table1.Controls.Add(this.TextBalance10, 3, 10);
            this.Table1.Controls.Add(this.TextActual10, 2, 10);
            this.Table1.Controls.Add(this.TextPlan10, 1, 10);
            this.Table1.Controls.Add(this.Label13, 1, 0);
            this.Table1.Location = new System.Drawing.Point(12, 304);
            this.Table1.Name = "Table1";
            this.Table1.RowCount = 11;
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Table1.Size = new System.Drawing.Size(1036, 549);
            this.Table1.TabIndex = 3;
            // 
            // TextTime10
            // 
            this.TextTime10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime10.Location = new System.Drawing.Point(4, 506);
            this.TextTime10.Name = "TextTime10";
            this.TextTime10.ReadOnly = true;
            this.TextTime10.Size = new System.Drawing.Size(117, 26);
            this.TextTime10.TabIndex = 61;
            // 
            // TextTime9
            // 
            this.TextTime9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime9.Location = new System.Drawing.Point(4, 460);
            this.TextTime9.Name = "TextTime9";
            this.TextTime9.ReadOnly = true;
            this.TextTime9.Size = new System.Drawing.Size(117, 26);
            this.TextTime9.TabIndex = 58;
            // 
            // TextTime8
            // 
            this.TextTime8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime8.Location = new System.Drawing.Point(4, 414);
            this.TextTime8.Name = "TextTime8";
            this.TextTime8.ReadOnly = true;
            this.TextTime8.Size = new System.Drawing.Size(117, 26);
            this.TextTime8.TabIndex = 57;
            // 
            // TextTime7
            // 
            this.TextTime7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime7.Location = new System.Drawing.Point(4, 368);
            this.TextTime7.Name = "TextTime7";
            this.TextTime7.ReadOnly = true;
            this.TextTime7.Size = new System.Drawing.Size(117, 26);
            this.TextTime7.TabIndex = 56;
            // 
            // TextTime6
            // 
            this.TextTime6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime6.Location = new System.Drawing.Point(4, 322);
            this.TextTime6.Name = "TextTime6";
            this.TextTime6.ReadOnly = true;
            this.TextTime6.Size = new System.Drawing.Size(117, 26);
            this.TextTime6.TabIndex = 55;
            // 
            // TextTime5
            // 
            this.TextTime5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime5.Location = new System.Drawing.Point(4, 276);
            this.TextTime5.Name = "TextTime5";
            this.TextTime5.ReadOnly = true;
            this.TextTime5.Size = new System.Drawing.Size(117, 26);
            this.TextTime5.TabIndex = 54;
            // 
            // TextTime4
            // 
            this.TextTime4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime4.Location = new System.Drawing.Point(4, 230);
            this.TextTime4.Name = "TextTime4";
            this.TextTime4.ReadOnly = true;
            this.TextTime4.Size = new System.Drawing.Size(117, 26);
            this.TextTime4.TabIndex = 53;
            // 
            // TextTime3
            // 
            this.TextTime3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime3.Location = new System.Drawing.Point(4, 184);
            this.TextTime3.Name = "TextTime3";
            this.TextTime3.ReadOnly = true;
            this.TextTime3.Size = new System.Drawing.Size(117, 26);
            this.TextTime3.TabIndex = 52;
            // 
            // TextTime2
            // 
            this.TextTime2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime2.Location = new System.Drawing.Point(4, 138);
            this.TextTime2.Name = "TextTime2";
            this.TextTime2.ReadOnly = true;
            this.TextTime2.Size = new System.Drawing.Size(117, 26);
            this.TextTime2.TabIndex = 51;
            // 
            // TextComment9
            // 
            this.TextComment9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment9.Location = new System.Drawing.Point(429, 460);
            this.TextComment9.Name = "TextComment9";
            this.TextComment9.Size = new System.Drawing.Size(603, 38);
            this.TextComment9.TabIndex = 49;
            this.TextComment9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance9
            // 
            this.TextBalance9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance9.Location = new System.Drawing.Point(314, 460);
            this.TextBalance9.Name = "TextBalance9";
            this.TextBalance9.Size = new System.Drawing.Size(108, 38);
            this.TextBalance9.TabIndex = 48;
            this.TextBalance9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment8
            // 
            this.TextComment8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment8.Location = new System.Drawing.Point(429, 414);
            this.TextComment8.Name = "TextComment8";
            this.TextComment8.Size = new System.Drawing.Size(603, 38);
            this.TextComment8.TabIndex = 46;
            this.TextComment8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance8
            // 
            this.TextBalance8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance8.Location = new System.Drawing.Point(314, 414);
            this.TextBalance8.Name = "TextBalance8";
            this.TextBalance8.Size = new System.Drawing.Size(108, 38);
            this.TextBalance8.TabIndex = 45;
            this.TextBalance8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment7
            // 
            this.TextComment7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment7.Location = new System.Drawing.Point(429, 368);
            this.TextComment7.Name = "TextComment7";
            this.TextComment7.Size = new System.Drawing.Size(603, 38);
            this.TextComment7.TabIndex = 44;
            this.TextComment7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance7
            // 
            this.TextBalance7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance7.Location = new System.Drawing.Point(314, 368);
            this.TextBalance7.Name = "TextBalance7";
            this.TextBalance7.Size = new System.Drawing.Size(108, 38);
            this.TextBalance7.TabIndex = 43;
            this.TextBalance7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment6
            // 
            this.TextComment6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment6.Location = new System.Drawing.Point(429, 322);
            this.TextComment6.Name = "TextComment6";
            this.TextComment6.Size = new System.Drawing.Size(603, 38);
            this.TextComment6.TabIndex = 42;
            this.TextComment6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance6
            // 
            this.TextBalance6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance6.Location = new System.Drawing.Point(314, 322);
            this.TextBalance6.Name = "TextBalance6";
            this.TextBalance6.Size = new System.Drawing.Size(108, 38);
            this.TextBalance6.TabIndex = 41;
            this.TextBalance6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment5
            // 
            this.TextComment5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment5.Location = new System.Drawing.Point(429, 276);
            this.TextComment5.Name = "TextComment5";
            this.TextComment5.Size = new System.Drawing.Size(603, 38);
            this.TextComment5.TabIndex = 40;
            this.TextComment5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment4
            // 
            this.TextComment4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment4.Location = new System.Drawing.Point(429, 230);
            this.TextComment4.Name = "TextComment4";
            this.TextComment4.Size = new System.Drawing.Size(603, 38);
            this.TextComment4.TabIndex = 39;
            this.TextComment4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance4
            // 
            this.TextBalance4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance4.Location = new System.Drawing.Point(314, 230);
            this.TextBalance4.Name = "TextBalance4";
            this.TextBalance4.Size = new System.Drawing.Size(108, 38);
            this.TextBalance4.TabIndex = 38;
            this.TextBalance4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment3
            // 
            this.TextComment3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment3.Location = new System.Drawing.Point(429, 184);
            this.TextComment3.Name = "TextComment3";
            this.TextComment3.Size = new System.Drawing.Size(603, 38);
            this.TextComment3.TabIndex = 37;
            this.TextComment3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment2
            // 
            this.TextComment2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment2.Location = new System.Drawing.Point(429, 138);
            this.TextComment2.Name = "TextComment2";
            this.TextComment2.Size = new System.Drawing.Size(603, 38);
            this.TextComment2.TabIndex = 36;
            this.TextComment2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextComment1
            // 
            this.TextComment1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment1.Location = new System.Drawing.Point(429, 84);
            this.TextComment1.Name = "TextComment1";
            this.TextComment1.Size = new System.Drawing.Size(603, 38);
            this.TextComment1.TabIndex = 35;
            this.TextComment1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual9
            // 
            this.TextActual9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual9.Location = new System.Drawing.Point(202, 460);
            this.TextActual9.Name = "TextActual9";
            this.TextActual9.Size = new System.Drawing.Size(105, 38);
            this.TextActual9.TabIndex = 34;
            this.TextActual9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label16
            // 
            this.Label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(429, 1);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(603, 79);
            this.Label16.TabIndex = 4;
            this.Label16.Text = "Ghi chú";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label15
            // 
            this.Label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(314, 1);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(108, 79);
            this.Label15.TabIndex = 3;
            this.Label15.Text = "Chênh lệch";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label14
            // 
            this.Label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(202, 1);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(105, 79);
            this.Label14.TabIndex = 2;
            this.Label14.Text = "Thực tế";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label12
            // 
            this.Label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(4, 1);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(117, 79);
            this.Label12.TabIndex = 0;
            this.Label12.Text = "Thời gian";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextActual1
            // 
            this.TextActual1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual1.Location = new System.Drawing.Point(202, 84);
            this.TextActual1.Name = "TextActual1";
            this.TextActual1.Size = new System.Drawing.Size(105, 38);
            this.TextActual1.TabIndex = 5;
            this.TextActual1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan1
            // 
            this.TextPlan1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan1.Location = new System.Drawing.Point(128, 84);
            this.TextPlan1.Name = "TextPlan1";
            this.TextPlan1.Size = new System.Drawing.Size(67, 38);
            this.TextPlan1.TabIndex = 7;
            this.TextPlan1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance1
            // 
            this.TextBalance1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance1.Location = new System.Drawing.Point(314, 84);
            this.TextBalance1.Name = "TextBalance1";
            this.TextBalance1.Size = new System.Drawing.Size(108, 38);
            this.TextBalance1.TabIndex = 16;
            this.TextBalance1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan2
            // 
            this.TextPlan2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan2.Location = new System.Drawing.Point(128, 138);
            this.TextPlan2.Name = "TextPlan2";
            this.TextPlan2.Size = new System.Drawing.Size(67, 38);
            this.TextPlan2.TabIndex = 17;
            this.TextPlan2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan3
            // 
            this.TextPlan3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan3.Location = new System.Drawing.Point(128, 184);
            this.TextPlan3.Name = "TextPlan3";
            this.TextPlan3.Size = new System.Drawing.Size(67, 38);
            this.TextPlan3.TabIndex = 18;
            this.TextPlan3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan4
            // 
            this.TextPlan4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan4.Location = new System.Drawing.Point(128, 230);
            this.TextPlan4.Name = "TextPlan4";
            this.TextPlan4.Size = new System.Drawing.Size(67, 38);
            this.TextPlan4.TabIndex = 19;
            this.TextPlan4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan6
            // 
            this.TextPlan6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan6.Location = new System.Drawing.Point(128, 322);
            this.TextPlan6.Name = "TextPlan6";
            this.TextPlan6.Size = new System.Drawing.Size(67, 38);
            this.TextPlan6.TabIndex = 20;
            this.TextPlan6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan5
            // 
            this.TextPlan5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan5.Location = new System.Drawing.Point(128, 276);
            this.TextPlan5.Name = "TextPlan5";
            this.TextPlan5.Size = new System.Drawing.Size(67, 38);
            this.TextPlan5.TabIndex = 21;
            this.TextPlan5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan7
            // 
            this.TextPlan7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan7.Location = new System.Drawing.Point(128, 368);
            this.TextPlan7.Name = "TextPlan7";
            this.TextPlan7.Size = new System.Drawing.Size(67, 38);
            this.TextPlan7.TabIndex = 22;
            this.TextPlan7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan8
            // 
            this.TextPlan8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan8.Location = new System.Drawing.Point(128, 414);
            this.TextPlan8.Name = "TextPlan8";
            this.TextPlan8.Size = new System.Drawing.Size(67, 38);
            this.TextPlan8.TabIndex = 23;
            this.TextPlan8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan9
            // 
            this.TextPlan9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan9.Location = new System.Drawing.Point(128, 460);
            this.TextPlan9.Name = "TextPlan9";
            this.TextPlan9.Size = new System.Drawing.Size(67, 38);
            this.TextPlan9.TabIndex = 15;
            this.TextPlan9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual2
            // 
            this.TextActual2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual2.Location = new System.Drawing.Point(202, 138);
            this.TextActual2.Name = "TextActual2";
            this.TextActual2.Size = new System.Drawing.Size(105, 38);
            this.TextActual2.TabIndex = 24;
            this.TextActual2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance2
            // 
            this.TextBalance2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance2.Location = new System.Drawing.Point(314, 138);
            this.TextBalance2.Name = "TextBalance2";
            this.TextBalance2.Size = new System.Drawing.Size(108, 38);
            this.TextBalance2.TabIndex = 25;
            this.TextBalance2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual3
            // 
            this.TextActual3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual3.Location = new System.Drawing.Point(202, 184);
            this.TextActual3.Name = "TextActual3";
            this.TextActual3.Size = new System.Drawing.Size(105, 38);
            this.TextActual3.TabIndex = 26;
            this.TextActual3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance3
            // 
            this.TextBalance3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance3.Location = new System.Drawing.Point(314, 184);
            this.TextBalance3.Name = "TextBalance3";
            this.TextBalance3.Size = new System.Drawing.Size(108, 38);
            this.TextBalance3.TabIndex = 27;
            this.TextBalance3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual4
            // 
            this.TextActual4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual4.Location = new System.Drawing.Point(202, 230);
            this.TextActual4.Name = "TextActual4";
            this.TextActual4.Size = new System.Drawing.Size(105, 38);
            this.TextActual4.TabIndex = 28;
            this.TextActual4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual5
            // 
            this.TextActual5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual5.Location = new System.Drawing.Point(202, 276);
            this.TextActual5.Name = "TextActual5";
            this.TextActual5.Size = new System.Drawing.Size(105, 38);
            this.TextActual5.TabIndex = 29;
            this.TextActual5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance5
            // 
            this.TextBalance5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance5.Location = new System.Drawing.Point(314, 276);
            this.TextBalance5.Name = "TextBalance5";
            this.TextBalance5.Size = new System.Drawing.Size(108, 38);
            this.TextBalance5.TabIndex = 30;
            this.TextBalance5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual6
            // 
            this.TextActual6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual6.Location = new System.Drawing.Point(202, 322);
            this.TextActual6.Name = "TextActual6";
            this.TextActual6.Size = new System.Drawing.Size(105, 38);
            this.TextActual6.TabIndex = 31;
            this.TextActual6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual7
            // 
            this.TextActual7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual7.Location = new System.Drawing.Point(202, 368);
            this.TextActual7.Name = "TextActual7";
            this.TextActual7.Size = new System.Drawing.Size(105, 38);
            this.TextActual7.TabIndex = 32;
            this.TextActual7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual8
            // 
            this.TextActual8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual8.Location = new System.Drawing.Point(202, 414);
            this.TextActual8.Name = "TextActual8";
            this.TextActual8.Size = new System.Drawing.Size(105, 38);
            this.TextActual8.TabIndex = 33;
            this.TextActual8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextTime1
            // 
            this.TextTime1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTime1.Location = new System.Drawing.Point(4, 84);
            this.TextTime1.Name = "TextTime1";
            this.TextTime1.ReadOnly = true;
            this.TextTime1.Size = new System.Drawing.Size(117, 26);
            this.TextTime1.TabIndex = 50;
            // 
            // TextComment10
            // 
            this.TextComment10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment10.Location = new System.Drawing.Point(429, 506);
            this.TextComment10.Name = "TextComment10";
            this.TextComment10.Size = new System.Drawing.Size(603, 38);
            this.TextComment10.TabIndex = 59;
            this.TextComment10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBalance10
            // 
            this.TextBalance10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBalance10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBalance10.Location = new System.Drawing.Point(314, 506);
            this.TextBalance10.Name = "TextBalance10";
            this.TextBalance10.Size = new System.Drawing.Size(108, 38);
            this.TextBalance10.TabIndex = 60;
            this.TextBalance10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextActual10
            // 
            this.TextActual10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextActual10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextActual10.Location = new System.Drawing.Point(202, 506);
            this.TextActual10.Name = "TextActual10";
            this.TextActual10.Size = new System.Drawing.Size(105, 38);
            this.TextActual10.TabIndex = 60;
            this.TextActual10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPlan10
            // 
            this.TextPlan10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlan10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPlan10.Location = new System.Drawing.Point(128, 506);
            this.TextPlan10.Name = "TextPlan10";
            this.TextPlan10.Size = new System.Drawing.Size(67, 38);
            this.TextPlan10.TabIndex = 60;
            this.TextPlan10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label13
            // 
            this.Label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(128, 1);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(67, 79);
            this.Label13.TabIndex = 1;
            this.Label13.Text = "Kế hoạch";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shape2
            // 
            this.Shape2.BackColor = System.Drawing.Color.Yellow;
            this.Shape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.Shape2.BorderColor = System.Drawing.Color.Transparent;
            this.Shape2.FillColor = System.Drawing.Color.Black;
            this.Shape2.Location = new System.Drawing.Point(118, 115);
            this.Shape2.Name = "Shape2";
            this.Shape2.Size = new System.Drawing.Size(55, 55);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.BtReduce);
            this.GroupBox2.Controls.Add(this.BtIncrease);
            this.GroupBox2.Controls.Add(this.Label19);
            this.GroupBox2.Controls.Add(this.Label18);
            this.GroupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(1050, 651);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(198, 122);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            // 
            // BtReduce
            // 
            this.BtReduce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtReduce.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtReduce.Image = global::Line_Production.Properties.Resources.minus;
            this.BtReduce.Location = new System.Drawing.Point(140, 70);
            this.BtReduce.Name = "BtReduce";
            this.BtReduce.Size = new System.Drawing.Size(53, 43);
            this.BtReduce.TabIndex = 11;
            this.BtReduce.UseVisualStyleBackColor = true;
            this.BtReduce.Click += new System.EventHandler(this.BtReduce_Click);
            // 
            // BtIncrease
            // 
            this.BtIncrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtIncrease.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIncrease.Image = global::Line_Production.Properties.Resources.plus;
            this.BtIncrease.Location = new System.Drawing.Point(140, 15);
            this.BtIncrease.Name = "BtIncrease";
            this.BtIncrease.Size = new System.Drawing.Size(53, 46);
            this.BtIncrease.TabIndex = 10;
            this.BtIncrease.UseVisualStyleBackColor = true;
            this.BtIncrease.Click += new System.EventHandler(this.BtIncrease_Click);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(4, 77);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(109, 19);
            this.Label19.TabIndex = 9;
            this.Label19.Text = "Giảm Số Lượng:";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(5, 26);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(107, 19);
            this.Label18.TabIndex = 9;
            this.Label18.Text = "Tăng Số Lượng:";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.LabelShapeError);
            this.GroupBox3.Controls.Add(this.LabelShapeOffLine);
            this.GroupBox3.Controls.Add(this.LabelShapeOnline);
            this.GroupBox3.Controls.Add(this.ShapeContainer2);
            this.GroupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(1050, 305);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(198, 312);
            this.GroupBox3.TabIndex = 10;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Tình trạng Line";
            // 
            // LabelShapeError
            // 
            this.LabelShapeError.AutoSize = true;
            this.LabelShapeError.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShapeError.Location = new System.Drawing.Point(9, 268);
            this.LabelShapeError.Name = "LabelShapeError";
            this.LabelShapeError.Size = new System.Drawing.Size(85, 19);
            this.LabelShapeError.TabIndex = 9;
            this.LabelShapeError.Text = "Bất thường";
            // 
            // LabelShapeOffLine
            // 
            this.LabelShapeOffLine.AutoSize = true;
            this.LabelShapeOffLine.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShapeOffLine.Location = new System.Drawing.Point(9, 162);
            this.LabelShapeOffLine.Name = "LabelShapeOffLine";
            this.LabelShapeOffLine.Size = new System.Drawing.Size(72, 19);
            this.LabelShapeOffLine.TabIndex = 8;
            this.LabelShapeOffLine.Text = "Báo động";
            // 
            // LabelShapeOnline
            // 
            this.LabelShapeOnline.AutoSize = true;
            this.LabelShapeOnline.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShapeOnline.Location = new System.Drawing.Point(9, 55);
            this.LabelShapeOnline.Name = "LabelShapeOnline";
            this.LabelShapeOnline.Size = new System.Drawing.Size(92, 19);
            this.LabelShapeOnline.TabIndex = 7;
            this.LabelShapeOnline.Text = "Bình thường";
            // 
            // ShapeContainer2
            // 
            this.ShapeContainer2.Location = new System.Drawing.Point(3, 22);
            this.ShapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer2.Name = "ShapeContainer2";
            this.ShapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Shape3,
            this.Shape1,
            this.Shape2});
            this.ShapeContainer2.Size = new System.Drawing.Size(192, 287);
            this.ShapeContainer2.TabIndex = 6;
            this.ShapeContainer2.TabStop = false;
            // 
            // Shape3
            // 
            this.Shape3.BackColor = System.Drawing.Color.Red;
            this.Shape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.Shape3.BorderColor = System.Drawing.Color.Transparent;
            this.Shape3.FillColor = System.Drawing.Color.Black;
            this.Shape3.Location = new System.Drawing.Point(118, 219);
            this.Shape3.Name = "Shape3";
            this.Shape3.Size = new System.Drawing.Size(55, 55);
            // 
            // Shape1
            // 
            this.Shape1.BackColor = System.Drawing.Color.Lime;
            this.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.Shape1.BorderColor = System.Drawing.Color.Transparent;
            this.Shape1.FillColor = System.Drawing.Color.Black;
            this.Shape1.Location = new System.Drawing.Point(118, 11);
            this.Shape1.Name = "Shape1";
            this.Shape1.Size = new System.Drawing.Size(55, 55);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.txtSearch);
            this.GroupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox7.Location = new System.Drawing.Point(1051, 780);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(200, 71);
            this.GroupBox7.TabIndex = 15;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.LightGray;
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2,
            this.ToolStripStatusLabel3,
            this.lblVersion,
            this.ToolStripStatusLabel4,
            this.lblComcontrol,
            this.ToolStripStatusLabel6,
            this.lblState,
            this.ToolStripStatusLabel7,
            this.lblUser,
            this.ToolStripStatusLabel9,
            this.lblTotal,
            this.ToolStripStatusLabel5,
            this.ToolStripStatusLabel8,
            this.lblDate});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 858);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1273, 22);
            this.StatusStrip1.TabIndex = 16;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.ToolStripStatusLabel1.Text = "Support:";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(40, 17);
            this.ToolStripStatusLabel2.Text = "PE-IT";
            this.ToolStripStatusLabel2.ToolTipText = "Support";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(48, 17);
            this.ToolStripStatusLabel3.Text = "Version:";
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(15, 17);
            this.lblVersion.Text = "0";
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(80, 17);
            this.ToolStripStatusLabel4.Text = "Device Name:";
            // 
            // lblComcontrol
            // 
            this.lblComcontrol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComcontrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblComcontrol.Name = "lblComcontrol";
            this.lblComcontrol.Size = new System.Drawing.Size(45, 17);
            this.lblComcontrol.Text = "COM1";
            // 
            // ToolStripStatusLabel6
            // 
            this.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            this.ToolStripStatusLabel6.Size = new System.Drawing.Size(36, 17);
            this.ToolStripStatusLabel6.Text = "State:";
            // 
            // lblState
            // 
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 17);
            this.lblState.Text = "None";
            // 
            // ToolStripStatusLabel7
            // 
            this.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7";
            this.ToolStripStatusLabel7.Size = new System.Drawing.Size(33, 17);
            this.ToolStripStatusLabel7.Text = "User:";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 17);
            this.lblUser.Text = "u23702";
            // 
            // ToolStripStatusLabel9
            // 
            this.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9";
            this.ToolStripStatusLabel9.Size = new System.Drawing.Size(36, 17);
            this.ToolStripStatusLabel9.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 17);
            this.lblTotal.Text = "#NA";
            // 
            // ToolStripStatusLabel5
            // 
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(42, 17);
            this.ToolStripStatusLabel5.Text = "Server:";
            // 
            // ToolStripStatusLabel8
            // 
            this.ToolStripStatusLabel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8";
            this.ToolStripStatusLabel8.Size = new System.Drawing.Size(76, 17);
            this.ToolStripStatusLabel8.Text = "172.28.10.8";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(628, 17);
            this.lblDate.Spring = true;
            this.lblDate.Text = "00:00:00";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelTimeDate
            // 
            this.LabelTimeDate.AutoSize = true;
            this.LabelTimeDate.BackColor = System.Drawing.Color.Black;
            this.LabelTimeDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTimeDate.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelTimeDate.Location = new System.Drawing.Point(575, 0);
            this.LabelTimeDate.Name = "LabelTimeDate";
            this.LabelTimeDate.Size = new System.Drawing.Size(495, 65);
            this.LabelTimeDate.TabIndex = 18;
            this.LabelTimeDate.Text = "10:10:50   2016/08/16";
            this.LabelTimeDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkLinkWip
            // 
            this.chkLinkWip.AutoSize = true;
            this.chkLinkWip.Checked = true;
            this.chkLinkWip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLinkWip.Location = new System.Drawing.Point(1105, 635);
            this.chkLinkWip.Name = "chkLinkWip";
            this.chkLinkWip.Size = new System.Drawing.Size(70, 17);
            this.chkLinkWip.TabIndex = 19;
            this.chkLinkWip.Text = "Link WIP";
            this.chkLinkWip.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 3;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.98433F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.44444F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.63492F));
            this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.LabelTimeDate, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.Panel1, 2, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1273, 65);
            this.TableLayoutPanel1.TabIndex = 20;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lblCode);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.lUser);
            this.Panel1.Controls.Add(this.LinkLabel1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(1076, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(194, 59);
            this.Panel1.TabIndex = 19;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(45, 26);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 16);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Code";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Line_Production.Properties.Resources.icons8_user_30;
            this.PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(37, 33);
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUser.Location = new System.Drawing.Point(45, 5);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(37, 16);
            this.lUser.TabIndex = 1;
            this.lUser.Text = "User";
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel1.Location = new System.Drawing.Point(1, 42);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(43, 16);
            this.LinkLabel1.TabIndex = 0;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Thoát";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Timer3
            // 
            this.Timer3.Enabled = true;
            this.Timer3.Interval = 5000;
            this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfig.Image = global::Line_Production.Properties.Resources.tools_16;
            this.lblConfig.Location = new System.Drawing.Point(1060, 632);
            this.lblConfig.MinimumSize = new System.Drawing.Size(25, 25);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(25, 25);
            this.lblConfig.TabIndex = 17;
            this.lblConfig.Click += new System.EventHandler(this.lblConfig_Click);
            // 
            // Control
            // 
            this.AcceptButton = this.BtStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 880);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.chkLinkWip);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.GroupBox7);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line Production";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Control_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.Table1.ResumeLayout(false);
            this.Table1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Label Label1;
        internal Label Label2;
        internal GroupBox GroupBox1;
        internal TextBox txtDate;
        internal Label Label4;
        internal Label Label3;
        public ComboBox cbbModel;
        public TextBox txtLine;
        internal Label Label5;
        internal TextBox TextCycleTimeCurrent;
        internal Label Label8;
        internal TextBox TextCycleTimeModel;
        internal Label Label7;
        internal Label Label11;
        internal Label Label10;
        internal Label Label9;
        internal TextBox TextBalance;
        internal TextBox txtActual;
        internal TextBox txtPlan;
        internal TableLayoutPanel Table1;
        internal Label Label12;
        internal Label Label16;
        internal Label Label15;
        internal Label Label14;
        internal Label Label13;
        internal TextBox TextActual1;
        internal TextBox TextComment9;
        internal TextBox TextBalance9;
        internal TextBox TextComment8;
        internal TextBox TextBalance8;
        internal TextBox TextComment7;
        internal TextBox TextBalance7;
        internal TextBox TextComment6;
        internal TextBox TextBalance6;
        internal TextBox TextComment5;
        internal TextBox TextComment4;
        internal TextBox TextBalance4;
        internal TextBox TextComment3;
        internal TextBox TextComment2;
        internal TextBox TextComment1;
        internal TextBox TextActual9;
        internal TextBox TextPlan1;
        internal TextBox TextBalance1;
        internal TextBox TextPlan2;
        internal TextBox TextPlan3;
        internal TextBox TextPlan4;
        internal TextBox TextPlan6;
        internal TextBox TextPlan5;
        internal TextBox TextPlan7;
        internal TextBox TextPlan8;
        internal TextBox TextPlan9;
        internal TextBox TextActual2;
        internal TextBox TextBalance2;
        internal TextBox TextActual3;
        internal TextBox TextBalance3;
        internal TextBox TextActual4;
        internal TextBox TextActual5;
        internal TextBox TextBalance5;
        internal TextBox TextActual6;
        internal TextBox TextActual7;
        internal TextBox TextActual8;
        internal TextBox txtSerial;
        internal Label Label17;
        internal GroupBox GroupBox2;
        internal Label Label19;
        internal Label Label18;
        internal GroupBox GroupBox3;
        internal TextBox txtPeople;
        public  System.IO.Ports.SerialPort ComControlPort;
        public  System.IO.Ports.SerialPort ComPressPort;
        internal Timer Timer1;
        internal Button BtStop;
        internal Button BtStart;
        internal Label Label6;
        internal TextBox txtShift;
        internal Label LabelShapeError;
        internal Label LabelShapeOffLine;
        internal Label LabelShapeOnline;
        internal TextBox TextTime9;
        internal TextBox TextTime8;
        internal TextBox TextTime7;
        internal TextBox TextTime6;
        internal TextBox TextTime5;
        internal TextBox TextTime4;
        internal TextBox TextTime3;
        internal TextBox TextTime2;
        internal TextBox TextTime1;
        internal Label lblQuantity;
        internal Button BtReduce;
        internal Button BtIncrease;
        internal TextBox TextTime10;
        internal TextBox TextComment10;
        internal TextBox TextBalance10;
        internal TextBox TextActual10;
        internal TextBox TextPlan10;
        internal Label LabelPCS1BOX;
        internal Label Label23;
        internal Label LabelPCBA;
        internal Label Label22;
        internal TextBox TextMacBox;
        internal Label Label24;
        internal GroupBox GroupBox5;
        internal GroupBox GroupBox4;
        internal Label LabelSoThung;
        internal GroupBox GroupBox6;
        internal Button btDTle;
        internal Timer Timer2;
        internal CheckBox CheckBox1;
        internal GroupBox GroupBox7;
        internal TextBox txtSearch;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripStatusLabel ToolStripStatusLabel3;
        internal ToolStripStatusLabel lblVersion;
        internal ToolStripStatusLabel ToolStripStatusLabel4;
        internal ToolStripStatusLabel lblComcontrol;
        internal ToolStripStatusLabel ToolStripStatusLabel6;
        internal ToolStripStatusLabel lblState;
        internal ToolStripStatusLabel lblDate;
        internal LinkLabel lblConfig;
        private CheckBox chkNG;
        internal ToolStripStatusLabel ToolStripStatusLabel7;
        public ToolStripStatusLabel lblUser;
        internal ToolStripStatusLabel ToolStripStatusLabel5;
        internal ToolStripStatusLabel ToolStripStatusLabel8;
        internal Label LabelTimeDate;
        internal CheckBox chkLinkWip;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Panel Panel1;
        internal PictureBox PictureBox1;
        public  Label lUser;
        internal LinkLabel LinkLabel1;
        public Label lblCode;
        internal ToolStripStatusLabel ToolStripStatusLabel9;
        internal ToolStripStatusLabel lblTotal;
        internal Timer Timer3;
        internal TextBox txtConfirm;
        internal Label Label20;
        private CheckBox chkOK;
        private OvalShape Shape2;
        private ShapeContainer ShapeContainer2;
        private OvalShape Shape3;
        private OvalShape Shape1;
    }
}
