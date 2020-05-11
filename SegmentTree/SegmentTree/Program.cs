using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegmentTree
{
    class SegmentTree
    {
        public int Size { get; private set; }
        private int[] mas;
        public SegmentTree(int[] a, int n)
        {
            Size = n;
            mas = new int[4 * n];
            Build_tree(a, 1, 0, n - 1);
        }

        private void Build_tree(int[] a, int v, int tl, int tr)
        {
            if (tl == tr)
            {
                mas[v] = a[tl];    //сумма отрезка из одного элемента равна этому элементу
            }
            else
            {
                //tm - средний элемент отрезка.
                //отрезок разбивается на два отрезка [tl; tm], [tm + 1; tr]
                int tm = (tl + tr) / 2;
                Build_tree(a, v * 2,     tl, tm);
                Build_tree(a, v * 2 + 1, tm + 1, tr);
                mas[v] = mas[v * 2] + mas[v * 2 + 1];
                //mas[v] = mas[v * 2] > mas[v * 2 + 1]?mas[v*2]:mas[v*2+1];
            }
        }

        public int Get_Sum(int l, int r)
        {
            return Get_sum(l, r, 1, 1, Size);
        }

        private int Get_sum(int l, int r, int v, int tl, int tr)
        {
            //вариант 1
            if (l <= tl && tr <= r) // Текущий отрезок полностью входит в запрос (l≤tl;tr≤r).
            {
                return mas[v];
            }

            //вариант 2
            if (tr < l || r < tl)  //Текущий отрезок полностью не входит в запрос (tr<l или l<tr).
            {
                return 0;
            }

            //вариант 3
            //Текущий отрезок частично входит в запрос.
            int tm = (tl + tr) / 2;
            return Get_sum(l, r, v * 2, tl, tm)
                 + Get_sum(l, r, v * 2 + 1, tm + 1, tr);
        }

        public void Update(int idx, int val)
        {
            Update(idx, val, 1, 1, Size);
        }

        //TODO
        public void Update(int idxl, int idxr, int[] mval)
        {
            throw new NotImplementedException();
        }

        private void Update(int idx, int val, int v, int tl, int tr)
        {
            //вариант 1
            if (idx <= tl && tr <= idx)
            {    //То же, что и idx == tl == tr
                mas[v] = val;
                return;
            }

            //вариант 2
            if (tr < idx || idx < tl)
            {
                return;
            }

            //вариант 3
            int tm = (tl + tr) / 2;
            Update(idx, val, v * 2, tl, tm);
            Update(idx, val, v * 2 + 1, tm + 1, tr);
            mas[v] = mas[v * 2] + mas[v * 2 + 1];
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < 4 * Size; i++)
                sb.Append($"{mas[i]} ");
            return sb.ToString();
        }



    }


    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int[] a = new int[n];
            for(int i =0; i<n; i++)
            {
                a[i] = i + 1;
            }
            SegmentTree st = new SegmentTree(a, n);

            //Console.WriteLine(st);

            Console.WriteLine(st.Get_Sum(600, 602));
            st.Update(600, 0);
            st.Update(601, 0);
            st.Update(602, 0);
            Console.WriteLine(st.Get_Sum(600, 603));


        }
    }
}



/*
 
//Запрос модификации
//idx - индекс элемента, val - новое значение
//v - номер текущей вершины; tl, tr - границы соответствующего отрезка
int main()
{
    //Ввод массива...

        //параметры корня дерева.
                                //все запросы должны вызываться для этих параметров.

    // get_sum(l, r, 1, 0, n - 1) 
    // update(idx, val, 1, 0, n - 1);
}
*/