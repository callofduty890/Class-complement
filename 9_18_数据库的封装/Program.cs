using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_18_数据库的封装
{
    class TempRecord
    {
        //温度数组-定义了一组温度
        private double[] temps = new double[5] { 31.2, 35.2, 30.1, 28.5, 24.7 };

        private double[] temp = new double[5] { 65, 101, 75, 80, 110 };

        public int Length //属性->长度
        {
            get { return temps.Length; }
        }

        public int TempLength
        {
            get { return temp.Length; }
        } //属性->华氏度数组的长度

        public double this[int index] //索引器
        {
            get { return temps[index]; } //返回指定索引对应的数组元素
            set { temps[index] = value; }//设定指定索引对应的数组元素值
        }

        public double this[string str, int index]
        {
            get 
            {
                if (str == "摄氏度")
                {
                    return temps[index];
                }
                else
                {
                    return temp[index];
                }
            }

            set
            {
                if (str == "摄氏度")
                {
                    temps[index]=value;
                }
                else
                {
                     temp[index]=value;
                }
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TempRecord tempRecord = new TempRecord();
            tempRecord[3] = 20.1;
            tempRecord[4] = 30.4;
            for (int i = 0; i < tempRecord.Length; i++)
            {
                Console.WriteLine("tempRecord Element #{0}={1}", i, tempRecord[i]);
            }
            Console.WriteLine("=============================");
            tempRecord["摄氏度",3] = 14.1;//访问索引器设置值
            tempRecord["摄氏度",4] = 16.3;//访问索引器设置值
            //输出温度的值
            for (int i = 0; i < tempRecord.Length; i++)
            {
                Console.WriteLine("摄氏度 Element #{0}={1}", i,tempRecord["摄氏度", i]);
            }
            Console.WriteLine("=============================");
            tempRecord["华氏度", 3] = 10;//访问索引器设置值
            tempRecord["华氏度", 4] = 20;//访问索引器设置值
            //输出华氏度的值
            for (int i = 0; i < tempRecord.Length; i++)
            {
                Console.WriteLine("华氏度 Element #{0}={1}", i, tempRecord["华氏度", i]);
            }

            Console.WriteLine("=============================");
            string str = "123456789";
            //str[0] = 'A'; 只有get没有set
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("str Element #{0}={1}", i, str[i]);
            }

            Console.ReadKey();
        }
    }
}
