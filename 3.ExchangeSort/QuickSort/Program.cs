using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
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

            QuickSort(y, 1, y.Length - 1);

            Console.WriteLine("排序后：");
            for (int i = 1; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.ReadLine();
        }

        static int partition(double[] list, int low, int high)
        {
            list[0] = list[low];
            while (low < high)
            {
                while ((low < high) && (list[high] > list[0]))
                {
                    high--;
                }
                if (low < high)
                {
                    list[low] = list[high];
                    low++;
                }
                while ((low < high) && (list[low] < list[0]))
                {
                    low++;
                }
                if (low < high)
                {
                    list[high] = list[low];
                    high--;
                }
            }
            list[high] = list[0];

            return high;
        }


        static void QuickSort(double[] list, int low, int high)
        {
            int t;
            if (low < high)
            {
                t = partition(list, low, high);
                QuickSort(list, low, t - 1);
                QuickSort(list, t + 1, high);
            }
        }
    }
}
