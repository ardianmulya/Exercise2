using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                aan[AW + 1] = temp;
            }
        }

        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int AW= 0; AW < n; AW++)
            {
                Console.WriteLine(aan[AW]);
            }
            Console.WriteLine("");
        }
        void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];


            i = 0;
            j = 0;


            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }


            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }


            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {

                int m = l + (r - l) / 2;


                sort(arr, l, m);
                sort(arr, m + 1, r);


                merge(arr, l, m, r);
            }
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            int pilihanmenu;

            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("==================");
                Console.WriteLine("1.insertion sort");
                Console.WriteLine("2.merge sort");
                Console.WriteLine("3.Exit");
                Console.Write("Enter your choice (1,2,3) : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine(". . . . . . . . . . . .");
                        Console.WriteLine("insertion sort");
                        Console.WriteLine(". . . . . . . . . . . .");
                        P.input();
                        P.insertion_sort();
                        P.display();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine(". . . . . . . . . . . .");
                        Console.WriteLine("merge sort");
                        Console.WriteLine(". . . . . . . . . . . .");

                        break;
                    case 3:
                        Console.WriteLine("exit");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("\n\nPress Return to exit");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}
