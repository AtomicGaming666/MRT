using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mordhau_RCON
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            lblVersion.Text = "Version: " + Application.ProductVersion;
        }

        private void CopyMail(object sender, EventArgs e)
        {
            Clipboard.SetText("ashflannery92@yahoo.com");
        }

        private void mailClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:ashflannery92@yahoo.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("AtomicGaming666#8864");
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("#");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
