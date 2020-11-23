using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExampleFA20
{

    class Stack
    {
        int[] elements = new int[5];
        private int count = -1;

        public void push(int val)
        {
            if (count == elements.Length)
                throw new Exception(message: "stack is full");
            count++;
            elements[count] = val;
        }

        public int? pop()
        {
            if (count == -1)
                return null;
            int value = elements[count];
            count--;
            return value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            Console.WriteLine(s.pop());
            s.push(val:10);
            s.push(val:15);
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
        }
    }
}
