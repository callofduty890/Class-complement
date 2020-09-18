using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_析构函数
{
    class SimpleClassA
    {
        public SimpleClassA()
        {
            Console.WriteLine("执行SimpleClassA的构造函数");
        }
        ~ SimpleClassA()
        {
            Console.WriteLine("执行SimpleClassA的析构函数");
        }
    }

    class SimpleClassB
    {
        public SimpleClassB()
        {
            Console.WriteLine("执行SimpleClassB的构造函数");
        }
        ~SimpleClassB()
        {
            Console.WriteLine("执行SimpleClassB的析构函数");
        }
        public void CreateObject()
        {
            Console.WriteLine("进入SimpleClassB.CreateObject()");
            SimpleClassA objSimpleClassA = new SimpleClassA();
            Console.WriteLine("退出SimpleClassB.CreateObject()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("进入Main()");
            SimpleClassB objSimpleClassB = new SimpleClassB();
            objSimpleClassB.CreateObject();//创建对象
            Console.WriteLine("退出Main()");
            //Console.ReadKey();
        }
    }
}
