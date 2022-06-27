using System;
using System.Collections;

namespace Assignment4
{
    class MyException : Exception
    {
        public void MyExceptions()
        {
            Console.WriteLine("An exception occured");
        }
        public void StackEmptyException()
        {
            Console.WriteLine("Exception occured, stack is empty");
        }
        public void StackFullException() 
        {
            Console.WriteLine("Exception occured, Stack is full");
        }
    }
        class Program
        {

        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            try
            {
                if(s.Count==0)
                {
                    throw new MyException();
                }
            }
            catch(MyException e)
            {
                 e.StackEmptyException();
            }
            try
            {
                if (s.Contains(s))
                {
                    throw new MyException();
                }
            }
            catch (MyException e)
            {
                e.StackFullException();
            }
            Console.WriteLine("Number of elements in Stack: {0}",s.Count);
        }
    }
}
