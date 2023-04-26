﻿
/* 2. Сравнить их между собой на различных входных данных:\\
    3. Наглядно представить полученные результаты и сделать выводы 
    (соответствие теоретическим оценкам, в каких ситуациях какую сортировку использовать и т.д.).
*/
/*
 Дополнительные (необязательные) задания:\\
            4*. Построить нерекурсивные реализации рекурсивных методов сортировки и сравнить с исходными
            (проверить, работает ли рекурсия медленнее). Как быть с переполнением стека? Как выполнять сортировку больших массивов?\\
            5*. На основе полученных результатов сформулировать и реализовать собственную гибридную сортировку, 
                использующую преимущества разных методов в зависимости от входных данных.\\
            * В каких случаях оправданно использование поразрядной сортировки?\\
            ** В каких случаях можно обогнать встроенную в язык сортировку?\\
            *** В каких случаях имеет смысл использовать простые методы сортировки?\\
            **** Какая сортировка лучше, если не знаем ничего про входные данные?\\
 */

using SortingAndSearchAlgorithmsVasyliev;
string d = Directory.GetParent(
              Directory.GetParent(
                Directory.GetParent(
                    Directory.GetCurrentDirectory()).ToString()).ToString()).ToString();
void StartRandomArraysSorting(int e)
{

    Console.WriteLine("1) RANDOM ARRAYS SORTING:");
    Console.WriteLine("SORTING RANDOM ARRAYS OF DIGITS");
    TestcaseStarters.StartDigitsSortingAlgorithmsComplexityTestcase(ListGenerators.RandomDigitsList((int)Math.Pow(10, e)/2),
                                                                d + "/SortingsData/RandomSortingsData.csv");
    Console.WriteLine("SORTING RANDOM ARRAYS OF NUMBERS FROM -1000 TO 1000");
    TestcaseStarters.StartSortingAlgorithmsComplexityTestcase(ListGenerators.RandomDoublesList((int)Math.Pow(10, e)/2, -1000, 1000),
                                                                d + "/SortingsData/RandomSortingsData.csv");
    Console.WriteLine("SORTING RANDOM STRING ARRAYS BY THE LENGTH OF A RANGE [2, 100)");
    TestcaseStarters.StartStringSortingAlgorithmsComplexityTestcase(ListGenerators.RandomStringsList((int)Math.Pow(10, e)/2, 2, 100),
                                                                    d + "/SortingsData/RandomSortingsData.csv");
    Console.WriteLine("SORTING RANDOM DATETIME STRUCT ARRAYS");
    TestcaseStarters.StartDateSortingAlgorithmsComplexityTestcase(ListGenerators.RandomDatesList((int)Math.Pow(10, e)/2),
                                                                    d + "/SortingsData/RandomSortingsData.csv");
}
void StartInsertedArraysSorting(int e)
{
    Console.WriteLine("2a) ARRAYS WITH INSERTIONS SORTING:");
    Console.WriteLine("SORTING INSERTED ARRAYS OF DIGITS");
    TestcaseStarters.StartDigitsSortingAlgorithmsComplexityTestcase(ListGenerators.InsertedDigitsSortedList((int)Math.Pow(10, e)/2 - (int)Math.Pow(10, e - 1)/2,
                                                                        (int)Math.Pow(10, e - 1)/2), d + "/SortingsData/InsertedItemSortingsData.csv");
    Console.WriteLine("SORTING INSERTED ARRAYS OF NUMBERS FROM -1000 TO 1000");
    TestcaseStarters.StartSortingAlgorithmsComplexityTestcase(ListGenerators.InsertedNumbersSortedList((int)Math.Pow(10, e)/2 - (int)Math.Pow(10, e - 1)/2,
                                                                        (int)Math.Pow(10, e - 1)/2, -1000, 1000), d + "/SortingsData/InsertedItemSortingsData.csv");
    Console.WriteLine("SORTING INSERTED STRING ARRAYS BY THE LENGTH OF A RANGE [2, 100)");
    TestcaseStarters.StartStringSortingAlgorithmsComplexityTestcase(ListGenerators.InsertedStringsSortedList((int)Math.Pow(10, e)/2 - (int)Math.Pow(10, e - 1)/2,
                                                                        (int)Math.Pow(10, e - 1)/2, 2, 100), d + "/SortingsData/InsertedItemSortingsData.csv");
    Console.WriteLine("SORTING INSERTED DATETIME STRUCT ARRAYS");
    TestcaseStarters.StartDateSortingAlgorithmsComplexityTestcase(ListGenerators.InsertedDatesSortedList((int)Math.Pow(10, e)/2 - (int)Math.Pow(10, e - 1)/2,
                                                                        (int)Math.Pow(10, e - 1)/2), d + "/SortingsData/InsertedItemSortingsData.csv");
}
void StartPartiallyShuffledArraysSorting(int e)
{
    Console.WriteLine("2b) SORTING PARTIALLY SHUFFLED SORTED ARRAYS:");
    Console.WriteLine("SORTING PARTIALLY SHUFFLED SORTED ARRAYS OF DIGITS");
    TestcaseStarters.StartDigitsSortingAlgorithmsComplexityTestcase(ListGenerators.PartiallyShuffledDigitsList((int)Math.Pow(10, e)/2, e, (int)Math.Pow(5, e)/2),
                                                                    d + "/SortingsData/PartialShuffleSortingsData.csv");
    Console.WriteLine("SORTING PARTIALLY SHUFFLED SORTED ARRAYS OF NUMBERS FROM -1000 TO 1000");
    TestcaseStarters.StartSortingAlgorithmsComplexityTestcase(ListGenerators.PartiallyShuffledDoublesList((int)Math.Pow(10, e)/2, -1000, 1000, e, (int)Math.Pow(5, e)/2),
                                                                    d + "/SortingsData/PartialShuffleSortingsData.csv");
    Console.WriteLine("SORTING PARTIALLY SHUFFLED SORTED STRING ARRAYS BY THE LENGTH OF A RANGE [2, 100)");
    TestcaseStarters.StartStringSortingAlgorithmsComplexityTestcase(ListGenerators.PartiallyShuffledStringsList((int)Math.Pow(10, e)/2, 2, 100, e, (int)Math.Pow(5, e)/2),
                                                                    d + "/SortingsData/PartialShuffleSortingsData.csv");
    Console.WriteLine("SORTING PARTIALLY SHUFFLED SORTED DATETIME STRUCT ARRAYS");
    TestcaseStarters.StartDateSortingAlgorithmsComplexityTestcase(ListGenerators.PartiallyShuffledDatesList((int)Math.Pow(10, e)/2, e, (int)Math.Pow(5, e)/2),
                                                                    d + "/SortingsData/PartialShuffleSortingsData.csv");
}



