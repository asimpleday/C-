namespace WindowsFormsDemo1
{
    partial class AddStudent
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelStudentNumber = new System.Windows.Forms.Label();
            this.textStudentNumber = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textPassword2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.radioSex2 = new System.Windows.Forms.RadioButton();
            this.radioSex = new System.Windows.Forms.RadioButton();
            this.labelSex = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(102, 375);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 18);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(328, 375);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 18);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelStudentNumber
            // 
            this.labelStudentNumber.AutoSize = true;
            this.labelStudentNumber.Location = new System.Drawing.Point(40, 32);
            this.labelStudentNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStudentNumber.Name = "labelStudentNumber";
            this.labelStudentNumber.Size = new System.Drawing.Size(41, 12);
            this.labelStudentNumber.TabIndex = 3;
            this.labelStudentNumber.Text = "学号：";
            // 
            // textStudentNumber
            // 
            this.textStudentNumber.Location = new System.Drawing.Point(84, 30);
            this.textStudentNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textStudentNumber.Name = "textStudentNumber";
            this.textStudentNumber.ReadOnly = true;
            this.textStudentNumber.Size = new System.Drawing.Size(210, 21);
            this.textStudentNumber.TabIndex = 4;
            this.textStudentNumber.TextChanged += new System.EventHandler(this.textStudentNumber_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(40, 69);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(41, 12);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "密码：";
            this.labelPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(84, 66);
            this.textPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(210, 21);
            this.textPassword.TabIndex = 6;
            this.textPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(18, 106);
            this.labelPassword2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(65, 12);
            this.labelPassword2.TabIndex = 7;
            this.labelPassword2.Text = "确认密码：";
            this.labelPassword2.Click += new System.EventHandler(this.labelPassword2_Click);
            // 
            // textPassword2
            // 
            this.textPassword2.Location = new System.Drawing.Point(85, 102);
            this.textPassword2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPassword2.Name = "textPassword2";
            this.textPassword2.PasswordChar = '*';
            this.textPassword2.Size = new System.Drawing.Size(209, 21);
            this.textPassword2.TabIndex = 8;
            this.textPassword2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.textPassword2);
            this.groupBox1.Controls.Add(this.labelStudentNumber);
            this.groupBox1.Controls.Add(this.labelPassword2);
            this.groupBox1.Controls.Add(this.textStudentNumber);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Location = new System.Drawing.Point(84, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(318, 142);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户注册信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Controls.Add(this.labelTime);
            this.groupBox2.Controls.Add(this.comboBoxGrade);
            this.groupBox2.Controls.Add(this.labelGrade);
            this.groupBox2.Controls.Add(this.radioSex2);
            this.groupBox2.Controls.Add(this.radioSex);
            this.groupBox2.Controls.Add(this.labelSex);
            this.groupBox2.Controls.Add(this.textName);
            this.groupBox2.Controls.Add(this.labelName);
            this.groupBox2.Location = new System.Drawing.Point(84, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(318, 152);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户基本信息";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(76, 114);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker.TabIndex = 8;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(9, 119);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(65, 12);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "出生日期：";
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "一年级",
            "二年级",
            "三年级",
            "四年级",
            "五年级"});
            this.comboBoxGrade.Location = new System.Drawing.Point(76, 88);
            this.comboBoxGrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(218, 20);
            this.comboBoxGrade.TabIndex = 6;
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(32, 91);
            this.labelGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(41, 12);
            this.labelGrade.TabIndex = 5;
            this.labelGrade.Text = "年级：";
            // 
            // radioSex2
            // 
            this.radioSex2.AutoSize = true;
            this.radioSex2.Location = new System.Drawing.Point(113, 58);
            this.radioSex2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioSex2.Name = "radioSex2";
            this.radioSex2.Size = new System.Drawing.Size(35, 16);
            this.radioSex2.TabIndex = 4;
            this.radioSex2.TabStop = true;
            this.radioSex2.Text = "女";
            this.radioSex2.UseVisualStyleBackColor = true;
            // 
            // radioSex
            // 
            this.radioSex.AutoSize = true;
            this.radioSex.Checked = true;
            this.radioSex.Location = new System.Drawing.Point(76, 58);
            this.radioSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioSex.Name = "radioSex";
            this.radioSex.Size = new System.Drawing.Size(35, 16);
            this.radioSex.TabIndex = 3;
            this.radioSex.TabStop = true;
            this.radioSex.Text = "男";
            this.radioSex.UseVisualStyleBackColor = true;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(32, 59);
            this.labelSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(41, 12);
            this.labelSex.TabIndex = 2;
            this.labelSex.Text = "性别：";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(76, 25);
            this.textName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(218, 21);
            this.textName.TabIndex = 1;
            this.textName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 29);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "姓名：";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddStudent";
            this.Text = "新增学生";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelStudentNumber;
        private System.Windows.Forms.TextBox textStudentNumber;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textPassword2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.RadioButton radioSex2;
        private System.Windows.Forms.RadioButton radioSex;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelTime;
    }
}