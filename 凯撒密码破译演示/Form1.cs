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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            MessageBox.Show("输入已清空", "提示");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox3.Text == ""))
            {
                if((textBox1.Text == "")&&(textBox3.Text != ""))
                {
                    MessageBox.Show("请输入明文!", "警告");
                }
                else if((textBox1.Text != "") && (textBox3.Text == ""))
                {
                    MessageBox.Show("请输入密钥!", "警告");
                }
                else
                {
                    MessageBox.Show("请输入明文和密钥!", "警告");
                }
            }
            else
            {
                try
                {
                    String st = textBox3.Text;
                    int my = int.Parse(st);
                    if(my > 25 || my < 0)
                    {
                        MessageBox.Show("密钥请输入0-25之间的整数!", "警告");
                    }
                    else
                    {
                        encryption ep = new encryption(int.Parse(textBox3.Text), (textBox1.Text).ToString(), "", 1);   //最后一个参数1代表加密请求
                        ep.ShowDialog();
                    }
                }
                catch
                {
                    MessageBox.Show("密钥请输入整数!", "警告");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "") || (textBox3.Text == ""))
            {
                if ((textBox2.Text == "") && (textBox3.Text != ""))
                {
                    MessageBox.Show("请输入密文!", "警告");
                }
                else if ((textBox2.Text != "") && (textBox3.Text == ""))
                {
                    MessageBox.Show("请输入密钥!", "警告");
                }
                else
                {
                    MessageBox.Show("请输入密文和密钥!", "警告");
                }
            }
            else
            {
                try
                {
                    String st = textBox3.Text;
                    int my = int.Parse(st);
                    if (my > 25 || my < 0)
                    {
                        MessageBox.Show("密钥请输入0-25之间的整数!", "警告");
                    }
                    else
                    {
                        encryption ep = new encryption(int.Parse(textBox3.Text), "", (textBox2.Text).ToString(), 2);   //最后一个参数2代表解密请求
                        ep.ShowDialog();
                    }
                }
                catch
                {
                    MessageBox.Show("密钥请输入整数!", "警告");
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DecipherUi decipherUi = new DecipherUi();
            decipherUi.ShowDialog();
        }
    }
}