int e = 6, to = 7;
while (e < to) {
    Console.WriteLine("!!!TEST CASE NUMBER " + (e) + "!!!");
    Thread newThread = new Thread(x => { StartRandomArraysSorting(e); StartInsertedArraysSorting(e); StartPartiallyShuffledArraysSorting(e); e++; }, 536870912);
    newThread.Start(); newThread.Join();
    /*

    Console.WriteLine("2c)  :");
    Console.WriteLine("SORTING PARTIALLY SORTED ARRAYS OF DIGITS");
    TestcaseStarters.StartDigitsSortingAlgorithmsComplexityTestcase();
    Console.WriteLine("SORTING PARTIALLY SORTED ARRAYS OF NUMBERS FROM -1000 TO 1000");
    TestcaseStarters.StartSortingAlgorithmsComplexityTestcase();
    Console.WriteLine("SORTING PARTIALLY SORTED STRING ARRAYS BY THE LENGTH OF A RANGE [2, 100)");
    TestcaseStarters.StartStringSortingAlgorithmsComplexityTestcase();
    Console.WriteLine("SORTING PARTIALLY SORTED DATETIME STRUCT ARRAYS");
    TestcaseStarters.StartDateSortingAlgorithmsComplexityTestcase();

    Console.WriteLine("2d)  :");
    Console.WriteLine("SORTING PARTIALLY SORTED ARRAYS OF DIGITS");
    TestcaseStarters.StartDigitsSortingAlgorithmsComplexityTestcase();
    Console.WriteLine("SORTING PARTIALLY SORTED ARRAYS OF NUMBERS FROM -1000 TO 1000");
    TestcaseStarters.StartSortingAlgorithmsComplexityTestcase();
    Console.WriteLine("SORTING PARTIALLY SORTED STRING ARRAYS BY THE LENGTH OF A RANGE [2, 100)");
    TestcaseStarters.StartStringSortingAlgorithmsComplexityTestcase();
    Console.WriteLine("SORTING PARTIALLY SORTED DATETIME STRUCT ARRAYS");
    TestcaseStarters.StartDateSortingAlgorithmsComplexityTestcase();

    Console.WriteLine("3) MANY SAME ITEM ARRAYS SORTING:");
    Console.WriteLine("SORTING MANY SAME ITEM ARRAYS OF DIGITS");
    TestcaseStarters.StartDigitsSortingAlgorithmsComplexityTestcase();
    Console.WriteLine("SORTING MANY SAME ITEM ARRAYS OF NUMBERS FROM -1000 TO 1000");
    TestcaseStarters.StartSortingAlgorithmsComplexityTestcase();
    Console.WriteLine("SORTING MANY SAME ITEM STRING ARRAYS BY THE LENGTH OF A RANGE [2, 100)");
    TestcaseStarters.StartStringSortingAlgorithmsComplexityTestcase();
    Console.WriteLine("SORTING MANY SAME ITEM DATETIME STRUCT ARRAYS");
    TestcaseStarters.StartDateSortingAlgorithmsComplexityTestcase();*/
}