using System;
using System.Collections.Generic;
using System.ComponentModel;
using ListViewColumSortDLL;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Microsoft.Win32;
using System.Collections;

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
            //Form1_Load, 컴퓨터 정보(?)
            timer1.Start();

            label3.Text = "PC Name : " + SystemInformation.ComputerName;
            label4.Text = "User Name: " + SystemInformation.UserName;
            label5.Text = "Boot Mode: " + SystemInformation.BootMode;
            label6.Text = "User Domain: " + SystemInformation.UserDomainName;
            label7.Text = "Network Connection: " + SystemInformation.Network;
            label8.Text = "Mouse Speed: " + SystemInformation.MouseSpeed;

            //Form1_Load2, 프로세스
            try
            {
                Process[] proc = Process.GetProcesses();
                listView1.CheckBoxes = true;
                metroLabel3.Text = Convert.ToString(proc.Length);
                foreach (Process p in proc)
                {
                    WriteProcessInfo(p);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Form1_Load3, 프로그램
            string computer = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey app = Registry.LocalMachine.OpenSubKey(computer))
            {
                foreach (string appName in app.GetSubKeyNames())
                {

                    using (RegistryKey name = app.OpenSubKey(appName))
                    {
                        try
                        {
                            var displayName = name.GetValue("DisplayName");
                            var installDate = name.GetValue("InstallDate");

                            string[] row = { Convert.ToString(displayName.ToString()), Convert.ToString(installDate.ToString()) };
                            var listViewItem = new ListViewItem(row);
                            listView2.Items.Add(listViewItem);
                        }
                        catch (Exception ex)
                        { Console.WriteLine(ex.Message); }
                    }
                }
                label10.Text += " : " + listView2.Items.Count.ToString();
            }

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

            int ref_value = (int)fcpu;

            if (ref_value < 30)
            {
                pictureBox1.Image = global::icom.Properties.Resources.안정;
            }
            else if (ref_value < 60)
            {
                pictureBox1.Image = Properties.Resources.적정;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.위험;
            }
        }

        private void WriteProcessInfo(Process processInfo)
        {
            string[] row = { Convert.ToString(processInfo.ProcessName), Convert.ToString(processInfo.Id), Convert.ToString((processInfo.VirtualMemorySize64 / 1024) / 1024) };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);

        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            for (int i = 0; i < listView1.Columns.Count; i++)
            {

                listView1.Columns[i].Text = listView1.Columns[i].Text.Replace("▼", "");
                listView1.Columns[i].Text = listView1.Columns[i].Text.Replace("▲", "");

            }

            if (this.listView1.Sorting == SortOrder.Ascending || listView1.Sorting == SortOrder.None)
            {
                listView1.Sorting = SortOrder.Descending;
                listView1.Columns[e.Column].Text = listView1.Columns[e.Column].Text + "▲";
            }
            else
            {
                listView1.Sorting = SortOrder.Ascending;
                listView1.Columns[e.Column].Text = listView1.Columns[e.Column].Text + "▼";

            }
            if (e.Column == 1)
            {
                ItemSort.sort(listView1, e, true);
            }
            else if (e.Column == 0)
            {
                ItemSort.sort(listView1, e, false);
            }
            else
            {
                ItemSort.sort(listView1, e, true);
            }
        }


        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 1)
            { // 1번 칼럼: 숫자 정렬

                ItemSort.sort(listView2, e, true);

            }
            else if (e.Column == 0)
            { // 0번 칼럼: 문자 정렬

                ItemSort.sort(listView2, e, false);

            }
            else
            { // 그 외 칼럼: 문자 정렬

                ItemSort.sort(listView2, e, false);

            }

        }


        private void metroButton1_Click(object sender, EventArgs e)
        {

                if (MessageBox.Show("정말 선택항목을 삭제하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (listView1.SelectedItems.Count > 0)
                    {
                        listView1.Items[0].Focused = false;
                        listView1.Items[0].Selected = false;
                    }
                    if (listView1.Items.Count > 0)
                    {
                        for (int i = listView1.Items.Count - 1; i >= 0; i--)
                        {
                            if (listView1.Items[i].Checked == true)
                            {

                                listView1.Items[i].Remove();

                                metroLabel3.Text = Convert.ToString(listView1.Items.Count);

                            }
                        }
                    }

                }
            }
            private void button1_Click(object sender, EventArgs e) // 기준치 설정 버튼 클릭시 새로운 창 띄움
            {
                  Form2 form2 = new Form2();

                  form2.StartPosition = FormStartPosition.Manual;
                  form2.Location = new Point(400, 300);

                  form2.ShowDialog();

            }
        }
    }
