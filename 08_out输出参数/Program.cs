using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_out输出参数
{

    class TEST
    {
        public static bool MyTryParse(string str,out int Number)
        {
            bool result;
            try
            {
                Number = Convert.ToInt32(str);
                result = true;
            }
            catch (Exception)
            {
                Number = 0;
                result = false;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "123";
            int n;
            if (TEST.MyTryParse(s, out n))
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("不能转换成整数");
            }
            Console.ReadKey();
        }
    }
}
