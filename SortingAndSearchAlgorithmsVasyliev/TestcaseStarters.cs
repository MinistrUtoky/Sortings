using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearchAlgorithmsVasyliev
{
    public class TestcaseStarters
    {
        public static void StartDigitsSortingAlgorithmsTestcase(List<double> sortableList)
        {
            
            double min = 0;
            if (sortableList.Any(x => x < 0))
            {
                min = sortableList.Min();
                for (int i = 0; i < sortableList.Count; i++)
                    sortableList[i] += Math.Abs(min);
            }
            long O;
            List<double> listToSort = new List<double>(sortableList);
            Console.WriteLine("InsertionSort:");
            List<double> inserted = Sorts.InsertionSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("BubbleSort:");
            List<double> bubbled = Sorts.BubbleSort(listToSort, out O);
            bubbled.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("ShakerSort:");
            List<double> shaken = Sorts.ShakerSort(listToSort, out O);
            shaken.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("OddEvenSort:");
            List<double> evened = Sorts.OddEvenSort(listToSort, out O);
            evened.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("CombSort:");
            List<double> combed = Sorts.CombSort(listToSort, out O);
            combed.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("SelectionSort:");
            List<double> selected = Sorts.SelectionSort(listToSort, out O);
            selected.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("CountSort:");
            List<double> counted = Sorts.CountSort(listToSort, out O);
            counted.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("ShellSort:");
            List<double> shelled = Sorts.ShellSort(listToSort, out O);
            shelled.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("QuickSort:");
            List<double> quickQuack = Sorts.QuickSort(listToSort, out O);
            quickQuack.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("MergeSort:");
            List<double> merged = Sorts.MergeSort(listToSort, out O);
            merged.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("HeapSort:");
            List<double> heaped = Sorts.HeapSort(listToSort, out O);
            heaped.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("RadixSort:");
            List<double> radixed = Sorts.RadixSort(listToSort, out O);
            radixed.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("BucketSort:");
            List<double> bucketed = Sorts.BucketSort(listToSort, out O);
            bucketed.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("IntroSort:");
            List<double> introed = Sorts.IntroSort(listToSort, out O);
            introed.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("TimSort:");
            List<double> timmed = Sorts.TimSort(listToSort, out O);
            timmed.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");
        }
        public static void StartDigitsSortingAlgorithmsComplexityTestcase(List<double> sortableList, string file)
        {
            StreamReader prevData = new StreamReader(file);
            List<string> prevDataList = new List<string>();
            while (prevData.Peek() != -1) prevDataList.Add(prevData.ReadLine());
            prevData.Close();
            
            StreamWriter newData = new StreamWriter(file);
            newData.WriteLine((prevDataList.Count() > 0 ? prevDataList[0] : "") + "digit" + ";");
            newData.WriteLine((prevDataList.Count() > 1 ? prevDataList[1] : "") + sortableList.Count().ToString() + ";");
            try
            {
                double min = 0;
                if (sortableList.Any(x => x < 0))
                {
                    min = sortableList.Min();
                    for (int i = 0; i < sortableList.Count; i++)
                        sortableList[i] += Math.Abs(min);
                }
                long O; int j = 2; 
                List<double> listToSort = new List<double>(sortableList);
                Console.WriteLine("InsertionSort:");
                List<double> inserted = Sorts.InsertionSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("BubbleSort:");
                List<double> bubbled = Sorts.BubbleSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("ShakerSort:");
                List<double> shaken = Sorts.ShakerSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("OddEvenSort:");
                List<double> evened = Sorts.OddEvenSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("CombSort:");
                List<double> combed = Sorts.CombSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("SelectionSort:");
                List<double> selected = Sorts.SelectionSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("CountSort:");
                List<double> counted = Sorts.CountSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("ShellSort:");
                List<double> shelled = Sorts.ShellSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("QuickSort:");
                List<double> quickQuack = Sorts.QuickSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("MergeSort:");
                List<double> merged = Sorts.MergeSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("HeapSort:");
                List<double> heaped = Sorts.HeapSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("RadixSort:");
                List<double> radixed = Sorts.RadixSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("BucketSort:");
                List<double> bucketed = Sorts.BucketSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("IntroSort:");
                List<double> introed = Sorts.IntroSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("TimSort:");
                List<double> timmed = Sorts.TimSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count()? prevDataList[j++]: "") + O + ";");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            newData.Close();
            }

        public static void StartSortingAlgorithmsTestcase(List<double> sortableList)
        {
            double min = 0;
            if (sortableList.Any(x => x < 0))
            {
                min = sortableList.Min();
                for (int i = 0; i < sortableList.Count; i++)
                    sortableList[i] += Math.Abs(min);
            }
            long O;
            List<double> listToSort = new List<double>(sortableList);
            Console.WriteLine("InsertionSort:");
            List<double> inserted = Sorts.InsertionSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("BubbleSort:");
            List<double> bubbled = Sorts.BubbleSort(listToSort, out O);
            bubbled.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("ShakerSort:");
            List<double> shaken = Sorts.ShakerSort(listToSort, out O);
            shaken.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("OddEvenSort:");
            List<double> evened = Sorts.OddEvenSort(listToSort, out O);
            evened.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("CombSort:");
            List<double> combed = Sorts.CombSort(listToSort, out O);
            combed.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("SelectionSort:");
            List<double> selected = Sorts.SelectionSort(listToSort, out O);
            selected.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("CountSort:");
            List<double> counted = Sorts.CountSort(listToSort, out O);
            counted.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("ShellSort:");
            List<double> shelled = Sorts.ShellSort(listToSort, out O);
            shelled.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("QuickSort:");
            List<double> quickQuack = Sorts.QuickSort(listToSort, out O);
            quickQuack.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("MergeSort:");
            List<double> merged = Sorts.MergeSort(listToSort, out O);
            merged.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("HeapSort:");
            List<double> heaped = Sorts.HeapSort(listToSort, out O);
            heaped.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("RadixSort:");
            List<double> radixed = Sorts.RadixSort(listToSort, out O);
            radixed.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("BucketSort:");
            List<double> bucketed = Sorts.BucketSort(listToSort, out O);
            bucketed.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("IntroSort:");
            List<double> introed = Sorts.IntroSort(listToSort, out O);
            introed.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");

            listToSort = new List<double>(sortableList);
            Console.WriteLine("TimSort:");
            List<double> timmed = Sorts.TimSort(listToSort, out O);
            timmed.ForEach(x => Console.WriteLine(x + min));
            Console.WriteLine(O + "!");
        }
        public static void StartSortingAlgorithmsComplexityTestcase(List<double> sortableList, string file)
        {
            StreamReader prevData = new StreamReader(file);
            List<string> prevDataList = new List<string>();
            while (prevData.Peek() != -1) prevDataList.Add(prevData.ReadLine());
            prevData.Close();

            StreamWriter newData = new StreamWriter(file);
            newData.WriteLine((prevDataList.Count() > 0 ? prevDataList[0] : "") + "double" + ";");
            newData.WriteLine((prevDataList.Count() > 1 ? prevDataList[1] : "") + sortableList.Count().ToString() + ";");
            try
            {
                double min = 0;
                if (sortableList.Any(x => x < 0))
                {
                    min = sortableList.Min();
                    for (int i = 0; i < sortableList.Count; i++)
                        sortableList[i] += Math.Abs(min);
                }
                long O; int j = 2;
                List<double> listToSort = new List<double>(sortableList);
                Console.WriteLine("InsertionSort:");
                List<double> inserted = Sorts.InsertionSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("BubbleSort:");
                List<double> bubbled = Sorts.BubbleSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("ShakerSort:");
                List<double> shaken = Sorts.ShakerSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("OddEvenSort:");
                List<double> evened = Sorts.OddEvenSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("CombSort:");
                List<double> combed = Sorts.CombSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("SelectionSort:");
                List<double> selected = Sorts.SelectionSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
            
                listToSort = new List<double>(sortableList);
                Console.WriteLine("CountSort:");
                List<double> counted = Sorts.CountSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("ShellSort:");
                List<double> shelled = Sorts.ShellSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("QuickSort:");
                List<double> quickQuack = Sorts.QuickSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("MergeSort:");
                List<double> merged = Sorts.MergeSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("HeapSort:");
                List<double> heaped = Sorts.HeapSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("RadixSort:");
                List<double> radixed = Sorts.RadixSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("BucketSort:");
                List<double> bucketed = Sorts.BucketSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<double>(sortableList);
                Console.WriteLine("IntroSort:");
                List<double> introed = Sorts.IntroSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
                
            
                listToSort = new List<double>(sortableList);
                Console.WriteLine("TimSort:");
                List<double> timmed = Sorts.TimSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            newData.Close();
        }

        public static void StartStringSortingAlgorithmsTestcase(List<string> sortableList)
        {
            long O;
            List<string> listToSort = new List<string>(sortableList);
            Console.WriteLine("InsertionSort:");
            List<string> inserted = StringSorts.InsertionSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<string>(sortableList);
            Console.WriteLine("BubbleSort:");
            List<string> bubbled = StringSorts.BubbleSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<string>(sortableList);
            Console.WriteLine("ShakerSort:");
            List<string> shaken = StringSorts.ShakerSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<string>(sortableList);
            Console.WriteLine("OddEvenSort:");
            List<string> evened = StringSorts.OddEvenSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<string>(sortableList);
            Console.WriteLine("CombSort:");
            List<string> combed = StringSorts.CombSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<string>(sortableList);
            Console.WriteLine("SelectionSort:");
            List<string> selected = StringSorts.SelectionSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            Console.WriteLine("Counting Sort cannot be used on string type arrays");

            listToSort = new List<string>(sortableList);
            Console.WriteLine("ShellSort:");
            List<string> shelled = StringSorts.ShellSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<string>(sortableList);
            Console.WriteLine("QuickSort:");
            List<string> quickQuack = StringSorts.QuickSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<string>(sortableList);
            Console.WriteLine("MergeSort:");
            List<string> merged = StringSorts.MergeSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<string>(sortableList);
            Console.WriteLine("HeapSort:");
            List<string> heaped = StringSorts.HeapSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            Console.WriteLine("Radix Sort cannot be used on string type arrays");

            Console.WriteLine("Bucket Sort cannot be used on string type arrays");

            listToSort = new List<string>(sortableList);
            Console.WriteLine("IntroSort:");
            List<string> introed = StringSorts.IntroSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<string>(sortableList);
            Console.WriteLine("TimSort:");
            List<string> timmed = StringSorts.TimSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");
        }
        public static void StartStringSortingAlgorithmsComplexityTestcase(List<string> sortableList, string file)
        {
            StreamReader prevData = new StreamReader(file);
            List<string> prevDataList = new List<string>();
            while (prevData.Peek() != -1) prevDataList.Add(prevData.ReadLine());
            prevData.Close();

            StreamWriter newData = new StreamWriter(file);
            newData.WriteLine((prevDataList.Count() > 0 ? prevDataList[0] : "") + "string" + ";");
            newData.WriteLine((prevDataList.Count() > 1 ? prevDataList[1] : "") + sortableList.Count().ToString() + ";");
            try
            {
                long O; int j = 2;
                List<string> listToSort = new List<string>(sortableList);
                
                    Console.WriteLine("InsertionSort:");
                    List<string> inserted = StringSorts.InsertionSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                    listToSort = new List<string>(sortableList);
                    Console.WriteLine("BubbleSort:");
                    List<string> bubbled = StringSorts.BubbleSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                    listToSort = new List<string>(sortableList);
                    Console.WriteLine("ShakerSort:");
                    List<string> shaken = StringSorts.ShakerSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                    listToSort = new List<string>(sortableList);
                    Console.WriteLine("OddEvenSort:");
                    List<string> evened = StringSorts.OddEvenSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                    listToSort = new List<string>(sortableList);
                    Console.WriteLine("CombSort:");
                    List<string> combed = StringSorts.CombSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                    listToSort = new List<string>(sortableList);
                    Console.WriteLine("SelectionSort:");
                    List<string> selected = StringSorts.SelectionSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");


                    //listToSort = new List<string>(sortableList);
                    //Console.WriteLine("CountSort:");
                    //List<string> counted = StringSorts.CountSort(listToSort, out O);
                    //Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
                    newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + "-;"); 

                    listToSort = new List<string>(sortableList);
                    Console.WriteLine("ShellSort:");
                    List<string> shelled = StringSorts.ShellSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                    listToSort = new List<string>(sortableList);
                    Console.WriteLine("QuickSort:");
                    List<string> quickQuack = StringSorts.QuickSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                    listToSort = new List<string>(sortableList);
                    Console.WriteLine("MergeSort:");
                    List<string> merged = StringSorts.MergeSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                    listToSort = new List<string>(sortableList);
                    Console.WriteLine("HeapSort:");
                    List<string> heaped = StringSorts.HeapSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                    //listToSort = new List<string>(sortableList);
                    //Console.WriteLine("RadixSort:");
                    //List<string> radixed = StringSorts.RadixSort(listToSort, out O);
                    //Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
                    newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + "-;");


                    //listToSort = new List<string>(sortableList);
                    //Console.WriteLine("BucketSort:");
                    //List<string> bucketed = StringSorts.BucketSort(listToSort, out O);
                    //Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
                    newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + "-;");

                    listToSort = new List<string>(sortableList);
                    Console.WriteLine("IntroSort:");
                    List<string> introed = StringSorts.IntroSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<string>(sortableList);
                Console.WriteLine("TimSort:");
                List<string> timmed = StringSorts.TimSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            newData.Close(); 
        }

        public static void StartDateSortingAlgorithmsTestcase(List<DateTime> sortableList)
        {
            long O;
            List<DateTime> listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("InsertionSort:");
            List<DateTime> inserted = DateSorts.InsertionSort(listToSort, out O);
            inserted.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("BubbleSort:");
            List<DateTime> bubbled = DateSorts.BubbleSort(listToSort, out O);
            bubbled.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("ShakerSort:");
            List<DateTime> shaken = DateSorts.ShakerSort(listToSort, out O);
            shaken.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("OddEvenSort:");
            List<DateTime> evened = DateSorts.OddEvenSort(listToSort, out O);
            evened.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("CombSort:");
            List<DateTime> combed = DateSorts.CombSort(listToSort, out O);
            combed.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("SelectionSort:");
            List<DateTime> selected = DateSorts.SelectionSort(listToSort, out O);
            selected.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            if (!sortableList.Any(t =>
                        (t.ToUniversalTime() - new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds > Int32.MaxValue))
            {
                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("CountSort:");
                List<DateTime> counted = DateSorts.CountSort(listToSort, out O);
                counted.ForEach(x => Console.WriteLine(x));
                Console.WriteLine(O + "!");
            }
            else
            {
                Console.WriteLine("Counting Sort is not applicable, cause " +
                    "one of the dates' seconds value exceeds the maximum size for an array");
            }

            listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("ShellSort:");
            List<DateTime> shelled = DateSorts.ShellSort(listToSort, out O);
            shelled.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("QuickSort:");
            List<DateTime> quickQuack = DateSorts.QuickSort(listToSort, out O);
            quickQuack.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("MergeSort:");
            List<DateTime> merged = DateSorts.MergeSort(listToSort, out O);
            merged.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("HeapSort:");
            List<DateTime> heaped = DateSorts.HeapSort(listToSort, out O);
            heaped.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            if (!sortableList.Any(t =>
                        (t.ToUniversalTime() - new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds > Int32.MaxValue))
            {
                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("RadixSort:");
                List<DateTime> radixed = DateSorts.RadixSort(listToSort, out O);
                radixed.ForEach(x => Console.WriteLine(x));
                Console.WriteLine(O + "!");
            }
            else
            {
                Console.WriteLine("Radix Sort is not applicable, cause " +
                    "one of the dates' seconds value exceeds the maximum size for an array");
            }

            if (!sortableList.Any(t =>
                       (t.ToUniversalTime() - new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds > Int32.MaxValue))
            {
                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("BucketSort:");
                List<DateTime> bucketed = DateSorts.BucketSort(listToSort, out O);
                bucketed.ForEach(x => Console.WriteLine(x));
                Console.WriteLine(O + "!");
            }
            else
            {
                Console.WriteLine("Bucket Sort is not applicable, cause " +
                    "one of the dates' seconds value exceeds the maximum size for an array");
            }


            listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("IntroSort:");
            List<DateTime> introed = DateSorts.IntroSort(listToSort, out O);
            introed.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");

            listToSort = new List<DateTime>(sortableList);
            Console.WriteLine("TimSort:");
            List<DateTime> timmed = DateSorts.TimSort(listToSort, out O);
            timmed.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(O + "!");
        }
        public static void StartDateSortingAlgorithmsComplexityTestcase(List<DateTime> sortableList, string file)
        {
            StreamReader prevData = new StreamReader(file);
            List<string> prevDataList = new List<string>();
            while (prevData.Peek() != -1) prevDataList.Add(prevData.ReadLine());
            prevData.Close();

            StreamWriter newData = new StreamWriter(file);
            newData.WriteLine((prevDataList.Count() > 0 ? prevDataList[0] : "") + "date" + ";");
            newData.WriteLine((prevDataList.Count() > 1 ? prevDataList[1] : "") + sortableList.Count().ToString() + ";");
            try
            {
                long O; int j = 2;
                List<DateTime> listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("InsertionSort:");
                List<DateTime> inserted = DateSorts.InsertionSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("BubbleSort:");
                List<DateTime> bubbled = DateSorts.BubbleSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("ShakerSort:");
                List<DateTime> shaken = DateSorts.ShakerSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("OddEvenSort:");
                List<DateTime> evened = DateSorts.OddEvenSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("CombSort:");
                List<DateTime> combed = DateSorts.CombSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("SelectionSort:");
                List<DateTime> selected = DateSorts.SelectionSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
                
                if (!sortableList.Any(t =>
                            (t.ToUniversalTime() - new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds > Int32.MaxValue))
                {
                    listToSort = new List<DateTime>(sortableList);
                    Console.WriteLine("CountSort:");
                    List<DateTime> counted = DateSorts.CountSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
                }
                else
                {
                    Console.WriteLine("Counting Sort is not applicable, cause " +
                        "one of the dates' seconds value exceeds the maximum size for an array");
                    newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + "-;");
                }

                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("ShellSort:");
                List<DateTime> shelled = DateSorts.ShellSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("QuickSort:");
                List<DateTime> quickQuack = DateSorts.QuickSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("MergeSort:");
                List<DateTime> merged = DateSorts.MergeSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("HeapSort:");
                List<DateTime> heaped = DateSorts.HeapSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                if (!sortableList.Any(t =>
                            (t.ToUniversalTime() - new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds > Int32.MaxValue))
                {
                    listToSort = new List<DateTime>(sortableList);
                    Console.WriteLine("RadixSort:");
                    List<DateTime> radixed = DateSorts.RadixSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
                }
                else
                {
                    Console.WriteLine("Radix Sort is not applicable, cause " +
                        "one of the dates' seconds value exceeds the maximum size for an array");
                    newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + "-;");
                }

                if (!sortableList.Any(t =>
                           (t.ToUniversalTime() - new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds > Int32.MaxValue))
                {
                    listToSort = new List<DateTime>(sortableList);
                    Console.WriteLine("BucketSort:");
                    List<DateTime> bucketed = DateSorts.BucketSort(listToSort, out O);
                    Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
                }
                else
                {
                    Console.WriteLine("Bucket Sort is not applicable, cause " +
                        "one of the dates' seconds value exceeds the maximum size for an array");
                    newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + "-;");
                }


                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("IntroSort:");
                List<DateTime> introed = DateSorts.IntroSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");

                listToSort = new List<DateTime>(sortableList);
                Console.WriteLine("TimSort:");
                List<DateTime> timmed = DateSorts.TimSort(listToSort, out O);
                Console.WriteLine(O + "!"); newData.WriteLine((j < prevDataList.Count() ? prevDataList[j++] : "") + O + ";");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            newData.Close(); 

            }
    }
}
