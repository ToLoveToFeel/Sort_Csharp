using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 3, 1 };
            double[] y = new double[] { 0.0, 6.0, 2.2, 7.2, 4.0, 9.0, 0.8, 5.0, 6.0 };  //第一项为哨兵项，不参与排序
            Console.WriteLine("排序前：");
            for (int i = 1; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.WriteLine();

            for(int i=0; i<a.Length; i++)
            {
                ShellSort(y, y.Length - 1, a[i]);
            }

            Console.WriteLine("排序后：");
            for (int i = 1; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.ReadLine();
        }

        static void ShellSort(double[] list, int size, int d)
        {
            int i, j;
            for (i = d + 1; i <= size; i++)
            {
                if (list[i] < list[i - d])
                {
                    list[0] = list[i];
                    list[i] = list[i - d];
                    for (j = i - 2 * d; (j > 0) && (list[0] < list[j]); j = j - d)
                    {
                        list[j + d] = list[j];
                    }
                    list[j + d] = list[0];
                }
            }
        }
    }
}
