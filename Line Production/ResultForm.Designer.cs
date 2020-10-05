using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic

namespace Line_Production
{
    [DesignerGenerated()]
    public partial class ResultForm : System.Windows.Forms.Form
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
            dgv = new System.Windows.Forms.DataGridView();
            _no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _macBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { _no, _macBox, _id });
            dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv.Location = new System.Drawing.Point(0, 0);
            dgv.Name = "dgv";
            dgv.Size = new System.Drawing.Size(841, 721);
            dgv.TabIndex = 0;
            // 
            // _no
            // 
            _no.DataPropertyName = "_no";
            _no.HeaderText = "No";
            _no.Name = "_no";
            _no.ReadOnly = true;
            // 
            // _macBox
            // 
            _macBox.DataPropertyName = "_macBox";
            _macBox.HeaderText = "Mac box";
            _macBox.Name = "_macBox";
            _macBox.ReadOnly = true;
            _macBox.Width = 300;
            // 
            // _id
            // 
            _id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            _id.DataPropertyName = "_id";
            _id.HeaderText = "ID";
            _id.Name = "_id";
            _id.ReadOnly = true;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 721);
            this.Controls.Add(dgv);
            this.Name = "ResultForm";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            this.ResumeLayout(false);
        }

        internal DataGridView dgv;
        internal DataGridViewTextBoxColumn _no;
        internal DataGridViewTextBoxColumn _macBox;
        internal DataGridViewTextBoxColumn _id;
    }
}
