using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearchAlgorithmsVasyliev
{
    internal class StringSorts
    {
        public static List<string> InsertionSort(List<string> list, out long O)
        {
            O = 0; int i = 1, j;
            while (i < list.Count)
            {
                j = i; 
                while (j > 0 && String.Compare(list[j - 1], list[j], comparisonType: StringComparison.OrdinalIgnoreCase) > 0)
                {
                    (list[j - 1], list[j]) = (list[j], list[j - 1]);
                    j--; O++;
                }
                i++;
            }
            return list;
        }
        public static List<string> BubbleSort(List<string> list, out long O)
        {
            bool swapped; O = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (String.Compare(list[j], list[j + 1], comparisonType: StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        (list[j + 1], list[j]) = (list[j], list[j + 1]);
                        swapped = true;
                    }
                    O++;
                }
                if (!swapped) break;
            }
            return list;
        }
        public static List<string> ShakerSort(List<string> list, out long O)
        {
            O = 0; bool swapped = true;
            int start = 0, end = list.Count - 1;
            while (swapped)
            {
                swapped = false;
                for (int i = start; i < end; ++i)
                {
                    if (String.Compare(list[i], list[i + 1], comparisonType: StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        (list[i + 1], list[i]) = (list[i], list[i + 1]);
                        swapped = true;
                    }
                    O++;
                }
                if (!swapped) break;
                swapped = false; end--;
                for (int i = end - 1; i >= start; --i)
                {
                    if (String.Compare(list[i], list[i + 1], comparisonType: StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        (list[i + 1], list[i]) = (list[i], list[i + 1]);
                        swapped = true;
                    }
                    O++;
                }
                start++;
            }
            return list;
        }
        public static List<string> OddEvenSort(List<string> list, out long O)
        {
            O = 0; bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 1; i <= list.Count - 2; i = i + 2)
                {
                    if (String.Compare(list[i], list[i + 1], comparisonType: StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        (list[i + 1], list[i]) = (list[i], list[i + 1]);
                        isSorted = false;
                    }
                    O++;
                }
                for (int i = 0; i <= list.Count - 2; i = i + 2)
                {
                    if (String.Compare(list[i], list[i + 1], comparisonType: StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        (list[i + 1], list[i]) = (list[i], list[i + 1]);
                        isSorted = false;
                    }
                    O++;
                }
            }
            return list;
        }
        public static List<string> CombSort(List<string> list, out long O)
        {
            O = 0; int gap = list.Count; bool swapped = true;
            while (gap != 1 || swapped == true)
            {
                gap = gap * 10 / 13;
                if (gap < 1) gap = 1;
                swapped = false;
                for (int i = 0; i < list.Count - gap; i++)
                {
                    if (String.Compare(list[i], list[i + gap], comparisonType: StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        (list[i + gap], list[i]) = (list[i], list[i + gap]);
                        swapped = true;
                    }
                    O++;
                }
            }
            return list;
        }
        public static List<string> SelectionSort(List<string> list, out long O)
        {
            O = 0; int minI; string t;
            for (int i = 0; i < list.Count - 1; i++)
            {
                minI = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (String.Compare(list[j], list[minI], comparisonType: StringComparison.OrdinalIgnoreCase) < 0) minI = j;
                    O++;
                }
                t = list[minI];
                list[minI] = list[i];
                list[i] = t;
            }
            return list;
        }
        public static List<string> CountSort(List<string> list, out long O)
        {
            O = 0;
            double max = Convert.ToInt32(list.MaxBy(x => Convert.ToInt32(x)));
            double[] output = new double[(int)max + 2];
            foreach (string e in list)
            {
                ++output[Convert.ToInt32(e)]; O++;
            }
            int b = 0;
            for (int i = 0; i < max + 1; ++i)
                for (int j = 0; j < output[i]; ++j)
                {
                    //list[b++] = i; O++;
                }
            return list;
        }
        public static List<string> ShellSort(List<string> list, out long O)
        {
            O = 0;
            int n = list.Count, j, k; string temp;
            for (int gap = n / 2; gap > 0; gap /= 2)
                for (int i = gap; i < n; i += 1)
                {
                    temp = list[i]; k = 0; 
                    for (j = i; j >= gap && String.Compare(list[j - gap], temp, comparisonType: StringComparison.OrdinalIgnoreCase) > 0; j -= gap)
                    {
                        list[j] = list[j - gap]; k++;
                    }
                    if (k == 0) O++;
                    else O += k;
                    list[j] = temp;
                }
            return list;
        }
        private static List<string> QuickSort(List<string> list, int l, int r, long On, out long O)
        {
            if (l < r)
            {
                string pivot = list[(l + r) / 2];
                int i = l + 1;
                for (int j = l + 1; j <= r; j++)
                {
                    if (String.Compare(list[j], pivot, comparisonType: StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        (list[j], list[i]) = (list[i], list[j]);
                        i++;
                    }
                    On++;
                }
                list[l] = list[i - 1]; list[i - 1] = pivot;
                list = QuickSort(list, l, i - 2, On, out On);
                list = QuickSort(list, i, r, On, out On);
            }
            O = On;
            return list;
        }
        public static List<string> QuickSort(List<string> list, out long O)
        {
            O = 0;
            list = QuickSort(list, 0, list.Count - 1, O, out O);
            return list;
        }
        private static List<string> MergeSort(List<string> list, long On, out long O)
        {
            O = On;
            if (list.Count == 1 || list.Count == 0) return list;
            List<string> l, r;
            if (list.Count % 2 == 0)
            {
                l = MergeSort(list.GetRange(0, list.Count / 2), O, out O);
                r = MergeSort(list.GetRange(list.Count / 2, list.Count / 2), O, out O);
            }
            else
            {
                l = MergeSort(list.GetRange(0, (int)Math.Floor((double)list.Count / 2)), O, out O);
                r = MergeSort(list.GetRange((int)Math.Floor((double)list.Count / 2), (int)Math.Floor((double)list.Count / 2) + 1), O, out O);
            }
            int n = 0, m = 0, k = 0;
            string[] c = new string[l.Count + r.Count];
            while (n < l.Count && m < r.Count)
            {                
                if (String.Compare(l[n], r[m], comparisonType: StringComparison.OrdinalIgnoreCase) <= 0) c[k] = l[n++];
                else c[k] = r[m++];
                k++; O++;
            }
            while (n < l.Count)
            {
                c[k++] = l[n++]; O++;
            }
            while (m < r.Count)
            {
                c[k++] = r[m++]; O++;
            }
            return c.ToList();
        }
        public static List<string> MergeSort(List<string> list, out long O)
        {
            O = 0;
            return MergeSort(list, O, out O);
        }
        private static List<string> HeapSort(List<string> list, int N, int i, long On, out long O)
        {
            O = On; int largest = i, l = 2 * i + 1, r = 2 * i + 2;
            if (l < N && String.Compare(list[l], list[largest], comparisonType: StringComparison.OrdinalIgnoreCase) > 0)
                largest = l; 
            if (r < N && String.Compare(list[r], list[largest], comparisonType: StringComparison.OrdinalIgnoreCase) > 0)
                largest = r;
            if (largest != i)
            {
                (list[i], list[largest]) = (list[largest], list[i]);
                HeapSort(list, N, largest, O, out O);
            }
            O++;
            return list;
        }
        public static List<string> HeapSort(List<string> list, out long O)
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
        public static List<string> BucketSort(List<string> list, out long O)
        {
            O = 0; int numOfBuckets = 32; long On;
            List<string> sortedArray = new List<string>();
            List<string>[] buckets = new List<string>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<string>(); O++;
            }
            for (int i = 0; i < list.Count; i++)
            {
                buckets[Convert.ToInt32(list[i]) / numOfBuckets].Add(list[i]); O++;
            }
            for (int i = 0; i < numOfBuckets; i++)
            {
                sortedArray.AddRange(InsertionSort(buckets[i], out On)); O += On;
            }
            return sortedArray;
        }
        public static List<string> RadixSort(List<string> list, out long O)
        {
            O = 0;
            int n = list.Count; double max = Convert.ToInt32(list.MaxBy(x => Convert.ToInt32(x)));

            for (int e = 1; max / e >= 1; e *= 10)
            {
                n = list.Count;
                List<string> output = new List<string>(new string[n]);
                int[] frequency = new int[10];
                for (int i = 0; i < n; i++)
                {
                    frequency[(Convert.ToInt32(list[i]) / e) % 10]++;
                    O++;
                }
                for (int i = 1; i < 10; i++)
                {
                    frequency[i] += frequency[i - 1]; O++;
                }
                for (int i = n - 1; i >= 0; i--)
                {
                    output[frequency[(Convert.ToInt32(list[i]) / e) % 10] - 1] = list[i];
                    frequency[(Convert.ToInt32(list[i]) / e) % 10]--;
                    O++;
                }
                list = output;
            }
            return list;
        }
        private static int Partition(List<string> list, int l, int r, out long O)
        {
            O = 0; 
            string pivot = list[r];
            int i = l;
            for (int j = l; j < r; ++j)
            {
                if (String.Compare(list[j], list[r], comparisonType: StringComparison.OrdinalIgnoreCase) <= 0)
                {
                    (list[i], list[j]) = (list[j], list[i]);
                    i++; O++;
                }
            }
            (list[i], list[r]) = (list[r], list[i]);
            return i;

        }
        public static List<string> IntroSort(List<string> list, out long O)
        {
            O = 0;
            int partitionSize = Partition(list, 0, list.Count - 1, out O);
            if (partitionSize < 16)
            {
                list = InsertionSort(list, out O);
            }
            else if (partitionSize > (2 * Math.Log(list.Count)))
            {
                list = HeapSort(list, out O);
            }
            else
            {
                list = QuickSort(list, out O);
            }
            return list;
        }
        public static List<string> TimSortInsertion(List<string> list, int left, int right, out long O)
        {
            O = 0; string temp; int j;
            for (int i = left + 1; i <= right; i++)
            {
                temp = list[i];
                j = i - 1; 
                if (j >= left && (String.Compare(list[j], temp, comparisonType: StringComparison.OrdinalIgnoreCase) > 0))
                    while (j >= left && (String.Compare(list[j], temp, comparisonType: StringComparison.OrdinalIgnoreCase) > 0))
                    {
                        list[j + 1] = list[j];
                        j--;
                        O++;
                    }
                else O++;
                list[j + 1] = temp;
            }
            return list;
        }
        public static List<string> TimSortMerge(List<string> list, int l, int m, int r, out long O)
        {
            O = 0;
            string[] left = new string[m - l + 1], right = new string[r - m];
            for (int x = 0; x < m - l + 1; x++)
            {
                left[x] = list[l + x]; O++;
            }
            for (int x = 0; x < r - m; x++)
            {
                right[x] = list[m + 1 + x]; O++;
            }
            int i = 0, j = 0, k = l;
            while (i < m - l + 1 && j < r - m)
            {
                if (String.Compare(list[i], right[j], comparisonType: StringComparison.OrdinalIgnoreCase) <= 0)
                {
                    list[k] = left[i]; i++;
                }
                else
                {
                    list[k] = right[j]; j++;
                }
                k++; O++;
            }
            while (i < m - l + 1)
            {
                list[k] = left[i];
                k++; i++; O++;
            }
            while (j < r - m)
            {
                list[k] = right[j];
                k++; j++; O++;
            }
            return list;
        }
        public static List<string> TimSort(List<string> list, out long O)
        {
            O = 0;
            int minRun = 32, n = list.Count, mid, right; long On;
            for (int i = 0; i < n; i += minRun)
            {
                TimSortInsertion(list, i, Math.Min(i + minRun - 1, n - 1), out On); O += On;
            }
            for (int size = minRun; size < n; size = 2 * size)
            {
                for (int left = 0; left < n; left += 2 * size)
                {
                    mid = left + size - 1; right = Math.Min(left + 2 * size - 1, n - 1);
                    if (mid < right)
                    {
                        list = TimSortMerge(list, left, mid, right, out On); O += On;
                    }
                }
            }
            return list;
        }
    }
}
