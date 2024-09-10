using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Task
{
    internal class Node
    {
        private int Data { get; set; }

        public Node? Next { get; set; }

        public Node(int input)              //Creates a node with a value stored
        {
            this.Data = input;
        }

        public Node() { }

        public void Set(int input)          //Sets the value inside the node to th einputted int
        {
            Data = input;
        }

        public int Get()                    //returns the value stored inside the node
        {
            return Data;
        }
    }
}
