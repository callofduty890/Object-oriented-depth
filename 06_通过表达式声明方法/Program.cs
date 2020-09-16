using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_通过表达式声明方法
{
    class SimpleMath
    {

        public int AddTwoNumbers(int Number1, int Number2) => Number1 + Number2;//两数相加


        public int SquareANumber(int Number) => Number * Number;//求某数的平方
     

        public static void DisplayResult(int number)=>Console.WriteLine("结果为:{0}", number);//显示结果

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
