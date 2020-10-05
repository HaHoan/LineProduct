using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line_Production
{
    public partial class NG_FORM : Form
    {
        public NG_FORM()
        {
            InitializeComponent();
        }


        private void NG_FORM_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Control().Show();
           
        }

        private void NG_FORM_FormClosing(object sender, FormClosingEventArgs e)
        {
            // e.Cancel = closeForm
        }

        private void NG_FORM_Load(object sender, EventArgs e)
        {
            // closeForm = True
        }

        private void NG_FORM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}
