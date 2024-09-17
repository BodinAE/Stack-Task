using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stack_Task
{
    internal class My_list
    {
        Node Head { get; set; }
        Node Tail { get; set; }
        int Length { get; set; }

        //My_list(int length)
        //{
        //    Node CurrNode = Head;
        //    for (int i = 0; i < length - 1; i++) 
        //    { 
        //        CurrNode.Next = new Node();
        //        CurrNode = CurrNode.Next;
        //    }
        //    this.Length = length;
        //}

        public My_list()                       //creates an empty list
        {
            Head = null;
            Tail = Head;
            Length = 0;
        }
        public My_list(int input)               //creates a list with one element
        {
            Head = new Node(input);
            Tail = Head;
            Length = 1;
        }


        public void AddTailNode(int input)      //adds a node at the end of the list
        {
            Tail.Next = new Node(input);
            Tail = Tail.Next;
            this.Length++;
        }

        public void AddHeadNode(int input)      //adds a node at the start of list
        {
            Node NewHead = new Node(input);
            NewHead.Next = Head;
            Head = NewHead;
            this.Length++;
        }

        public void RemoveHeadNode()            //removes first node
        {
            Node CurrHead = Head;
            Head = Head.Next;
            CurrHead.Next = null;
            this.Length--;
        }

        public int GetHeadNode()                //returns first node
        {
            return Head.Get();
        }

        public int GetTailNode()                //returns last node
        {
            return Tail.Get();
        }

        public int GetLength()                  //returns the length of the list
        { 
            return Length; 
        }

        public My_list Copy()                   //creates an identical list
        {
            My_list output;
            if (this.GetLength() > 0)
            {
                output = new My_list(this.GetHeadNode());
                Node? currnode = this.Head.Next;
                while (currnode != null)
                {
                    output.AddTailNode(currnode.Get());
                    currnode = currnode.Next;
                }
            }
            else { output = new My_list(); }
            return output;
        }
    }
}
