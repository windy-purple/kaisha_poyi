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
    public partial class Uiviolence : Form
    {
        public String mw;
        public Uiviolence(String mw)
        {
            InitializeComponent();
            this.mw = mw;
            init();
        }
        public void init()
        {
            jiami jm = new jiami();
            label2.Text = jm.Decrypt(this.mw, 0);
            label4.Text = jm.Decrypt(this.mw, 1);
            label6.Text = jm.Decrypt(this.mw, 2);
            label8.Text = jm.Decrypt(this.mw, 3);
            label10.Text = jm.Decrypt(this.mw, 4);
            label12.Text = jm.Decrypt(this.mw, 5);
            label14.Text = jm.Decrypt(this.mw, 6);
            label16.Text = jm.Decrypt(this.mw, 7);
            label18.Text = jm.Decrypt(this.mw, 8);
            label20.Text = jm.Decrypt(this.mw, 9);
            label22.Text = jm.Decrypt(this.mw, 10);
            label24.Text = jm.Decrypt(this.mw, 11);
            label26.Text = jm.Decrypt(this.mw, 12);
            label28.Text = jm.Decrypt(this.mw, 13);
            label30.Text = jm.Decrypt(this.mw, 14);
            label32.Text = jm.Decrypt(this.mw, 15);
            label34.Text = jm.Decrypt(this.mw, 16);
            label36.Text = jm.Decrypt(this.mw, 17);
            label38.Text = jm.Decrypt(this.mw, 18);
            label40.Text = jm.Decrypt(this.mw, 19);
            label42.Text = jm.Decrypt(this.mw, 20);
            label44.Text = jm.Decrypt(this.mw, 21);
            label46.Text = jm.Decrypt(this.mw, 22);
            label48.Text = jm.Decrypt(this.mw, 23);
            label50.Text = jm.Decrypt(this.mw, 24);
            label52.Text = jm.Decrypt(this.mw, 25);
        }
    }
}
