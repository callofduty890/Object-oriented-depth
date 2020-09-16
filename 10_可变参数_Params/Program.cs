using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_可变参数_Params
{
    class Program
    {
        static void F(params int[] args)
        {
            Console.Write("数组包含了{0}个元素", args.Length);
            foreach (int item in args)Console.Write("{0}\t", item);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            F(arr);
            F(10, 20, 30, 40);
            F();
            Console.ReadKey();
        }
    }
}
