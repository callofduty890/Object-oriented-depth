using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_只读字段
{
    class ReadOnlyField
    {
        public int x;
        public readonly int y = 2;//声明并初始化只读字段
        public readonly int z;      //声明只读字段
        public ReadOnlyField()
        {
            y = 6;
            z = 3;//初始化只读字段
        }
        public ReadOnlyField(int p1, int p2, int p3)
        {
            this.x = p1;this.y = p2;this.z = p3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReadOnlyField p1 = new ReadOnlyField();//无参
            p1.x = 1;//正确
            //p1.z = 33;//错误：编译错误对只读字段赋值
            Console.WriteLine("p1:x={0}, y={1}, z{2}", p1.x, p1.y, p1.z);

            ReadOnlyField p2 = new ReadOnlyField(11, 22, 33);
            Console.WriteLine("p2:x={0}, y={1}, z{2}", p2.x, p2.y, p2.z);

            Console.ReadKey();
        }
    }
}
