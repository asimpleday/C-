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
using WindowsFormsDemo1.Entity;

namespace WindowsFormsDemo1
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void textStudentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void labelPassword2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 增加学生
            Student student = new Student();
            student.StudentNo = textStudentNumber.Text;
            student.LoginPwd = textPassword.Text;
            student.StudentName = textName.Text;
            student.Gender = radioSex.Checked ? "1" : "0";
            student.GradeId = comboBoxGrade.SelectedValue.ToString();
            student.Phone = "18521347105";
            student.Address = "上海市杨浦区国定路335号7楼B区";
            student.Birthday = "1994-02-19";
            student.Email = "1637203692@qq.com";
            Add(student);

        }

        public void Add(Student student)
        {
            // 1、建立连接
            string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            // 3、编写sql语句
            string sql = string.Format(@"insert into Student(StudentNo, LoginPwd, StudentName, Gender, GradeId, Phone, Address, Birthday, Email) 
values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", student.StudentNo, student.LoginPwd, student.StudentName, student.Gender, student.GradeId, student.Phone, student.Address,student.Birthday, student.Email);
            
            // 4、创建命令对象
            SqlCommand command = new SqlCommand(sql.ToString(), connection);

            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("新增成功~");
            }
            else
            {
                MessageBox.Show("新增失败~");
            }
        }

        // 初始化
        private void AddStudent_Load(object sender, EventArgs e)
        {
            InitData();
        }

        public void InitData()
        {
            var list = new List<Grade>();
            list.Add(new Grade() { GradeId = '1', GradeName = "一年级" });
            list.Add(new Grade() { GradeId = '2', GradeName = "二年级" });
            list.Add(new Grade() { GradeId = '3', GradeName = "三年级" });
            comboBoxGrade.DataSource = list;
            comboBoxGrade.DisplayMember = "GradeName";
            comboBoxGrade.ValueMember = "GradeId";
        }
    }
}
