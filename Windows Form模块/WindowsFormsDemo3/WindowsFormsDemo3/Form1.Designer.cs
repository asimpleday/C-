namespace WindowsFormsDemo3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("C盘", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("D盘", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("E盘", 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LVComputer = new System.Windows.Forms.ListView();
            this.ILLarge = new System.Windows.Forms.ImageList(this.components);
            this.ILSmall = new System.Windows.Forms.ImageList(this.components);
            this.btnLarge = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LVComputer
            // 
            this.LVComputer.Dock = System.Windows.Forms.DockStyle.Top;
            this.LVComputer.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.LVComputer.LargeImageList = this.ILLarge;
            this.LVComputer.Location = new System.Drawing.Point(0, 0);
            this.LVComputer.Name = "LVComputer";
            this.LVComputer.Size = new System.Drawing.Size(800, 304);
            this.LVComputer.SmallImageList = this.ILSmall;
            this.LVComputer.TabIndex = 0;
            this.LVComputer.UseCompatibleStateImageBehavior = false;
            // 
            // ILLarge
            // 
            this.ILLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILLarge.ImageStream")));
            this.ILLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ILLarge.Images.SetKeyName(0, "tsbtn2.png");
            this.ILLarge.Images.SetKeyName(1, "tsbtn1.png");
            this.ILLarge.Images.SetKeyName(2, "tsbtn3.png");
            // 
            // ILSmall
            // 
            this.ILSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILSmall.ImageStream")));
            this.ILSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ILSmall.Images.SetKeyName(0, "tsbtn1.png");
            this.ILSmall.Images.SetKeyName(1, "tsbtn2.png");
            this.ILSmall.Images.SetKeyName(2, "tsbtn3.png");
            // 
            // btnLarge
            // 
            this.btnLarge.Location = new System.Drawing.Point(285, 367);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(75, 23);
            this.btnLarge.TabIndex = 1;
            this.btnLarge.Text = "大图标";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(437, 367);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(75, 23);
            this.btnSmall.TabIndex = 1;
            this.btnSmall.Text = "小图标";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.LVComputer);
            this.Name = "Form1";
            this.Text = "计算机";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LVComputer;
        private System.Windows.Forms.ImageList ILLarge;
        private System.Windows.Forms.ImageList ILSmall;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.Button btnSmall;
    }
}

