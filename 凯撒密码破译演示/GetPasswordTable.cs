using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 凯撒密码破译演示
{
    class GetPasswordTable
    {
        public char[] NormalUppercase = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        private char[] NormalLowercase = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };

        public GetPasswordTable()
        {
        }

        public char[] get_uppercase_pt(int k)
        {
            char[] arr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int i;
            try
            {
                for (i = 0; i <= 25; i++)
                {
                    int n = (i + k) % 26;
                    arr[i] = NormalUppercase[n];
                }
            }
            catch
            {

            }
            return arr;
        }

        public char[] get_lowercase_pt(int k)
        {
            char[] arr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int i;
            for (i = 0; i < 26; i++)
            {
                int n = (i + k) % 26;
                arr[i] = this.NormalLowercase[n];
            }
            return arr;
        }
    }
}
