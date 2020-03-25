using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    public class Elem
    {
        public int Info { get; set; }
        public Elem Left { get; set; }
        public Elem Right { get; set; }
    }


    public class Tree
    {
        private Elem Root { get; set; }


        public static Tree CreateTree()
        {
            return new Tree()
            {
                Root = new Elem() { 
                    Info=17,
                    Left = new Elem() {
                        Info= 10,
                        Left = new Elem() { Info = 2 },
                        Right = new Elem() { Info = 9 }
                    },
                    Right = new Elem() { 
                        Info = 38,
                        Left = new Elem() { Info = 10 },
                        Right = new Elem() { Info = 66 }
                    }
                }
            };
        }

        public void Show()
        {
            ShowElem(Root);
            Console.WriteLine();
        }

        private void ShowElem(Elem el)
        {
            if (el == null)
                return;
            if (el.Left == el.Right)//el.l==null && el.r==null
            {
                Console.Write(el.Info);
                return;
            }
            Console.Write($"({el.Info},");
            ShowElem(el.Left);
            Console.Write(",");
            ShowElem(el.Right);
            Console.Write(")");
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

        public int Max()
        {
            if (Root == null)
                throw new ArgumentException("tree is empty!");
            return MaxElem(Root);
        }

        private int MaxElem(Elem el)
        {
            if (el.Left == el.Right)
                return el.Info;

            int max = el.Info, ml;
            if(el.Left != null)
            {
                ml = MaxElem(el.Left);
                if (max < ml)
                    max = ml;
            }
            if (el.Right != null)
            {
                ml = MaxElem(el.Right);
                if (max < ml)
                    max = ml;
            }
            return max;
        }




    }
}
