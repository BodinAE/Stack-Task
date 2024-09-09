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

        public Node(int input)
        {
            this.Data = input;
        }

        public Node() { }

        public void Set(int input)
        {
            Data = input;
        }

        public int Get()
        {
            return Data;
        }
    }
}
