using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_访问修饰符
{
    class Person
    {
        public const int PRETIREMENT_AGE = 65;//访问不受限
        public string name;//访问不受限
        internal string nickName;//在当前程序内可以访问
        protected bool isMarried;//在person类或派生类中可以访问
        private int age;//只能在person类中访问
        string creditiCarNum;//使用默认访问修饰符:Private。只能在类中可以访问
        public void Speak() //访问不受限
        {
            Console.WriteLine("Hi");
        }

        public void Mothod1()
        {
            //对当前类的成员都可以访问
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person pr = new Person();
            //对程序的类中的方法，对象person成员的访问权限如下
            //publi和internal成员都可以访问；Protected和Private成员不可访问

        }
    }
}
