using System;

namespace Project3B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            foreach(int i in array)
            {
               Console.WriteLine("Element Value = " + i);
            }
        }
    }
}
