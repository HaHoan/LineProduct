using Microsoft.VisualBasic.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace Line_Production
{
    partial class fmLogin
    {
        // Form overrides dispose to clean up the component list.
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.RectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.RectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.RectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblCapslock = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.OvalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(295, 50);
            this.Panel1.TabIndex = 0;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(268, 13);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(17, 20);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "X";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            this.Label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(67, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(129, 31);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Client Login";
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.OvalShape1,
            this.RectangleShape3,
            this.RectangleShape2,
            this.RectangleShape1});
            this.ShapeContainer1.Size = new System.Drawing.Size(295, 435);
            this.ShapeContainer1.TabIndex = 1;
            this.ShapeContainer1.TabStop = false;
            // 
            // RectangleShape3
            // 
            this.RectangleShape3.BackColor = System.Drawing.Color.Gold;
            this.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.RectangleShape3.BorderColor = System.Drawing.Color.Gold;
            this.RectangleShape3.CornerRadius = 3;
            this.RectangleShape3.Location = new System.Drawing.Point(12, 357);
            this.RectangleShape3.Name = "RectangleShape3";
            this.RectangleShape3.Size = new System.Drawing.Size(271, 38);
            // 
            // RectangleShape2
            // 
            this.RectangleShape2.BackColor = System.Drawing.Color.White;
            this.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.RectangleShape2.BorderColor = System.Drawing.Color.White;
            this.RectangleShape2.CornerRadius = 3;
            this.RectangleShape2.Location = new System.Drawing.Point(12, 251);
            this.RectangleShape2.Name = "RectangleShape2";
            this.RectangleShape2.Size = new System.Drawing.Size(271, 38);
            // 
            // RectangleShape1
            // 
            this.RectangleShape1.BackColor = System.Drawing.Color.White;
            this.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.RectangleShape1.BorderColor = System.Drawing.Color.White;
            this.RectangleShape1.CornerRadius = 3;
            this.RectangleShape1.Location = new System.Drawing.Point(12, 170);
            this.RectangleShape1.Name = "RectangleShape1";
            this.RectangleShape1.Size = new System.Drawing.Size(271, 38);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(19, 260);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 19);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gold;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(14, 359);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(268, 36);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(19, 179);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(260, 19);
            this.txtUsername.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(15, 144);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(87, 20);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Username:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(15, 225);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(82, 20);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Password:";
            // 
            // lblCapslock
            // 
            this.lblCapslock.AutoSize = true;
            this.lblCapslock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapslock.ForeColor = System.Drawing.Color.White;
            this.lblCapslock.Location = new System.Drawing.Point(76, 316);
            this.lblCapslock.Name = "lblCapslock";
            this.lblCapslock.Size = new System.Drawing.Size(11, 16);
            this.lblCapslock.TabIndex = 10;
            this.lblCapslock.Text = ".";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Line_Production.Properties.Resources.secrecy_icon1;
            this.PictureBox1.Location = new System.Drawing.Point(3, 8);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(34, 37);
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            // 
            // OvalShape1
            // 
            this.OvalShape1.BackgroundImage = global::Line_Production.Properties.Resources.umcvn;
            this.OvalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OvalShape1.Location = new System.Drawing.Point(101, 58);
            this.OvalShape1.Name = "OvalShape1";
            this.OvalShape1.Size = new System.Drawing.Size(75, 75);
            // 
            // fmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(295, 435);
            this.ControlBox = false;
            this.Controls.Add(this.lblCapslock);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ShapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "fmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fmLogin_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Panel Panel1;
        internal Label Label2;
        internal Label Label1;
        internal TextBox txtPassword;
        internal Button btnLogin;
        internal TextBox txtUsername;
        internal Label Label3;
        internal Label Label4;
        internal PictureBox PictureBox1;
        internal Label lblCapslock;
        private ShapeContainer ShapeContainer1;
        private RectangleShape RectangleShape2;
        private RectangleShape RectangleShape1;
        private RectangleShape RectangleShape3;
        private OvalShape OvalShape1;
    }
}
