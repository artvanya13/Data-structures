using System;
using System.Collections.Generic;
using System.Text;

namespace Data_structures
{
    class Stack
    {
        private Student[] students;
        private int top;
        private int depth;

        public Stack (int depth)
        {
            students = new Student[depth];
            top = 0;
        }
        
        public void Push (Student x)
        {
            if (top != depth)
            {
                students[top] = x;
                top++;
            }
            else
            {
                Console.WriteLine("Full stack");
            }
        }

        public Student Pop()
        {
            if (top != 0)
            {
                top--;
                return students[top];
            }
            else
            {
                Console.WriteLine("Empty stack");
                return null;
            }
        }
    }
}
