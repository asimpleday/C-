using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            // 大图标设置
            LVComputer.View = View.LargeIcon;
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            // 小图标设置
            LVComputer.View = View.SmallIcon;
        }
    }
}
