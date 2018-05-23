using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace icom
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            label3.Text = "PC Name : " + SystemInformation.ComputerName;
            label4.Text = "User Name: " + SystemInformation.UserName;
            label5.Text = "Boot Mode: " + SystemInformation.BootMode;
            label6.Text = "User Domain: " + SystemInformation.UserDomainName;
            label7.Text = "Network Connection: " + SystemInformation.Network;
            label8.Text = "Mouse Speed: " + SystemInformation.MouseSpeed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            metroProgressBar1.Value = (int)fcpu;
            metroProgressBar2.Value = (int)fram;
            metroLabel1.Text = string.Format("{0:0.00}%", fcpu);
            metroLabel2.Text = string.Format("{0:0.00}%", fram);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }

    }
}
