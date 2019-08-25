using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
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

            MergeSort(y, y.Length - 1);

            Console.WriteLine("排序后：");
            for (int i = 1; i < y.Length; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.ReadLine();
        }

        static void Merge(double[] list2, double[] list, int left, int middle, int right)
        {
            //list为合并后的目标数组，将有序的序列 list2[s..m] 和 list2[m+1..t]归并为有序的序列 list[s..t]
            int i, j, k;
            for (i = left, j = middle + 1, k = left; (i <= middle) && (j <= right); k++)
            {
                if (list2[i] <= list2[j])
                {
                    list[k] = list2[i++];
                }
                else
                {
                    list[k] = list2[j++];
                }
            }
            if (i <= middle)
            {
                for (; i <= middle;)
                {
                    list[k++] = list2[i++];
                }
            }
            if (j <= right)
            {
                for (; j <= right;)
                {
                    list[k++] = list2[j++];
                }
            }
        }

        //分
        static void Msort(double[] list2, double[] list, int start, int end)
        {
            //将 list2[s..t] 通过 list3[] 归并排序为 list[s..t]
            //double[] list3 = new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            double[] list3 = new double[] { 0.0, 6.0, 2.2, 7.2, 4.0, 9.0, 0.8, 5.0, 5.7, 1.314 };
            if (start == end)
            {
                list[start] = list2[start];
            }
            else
            {
                int middle = (start + end) / 2;
                Msort(list2, list3, start, middle);     //体现了分久必合的思想
                Msort(list2, list3, middle + 1, end);
                Merge(list3, list, start, middle, end);
            }
        }


        static void MergeSort(double[] list, int size)
        {
            Msort(list, list, 1, size);
        }
    }
}
