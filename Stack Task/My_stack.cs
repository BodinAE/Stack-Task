using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Task
{
    internal class My_stack
    {
        int MaxLength { get; set; }
        int Sum { get; set; }
        My_list Storage { get; set; }
        My_stack(int length)
        {
            //Node CurrNode = Head;
            //for (int i = 0; i < length - 1; i++)
            //{
            //    CurrNode.Next = new Node();
            //    CurrNode = CurrNode.Next;
            //}
            this.MaxLength = length;
            this.Sum = 0;
            this.Storage = new My_list();
        }
        My_stack(My_stack OrigStack)
        {
            ////Node CurrNode = Head;
            ////Node OrigCurrNode = OrigStack.Head;
            ////while (true)
            ////{
            ////    CurrNode = OrigCurrNode;
            ////    OrigCurrNode = OrigCurrNode.Next;
            ////    if (OrigCurrNode.Next == null)
            ////    {
            ////        CurrNode.Next = OrigCurrNode;
            ////        break;
            ////    }
            ////    CurrNode.Next = new Node();
            ////}

            //int length = OrigStack.Length;
            //Node CurrNode = Head;
            //Node OrigCurrNode = OrigStack.Head;
            //for (int i = 0; i < length; i++)
            //{
            //    CurrNode.Set(OrigCurrNode.Get());
            //    CurrNode = CurrNode.Next;
            //    OrigCurrNode = OrigCurrNode.Next;
            //}
            this.MaxLength = OrigStack.MaxLength;
            this.Sum = OrigStack.Sum;
            this.Storage = OrigStack.Storage.Copy();
        }
        public void Push(int Input)
        {
            if (this.Storage.GetLength() < this.MaxLength)
            {
                this.Storage.AddHeadNode(Input);
                this.Sum += Input;
            }
            else 
            {
                My_IO.Output("Stack Overflow");
            }
        }

        public int Pop()
        {
            int output = 0;
            if (this.Storage.GetLength() > 0)
            {
                output = Storage.GetHeadNode();
                this.Storage.RemoveHeadNode();
            }
            else
            {
                My_IO.Output("Stack Underflow");
            }
            return output;
        }

        public int Peek()
        {
            return this.Storage.GetHeadNode();
        }

        public void Print() 
        {
            My_stack prnt_stack = new My_stack(this);
            while (prnt_stack.GetCount() > 0)
            {
                My_IO.Output(prnt_stack.Pop());
            }
        }

        public int GetCount() 
        { 
            return this.Storage.GetLength(); 
        }

        public float GetAverage()
        {
            return Sum / this.GetCount();
        }
    }
}
