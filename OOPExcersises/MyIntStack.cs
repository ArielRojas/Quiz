using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExcersises
{
    internal class MyIntStack
    {
        private int[] contents;
        private int tos; // Top of the stack

        public MyIntStack()
        {
            contents = new int[5];
            tos = -1;
        }

        public void Push(int value)
        {
            if (tos >= contents.Length)
            {
                Console.WriteLine("It is not possible to add more data.");
            }
            else
            {
                contents[++tos] = value;
            }
        }

        public int Pop()
        {

            if (tos < 0)
            {
                Console.WriteLine("None data exists.");

                return 0;
            }
            else
            {
                int value = contents[tos--];

                return value;
            }
        }

        public void PrintStack()
        {
            if (tos < 0)
            {
                Console.WriteLine("None data exists.");
            }
            else
            {
                Console.WriteLine("Prints data in the Stack: ");

                for (int count = tos; count >= 0; count--)
                {
                    Console.WriteLine(contents[count]);
                }
            }
        }
    }
}
