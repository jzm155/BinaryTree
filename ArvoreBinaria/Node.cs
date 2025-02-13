using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public Node(int value, Node? left, Node? right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public void InsertNewValue(int value)
        {
            if (Value > value)
            {
                if (Left is null)
                    Left = new Node(value, null, null);
                else
                {
                    Left.InsertNewValue(value);
                }
            }
            else
            {
                if (Right is null)
                    Right = new Node(value, null, null);
                else
                {
                    Right.InsertNewValue(value);
                }
            }
        }

        public void InvertNode()
        {
            if(Left is not null || Right is not null)
            {
                Left.InvertNode();
                Right.InvertNode();
            }

            Trade();
        }
        
        public void Trade()
        {
          var leftValue = Left;
          Left = Right;
          Right = leftValue;
        }
    }
}
