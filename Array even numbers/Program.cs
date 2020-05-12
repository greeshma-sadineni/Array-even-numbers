using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Array_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            int[] a = new int[10];
            Console.WriteLine("Enter number of elements to array");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("element - {0} : ", +i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in an array");
                foreach (int k in a)
            {
                Console.WriteLine("{0}", k);
            }

 Console.WriteLine("even elements in an array");
            foreach(int j in a)
            {
                if (j%2== 0)
                {

                    Console.WriteLine("{0} ", j);
                }
            }
           
        }
    }
}
