using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic

namespace Line_Production
{
    

    [DesignerGenerated()]
    public partial class frmConfig : System.Windows.Forms.Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
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
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.chkWip = new System.Windows.Forms.CheckBox();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnSaveChanged = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbCOM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chkWip
            // 
            this.chkWip.AutoSize = true;
            this.chkWip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWip.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkWip.Location = new System.Drawing.Point(87, 207);
            this.chkWip.Name = "chkWip";
            this.chkWip.Size = new System.Drawing.Size(109, 17);
            this.chkWip.TabIndex = 2;
            this.chkWip.Text = "Write Log WIP";
            this.chkWip.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 103);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Path Log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(87, 93);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(205, 20);
            this.txtLog.TabIndex = 26;
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point(302, 93);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(31, 20);
            this.btnBrower.TabIndex = 27;
            this.btnBrower.Text = "...";
            this.btnBrower.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 66);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(27, 13);
            this.Label2.TabIndex = 29;
            this.Label2.Text = "Line";
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(87, 59);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(205, 20);
            this.txtLine.TabIndex = 30;
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(87, 129);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(205, 20);
            this.txtStation.TabIndex = 32;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 136);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 13);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "Station";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(87, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(205, 20);
            this.txtId.TabIndex = 36;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(12, 31);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(16, 13);
            this.Label5.TabIndex = 35;
            this.Label5.Text = "Id";
            // 
            // btnSaveChanged
            // 
            this.btnSaveChanged.BackColor = System.Drawing.Color.Green;
            this.btnSaveChanged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanged.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanged.Image = global::Line_Production.Properties.Resources.Save;
            this.btnSaveChanged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanged.Location = new System.Drawing.Point(87, 243);
            this.btnSaveChanged.Name = "btnSaveChanged";
            this.btnSaveChanged.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSaveChanged.Size = new System.Drawing.Size(118, 30);
            this.btnSaveChanged.TabIndex = 24;
            this.btnSaveChanged.Text = "Save change";
            this.btnSaveChanged.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanged.UseVisualStyleBackColor = false;
            this.btnSaveChanged.Click += new System.EventHandler(this.btnSaveChanged_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "COM";
            // 
            // cbbCOM
            // 
            this.cbbCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCOM.FormattingEnabled = true;
            this.cbbCOM.Location = new System.Drawing.Point(87, 167);
            this.cbbCOM.Name = "cbbCOM";
            this.cbbCOM.Size = new System.Drawing.Size(121, 21);
            this.cbbCOM.TabIndex = 38;
            // 
            // frmConfig
            // 
            this.AcceptButton = this.btnSaveChanged;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 308);
            this.Controls.Add(this.cbbCOM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnSaveChanged);
            this.Controls.Add(this.chkWip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configs";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private CheckBox chkWip;
        private Button btnSaveChanged;
        internal FolderBrowserDialog FolderBrowserDialog1;
        internal Label Label1;
        internal TextBox txtLog;
        internal Button btnBrower;
        internal Label Label2;
        internal TextBox txtLine;
        internal TextBox txtStation;
        internal Label Label3;
        internal TextBox txtId;
        internal Label Label5;
        private Label label4;
        private ComboBox cbbCOM;
    }
}