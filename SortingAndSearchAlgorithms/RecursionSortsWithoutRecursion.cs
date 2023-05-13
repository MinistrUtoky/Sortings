using SortingAndSearchAlgorithmsVasyliev;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionSortsWithoutRecursionAndMyHybridSort
{
    internal class RecursionSortsWithoutRecursion
    {
        public static List<double> QuickSort(List<double> list, out long O)
        {
            O = 0;
            Stack<int> leftRightStack = new Stack<int>();
            int i, j, l = 0, r = list.Count - 1;
            double pivot;
            leftRightStack.Push(l); leftRightStack.Push(r);
            while (leftRightStack.Any() || l < r)
            {
                r = leftRightStack.Pop();
                l = leftRightStack.Pop();
                if (l < r)
                {
                    pivot = list[r];
                    i = l - 1;
                    for (j = l; j < r; j++)
                    {
                        if (list[j] <= pivot)
                        {
                            i++;
                            (list[i], list[j]) = (list[j], list[i]);
                        }
                        O++;
                    }
                    (list[i + 1], list[r]) = (list[r], list[i + 1]);
                    leftRightStack.Push(l); leftRightStack.Push(i);
                    leftRightStack.Push(i + 2); leftRightStack.Push(r);
                }
                else O++;
            }
            return list;
        }


        public static List<double> MergeSort(List<double> list, out long O)
        {
            O = 0;
            int n = list.Count, curr_size, l, i, j, k, m, r, n1, n2;
            List<double> L, R;
            for (curr_size = 1; curr_size <= n - 1;  curr_size = 2 * curr_size)
            {
                for (l = 0; l < n - 1; l += 2 * curr_size)
                {
                    m = Math.Min(l + curr_size - 1, n - 1);
                    r = Math.Min(l + 2 * curr_size - 1, n - 1);
                    n1 = m - l + 1;
                    n2 = r - m;
                    L = new List<double>();
                    R = new List<double>();
                    L.AddRange(list.GetRange(l, n1));
                    R.AddRange(list.GetRange(m + 1, n2));
                    i = 0; j = 0; k = l;
                    while (i < n1 && j < n2)
                    {
                        if (L[i] <= R[j])
                        {
                            list[k] = L[i];
                            i++;
                        }
                        else
                        {
                            list[k] = R[j];
                            j++;
                        }
                        k++; O++;
                    }
                    while (i < n1)
                    {
                        list[k] = L[i];
                        i++; k++; O++;
                    }
                    while (j < n2)
                    {
                        list[k] = R[j];
                        j++; k++; O++;
                    }
                }
            }
            return list;
        }


         public static List<double> HeapSort(List<double> list, out long O)
         {
             O = 0;
             int n = list.Count, larger, l, r, size, ind; double top, max;
             for (int i = n / 2 - 1; i >= 0; i--)
             {
                 top = list[i];
                 if (i < n / 2)
                     while (i < n / 2)
                     {
                         l = 2 * i + 1;
                         r = 2 * i + 2;
                         if (r < n && list[r] > list[l]) larger = r;
                         else larger = l;
                         if (top >= list[larger]) break;
                         list[i] = list[larger];
                         i = larger;
                         O++;
                     }
                 else O++;
                 list[i] = top;
             }
             for (int i = 0; i < n; i++)
             { 
                 size = n - i - 1;
                 max = list[0];
                 list[0] = list[size];
                 top = list[0];
                 ind = 0;
                 if (ind < size / 2)
                     while (ind < size / 2)
                     {
                         l = 2 * ind + 1;
                         r = 2 * ind + 2;
                         if (r < size && list[r] > list[l]) larger = r;
                         else larger = l;
                         if (top >= list[larger]) break;
                         list[ind] = list[larger];
                         ind = larger;
                         O++;
                     }
                 else O++;
                 list[ind] = top;
                 list[size] = max; 
             }
             return list;
         }  

        public static void RecursionlessRecursionSortingsStarter()
        {
            long O;
            List<double> list;
            for (int k = 2; k < 7; k++)
            {
                Console.WriteLine("QuickSort");
                Console.WriteLine(Math.Pow(8, k));
                list = Sorts.QuickSort(ListGenerators.RandomDoublesList((int)Math.Pow(8, k), -1000000, 1000000), out O);
                Console.WriteLine(O + "!");
                list = RecursionSortsWithoutRecursion.QuickSort(ListGenerators.RandomDoublesList((int)Math.Pow(8, k), -1000000, 1000000), out O);
                Console.WriteLine(O + "!");
                Console.WriteLine();


                Console.WriteLine("HeapSort");
                Console.WriteLine(Math.Pow(8, k));
                list = Sorts.HeapSort(ListGenerators.RandomDoublesList((int)Math.Pow(8, k), -1000000, 1000000), out O);
                Console.WriteLine(O + "!!");
                list = RecursionSortsWithoutRecursion.HeapSort(ListGenerators.RandomDoublesList((int)Math.Pow(8, k), -1000000, 1000000), out O);
                Console.WriteLine(O + "!!");
                Console.WriteLine();


                Console.WriteLine("MergeSort");
                Console.WriteLine(Math.Pow(8, k));
                list = Sorts.MergeSort(ListGenerators.RandomDoublesList((int)Math.Pow(8, k), -1000000, 1000000), out O);
                Console.WriteLine(O + "!!!");
                list = RecursionSortsWithoutRecursion.MergeSort(ListGenerators.RandomDoublesList((int)Math.Pow(8, k), -1000000, 1000000), out O);
                Console.WriteLine(O + "!!!");
                Console.WriteLine();
            }
        }
    }
}
