using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectInsertSort
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

            DirectInsertSort(y, y.Length - 1);

            Console.WriteLine("排序后：");
            for (int i = 1; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.ReadLine();
        }

        static void DirectInsertSort(double[] list, int size)
        {
            int i, j;
            for (i = 2; i <= size; i++)
            {
                if (list[i] < list[i - 1])
                {
                    list[0] = list[i];
                    list[i] = list[i - 1];
                    for (j = i - 2; list[j] > list[0]; j--)
                    {
                        list[j + 1] = list[j];
                    }
                    list[j + 1] = list[0];
                }

            }
        }
    }
}
