namespace icom
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.explanation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.Label();
            this.user_name_Input = new System.Windows.Forms.TextBox();
            this.Certify_Button = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            //
            // explanation
            //
            this.explanation.AutoSize = true;
            this.explanation.Font = new System.Drawing.Font("휴먼모음T", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explanation.Location = new System.Drawing.Point(135, 105);
            this.explanation.Name = "explanation";
            this.explanation.Size = new System.Drawing.Size(432, 54);
            this.explanation.TabIndex = 0;
            this.explanation.Text = "프로세스를 삭제하기 위한 인증 창 입니다.\nSystem의 User name을 입력하여 주세요.";
            //
            // label2
            //
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            //
            // User_name
            //
            this.User_name.AutoSize = true;
            this.User_name.Font = new System.Drawing.Font("휴먼매직체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.User_name.Location = new System.Drawing.Point(38, 206);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(117, 19);
            this.User_name.TabIndex = 1;
            this.User_name.Text = "User name :";
            //
            // user_name_Input
            //
            this.user_name_Input.Location = new System.Drawing.Point(161, 200);
            this.user_name_Input.Name = "user_name_Input";
            this.user_name_Input.Size = new System.Drawing.Size(255, 25);
            this.user_name_Input.TabIndex = 2;
            this.user_name_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Enter2);

            //
            // Certify_Button
            //
            this.Certify_Button.Location = new System.Drawing.Point(441, 200);
            this.Certify_Button.Name = "Certify_Button";
            this.Certify_Button.Size = new System.Drawing.Size(75, 23);
            this.Certify_Button.TabIndex = 3;
            this.Certify_Button.Text = "확인";
            this.Certify_Button.Click += new System.EventHandler(this.metroButton1_Click);
            //
            // Form3
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Certify_Button);
            this.Controls.Add(this.user_name_Input);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.explanation);
            this.Name = "Form3";
            this.Text = "시스템 인증";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label explanation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label User_name;
        private System.Windows.Forms.TextBox user_name_Input;
        private MetroFramework.Controls.MetroButton Certify_Button;
    }
}
