using System;
using System.Windows.Forms;

namespace Line_Production
{
  
    public partial class Schedule : Form
    {
        public Action<string> updateTotal;
        public Schedule()
        {
            InitializeComponent();
        }
        private bool closeForm = true;

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (Common.Validate_qty(txtTotal.Text))
                {
                    // hoan modify
                    /// Control.lblTotal.Text = txtTotal.Text;
                    updateTotal(txtTotal.Text);
                    txtTotal.ResetText();
                    closeForm = false;
                    Close();
                }
                else
                {
                    MessageBox.Show("Số lượng không đúng định dạng!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTotal.SelectAll();
                }
            }
        }

        private void Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = closeForm;
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            closeForm = true;
        }
    }
}
