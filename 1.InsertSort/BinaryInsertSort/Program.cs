using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryInsertSort
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

            BinaryInsertSort(y, y.Length - 1);

            Console.WriteLine("排序后：");
            for (int i = 1; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.ReadLine();
        }

        static void BinaryInsertSort(double[] list, int size)
        {
            int i, j;
            int high, low, middle;
            for (i = 2; i <= size; i++)
            {
                list[0] = list[i];
                high = i - 1;
                low = 1;
                while (low <= high)
                {
                    middle = (high + low) / 2;
                    if (list[0] > list[middle])
                    {
                        low = middle + 1;
                    }
                    else
                    {
                        high = middle - 1;
                    }
                }
                for (j = i - 1; j >= high + 1; j--)
                {
                    list[j + 1] = list[j];
                }
                list[high + 1] = list[0];
            }
        }
    }
}
