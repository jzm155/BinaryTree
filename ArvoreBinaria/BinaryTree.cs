using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    public class BinaryTree
    {
        public Node? Root;

        public void Insert(int value)
        {
            if(Root is null)
                Root = new Node(value, null, null);
            else
            {
                if (value <= Root.Value)
                {
                    if (Root.Left is null)
                        Root.Left = new Node(value, null, null);
                    else
                    {
                        Root.Left.InsertNewValue(value);
                    }
                }
                else
                {
                    if (Root.Right is null)
                        Root.Right = new Node(value, null, null);
                    else
                    {
                        Root.Right.InsertNewValue(value);
                    }
                }
            }
        }

        public void Invert()
        {
            Root.InvertNode();
        }
    }
}
