using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic
namespace Line_Production
{
    [DesignerGenerated()]
    public partial class NG_FORM : System.Windows.Forms.Form
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
            this.components = new System.ComponentModel.Container();
            this.Label1 = new System.Windows.Forms.Label();
            this.Lb_inform_NG = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(276, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(447, 270);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "NG";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_inform_NG
            // 
            this.Lb_inform_NG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_inform_NG.Font = new System.Drawing.Font("Palatino Linotype", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_inform_NG.ForeColor = System.Drawing.Color.Red;
            this.Lb_inform_NG.Location = new System.Drawing.Point(3, 16);
            this.Lb_inform_NG.Name = "Lb_inform_NG";
            this.Lb_inform_NG.Size = new System.Drawing.Size(1078, 201);
            this.Lb_inform_NG.TabIndex = 1;
            this.Lb_inform_NG.Text = "Label must be 10 digitals";
            this.Lb_inform_NG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 400;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Lb_inform_NG);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox2.Location = new System.Drawing.Point(0, 494);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(1084, 220);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.txtPass);
            this.GroupBox3.Location = new System.Drawing.Point(274, 372);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(548, 59);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(6, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(227, 29);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Xác nhận mở khóa";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(239, 13);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(291, 35);
            this.txtPass.TabIndex = 0;
            // 
            // NG_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 714);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NG_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NG_FORM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NG_FORM_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NG_FORM_FormClosed);
            this.Load += new System.EventHandler(this.NG_FORM_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NG_FORM_KeyDown);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Label Label1;
        internal Label Lb_inform_NG;
        internal Timer Timer1;
        internal GroupBox GroupBox2;
        internal GroupBox GroupBox3;
        internal Label Label2;
        internal TextBox txtPass;
    }
}
