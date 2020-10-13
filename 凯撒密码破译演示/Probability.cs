using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 凯撒密码破译演示
{
    class Probability
    {
        public String Mw;
        public  char[] arr4;
        public double[] LetterTable = { 0.080,0.015,0.030,0.040,0.130,0.020,0.015,0.060,0.065,0.005,0.005,0.035,0.030,0.070,0.080,0.020,0.002,0.065,0.060,0.090,0.030,0.010,0.015,0.005,0.020,0.002};
        public char[] Table = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public Probability(String miwen)
        {
            this.Mw = miwen;
        }

        public double[] getFrequency()              //计算密文每个字母出现频率，char[] arr4存储了密文字母，返回的double[]存储了对应的频率
        {
            char[] arr1 = Mw.ToCharArray();
            ArrayList arr = new ArrayList();
            ArrayList strarr = new ArrayList();
            double result;
            int i, count, m;
            char ch;
            String str = "";
            count = 0;
            for (i = 0; i < arr1.Length; i++)
            {
                m = (int)arr1[i];
                if (((m <= 122) && (m >= 97)) || ((m <= 90) && (m >= 65)))
                {
                    str += arr1[i].ToString().ToLower();
                    count++;
                }
            }
            char[] arr2 = str.ToCharArray();
            for (i = 0; i < arr2.Length; i++)
            {
                ch = arr2[i];
                if (ch != '#')
                {
                    strarr.Add(ch);
                    arr2[i] = '#';
                    int n = 1;
                    for (int k = i + 1; k < arr2.Length; k++)
                    {
                        if (arr2[k] == ch)
                        {
                            n++;
                            arr2[k] = '#';
                        }
                    }
                    result = (double)n / (double)count;
                    result = Math.Round(result, 4);
                    arr.Add(result);
                }
                else
                {
                    continue;
                }
            }
            int j = arr.Count;
            double[] arr3 = new Double[j];
            arr4 = new char[j];
            i = 0;
            for (i = 0; i < j; i++)
            {
                arr3[i] = (double)arr[i];
            }
            i = 0;
            for (i = 0; i < j; i++)
            {
                arr4[i] = (char)strarr[i];
            }
            return arr3;
        }

        public int getCountTable(char ch)
        {
            int i,n;
            n = 0;
            for(i = 0;i < 26;i++)
            {
                if(Table[i] == ch)
                {
                    n = i;
                    break;
                }
            }
            return n;
        }

        public double getGaili(int Key)                 //计算假定密钥为i的概率
        {
            int i,n,m;
            double result;
            char ch;
            double[] arr;
            result = 0;
            arr = getFrequency();
            for(i = 0;i < arr4.Length; i++)
            {
                ch = (char)arr4[i];
                m = getCountTable(ch);
                n = (m - Key) % 26;
                if(n < 0)
                {
                    n += 26;
                }
                result += Math.Round((arr[i] * LetterTable[n]),4);
            }
            return result;
        }
    }
}
