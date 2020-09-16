using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_16_类与对象
{
    class Counter
    {
        public int number;//实例字段
        public static int count;//静态字段

        public Counter()
        {
            count = count + 1;
            number = count;
        }

        public void ShowInStance()
        {
            //正确:实例方法中可以直接访问引用的实例字段
            Console.WriteLine("object:{0}", number);
            //正确:实例方法内可以直接访问静态字段
            Console.WriteLine("count:{0}", count);
        }

        public static void ShowStatic()
        {
            //错误:静态的方法不能直接引用实例字段
            //Console.WriteLine("object:{0}", number);
            //正确:实例方法内可以直接访问静态字段
            Console.WriteLine("count:{0}", count);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();//创建对象

            c1.ShowInStance();    //正确：对象调用方法
            //c1.ShowStatic();        //错误:不能用对象调用静态的方法
            Console.Write("object:{0}",c1.number);//正确：用对象引用实例字段
            Console.Write("object:{0}", Counter.number);//错误：不能用类名引用实例字段
            Console.Write("count:{0}", c1.count);//错误：不能用对象名引用静态字段
            Console.Write("count:{0}", Counter.count);//正确:用类名调用静态字段


            Counter.ShowStatic(); //正确:类名调用静态方法

            c1.ShowInStance();//正确:对象名引用方法

        }
    }
}
