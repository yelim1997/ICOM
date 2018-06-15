using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace icom
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public static string text;
        Form1 form;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Search_Enter2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //엔터 클릭시 Search Button 실행
            {
                this.metroButton1_Click(sender, e);

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            text = user_name_Input.Text;
            if (user_name_Input.Text == Environment.UserName)
            {
                MessageBox.Show("인증에 성공 하셨습니다.");
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("인증에 실패하셨습니다.");
            }
        }
    }
}
