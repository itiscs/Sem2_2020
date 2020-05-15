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
        
        private int[] tree;  //дерево отрезков. в вершинах хранятся суммы

        public SegmentTree(int[] a, int size)
        {
            Size = size;
            tree = new int[Size * 4];
            Build_tree(a, 1, 0, Size - 1);
        }

        private void Build_tree(int[] a, int v, int tl, int tr)
        {
            if (tl == tr)
            {
                tree[v] = a[tl];
                //сумма отрезка из одного элемента равна этому элементу
            }
            else
            {
                //tm - средний элемент отрезка.
                //отрезок разбивается на два отрезка [tl; tm], [tm + 1; tr]
                int tm = (tl + tr) / 2;
                Build_tree(a, v * 2,     tl, tm);
                Build_tree(a, v * 2 + 1, tm + 1, tr);

                tree[v] = tree[v * 2] + tree[v * 2 + 1];
                /*tree[v] = tree[v * 2] > tree[v * 2 + 1]
                    ? tree[v*2] : tree[v*2+1];*/
            }
        }

        public int Get_sum(int l, int r)
        {
            return Get_sum(l, r, 1, 1, Size);
        }
        private int Get_sum(int l, int r, int v, int tl, int tr)
        {
            //вариант 1
            //Текущий отрезок полностью входит в запрос 
            if (l <= tl && tr <= r)
            {
                return tree[v];
            }

            //вариант 2
            //Текущий отрезок полностью не входит в запрос
            if (tr < l || r < tl)
            {
                return 0;
            }

            //вариант 3
            //Текущий отрезок частично входит в запрос
            int tm = (tl + tr) / 2;
            
            /*var ml = Get_sum(l, r, v * 2, tl, tm);
            var mr = Get_sum(l, r, v * 2 + 1, tm + 1, tr);
            return (ml > mr)? ml : mr;
            */
            return Get_sum(l, r, v * 2, tl, tm)
                 + Get_sum(l, r, v * 2 + 1, tm + 1, tr);
        }

        public void Update(int idx, int val)
        {
            Update(idx, val, 1, 1, Size);
        }
        private void Update(int idx, int val, int v, int tl, int tr)
        {
            //вариант 1
            if (idx <= tl && tr <= idx)
            {    //То же, что и idx == tl == tr
                tree[v] = val;
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

            tree[v] = tree[v * 2] + tree[v * 2 + 1];
            /*tree[v] = tree[v * 2] > tree[v * 2 + 1]
                  ? tree[v * 2] : tree[v * 2 + 1];
                  */
        }




        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int k = 2;
            for(int i=1; i < 4*Size; i++)
            {
                if (i == k)
                {
                    sb.AppendLine();
                    k *= 2;
                }
                sb.Append($"{tree[i]} ");
                
            }

            return sb.ToString();
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int[] mas = new int[n];
            for(int i=0; i<n; i++)
            {
                mas[i] = i;
            }
            SegmentTree st = new SegmentTree(mas,n);

            
            Console.WriteLine($"Sum = {st.Get_sum(901,903)}");

            st.Update(901, 10);
            st.Update(902, 20);
            st.Update(903, 30);
            //Console.WriteLine(st);

            Console.WriteLine($"Sum = {st.Get_sum(901, 903)}");


        }
    }
}

