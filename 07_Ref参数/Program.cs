using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ref参数
{
    class Test
    {
        public static void Swap(ref int x,ref int y)//两个数进行交换
        {
            Console.WriteLine("[Swap]  Before x={0},y={1}", x, y);
            int temp = x;//中间变量
            x = y;
            y = temp;
            Console.WriteLine("[Swap]  After x={0},y={1}", x, y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 2;
            Console.WriteLine("Before swap,i={0},j={1}", i, j);
            Test.Swap(ref i,ref j);
            Console.WriteLine("After swap,i={0},j={1}", i, j);

            Console.ReadKey();
        }
    }
}
