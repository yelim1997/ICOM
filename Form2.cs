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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        string[] cpu_value = new string[30];
        int cnt = 0;
        int num = 0;


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("창을 닫으시겠습니까? ");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for(int i=0;i< cpu_value.Length;i++)
            {
                cpu_value[i] = textBox1.Text;
                cnt++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             num = Convert.ToInt32(cpu_value[cnt]);
        }
    }
}
