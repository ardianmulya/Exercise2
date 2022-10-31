using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        private int[] aan = new int[39];
        int n;
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 39))
                    break;
                else
                    Console.WriteLine("\nArray should have minimun 1 and maximum 39 elements.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("=====================");
            Console.WriteLine(" Enter array elements");
            Console.WriteLine("=====================");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                aan[i] = Int32.Parse(s1);
            }
        }

        public void insertion_sort()
        {
            for (int i = 1; i < n; i++)
            {
                int temp = aan[i];
                int AW = i - 1;
                while (AW >= 0 && aan[AW] > temp)
                {
                    aan[AW + 1] = aan[AW];
                    AW--;
                }
                aan[j + 1] = temp;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
