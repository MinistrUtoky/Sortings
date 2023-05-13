using SortingAndSearchAlgorithmsVasyliev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RecursionSortsWithoutRecursionAndMyHybridSort
{
    internal class MyHybridSort
    {
        public static void MyHybridSortingAlgorithmStarter()
        {
            long O;
            List<double> list;
            for (int k = 2; k < 8; k++)
            {
                Console.WriteLine(Math.Pow(8, k));
                list = MyHybridSort.DoubleCheeseburgerSort(ListGenerators.RandomDoublesList((int)Math.Pow(8, k), -100, 100), out O);
                Console.WriteLine(O + "!");
                list = Sorts.HeapSort(ListGenerators.RandomDoublesList((int)Math.Pow(8, k), -100, 100), out O);
                Console.WriteLine(O + "!!");
                Console.WriteLine();
            }
        }
        private static int UniqueElementsNumber(List<double> listToSort, int range, out long O)
        {
            O = 0;
            Dictionary<int, int> counter = new Dictionary<int, int>();
            foreach (double x in listToSort) {
                counter[(int)x] = counter.ContainsKey((int)x) ? counter[(int)x] + 1 : 1; O++; 
            }
            return counter.Count;
        }
        public static List<double> MySort(List<double> listToSort, out long O) // I call it evil clone insertion sort or 28 knife stabs sort
        {
            O = 0;
            if (listToSort.Count == 0) return listToSort;
            List<double> newList = new List<double>(); 
            double first = listToSort[0], last = first; int j;
            newList.Add(first);
            for (int i = 1; i < listToSort.Count; i++)
            {
                if (listToSort[i] >= last)
                {
                    newList.Add(listToSort[i]); last = listToSort[i]; O++;
                }
                else if (listToSort[i] <= first)
                {
                    newList.Insert(0, listToSort[i]); first = listToSort[i]; O++;
                }
                else
                {
                    j = newList.Count-1;
                    while (listToSort[i] < newList[j]) { j--; O++; }
                    newList.Insert(j+1, listToSort[i]);
                }
            }
            return newList;
        }
        private static List<double> HeapSort(List<double> list, int N, int i, long On, out long O)
        {
            O = On; int largest = i, l = 2 * i + 1, r = 2 * i + 2;
            if (l < N && list[l] > list[largest])
                largest = l;
            if (r < N && list[r] > list[largest])
                largest = r;
            if (largest != i)
            {
                (list[i], list[largest]) = (list[largest], list[i]);
                HeapSort(list, N, largest, O, out O);
            }
            O++;
            return list;
        }
        public static List<double> HeapSort(List<double> list, out long O)
        {
            O = 0;
            for (int i = list.Count / 2 - 1; i >= 0; i--)
                HeapSort(list, list.Count, i, O, out O);
            for (int i = list.Count - 1; i > 0; i--)
            {
                (list[0], list[i]) = (list[i], list[0]);
                HeapSort(list, i, 0, O, out O);
            }
            return list;
        }
        public static List<double> RadixSort(List<double> listToSort, out long O)
        {
            O = 0;
            List<double> output;
            int n = listToSort.Count; double max = listToSort.Max();
            for (int e = 1; max / e >= 1; e *= 10)
            {
                output = new List<double>(new double[n]);
                int[] frequency = new int[10];
                for (int i = 0; i < n; i++)
                {
                    frequency[((int)listToSort[i] / e) % 10]++;
                    O++;
                }
                for (int i = 1; i < 10; i++)
                {
                    frequency[i] += frequency[i - 1]; O++;
                }
                for (int i = n - 1; i >= 0; i--)
                {
                    output[frequency[((int)listToSort[i] / e) % 10] - 1] = listToSort[i];
                    frequency[((int)listToSort[i] / e) % 10]--;
                    O++;
                }
                listToSort = output;
            }

            return listToSort;
        }
        public static List<double> BucketSort(List<double> listToSort, out long O)
        {
            O = 0; int numOfBuckets = (int)Math.Sqrt(listToSort.Max()) + 1; long On;
            List<double> sortedArray = new List<double>();
            List<double>[] buckets = new List<double>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<double>(); O++;
            }
            for (int i = 0; i < listToSort.Count; i++)
            {
                buckets[(int)listToSort[i] / numOfBuckets].Add(listToSort[i]); O++;
            }
            for (int i = 0; i < numOfBuckets; i++)
            {
                sortedArray.AddRange(MySort(buckets[i], out On)); O += On;
            }
            return sortedArray;
        }
        public static List<double> DictionaryCountSort(List<double> listToSort, out long O)
        {
            O = 0;
            return listToSort;
        }
        public static List<double> DoubleCheeseburgerSort(List<double> listToSort, out long O) 
            // It's called that way because you buy double CB only if you're broke
        {
            double min = listToSort.Min(), max = listToSort.Max(); double n = listToSort.Count; O = 0;
            for (int i = 0; i < n; i++) { listToSort[i] -= min; O++; } //Makin 'em positive
            long On, uniqueness;
            if ((long)max < Int32.MaxValue)
            {
                uniqueness = UniqueElementsNumber(listToSort, (int)(max - min) + 1, out On); O += On;
                if (uniqueness > 0.7*n && uniqueness > 0.01*(int)(max - min))
                {
                    Console.WriteLine("B!");
                    listToSort = BucketSort(listToSort, out On); O += On;
                    listToSort = MySort(listToSort, out On); O += On;
                }
                else if (((int)max.ToString().Length * (n + 10) < 1.2 * n * Math.Log(n)) && uniqueness < (max - min))
                {
                    Console.WriteLine("R!");    
                    listToSort = RadixSort(listToSort, out On); O += On;
                    listToSort = MySort(listToSort, out On); O += On;
                }
                else
                {
                    Console.WriteLine("H!");
                    HeapSort(listToSort, out On); O += On;
                }
            }
            else { HeapSort(listToSort, out On); O += On; Console.WriteLine("H2!"); }
            for (int i = 0; i < n; i++) { listToSort[i] += min; O++; }
            return listToSort;
        }
    }
}
