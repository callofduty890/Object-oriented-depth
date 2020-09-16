using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_可选参数
{
    class Program
    {
        public static void Display(int a,int b=2,int c=3)
        {
            Console.WriteLine("调用有三个参数的方法");
            Console.WriteLine("a={0},b={1},c={2}", a, b, c);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Display(1);//a使用传入的参数，b与c使用默认的值
            Display(1, 3);
            Display(1, 3, 5);

            Console.ReadKey();
        }
    }
}
