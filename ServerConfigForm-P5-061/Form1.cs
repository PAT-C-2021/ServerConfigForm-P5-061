using ServiceMtk_P1_061;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_061
{
    public partial class Form1 : Form
    {

        private ServiceHost Host;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonOn_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik Off untuk Mematikan Server";
            Host.Open();
            buttonOff.Enabled = true;
            buttonOn.Enabled = false;

        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            buttonOff.Enabled = false;
            buttonOn.Enabled = true;
            Host.Close();
            labelKet.Text = "Klik Untuk Menjalankan Server";
            labelOnOrOff.Text = "Server Off";
        }
    }
}
