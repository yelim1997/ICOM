using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Management;

namespace icom
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int listindex = 0;
        int listindex2 = 0;

        public static string CpuSet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1_Load, 컴퓨터 정보(?)
            timer1.Start();

            PcName.Text = "PC Name : " + SystemInformation.ComputerName;
            UserName.Text = "User Name: " + SystemInformation.UserName;
            BootMode.Text = "Boot Mode: " + SystemInformation.BootMode;
            UserDomain.Text = "User Domain: " + SystemInformation.UserDomainName;
            NetworkCon.Text = "Network Connection: " + SystemInformation.Network;
            MouseSpeed.Text = "Mouse Speed: " + SystemInformation.MouseSpeed;

            //Form1_Load2, 프로세스
            try
            {
                Process[] proc = Process.GetProcesses();
                //   listView1.CheckBoxes = true;
                Process_Num_Value.Text = Convert.ToString(proc.Length);
                foreach (Process p in proc)
                {
                    WriteProcessInfo(p);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Form1_Load3, 프로그램리스트 정보 가져오기
            string computer = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey app = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(computer))
            {
                foreach (string appName in app.GetSubKeyNames())
                {

                    using (RegistryKey name = app.OpenSubKey(appName))
                    {
                        try
                        {
                            var uninstall = name.GetValue("UninstallString");
                            var programName = name.GetValue("DisplayName");
                            var installDate = name.GetValue("InstallDate");
                            var memorySize = (int)name.GetValue("EstimatedSize");
                            var publisher = name.GetValue("Publisher");

                            string[] row = { Convert.ToString(programName.ToString()), Convert.ToString(installDate.ToString()), Convert.ToString(memorySize / 1000), Convert.ToString(uninstall.ToString()), Convert.ToString(publisher.ToString()) };
                            var listViewItem = new ListViewItem(row);
                            listView2.Items.Add(listViewItem);
                            Process p = new Process();


                        }
                        catch (Exception ex)
                        { Console.WriteLine(ex.Message); }
                    }
                }
                programCount_head.Text += " : ";
                programCount_num.Text = listView2.Items.Count.ToString();
            }


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            CpuBar.Value = (int)fcpu;
            MemBar.Value = (int)fram;
            CpuValue.Text = string.Format("{0:0.00}%", fcpu);
            MemValue.Text = string.Format("{0:0.00}%", fram);
            CpuMemChart.Series["CPU"].Points.AddY(fcpu);
            CpuMemChart.Series["RAM"].Points.AddY(fram);

            int ref_value = (int)fcpu;

            if (Convert.ToInt32(CpuSet) == 0)
            {
                if (ref_value > 40)
                {
                    pictureBox.Image = global::icom.Properties.Resources.위험;
                }

                else if (40 > ref_value && ref_value > 10)
                {
                    pictureBox.Image = Properties.Resources.적정;
                }

                else
                {
                    pictureBox.Image = Properties.Resources.안정;
                }
            }
            else
            {
                if (ref_value > Convert.ToInt32(CpuSet))
                {
                    pictureBox.Image = global::icom.Properties.Resources.위험;
                }
                else
                {
                    pictureBox.Image = Properties.Resources.안정;
                }
            }
        }



        /*--------------------------------------정렬 작업----------------------------------------------*/
        // listView1 컬럼 클릭시
        private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            for (int i = 0; i < listView1.Columns.Count; i++)
            {

                listView1.Columns[i].Text = listView1.Columns[i].Text.Replace(" ▼", "");
                listView1.Columns[i].Text = listView1.Columns[i].Text.Replace(" ▲", "");

            }

            // false = 문자열 , true = 숫자열

            if (e.Column == 0)
            {
                // Process Name

                ItemSort.sort(listView1, e, false);

            }
            else if (e.Column == 1)
            {
                // Process id

                ItemSort.sort(listView1, e, true);
            }
            else if (e.Column == 3)
            {
                //Process Username

                ItemSort.sort(listView1, e, false);
            }
            else
            {
                // Size

                ItemSort.sort(listView1, e, true);
            }

        }


        private void ListView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            for (int i = 0; i < listView2.Columns.Count; i++)
            {
                listView2.Columns[i].Text = listView2.Columns[i].Text.Replace(" ▼", "");
                listView2.Columns[i].Text = listView2.Columns[i].Text.Replace(" ▲", "");
            }
            if (e.Column == 0)
            { // Program Name

                ItemSort.sort(listView2, e, false);

            }
            else if (e.Column == 1)
            {  // Install Date

                ItemSort.sort(listView2, e, true);
            }
            else if (e.Column == 2)
            { // Size

                ItemSort.sort(listView2, e, true);
            }
            else
            {

                ItemSort.sort(listView2, e, false);
            }
        }


        /*--------------------------------------프로세스 작업----------------------------------------------*/
        // 프로세스의 사용자 이름을 불러오도록 도와주는 함수
        public string GetProcessUsername(int processId)
        {
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            foreach (ManagementObject mgo in processList)
            {
                string[] argList = new string[] { string.Empty, string.Empty };
                int username = Convert.ToInt32(mgo.InvokeMethod("getowner", argList));
                if (username == 0)
                {
                    return argList[1] + "\\" + argList[0];
                }
            }
            return "System";
        }


        //프로세스의 정보를 불러와 listView1이 아이템으로 추가
        private void WriteProcessInfo(Process processInfo)
        {

            string name1 = GetProcessUsername(processInfo.Id);
            string[] row = { Convert.ToString(processInfo.ProcessName), Convert.ToString(processInfo.Id), Convert.ToString((processInfo.VirtualMemorySize64 / 1024) / 1024),Convert.ToString(name1)
 };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);

        }
        // 프로세스 명 검색 시 SearchBox(TextBox) 엔터 이벤트
        private void Search_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //엔터 클릭시 Search Button 실행
            {
                this.SearchButton_Click(sender, e);
            }
        }

        // listView1의 아이템 찾아주는 함수
        private ListViewItem Finditem(string searchtext, int startindex)
        {
            for (int i = startindex; i < listView1.Items.Count; i++)
            {
                ListViewItem SearchText = listView1.Items[i];
                bool isContains = SearchText.SubItems[0].Text.Contains(searchtext);
                if (isContains)
                {
                    return SearchText;
                }

            }
            return null;
        }

        private void Selectitem(ListViewItem SearchText)
        {
            listindex = SearchText.Index;
            listView1.MultiSelect = false;
            SearchText.Selected = true;
            listView1.Select();
            listView1.MultiSelect = true;
        }

        // 프로세스 종료 이벤트
        private void Process_Stop_Button_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.StartPosition = FormStartPosition.Manual;
            form3.Location = new Point(400, 350);
            form3.ShowDialog();
            user_name_value.Text = Form3.text;
            if (user_name_value.Text == Environment.UserName)
            {
                if (MessageBox.Show("정말 선택항목을 종료하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    // 프로세스 하나씩 삭제 구현
                    if (listView1.SelectedItems.Count > 0)
                    {

                        listView1.Items[0].Focused = false;
                        listView1.Items[0].Selected = false;



                        string processname = listView1.SelectedItems[0].SubItems[0].Text;
                        if (MessageBox.Show("'" + processname + "'" + " 을(를) 종료하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Process[] proc = Process.GetProcessesByName(processname);

                            foreach (Process p in proc)
                            {
                                p.Kill();
                            }
                            foreach (ListViewItem listview1 in listView1.SelectedItems)
                            {
                                listView1.Items.Remove(listview1);
                            }

                            Process_Num_Value.Text = Convert.ToString(listView1.Items.Count);

                        }


                    }
                    else
                    {
                        MessageBox.Show("선택된 프로세스가 없습니다.");
                    }
                }
            }
            else
            {
                user_name_value.Text = "";
                MessageBox.Show(" 삭제하실 수 없습니다.");
            }

        }

        // 검색 버튼 클릭 시 이벤트
        private void SearchButton_Click(object sender, EventArgs e)
        {
            ListViewItem SearchText = Finditem(SearchBox.Text, 0);

            if (SearchText == null)
                MessageBox.Show("일치하는 데이터가 없습니다.");
            else
                Selectitem(SearchText);
            listView1.EnsureVisible(listindex);
        }

        // 다음 버튼 클릭 시 이벤트
        private void NextButton_Search_Click(object sender, EventArgs e)
        {
            ListViewItem SearchText = Finditem(SearchBox.Text, ++listindex);
            if ((SearchText != null) && (listindex > 0))
            {
                Selectitem(SearchText);
                listView1.EnsureVisible(listindex);
            }
            else
            {
                MessageBox.Show("마지막 프로세스 입니다.");
                listindex = -1;
                if (listindex == -1)
                {
                    listindex = 0;
                }
            }
            if (listindex == (listView1.Items.Count - 1))
                listindex = -1;
        }

        private void Button1_Click(object sender, EventArgs e) // 기준치 설정 버튼 클릭시 새로운 창 띄움
        {
            Form2 form2 = new Form2();

            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(400, 350);

            form2.ShowDialog();

        }


        // 사용자 이름이 System일 경우 목록에서 제외시켜 주는 버튼
        private void System_Hiding_Click(object sender, EventArgs e)
        {

            if (listView1.Items.Count > 0)
            {

                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {


                    if (!listView1.Items[i].SubItems[3].Text.Contains(SystemInformation.UserName))
                    {
                        listView1.Items.Remove(listView1.Items[i]);
                        Process_Num_Value.Text = Convert.ToString(listView1.Items.Count);

                    }
                }

            }
        }
        // System 프로세스를 포함한 모든 프로세스로 되돌려주는 버튼
        private void Process_Revert_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Process[] proc = Process.GetProcesses();

            /*
            try
            {*/

            //    Process[] proc = Process.GetProcesses();
            //  Process_Num_Value.Text = Convert.ToString(proc.Length);
            foreach (Process p in proc)
            {
                WriteProcessInfo(p);

                //Process_Num_Value.Text = Convert.ToString(listView1.Items.Count);

            }

            /*   }
                  catch (Exception ex)
                  {
                      Console.WriteLine(ex.Message);
                  }*/
            Process_Num_Value.Text = listView1.Items.Count.ToString();

        }

        /*--------------------------------------프로그램 작업----------------------------------------------*/
        private void MetroButton2_Click(object sender, EventArgs e)//프로그램 삭제
        {
            int num = 0;//코드가져오기 성공한 프로그램
            int num2 = 0;//실패한 프로그램
            int num3 = 0;//삭제하면 안되는 프로그램
            if (MessageBox.Show("정말 선택항목을 삭제하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (listView2.SelectedItems.Count > 0)
                {
                    listView2.Items[0].Focused = false;
                    listView2.Items[0].Selected = false;
                }
                if (listView2.Items.Count > 0)
                {
                    string[] product = new string[listView2.Items.Count];
                    for (int i = listView2.Items.Count - 1; i >= 0; i--)
                    {

                        if (listView2.Items[i].Checked == true)
                        {

                            String code = listView2.Items[i].SubItems[3].ToString();

                            if (listView2.Items[i].SubItems[4].Text.Contains("Microsoft"))
                            {
                                num3++;
                            }
                            else if (listView2.Items[i].SubItems[4].Text.Contains("Initech"))
                            {
                                num3++;
                            }
                            else if (listView2.Items[i].SubItems[4].Text.Contains("IVI"))
                            {
                                num3++;
                            }
                            else if (listView2.Items[i].SubItems[4].Text.Contains("RaonSecure"))
                            {
                                num3++;
                            }
                            else if (listView2.Items[i].SubItems[4].Text.Contains("VISA"))
                            {
                                num3++;
                            }
                            else if (listView2.Items[i].SubItems[4].Text.Contains("Windows"))
                            {
                                num3++;
                            }

                            else if (code.Contains("MsiExec"))
                            {

                                product[num] = code.Substring(33, 36);
                                num++;
                                listView2.Items[i].Remove();
                            }
                            else
                                num2++;

                        }

                    }

                    for (int j = 0; j < num; j++)
                    {


                        Process p = new Process();
                        p.StartInfo.FileName = "msiexec.exe";
                        p.StartInfo.Arguments = "/X\"{" + product[j] + "}\"/qn";
                        p.Start();
                    }


                    if (num2 > 0) MessageBox.Show("프로그램 " + num2 + "개를 삭제 실패했습니다. UnistallString을 확인해 주세요.");
                    if (num3 > 0) MessageBox.Show("삭제시 시스템에 지장을 줄지도 모르는 프로그램 " + num3 + "개를 삭제에서 제외하였습니다.");
                    programCount_num.Text = listView2.Items.Count.ToString();


                }
                else
                {
                    MessageBox.Show("선택된 프로그램이 없습니다.");
                }

            }
        }
        // listView2의 아이템 찾아주는 함수
        private ListViewItem Finditem2(string searchtext, int startindex)
        {
            for (int i = startindex; i < listView2.Items.Count; i++)
            {
                ListViewItem SearchText = listView2.Items[i];
                bool isContains = SearchText.SubItems[0].Text.Contains(searchtext);
                if (isContains)
                {
                    return SearchText;
                }

            }
            return null;
        }

        private void Selectitem2(ListViewItem SearchText)
        {
            listindex2 = SearchText.Index;
            listView2.MultiSelect = false;
            SearchText.Selected = true;
            listView2.Select();
            listView2.MultiSelect = true;
        }

        private void program_searchButton_Click(object sender, EventArgs e)//프로그램 검색
        {
            ListViewItem SearchText = Finditem2(Program_SearchBox.Text, 0);

            if (SearchText == null)
                MessageBox.Show("일치하는 데이터가 없습니다.");
            else
                Selectitem2(SearchText);
            listView2.EnsureVisible(listindex2);
        }

        private void Search_Enter2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //엔터 클릭시 Search Button 실행
            {
                this.program_searchButton_Click(sender, e);
            }
        }

        private void program_nextbutton_Click(object sender, EventArgs e)//다음 버튼 클릭
        {
            ListViewItem SearchText = Finditem2(Program_SearchBox.Text, ++listindex2);
            if ((SearchText != null) && (listindex2 > 0))
            {
                Selectitem2(SearchText);
                listView2.EnsureVisible(listindex2); listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("마지막 프로그램 입니다.");
                listindex2 = -1;
                if (listindex2 == -1)
                {
                    listindex2 = 0;
                }
            }
            if (listindex2 == (listView2.Items.Count - 1))
                listindex2 = -1;
        }

        private void programHide_Click(object sender, EventArgs e)//중요 프로그램 숨기기 버튼 클릭 이벤트
        {
            if (listView2.Items.Count > 0)
            {

                for (int i = listView2.Items.Count - 1; i >= 0; i--)
                {
                    if (listView2.Items[i].SubItems[4].Text.Contains("Microsoft"))
                    {
                        listView2.Items.Remove(listView2.Items[i]);
                    }
                    else if (listView2.Items[i].SubItems[4].Text.Contains("Initech"))
                    {
                        listView2.Items.Remove(listView2.Items[i]);
                    }
                    else if (listView2.Items[i].SubItems[4].Text.Contains("IVI"))
                    {
                        listView2.Items.Remove(listView2.Items[i]);
                    }
                    else if (listView2.Items[i].SubItems[4].Text.Contains("RaonSecure"))
                    {
                        listView2.Items.Remove(listView2.Items[i]);
                    }
                    else if (listView2.Items[i].SubItems[4].Text.Contains("VISA"))
                    {
                        listView2.Items.Remove(listView2.Items[i]);
                    }
                    else if (listView2.Items[i].SubItems[4].Text.Contains("Windows"))
                    {
                        listView2.Items.Remove(listView2.Items[i]);
                    }

                }



            }
            listView2.Sorting = SortOrder.Ascending;
            programCount_num.Text = listView2.Items.Count.ToString();
        }

        private void programRevert_Click(object sender, EventArgs e)//전체 목록보기 버튼 클릭 이벤트
        {
            listView2.Items.Clear();

            string computer = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey app = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(computer))
            {
                foreach (string appName in app.GetSubKeyNames())
                {

                    using (RegistryKey name = app.OpenSubKey(appName))
                    {
                        try
                        {
                            var uninstall = name.GetValue("UninstallString");
                            var programName = name.GetValue("DisplayName");
                            var installDate = name.GetValue("InstallDate");
                            var memorySize = (int)name.GetValue("EstimatedSize");
                            var publisher = name.GetValue("Publisher");

                            string[] row = { Convert.ToString(programName.ToString()), Convert.ToString(installDate.ToString()), Convert.ToString(memorySize / 1000), Convert.ToString(uninstall.ToString()), Convert.ToString(publisher.ToString()) };
                            var listViewItem = new ListViewItem(row);
                            listView2.Items.Add(listViewItem);
                            Process p = new Process();


                        }
                        catch (Exception ex)
                        { Console.WriteLine(ex.Message); }
                    }
                }
                programCount_num.Text = listView2.Items.Count.ToString();
            }
        }
    }


    /*--------------------------------------정렬 클래스----------------------------------------------*/
    //sort
    public class ItemComparer : System.Collections.IComparer
    {
        /// <summary>
        /// 정렬할 칼럼의 index
        /// </summary>
        public int Column
        {
            get; set;
        }

        /// <summary>
        /// 정렬 방식
        /// ASC, DESC
        /// </summary>
        public SortOrder Order
        {
            get; set;
        }

        /// <summary>
        /// 숫자형 정렬 여부
        /// </summary>
        public bool IsNumber
        {
            get; set;
        }

        public ItemComparer(int colIndex)
        {
            Column = colIndex;
            Order = SortOrder.None;
            IsNumber = false;
        }

        public int Compare(object a, object b)
        {
            int result;

            ListViewItem itemA = a as ListViewItem;
            ListViewItem itemB = b as ListViewItem;

            if (IsNumber)
            {
                result = int.Parse(itemA.SubItems[Column].Text) - int.Parse(itemB.SubItems[Column].Text);
            }
            else
            {
                result = string.Compare(itemA.SubItems[Column].Text, itemB.SubItems[Column].Text);
            }

            if (Order == SortOrder.Descending)
            {
                result *= -1;
            }
            return result;
        }
    }


    public class ItemSort
    {

        /// <summary>
        /// ListView ColumnClick 함수 내에서 클릭
        /// 최초 클릭시 오름차순(ASC) 정렬 됨
        /// </summary>
        /// <param name="listView">정렬할 ListView 객체</param>
        /// <param name="e">ColumnClick Event의 이벤트 객체</param>
        /// <param name="isNumber">숫자형 정렬 여부</param>
        public static void sort(ListView listView, ColumnClickEventArgs e, bool isNumber)
        {
            ItemComparer sorter = listView.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                listView.ListViewItemSorter = sorter;
            }

            sorter.IsNumber = isNumber;
            if (e.Column == sorter.Column)
            {
                if (sorter.Order == SortOrder.Ascending)
                {
                    sorter.Order = SortOrder.Descending;
                    listView.Columns[e.Column].Text = listView.Columns[e.Column].Text + " ▼";
                }
                else
                {
                    sorter.Order = SortOrder.Ascending;
                    listView.Columns[e.Column].Text = listView.Columns[e.Column].Text + " ▲";
                }
            }
            else
            {
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
                listView.Columns[e.Column].Text = listView.Columns[e.Column].Text + " ▲";
            }
            listView.Sort();
        }
    }

}
