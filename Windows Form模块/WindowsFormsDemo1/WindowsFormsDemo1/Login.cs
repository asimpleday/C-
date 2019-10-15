using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("真的要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                // 窗体关闭
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPass = txtPassword.Text;
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("请输入用户名", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            else if(string.IsNullOrEmpty(userPass))
            {
                MessageBox.Show("请输入密码", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // 1、建立连接
            string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            // 3、编写sql语句
            StringBuilder sql = new StringBuilder(string.Format("select count(*) from admin where loginid = '{0}' and loginpwd = '{1}'", txtUserName.Text, txtPassword.Text));
            // 4、创建命令对象
            SqlCommand command = new SqlCommand(sql.ToString(), connection);

            int result = (int)command.ExecuteScalar();
            if (result > 0)
            {
                MessageBox.Show("登陆成功了");
                
                // 实例化主窗体类的一个对象
                MainForm mainForm = new MainForm();
                mainForm.userName = txtUserName.Text;
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("登陆失败了");
            }

        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("打开了一个新建窗口。");
        }

        private void 网站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("新建了一个网站。");
        }

        private void tsmi_AddStudent_Click(object sender, EventArgs e)
        {
            // 打开一个新增学生窗体
            AddStudent addStudent = new AddStudent();
            addStudent.MdiParent = this;
            addStudent.Show();
        }

        private void tsmi_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
