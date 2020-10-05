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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnSaveChanged_Click(object sender, EventArgs e)
        {
            Common.WriteRegistry(Constants.PathConfig, "id", txtId.Text);
            Common.WriteRegistry(Constants.PathConfig, "nameLine", txtLine.Text);
            Common.WriteRegistry(Constants.PathConfig, "useWip", chkWip.Checked.ToString());
            Common.WriteRegistry(Constants.PathConfig, "pathWip", txtLog.Text);
            Common.WriteRegistry(Constants.PathConfig, "station", txtStation.Text.Trim());
            Common.WriteRegistry(Constants.PathConfig, "stationBefore", txtStationBefore.Text.Trim());
            var confirm = MessageBox.Show("Save success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (confirm == DialogResult.OK)
            {
                Close();
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtId.Text = Common.GetValueRegistryKey(Constants.PathConfig, "id");
            try
            {
                bool chkWipValue = bool.Parse(Common.GetValueRegistryKey(Constants.PathConfig, "useWip"));
                chkWip.Checked = chkWipValue;
            } catch { }
            
            txtLog.Text = Common.GetValueRegistryKey(Constants.PathConfig, "pathWip");
            txtLine.Text = Common.GetValueRegistryKey(Constants.PathConfig, "nameLine");
            txtStation.Text = Common.GetValueRegistryKey(Constants.PathConfig, "station");
            txtStationBefore.Text = Common.GetValueRegistryKey(Constants.PathConfig, "stationBefore");

            // txtLine.Text = NameLine
            // txtStation.Text = STATION
            // txtStationBefore.Text = STATION_BEFORE
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {

        }
    }
}
