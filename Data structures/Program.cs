using System;

namespace Data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            stack.Push(new Student("Vanya", "A*"));
        }
    }
}
