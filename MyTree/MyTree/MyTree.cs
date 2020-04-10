using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    public class Elem
    {
        public int Info { get; set; }
        public Elem Left { get; set; }
        public Elem Right { get; set; }
    }

    public class MyTree
    {
        private Elem Root { get; set; }

        public static MyTree CreateTree()
        {
            return new MyTree(){ 
                Root = new Elem()
                {
                    Info = 5,
                    Left = new Elem()
                        { Info = 3,
                        Left = new Elem()
                        { Info = 10 },
                        Right = new Elem()
                        { Info = 4 }
                    },
                    Right = new Elem()
                        { Info = 8,
                        Left = new Elem()
                        { Info = 7 },
                        Right = new Elem()
                        { Info = 18 }
                    }
                }
                       
            };
        }

        public MyTree()
        {
            
        }
        public MyTree(string str)
        {
            // (1,(2,4,(5,8,)),(3,6,7))
            // (*,(+,4,(/,8,4)),(-,6,7))
            // (1 (2 4 (5 8 _ _ _ _ (3 6 7 _
            int k = 0;
            Root = Create(str.Split(new char[] { ',', ')' }), ref k);

        }

        private Elem Create(String[] str, ref int k)
        {
            Elem t = new Elem();
            if (!str[k].Contains('('))
            {
                t.Info = int.Parse(str[k]);
            }
            else
            {
                t.Info = int.Parse(str[k].Remove(0, 1));//убрали '(' 
                k++;
                if (str[k] != "")
                    t.Left = Create(str, ref k);
                k++;
                if (str[k] != "")
                    t.Right = Create(str, ref k);
                k++;
            }
            return t;
        }


        public void ShowTree()
        {
            ShowElem(Root);
            Console.WriteLine();
        }

        private void ShowElem(Elem el)
        {
            if (el == null)
                return;
            if (el.Left == el.Right) //(el.Left==null && el.Right==null)
                Console.Write(el.Info);
            else
            {
                Console.Write($"({el.Info},");
                ShowElem(el.Left);
                Console.Write(",");
                ShowElem(el.Right);
                Console.Write(")");
            }

        }

        public int Sum()
        {
            return SumElem(Root);

        }
        private int SumElem(Elem el)
        {
            if (el == null)
                return 0;
            return el.Info + SumElem(el.Left) + SumElem(el.Right);
        }

        public int Min()
        {
            if (Root == null)
                throw new ArgumentException("Дерево пустое!!!");
            return MinElem(Root);

        }
        private int MinElem(Elem el)
        {
            int m, min = el.Info;
            if(el.Left != null)
            {
                m = MinElem(el.Left);
                if (m < min)
                    min = m;
            }
            if (el.Right != null)
            {
                m = MinElem(el.Right);
                if (m < min)
                    min = m;
            }
            return min;
        }



    }



}
