using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] y = new double[] { 0.0, 6.0, 2.2, 7.2, 4.0, 9.0, 0.8, 5.0, 5.7, 1.314 };  //第一项为哨兵项，不参与排序
            Console.WriteLine("排序前：");
            for (int i = 1; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.WriteLine();

            BubbleSort(y, y.Length - 1);

            Console.WriteLine("排序后：");
            for (int i = 1; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.ReadLine();
        }

        static void BubbleSort(double[] list, int size)
        {
            int change_flag = 1;        //如果没发生交换说明已经排序完成，不需要继续运行，1代表发生变化

            for (int i = size; (i > 1) && (1 == change_flag); i--)
            {       //n-1趟排序
                change_flag = 0;
                for (int j = 1; j < i; j++)
                {       //第i趟需要比较n-i-1次
                    if (list[j] > list[j + 1])
                    {
                        list[0] = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = list[0];
                        change_flag = 1;    //发生交换
                    }
                }
            }
        }
    }
}
