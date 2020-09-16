using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_方法
{
    class SimpleMath
    {
        public int AddTwoNumbers(int Number1, int Number2)//两数相加
        {
            return Number1 + Number2;
        }

        public int SquareANumber(int Number)//求某数的平方
        {
            return Number * Number;
        }

        public static void DisplayResult(int number)//显示结果
        {
            Console.WriteLine("结果为:{0}", number);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int result; SimpleMath obj = new SimpleMath();
            result = obj.AddTwoNumbers(1, 2);//两个数相机
            SimpleMath.DisplayResult(result);//显示相加的结果
            SimpleMath.DisplayResult(obj.SquareANumber(result));//计算平方

            Console.ReadKey();
        }
    }
}
