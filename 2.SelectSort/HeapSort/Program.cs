using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
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

            HeapSort(y, y.Length - 1);

            Console.WriteLine("排序后：");
            for (int i = 1; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.ReadLine();
        }

        static void HeapAdjust(double[] list, int m, int n)
        {
            int i;
            list[0] = list[m];
            for (i = 2 * m; i <= n; i *= 2)
            {
                if (i < n && list[i] < list[i + 1])
                {       //选择左右孩子最大的一个
                    i++;
                }
                if (list[0] > list[i])
                {
                    break;
                }
                list[m] = list[i];
                m = i;
            }
            list[m] = list[0];
        }

        static void HeapSort(double[] list, int size)
        {
            int i;
            for (i = size / 2; i > 0; i--)
            {       //建堆
                HeapAdjust(list, i, size);
            }
            for (i = size; i > 1; i--)
            {           //排序
                list[0] = list[i];
                list[i] = list[1];
                list[1] = list[0];
                HeapAdjust(list, 1, i - 1);
            }
        }
    }
}
