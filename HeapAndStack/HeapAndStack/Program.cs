using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapAndStack
{
    class Program
    {
        class Heap
        {
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {
            Heap localheap = new Heap();
            localheap.x = 10;
            localheap.y = 20;
            int stack_a = 100;
            int stack_b = 200;
            Console.WriteLine("Stack Memory Variable a :" + stack_a + " b : " + stack_b);
            Console.WriteLine("Heap Memory Variable x : " + localheap.x + " y : " + localheap.y);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
