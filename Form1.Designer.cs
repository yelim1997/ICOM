using System;

namespace icom
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CpuBar = new MetroFramework.Controls.MetroProgressBar();
            this.MemBar = new MetroFramework.Controls.MetroProgressBar();
            this.CpuValue = new MetroFramework.Controls.MetroLabel();
            this.MemValue = new MetroFramework.Controls.MetroLabel();
            this.CpuMemChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.cpu = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NumSet = new System.Windows.Forms.Button();
            this.Plabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label10 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.user_name_value = new MetroFramework.Controls.MetroLabel();
            this.System_User = new System.Windows.Forms.Label();
            this.Process_Revert = new MetroFramework.Controls.MetroButton();
            this.System_Hiding = new MetroFramework.Controls.MetroButton();
            this.NextButton_Search = new MetroFramework.Controls.MetroButton();
            this.SearchButton = new MetroFramework.Controls.MetroButton();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.lProcess_Name = new System.Windows.Forms.Label();
            this.Process_End_Button = new MetroFramework.Controls.MetroButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Process_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Process_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Process_Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Process_Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Process_Num_Value = new MetroFramework.Controls.MetroLabel();
            this.lProcess_Num = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.MouseSpeed = new System.Windows.Forms.Label();
            this.NetworkCon = new System.Windows.Forms.Label();
            this.UserDomain = new System.Windows.Forms.Label();
            this.BootMode = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.PcName = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ProgrameInfo = new System.Windows.Forms.Label();
            this.GitHub = new System.Windows.Forms.Label();
            this.CreaterInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CpuMemChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            //
            // timer1
            //
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            //
            // CpuBar
            //
            this.CpuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CpuBar.Location = new System.Drawing.Point(90, 47);
            this.CpuBar.Name = "CpuBar";
            this.CpuBar.Size = new System.Drawing.Size(1036, 36);
            this.CpuBar.TabIndex = 0;
            //
            // MemBar
            //
            this.MemBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemBar.Location = new System.Drawing.Point(90, 105);
            this.MemBar.Name = "MemBar";
            this.MemBar.Size = new System.Drawing.Size(1036, 36);
            this.MemBar.TabIndex = 1;
            //
            // CpuValue
            //
            this.CpuValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CpuValue.AutoSize = true;
            this.CpuValue.Location = new System.Drawing.Point(1144, 58);
            this.CpuValue.Name = "CpuValue";
            this.CpuValue.Size = new System.Drawing.Size(84, 20);
            this.CpuValue.TabIndex = 2;
            this.CpuValue.Text = "metroLabel1";
            //
            // MemValue
            //
            this.MemValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MemValue.AutoSize = true;
            this.MemValue.Location = new System.Drawing.Point(1141, 121);
            this.MemValue.Name = "MemValue";
            this.MemValue.Size = new System.Drawing.Size(87, 20);
            this.MemValue.TabIndex = 3;
            this.MemValue.Text = "metroLabel2";
            //
            // CpuMemChart
            //
            this.CpuMemChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.CpuMemChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.CpuMemChart.Legends.Add(legend2);
            this.CpuMemChart.Location = new System.Drawing.Point(39, 160);
            this.CpuMemChart.Margin = new System.Windows.Forms.Padding(4);
            this.CpuMemChart.Name = "CpuMemChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "CPU";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "RAM";
            this.CpuMemChart.Series.Add(series3);
            this.CpuMemChart.Series.Add(series4);
            this.CpuMemChart.Size = new System.Drawing.Size(959, 367);
            this.CpuMemChart.TabIndex = 5;
            this.CpuMemChart.Text = "chart1";
            //
            // pRAM
            //
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            //
            // pCPU
            //
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            //
            // cpu
            //
            this.cpu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpu.AutoSize = true;
            this.cpu.Location = new System.Drawing.Point(18, 58);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(47, 15);
            this.cpu.TabIndex = 6;
            this.cpu.Text = "CPU :";
            //
            // ram
            //
            this.ram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ram.AutoSize = true;
            this.ram.Location = new System.Drawing.Point(18, 117);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(48, 15);
            this.ram.TabIndex = 7;
            this.ram.Text = "RAM :";
            //
            // tabControl1
            //
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1324, 563);
            this.tabControl1.TabIndex = 8;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.NumSet);
            this.tabPage1.Controls.Add(this.Plabel);
            this.tabPage1.Controls.Add(this.pictureBox);
            this.tabPage1.Controls.Add(this.CpuBar);
            this.tabPage1.Controls.Add(this.MemValue);
            this.tabPage1.Controls.Add(this.CpuMemChart);
            this.tabPage1.Controls.Add(this.CpuValue);
            this.tabPage1.Controls.Add(this.ram);
            this.tabPage1.Controls.Add(this.MemBar);
            this.tabPage1.Controls.Add(this.cpu);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1316, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CPU & RAM Manager";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // NumSet
            //
            this.NumSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumSet.Location = new System.Drawing.Point(1188, 269);
            this.NumSet.Name = "NumSet";
            this.NumSet.Size = new System.Drawing.Size(100, 40);
            this.NumSet.TabIndex = 10;
            this.NumSet.Text = "기준치 설정";
            this.NumSet.UseVisualStyleBackColor = true;
            this.NumSet.Click += new System.EventHandler(this.Button1_Click);
            //
            // Plabel
            //
            this.Plabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Plabel.AutoSize = true;
            this.Plabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Plabel.Location = new System.Drawing.Point(1028, 278);
            this.Plabel.Name = "Plabel";
            this.Plabel.Size = new System.Drawing.Size(135, 20);
            this.Plabel.TabIndex = 9;
            this.Plabel.Text = "현재 cpu 상태";
            //
            // pictureBox
            //
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = global::icom.Properties.Resources.안정;
            this.pictureBox.Location = new System.Drawing.Point(1018, 334);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(270, 170);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.metroLabel4);
            this.tabPage2.Controls.Add(this.metroButton2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1316, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Program Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // metroLabel4
            //
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(148, 23);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "metroLabel4";
            //
            // metroButton2
            //
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(953, 468);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(90, 40);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "삭제";
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Program Count";
            //
              // listView2
              //
              this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
              | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right)));
              this.listView2.CheckBoxes = true;
              this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
              this.columnHeader1,
              this.columnHeader2,
              this.columnHeader3,
              this.columnHeader4});
              this.listView2.Location = new System.Drawing.Point(30, 73);
              this.listView2.Margin = new System.Windows.Forms.Padding(2);
              this.listView2.Name = "listView2";
              this.listView2.Size = new System.Drawing.Size(885, 436);
              this.listView2.TabIndex = 0;
              this.listView2.UseCompatibleStateImageBehavior = false;
              this.listView2.View = System.Windows.Forms.View.Details;
              this.listView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView2_ColumnClick);
              //
              // columnHeader1
              //
              this.columnHeader1.Text = "";
              this.columnHeader1.Width = 20;
              //
              // columnHeader2
              //
              this.columnHeader2.Text = "Program Name";
              this.columnHeader2.Width = 300;
              //
              // columnHeader3
              //
              this.columnHeader3.Text = "Install Date";
              this.columnHeader3.Width = 150;
              //
              // columnHeader4
              //
              this.columnHeader4.Text = "Memory";
              this.columnHeader4.Width = 150;
              //
              // tabPage3
              //
              this.tabPage3.Controls.Add(this.user_name_value);
              this.tabPage3.Controls.Add(this.System_User);
              this.tabPage3.Controls.Add(this.Process_Revert);
              this.tabPage3.Controls.Add(this.System_Hiding);
              this.tabPage3.Controls.Add(this.NextButton_Search);
              this.tabPage3.Controls.Add(this.SearchButton);
              this.tabPage3.Controls.Add(this.SearchBox);
              this.tabPage3.Controls.Add(this.lProcess_Name);
              this.tabPage3.Controls.Add(this.Process_End_Button);
              this.tabPage3.Controls.Add(this.listView1);
              this.tabPage3.Controls.Add(this.Process_Num_Value);
              this.tabPage3.Controls.Add(this.lProcess_Num);
              this.tabPage3.Location = new System.Drawing.Point(4, 25);
              this.tabPage3.Name = "tabPage3";
              this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
              this.tabPage3.Size = new System.Drawing.Size(1316, 534);
              this.tabPage3.TabIndex = 2;
              this.tabPage3.Text = "Background & Foreground Manager";
              this.tabPage3.UseVisualStyleBackColor = true;
              //
              // user_name_value
              //
              this.user_name_value.AutoSize = true;
              this.user_name_value.Location = new System.Drawing.Point(1101, 293);
              this.user_name_value.Name = "user_name_value";
              this.user_name_value.Size = new System.Drawing.Size(116, 20);
              this.user_name_value.TabIndex = 12;
              this.user_name_value.Text = "user_name_value";
              //
              // System_User
              //
              this.System_User.AutoSize = true;
              this.System_User.Location = new System.Drawing.Point(1098, 264);
              this.System_User.Name = "System_User";
              this.System_User.Size = new System.Drawing.Size(112, 15);
              this.System_User.TabIndex = 10;
              this.System_User.Text = "시스템 사용자 :";
              //
              // Process_Revert
              //
              this.Process_Revert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
              this.Process_Revert.Location = new System.Drawing.Point(1117, 345);
              this.Process_Revert.Name = "Process_Revert";
              this.Process_Revert.Size = new System.Drawing.Size(125, 40);
              this.Process_Revert.TabIndex = 9;
              this.Process_Revert.Text = "모든 프로세스";
              this.Process_Revert.Click += new System.EventHandler(this.Process_Revert_Click);
              //
              // System_Hiding
              //
              this.System_Hiding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
              this.System_Hiding.Location = new System.Drawing.Point(1117, 406);
              this.System_Hiding.Name = "System_Hiding";
              this.System_Hiding.Size = new System.Drawing.Size(125, 40);
              this.System_Hiding.TabIndex = 8;
              this.System_Hiding.Text = "System 숨기기";
              this.System_Hiding.Click += new System.EventHandler(this.System_Hiding_Click);
              //
              // NextButton_Search
              //
              this.NextButton_Search.Location = new System.Drawing.Point(617, 29);
              this.NextButton_Search.Name = "NextButton_Search";
              this.NextButton_Search.Size = new System.Drawing.Size(75, 23);
              this.NextButton_Search.TabIndex = 7;
              this.NextButton_Search.Text = "다음";
              this.NextButton_Search.Click += new System.EventHandler(this.NextButton_Search_Click);
              //
              // SearchButton
              //
              this.SearchButton.Location = new System.Drawing.Point(518, 29);
              this.SearchButton.Name = "SearchButton";
              this.SearchButton.Size = new System.Drawing.Size(75, 23);
              this.SearchButton.TabIndex = 6;
              this.SearchButton.Text = "검색";
              this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
              //
              // SearchBox
              //
              this.SearchBox.Location = new System.Drawing.Point(130, 29);
              this.SearchBox.Name = "SearchBox";
              this.SearchBox.Size = new System.Drawing.Size(359, 25);
              this.SearchBox.TabIndex = 5;
              this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Enter);
              //
              // lProcess_Name
              //
              this.lProcess_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
              | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right)));
              this.lProcess_Name.AutoSize = true;
              this.lProcess_Name.Location = new System.Drawing.Point(27, 29);
              this.lProcess_Name.Name = "lProcess_Name";
              this.lProcess_Name.Size = new System.Drawing.Size(97, 15);
              this.lProcess_Name.TabIndex = 4;
              this.lProcess_Name.Text = "프로세스 명 :";
              //
              // Process_End_Button
              //
              this.Process_End_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
              this.Process_End_Button.Location = new System.Drawing.Point(1117, 469);
              this.Process_End_Button.Name = "Process_End_Button";
              this.Process_End_Button.Size = new System.Drawing.Size(90, 40);
              this.Process_End_Button.TabIndex = 3;
              this.Process_End_Button.Text = "프로세스 중지";
              this.Process_End_Button.Click += new System.EventHandler(this.Process_Stop_Button_Click);
              //
              // listView1
              //
              this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
              | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right)));
              this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
              this.Process_Name,
              this.Process_Id,
              this.Process_Memory,
              this.Process_Username});
              this.listView1.HideSelection = false;
              this.listView1.Location = new System.Drawing.Point(30, 115);
              this.listView1.Name = "listView1";
              this.listView1.Size = new System.Drawing.Size(1036, 394);
              this.listView1.TabIndex = 2;
              this.listView1.UseCompatibleStateImageBehavior = false;
              this.listView1.View = System.Windows.Forms.View.Details;
              this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView1_ColumnClick);
              //
              // Process_Name
              //
              this.Process_Name.Text = "ProcessName";
              this.Process_Name.Width = 249;
              //
              // Process_Id
              //
              this.Process_Id.Tag = "Numeric ";
              this.Process_Id.Text = "Process_Id";
              this.Process_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
              this.Process_Id.Width = 180;
              //
              // Process_Memory
              //
              this.Process_Memory.Text = "Process_MemorySize(MB)";
              this.Process_Memory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
              this.Process_Memory.Width = 246;
              //
              // Process_Username
              //
              this.Process_Username.Text = "Process_Username";
              this.Process_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
              this.Process_Username.Width = 200;
              //
              // Process_Num_Value
              //
              this.Process_Num_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
              | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right)));
              this.Process_Num_Value.AutoSize = true;
              this.Process_Num_Value.Location = new System.Drawing.Point(130, 73);
              this.Process_Num_Value.Name = "Process_Num_Value";
              this.Process_Num_Value.Size = new System.Drawing.Size(87, 20);
              this.Process_Num_Value.TabIndex = 1;
              this.Process_Num_Value.Text = "metroLabel3";
              //
              // lProcess_Num
              //
              this.lProcess_Num.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
              | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right)));
              this.lProcess_Num.AutoSize = true;
              this.lProcess_Num.Location = new System.Drawing.Point(27, 78);
              this.lProcess_Num.Name = "lProcess_Num";
              this.lProcess_Num.Size = new System.Drawing.Size(97, 15);
              this.lProcess_Num.TabIndex = 0;
              this.lProcess_Num.Text = "프로세스 수 :";
            //
            // tabPage4
            //
            this.tabPage4.Controls.Add(this.MouseSpeed);
            this.tabPage4.Controls.Add(this.NetworkCon);
            this.tabPage4.Controls.Add(this.UserDomain);
            this.tabPage4.Controls.Add(this.BootMode);
            this.tabPage4.Controls.Add(this.UserName);
            this.tabPage4.Controls.Add(this.PcName);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1316, 534);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "System Information";
            this.tabPage4.UseVisualStyleBackColor = true;
            //
            // MouseSpeed
            //
            this.MouseSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MouseSpeed.AutoSize = true;
            this.MouseSpeed.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MouseSpeed.Location = new System.Drawing.Point(111, 371);
            this.MouseSpeed.Name = "MouseSpeed";
            this.MouseSpeed.Size = new System.Drawing.Size(57, 20);
            this.MouseSpeed.TabIndex = 5;
            this.MouseSpeed.Text = "label8";
            //
            // NetworkCon
            //
            this.NetworkCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NetworkCon.AutoSize = true;
            this.NetworkCon.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NetworkCon.Location = new System.Drawing.Point(111, 306);
            this.NetworkCon.Name = "NetworkCon";
            this.NetworkCon.Size = new System.Drawing.Size(57, 20);
            this.NetworkCon.TabIndex = 4;
            this.NetworkCon.Text = "label7";
            //
            // UserDomain
            //
            this.UserDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserDomain.AutoSize = true;
            this.UserDomain.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserDomain.Location = new System.Drawing.Point(111, 245);
            this.UserDomain.Name = "UserDomain";
            this.UserDomain.Size = new System.Drawing.Size(57, 20);
            this.UserDomain.TabIndex = 3;
            this.UserDomain.Text = "label6";
            //
            // BootMode
            //
            this.BootMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BootMode.AutoSize = true;
            this.BootMode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BootMode.Location = new System.Drawing.Point(111, 183);
            this.BootMode.Name = "BootMode";
            this.BootMode.Size = new System.Drawing.Size(57, 20);
            this.BootMode.TabIndex = 2;
            this.BootMode.Text = "label5";
            //
            // UserName
            //
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserName.Location = new System.Drawing.Point(111, 120);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(57, 20);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "label4";
            //
            // PcName
            //
            this.PcName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PcName.AutoSize = true;
            this.PcName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PcName.Location = new System.Drawing.Point(111, 63);
            this.PcName.Name = "PcName";
            this.PcName.Size = new System.Drawing.Size(57, 20);
            this.PcName.TabIndex = 0;
            this.PcName.Text = "label3";
            //
            // tabPage5
            //
            this.tabPage5.Controls.Add(this.linkLabel1);
            this.tabPage5.Controls.Add(this.ProgrameInfo);
            this.tabPage5.Controls.Add(this.GitHub);
            this.tabPage5.Controls.Add(this.CreaterInfo);
            this.tabPage5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1316, 534);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            //
            // linkLabel1
            //
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(258, 200);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(320, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/yelim1997/ICOM";
            //
            // ProgrameInfo
            //
            this.ProgrameInfo.AutoSize = true;
            this.ProgrameInfo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProgrameInfo.Location = new System.Drawing.Point(107, 271);
            this.ProgrameInfo.Name = "ProgrameInfo";
            this.ProgrameInfo.Size = new System.Drawing.Size(157, 20);
            this.ProgrameInfo.TabIndex = 2;
            this.ProgrameInfo.Text = "프로그램 소개 : ";
            //
            // GitHub
            //
            this.GitHub.AutoSize = true;
            this.GitHub.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GitHub.Location = new System.Drawing.Point(107, 200);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(85, 20);
            this.GitHub.TabIndex = 1;
            this.GitHub.Text = "GitHub : ";
            //
            // CreaterInfo
            //
            this.CreaterInfo.AutoSize = true;
            this.CreaterInfo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CreaterInfo.Location = new System.Drawing.Point(107, 127);
            this.CreaterInfo.Name = "CreaterInfo";
            this.CreaterInfo.Size = new System.Drawing.Size(137, 20);
            this.CreaterInfo.TabIndex = 0;
            this.CreaterInfo.Text = "제작자 정보 : 버뮤다 ( 권예림, 최유진, 이정순 )";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 673);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ICOM | Bermuda";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CpuMemChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroProgressBar CpuBar;
        private MetroFramework.Controls.MetroProgressBar MemBar;
        private MetroFramework.Controls.MetroLabel CpuValue;
        private MetroFramework.Controls.MetroLabel MemValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart CpuMemChart;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Label cpu;
        private System.Windows.Forms.Label ram;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label MouseSpeed;
        private System.Windows.Forms.Label NetworkCon;
        private System.Windows.Forms.Label UserDomain;
        private System.Windows.Forms.Label BootMode;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label PcName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Process_Name;
        private System.Windows.Forms.ColumnHeader Process_Id;
        private MetroFramework.Controls.MetroLabel Process_Num_Value;
        private System.Windows.Forms.Label lProcess_Num;
        private MetroFramework.Controls.MetroButton Process_End_Button;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label Plabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button NumSet;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label lProcess_Name;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton NextButton_Search;
        private System.Windows.Forms.ColumnHeader Process_Memory;
        private System.Windows.Forms.ColumnHeader Process_Username;
        private MetroFramework.Controls.MetroButton System_Hiding;
        private MetroFramework.Controls.MetroButton Process_Revert;
        private System.Windows.Forms.Label System_User;
        private MetroFramework.Controls.MetroLabel user_name_value;
        private System.Windows.Forms.Label ProgrameInfo;
        private System.Windows.Forms.Label GitHub;
        private System.Windows.Forms.Label CreaterInfo;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
