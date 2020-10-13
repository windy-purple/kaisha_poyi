using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 凯撒密码破译演示
{
    class jiami
    {
        public String Encryption(String ClearText,int Key)
        {
            char[] arr = ClearText.ToCharArray();
            String str = "";
            int i,m;
            for(i = 0;i < arr.Length; i++)
            {
                m = (int)arr[i];
                if (((m <= 122) && (m >= 97)) || ((m <= 90) && (m >= 65)))
                {
                    if ((m <= 122) && (m >= 97))
                    {
                        if ((m + Key) > 122)
                        {
                            str += ((char)(m + Key - 26)).ToString();
                        }
                        else
                        {
                            str += ((char)(m + Key));

                        }
                    }
                    else if((m <= 90) && (m >= 65))
                    {
                        if ((m + Key) > 90)
                        {
                            str += ((char)(m + Key - 26)).ToString();
                        }
                        else
                        {
                            str += ((char)(m + Key)).ToString();
                            Console.WriteLine((char)(m + Key));
                        }
                    }
                }
                else
                {
                    str += arr[i].ToString();
                }
            }
            return str;
        }
        public String Decrypt(String CipherText,int Key)
        {
            char[] arr = CipherText.ToCharArray();
            String str = "";
            int i, m;
            for (i = 0; i < arr.Length; i++)
            {
                m = (int)arr[i];
                if (((m <= 122) && (m >= 97)) || ((m <= 90) && (m >= 65)))
                {
                    if ((m <= 122) && (m >= 97))
                    {
                        if ((m - Key) < 97)
                        {
                            str += ((char)(m - Key + 26)).ToString();
                        }
                        else
                        {
                            str += ((char)(m - Key));

                        }
                    }
                    else if ((m <= 90) && (m >= 65))
                    {
                        if ((m - Key) < 65)
                        {
                            str += ((char)(m - Key + 26)).ToString();
                        }
                        else
                        {
                            str += ((char)(m - Key)).ToString();
                        }
                    }
                }
                else
                {
                    str += arr[i].ToString();
                }
            }
            return str;
        }
    }
}
