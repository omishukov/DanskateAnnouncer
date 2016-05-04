using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace DanskateAnnouncer
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void LoadSettings(object sender, EventArgs e)
        {
            showMessageCheckBox.Checked = DanskateAnnouncer.Properties.Settings.Default.ShowMessage;

            IpIfIsuCalcCB.Items.Clear();
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            IpIfIsuCalcCB.Items.Add("127.0.0.1");
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet || adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    foreach (UnicastIPAddressInformation ip in adapter.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            IpIfIsuCalcCB.Items.Add(ip.Address.ToString());
                        }
                    }
                }
            }
            IpIfIsuCalcCB.SelectedIndex = IpIfIsuCalcCB.Items.IndexOf(DanskateAnnouncer.Properties.Settings.Default.IsuCalcIpIf);
            IpPortIsuCalcNUD.Value = Convert.ToDecimal(DanskateAnnouncer.Properties.Settings.Default.IsuCalcIpPort);
        }

        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            // If the user clicked "Save"
            if (this.DialogResult == DialogResult.OK)
            {
                DanskateAnnouncer.Properties.Settings.Default.ShowMessage = showMessageCheckBox.Checked;
                DanskateAnnouncer.Properties.Settings.Default.IsuCalcIpIf = IpIfIsuCalcCB.SelectedItem.ToString();
                DanskateAnnouncer.Properties.Settings.Default.IsuCalcIpPort = (uint)IpPortIsuCalcNUD.Value;
                DanskateAnnouncer.Properties.Settings.Default.Save();
            }
        }
    }
}