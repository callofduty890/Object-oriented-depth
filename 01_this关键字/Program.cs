using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_this关键字
{
    class ThisTest
    {
        public int i1 = 123;//声明实例字段并赋初值
        public string s1 = "abc";//声明实例字段并赋初值
        public ThisTest(int i1,string s1)
        {
            //i1 = i1;//变量赋值无意义：左边的是i1局部变量，没有赋值
            //s1 = s1;//变量赋值无意义：左边的是s1局部变量，没有赋值
            this.i1 = i1;   //正确
            this.s1 = s1; //正确
        }

        public void printInfo() //实例方法
        {
            int i1 = 456; //声明了局部变量，与实例字段重名
            string s1 = "def";//声明了局部变量，与实例字段重名
            Console.WriteLine(i1 + " " + s1);//输出局部变量
            Console.WriteLine(this.i1 + " " + this.s1);//输出实例字段
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ThisTest obj1 = new ThisTest(999, "AAA");
            obj1.printInfo();
            Console.ReadKey();
        }
    }
}
