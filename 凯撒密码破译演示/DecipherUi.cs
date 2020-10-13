using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 凯撒密码破译演示
{
    public partial class DecipherUi : Form
    {
        public DecipherUi()
        {
            InitializeComponent();
 //           setChart();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("密文不能输入为空！", "警告");
            }
            else
            {
                label3.Text = textBox1.Text;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(label3.Text == "等待密文输入中")
            {
                MessageBox.Show("请输入密文!", "警告");
            }
            else
            {
                Uiviolence uiviolence = new Uiviolence(label3.Text);
                uiviolence.ShowDialog();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (label3.Text == "等待密文输入中")
            {
                MessageBox.Show("请输入密文!", "警告");
            }
            else
            {
                chart ca = new chart((label3.Text).ToString());
                ca.ShowDialog();
            }
        }
 /*       public void setChart()
        {
            int i;
            Probability pb = new Probability("null");
            char[] arr = pb.Table;
            double[] arr1 = pb.LetterTable;
            chart1.Series.Clear();
            chart1.Titles.Add("密文字母频率图");
            Series si = new Series("测试");
            si.ChartType = SeriesChartType.Pie;
 //           si["PieLabelStyle"] = "Outside";
//            si["PieLineColor"] = "Black";
            si.IsValueShownAsLabel = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 0.5;
            //chart1.ChartAreas[0].AxisY.Interval = 0;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.LabelStyle.IsStaggered = true;
            chart1.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;
            chart1.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;
            String[] arrY = new string[26];
            for (i = 0; i < 26; i++)
            {
                arrY[i] = arr[i].ToString();
            }
            for (i = 1; i <= 26; i++)
            {
                si.Points.AddXY(arrY[i - 1], arr1[i - 1]);
            }
            chart1.Series.Add(si);
        }*/

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            prc_26 pr = new prc_26();
            pr.ShowDialog();
        }
    }
}
