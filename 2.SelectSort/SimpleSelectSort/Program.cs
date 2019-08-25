using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSelectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] y = new double[] { 0.0, 6.0, 2.2, 7.2, 4.0, 9.0, 0.8, 5.0, 6.0 };  //第一项为哨兵项，不参与排序
            Console.WriteLine("排序前：");
            for (int i = 1; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.WriteLine();

            SimpleSelectSort(y, y.Length - 1);

            Console.WriteLine("排序后：");
            for (int i = 1; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.ReadLine();
        }

        static void SimpleSelectSort(double[] list, int size)
        {
            int i, j;
            int min;
            for (i = 1; i < size; i++)
            {
                min = i;
                for (j = i + 1; j <= size; j++)
                {
                    if (list[j] < list[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    list[0] = list[i];
                    list[i] = list[min];
                    list[min] = list[0];
                }
            }
        }
    }
}
