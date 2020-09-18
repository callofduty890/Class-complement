using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_运算符的重载
{
    public struct Complex //复数
    {
        public int real;//实部
        public int imaginary;//虚部

        public Complex(int real,int imaginary) //构造函数
        {
            this.real = real;this.imaginary = imaginary;
        }

        //重载运算符
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        //重载Tostring方法用以显示复数的实部和虚部
        public override string ToString()
        {
            return (string.Format("{0}+{1}",real,imaginary));
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Complex num1 = new Complex(2, 3);
            Complex num2 = new Complex(3, 4);

            //使用重载过后的运算符
            Complex sum = num1 + num2;

            //调用重写的Tostring()方法
            Console.WriteLine("第一个复数:\t{0}", num1.ToString());
            Console.WriteLine("第二个复数:\t{0}", num2.ToString());
            Console.WriteLine("两个复数之和:\t{0}", sum.ToString());

            Console.ReadKey();
        }
    }
}
