using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    class SLCell
    {
        public string keys;
        public int next;
    }

    class SLList
    {
        public List<SLCell> r;
        public int keynum;
        public int recnum;
    }
    class Program
    {
        const int RADIX = 10;       //关键字的基数，此时是十进制整数的基数
        const int NUM_OF_NUM = 3;   //实际关键字个数
        static void Main(string[] args)
        {
            string[] y = new string[] { "369", "367", "167", "239", "237", "138", "230", "139" };

            SLList list = new SLList();
            //初始化list
            list.recnum =y.Length;
            list.keynum = NUM_OF_NUM;
            list.r = new List<SLCell>();        //实例化该List对象,C#不允许就地初始化,Java可以,C++17也可以
            for (int i = 0; i < list.recnum; i++)
            {
                SLCell slCell = new SLCell();
                slCell.keys = y[i];
                list.r.Add(slCell);
            }

            Console.Write("Before Sort : ");    //排序前
            for (int i = 0; i < y.Length; i++)
                Console.Write(y[i] + "   ");
            Console.WriteLine();

            RadixSort(list);

            Console.Write("After Sort  : ");    //排序后
            RadixPrint(list);

            Console.ReadLine();
        }

        static int ord(string keys, int i)
        {
            if (i > keys.Length)
                return 0;
            else
                return int.Parse(keys[i].ToString());
        }

        static void Distribute(List<SLCell> R, int t, int[] f, int[] r,int head)
        {
            int i;
            for (i = 0; i < RADIX; i++)
            {
                f[i] = -1;  //链尾指针置为-1
                r[i] = -1;
            }
            for (int p = head; p != -1; p = R[p].next)
            {
                i = ord(R[p].keys, NUM_OF_NUM - t - 1);     //ord将将记录中的第i个关键字映射到[]
                if (-1 == f[i])
                {   //说明关键字为该数字的是第一个
                    f[i] = p;
                }
                else
                {
                    R[r[i]].next = p;
                }
                r[i] = p;
            }
        }

        static int Collect(List<SLCell> R, int[] f, int[] r, int head)
        {
            int i;
            int t;
            for (i = 0; i < RADIX && -1 == f[i]; ++i)
            {

            }
            head = f[i];        //找到第一个存在的
            t = r[i];
            while (i < RADIX)
            {
                for (++i; i < RADIX - 1 && -1 == f[i]; ++i)
                {

                }
                if (i < RADIX && -1 != f[i])
                {
                    R[t].next = f[i];
                    t = r[i];
                }
            }
            R[t].next = -1;
            return head;
        }

        static int head = 0;
        static void RadixSort(SLList list)
        {
            for (int i = 0; i < list.recnum; i++)
            {
                list.r[i].next = i + 1;
            }
            list.r[list.recnum - 1].next = -1;
            int[] f = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int[] r = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            for (int i = 0; i < list.keynum; i++)
            {
                Distribute(list.r, i, f, r, head);
                head = Collect(list.r, f, r, head);
            }
        }


        static void RadixPrint(SLList list)
        {
            int p = head;
            for(int i=0; i<list.recnum; i++)
            {
                Console.Write(list.r[p].keys + "   ");
                p = list.r[p].next;
            }
            Console.WriteLine();
        }

    }
}
