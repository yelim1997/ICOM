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
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            var displayName = sk.GetValue("DisplayName");
                            var size = sk.GetValue("EstimatedSize");

                            ListViewItem item;
                            if (displayName != null)
                            {
                                if (size != null)
                                {
                                    item = new ListViewItem(new string[] {displayName.ToString(),
                                                       size.ToString()});
                                }
                                else
                                    item = new ListViewItem(new string[] { displayName.ToString() });
                                checkedListBox1.Items.Add(item);
                            }
                        }
                        catch (Exception ex)
                        { }
                    }
                }
                //label10.Text += " (" + ProgramName.Items.Count.ToString() + ")";
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
                listView1.Columns[i].Text = listView1.Columns[i].Text.Replace("▲", "");
                listView1.Columns[i].Text = listView1.Columns[i].Text.Replace("▼", "");

            }
            if (this.listView1.Sorting == SortOrder.Ascending || listView1.Sorting == SortOrder.None)
            {
                this.listView1.ListViewItemSorter = new ListViewItemComparerASC(e.Column);
                listView1.Sorting = SortOrder.Descending;
                listView1.Columns[e.Column].Text = listView1.Columns[e.Column].Text + "▲";
            }
            else
            {
                this.listView1.ListViewItemSorter = new ListViewItemComparerDESC(e.Column);
                listView1.Sorting = SortOrder.Ascending;
                listView1.Columns[e.Column].Text = listView1.Columns[e.Column].Text + "▼";

            }

            listView1.Sort();

        }
        class ListViewItemComparerASC : IComparer
        {
            private int col;

            public ListViewItemComparerASC()
            {
                col = 0;
            }
            public ListViewItemComparerASC(int column)
            {
                col = column;

            }
            public int Compare(object x, object y)

            {
                try
                {
                    if (Convert.ToInt32(((ListViewItem)x).SubItems[col].Text) > Convert.ToInt32(((ListViewItem)y).SubItems[col].Text))
                    {
                        return 1;
                    }
                    else
                        return -1;
                }
                catch (Exception)
                {


                    return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);

                }



            }





        }
        class ListViewItemComparerDESC : IComparer
        {
            private int col;

            public ListViewItemComparerDESC()
            {
                col = 0;
            }
            public ListViewItemComparerDESC(int column)
            {
                col = column;

            }
            public int Compare(object x, object y)

            {
                try
                {
                    if (Convert.ToInt32(((ListViewItem)x).SubItems[col].Text) < Convert.ToInt32(((ListViewItem)y).SubItems[col].Text))
                    {
                        return 1;
                    }
                    else
                        return -1;
                }
                catch (Exception)
                {

                    return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);
                }
            }

        }

    }
}
