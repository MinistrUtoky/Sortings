using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearchAlgorithmsVasyliev
{
    internal class DateSorts
    {
        public static List<DateTime> InsertionSort(List<DateTime> list, out long O)
        {
            O = 0; int i = 1, j;
            while (i < list.Count)
            {
                j = i;
                while (j > 0 && list[j - 1] > list[j])
                {
                    (list[j - 1], list[j]) = (list[j], list[j - 1]);
                    j--; O++;
                }
                i++;
            }
            return list;
        }
        public static List<DateTime> BubbleSort(List<DateTime> list, out long O)
        {
            bool swapped; O = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
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
        public static List<DateTime> ShakerSort(List<DateTime> list, out long O)
        {
            O = 0; bool swapped = true;
            int start = 0, end = list.Count - 1;
            while (swapped)
            {
                swapped = false;
                for (int i = start; i < end; ++i)
                {
                    if (list[i] > list[i + 1])
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
                    if (list[i] > list[i + 1])
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
        public static List<DateTime> OddEvenSort(List<DateTime> list, out long O)
        {
            O = 0; bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 1; i <= list.Count - 2; i = i + 2)
                {
                    if (list[i] > list[i + 1])
                    {
                        (list[i + 1], list[i]) = (list[i], list[i + 1]);
                        isSorted = false;
                    }
                    O++;
                }
                for (int i = 0; i <= list.Count - 2; i = i + 2)
                {
                    if (list[i] > list[i + 1])
                    {
                        (list[i + 1], list[i]) = (list[i], list[i + 1]);
                        isSorted = false;
                    }
                    O++;
                }
            }
            return list;
        }
        public static List<DateTime> CombSort(List<DateTime> list, out long O)
        {
            O = 0; int gap = list.Count; bool swapped = true;
            while (gap != 1 || swapped == true)
            {
                gap = gap * 10 / 13;
                if (gap < 1) gap = 1;
                swapped = false;
                for (int i = 0; i < list.Count - gap; i++)
                {
                    if (list[i] > list[i + gap])
                    {
                        (list[i + gap], list[i]) = (list[i], list[i + gap]);
                        swapped = true;
                    }
                    O++;
                }
            }
            return list;
        }
        public static List<DateTime> SelectionSort(List<DateTime> list, out long O)
        {
            O = 0; int minI; DateTime t;
            for (int i = 0; i < list.Count - 1; i++)
            {
                minI = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[minI]) minI = j;
                    O++;
                }
                t = list[minI];
                list[minI] = list[i];
                list[i] = t;
            }
            return list;
        }
        public static List<DateTime> CountSort(List<DateTime> list, out long O)
        {
            O = 0;
            List<double> listOfSeconds = new List<double>();
            DateTime dt = new DateTime(list.MinBy(x => x.Year).Year, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            list.ForEach(t => listOfSeconds.Add((t.ToUniversalTime() - dt).TotalSeconds));
            double max = listOfSeconds.Max();
            double[] output = new double[(int)max + 2];
            foreach (double e in listOfSeconds)
            {
                ++output[(int)e]; O++;
            }
            int b = 0;
            for (int i = 0; i < max + 1; ++i)
                for (int j = 0; j < output[i]; ++j)
                {
                    listOfSeconds[b++] = i; O++;
                }
            for (int i = 0; i < list.Count; i++) list[i] = dt + TimeSpan.FromSeconds((int)listOfSeconds[i]);
            return list;
        }
        public static List<DateTime> ShellSort(List<DateTime> list, out long O)
        {
            O = 0;
            int n = list.Count, j, k; DateTime temp;
            for (int gap = n / 2; gap > 0; gap /= 2)
                for (int i = gap; i < n; i += 1)
                {
                    temp = list[i]; k = 0;
                    for (j = i; j >= gap && list[j - gap] > temp; j -= gap)
                    {
                        list[j] = list[j - gap]; k++;
                    }
                    if (k == 0) O++;
                    else O += k;
                    list[j] = temp;
                }
            return list;
        }
        private static List<DateTime> QuickSort(List<DateTime> list, int l, int r, long On, out long O)
        {
            if (l < r)
            {
                DateTime pivot = list[(l + r) / 2];
                int i = l + 1;
                for (int j = l + 1; j <= r; j++)
                {
                    if (list[j] < pivot)
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
        public static List<DateTime> QuickSort(List<DateTime> list, out long O)
        {
            O = 0;
            list = QuickSort(list, 0, list.Count - 1, O, out O);
            return list;
        }
        private static List<DateTime> MergeSort(List<DateTime> list, long On, out long O)
        {
            O = On;
            if (list.Count == 1 || list.Count == 0) return list;
            List<DateTime> l, r;
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
            DateTime[] c = new DateTime[l.Count + r.Count];
            while (n < l.Count && m < r.Count)
            {
                if (l[n] <= r[m]) c[k] = l[n++];
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
        public static List<DateTime> MergeSort(List<DateTime> list, out long O)
        {
            O = 0;
            return MergeSort(list, O, out O);
        }
        private static List<DateTime> HeapSort(List<DateTime> list, int N, int i, long On, out long O)
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
        public static List<DateTime> HeapSort(List<DateTime> list, out long O)
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
        public static List<DateTime> BucketSort(List<DateTime> list, out long O)
        {
            O = 0; int numOfBuckets = 32;long On;
            List<double> listOfSeconds = new List<double>();
            DateTime dt = new DateTime(list.MinBy(x => x.Year).Year, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            list.ForEach(t => listOfSeconds.Add((t.ToUniversalTime() - dt).TotalSeconds));
            List<DateTime> sortedArray = new List<DateTime>();
            List<DateTime>[] buckets = new List<DateTime>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<DateTime>(); O++;
            }
            for (int i = 0; i < listOfSeconds.Count; i++)
            {
                buckets[(int)listOfSeconds[i] / numOfBuckets].Add(list[i]); O++;
            }
            for (int i = 0; i < numOfBuckets; i++)
            {
                sortedArray.AddRange(InsertionSort(buckets[i], out On)); O += On;
            }
            return sortedArray;
        }
        public static List<DateTime> RadixSort(List<DateTime> list, out long O)
        {
            O = 0;
            int n = list.Count;
            List<double> listOfSeconds = new List<double>();
            DateTime dt = new DateTime(list.MinBy(x => x.Year).Year, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            list.ForEach(t => listOfSeconds.Add((t.ToUniversalTime() - dt).TotalSeconds));
            double max = listOfSeconds.Max();
            for (int e = 1; max / e >= 1; e *= 10)
            {
                n = listOfSeconds.Count;
                List<double> output = new List<double>(new double[n]);
                int[] frequency = new int[10];
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        frequency[((int)listOfSeconds[i] / e) % 10]++;
                    }
                    catch
                    {
                        throw new Exception(((int)listOfSeconds[i] / e) % 10 + "");
                    }
                    O++;
                }
                for (int i = 1; i < 10; i++)
                {
                    frequency[i] += frequency[i - 1]; O++;
                }
                for (int i = n - 1; i >= 0; i--)
                {
                    output[frequency[((int)listOfSeconds[i] / e) % 10] - 1] = listOfSeconds[i];
                    frequency[((int)listOfSeconds[i] / e) % 10]--;
                    O++;
                }
                for (int i = 0; i < list.Count; i++) list[i] = dt + TimeSpan.FromSeconds((int)output[i]);
            }
            return list;
        }
        private static int Partition(List<DateTime> list, int l, int r, out long O)
        {
            O = 0;
            DateTime pivot = list[r];
            int i = l;
            for (int j = l; j < r; ++j)
            {
                if (list[j] <= list[r])
                {
                    (list[i], list[j]) = (list[j], list[i]);
                    i++; O++;
                }
            }
            (list[i], list[r]) = (list[r], list[i]);
            return i;

        }
        public static List<DateTime> IntroSort(List<DateTime> list, out long O)
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
        public static List<DateTime> TimSortInsertion(List<DateTime> list, int left, int right, out long O)
        {
            O = 0; DateTime temp; int j;
            for (int i = left + 1; i <= right; i++)
            {
                temp = list[i];
                j = i - 1;
                if (j >= left && list[j] > temp)
                    while (j >= left && list[j] > temp)
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
        public static List<DateTime> TimSortMerge(List<DateTime> list, int l, int m, int r, out long O)
        {
            O = 0;
            DateTime[] left = new DateTime[m - l + 1], right = new DateTime[r - m];
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
                if (left[i] <= right[j])
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
        public static List<DateTime> TimSort(List<DateTime> list, out long O)
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
