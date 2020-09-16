using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_常量与字段
{
    class person
    {
        public const int RETIREMENT_AGE = 60;//声明了一个常量
        public const int RETIREMENT_AGE_DELAY = RETIREMENT_AGE + 60;
        string name;int age;//声明了两个变量
    }

    class Program
    {
        static void Main(string[] args)
        {
            //调用显示常量
            Console.WriteLine("AGE={0},AGE_DELAY={1}", person.RETIREMENT_AGE, person.RETIREMENT_AGE_DELAY);
            
            Console.ReadKey();
        }
    }
}
