using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 凯撒密码破译演示
{
    public partial class result : Form
    {
        public result(String msg1,String text1,String msg2,String text2)
        {
            InitializeComponent();
            label1.Text = msg1;
            label2.Text = text1;
            label3.Text = msg2;
            label4.Text = text2;
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }


    }
}
