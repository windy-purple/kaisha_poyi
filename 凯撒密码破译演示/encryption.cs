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
    public partial class encryption : Form
    {
        private int Key;
        private String ClearText;
        private String CipherText;
        private int flag;
        public encryption(int key,String cleartext,String ciphertext,int mark)
        {
            InitializeComponent();
            this.Key = key;
            this.ClearText = cleartext;
            this.CipherText = ciphertext;
            this.flag = mark;
            init();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void init()
        {
            if (this.flag == 1)
            {
                label2.Text = (this.Key).ToString();
                GetPasswordTable gpt = new GetPasswordTable();
                char[] arr = gpt.get_uppercase_pt(this.Key);
                String pt = new string(arr);
                label7.Text = pt;
            }
            else if(this.flag == 2)
            {
                label2.Text = (this.Key).ToString();
                GetPasswordTable gpt = new GetPasswordTable();
                char[] arr = gpt.get_lowercase_pt(this.Key);
                String pt = new string(arr);
                label7.Text = pt;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.flag == 1)
            {
                jiami jm = new jiami();
                result re = new result("明文为：",ClearText,"加密后的密文为：", jm.Encryption(this.ClearText, this.Key));
                re.ShowDialog();
            }
            else
            {
                MessageBox.Show("解密时请勿使用加密操作!", "警告");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.flag == 2)
            {
                jiami jm = new jiami();
                result re = new result("密文为：", CipherText, "解密后的明文为：", jm.Decrypt(this.CipherText, this.Key));
                re.ShowDialog();
            }
            else
            {
                MessageBox.Show("加密时请勿使用解密操作!", "警告");
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}
