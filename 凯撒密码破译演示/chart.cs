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
    public partial class chart : Form
    {
        public String str;     //密文
        public int Count = 25;
        public double[] MyList = new double[26];
        public chart(String str1)
        {
            InitializeComponent();
            this.str = str1;
            setChart();
            setchart1();
            setMsg();
            setInformation();
        }

        public void setChart()
        {
            Probability pb = new Probability(str);
            double[] arr = pb.getFrequency();
            char[] mw = pb.arr4;
            chart1.Series.Clear();
            int i;
            int count = arr.Length;
            chart1.Titles.Add("密文字母频率图");
            Series si = new Series("密文字母");
            si.Color = Color.YellowGreen;
            si.ChartType = SeriesChartType.Column;
            si.IsValueShownAsLabel = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 0.5;
            chart1.ChartAreas[0].AxisY.Interval = 0.1;
            chart1.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;
            chart1.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;
            String[] arrY = new string[count];
            for(i = 0;i < count; i++)
            {
                arrY[i] = mw[i].ToString();
            }
            for (i = 1; i < (arr.Length + 1); i++)
            {
                si.Points.AddXY(arrY[i - 1], arr[i - 1]);
            }
            chart1.Series.Add(si);
        }

        public void setchart1()
        {
            Probability pb = new Probability(str);
            double[] arr = new double[26];
            chart2.Series.Clear();
            int i;
            double[] arr1 = pb.getFrequency();
            int count = (pb.arr4).Length;
            String[] arrY = new string[26];
            for (i = 0; i < 26; i++)
            {
                arrY[i] = ((char)(i + 65)).ToString();
//                Console.WriteLine(i.ToString() + "@");
                arr[i] = pb.getGaili(i);
                MyList[i] = arr[i];
//                Console.WriteLine(pb.getGaili(i));
            }
            chart2.Titles.Add("密钥分布图");
            Series series = new Series("密钥");
            series.Color = Color.Purple;
            series.ChartType = SeriesChartType.Line;
            series.IsValueShownAsLabel = true;
            chart2.ChartAreas[0].AxisX.MajorGrid.Interval = 0.5;
            chart2.ChartAreas[0].AxisY.Interval = 0.01;
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;
            chart2.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;
            for (i = 1; i < (arr.Length + 1); i++)
            {
                series.Points.AddXY(arrY[i - 1], arr[i - 1]);
            }
            chart2.Series.Add(series);
            Console.WriteLine(arr.Max());
        }

        public void setMsg()
        {
            label1.Text = "说明：\r\n\r\n    该破译的密文所取的密钥为概率最高的假定密钥\r\n\r\n    优先选取概率最高的密钥，最多可选五次密钥，剩下密钥因概率过低将拒绝访问\r\n\r\n    向下递减按钮可自动加载接下来一个概率次大的密钥";
        }

        public void setInformation()
        {
            label3.Text = str;
            //           Array.Sort();
            label5.Text = getIndex(MyList.Max()).ToString();
            jiami jm = new jiami();
            label7.Text = jm.Decrypt(str, getIndex(MyList.Max()));
            label9.Text = MyList.Max().ToString();
        }
        public int getIndex(double ch)
        {
            int n=0,i;
            for(i = 0;i < 26; i++)
            {
                if(MyList[i] == ch)
                {
                    n = i;
                    break;
                }
            }
            return n;
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double[] arr = new double[26];
            int i;
            for(i = 0;i < 26;i++)
            {
                arr[i] = MyList[i];
            }
            Array.Sort(arr);
            if (Count <= 20)
            {
                MessageBox.Show("剩下密钥概率过低，拒绝访问!", "提示");
            }
            else
            {
                label5.Text = getIndex(arr[Count - 1]).ToString();
                jiami jm = new jiami();
                label7.Text = jm.Decrypt(str, getIndex(arr[Count - 1]));
                label9.Text = arr[Count - 1].ToString();
                Count--;
            }
        }
    }
}
