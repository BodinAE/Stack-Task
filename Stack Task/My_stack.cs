﻿using System;
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
        public My_stack(int length)                     //creates an empty stack with a set max length
        {
            this.MaxLength = length;
            this.Sum = 0;
            this.Storage = new My_list();
        }
        public My_stack(My_stack OrigStack)             //creates a copy of a stack
        {
            this.MaxLength = OrigStack.MaxLength;
            this.Sum = OrigStack.Sum;
            this.Storage = OrigStack.Storage.Copy();
        }
        public void Push(int Input)                     //adds an element to the top
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

        public int Pop()                                //outputs the top element and deletes it
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

        public int Peek()                               //outputs the top element, without deleting it
        {
            return this.Storage.GetHeadNode();
        }

        public void Print()                             //outputs all elements in stack
        {
            My_stack prnt_stack = new My_stack(this);
            while (prnt_stack.GetCount() > 0)
            {
                My_IO.Output(prnt_stack.Pop());
            }
        }

        public int GetCount()                           //returns amount of elements in stack
        { 
            return this.Storage.GetLength(); 
        }

        public float GetAverage()                       //returns average of all elements in stack
        {
            return Sum / this.GetCount();
        }
    }
}
