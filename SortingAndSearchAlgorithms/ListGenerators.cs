using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearchAlgorithmsVasyliev
{
    public class ListGenerators
    {
        //Random items lists
        public static List<double> RandomDigitsList(int size)
        {
            List<double> randomDigitsList = new List<double>();
            Random r = new Random();
            for (int i = 0; i < size; i++) randomDigitsList.Add(r.Next(0, 10));
            return randomDigitsList;
        }
        public static List<double> RandomDoublesList(int size, double min, double max)
        {
            List<double> randomDoublesList = new List<double>();
            Random r = new Random();
            for (int i = 0; i < size; i++) randomDoublesList.Add(r.NextDouble() * (max - min) + min);
            return randomDoublesList;
        }
        public static List<string> RandomStringsList(int size, int minLength, int maxLength)
        {
            List<string> randomStringsList = new List<string>();
            Random r = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for (int i = 0; i < size; i++)
                randomStringsList.Add(new string(Enumerable.Repeat(chars, r.Next(minLength, maxLength)).Select(s => s[r.Next(s.Length)]).ToArray()));
            return randomStringsList;
        }
        public static List<DateTime> RandomDatesList(int size)
        {
            List<DateTime> randomDatesList = new List<DateTime>();
            Random r = new Random(); TimeSpan ts;
            int i = 0;
            while (i < size)
            {
                ts = TimeSpan.FromSeconds(r.NextInt64(0, 315537897600));
                randomDatesList.Add(new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc) + ts);
                i++;
            }
            return randomDatesList;
        }

        //Sorted lists with random insertions
        public static List<double> InsertedDigitsSortedList(int size, int insertedItemsNumber)
        {
            if (insertedItemsNumber > size) throw new Exception("Don't chew on what you cannot swall");
            long O = 0; int pos;
            List<double> sortedList = Sorts.IntroSort(RandomDigitsList(size), out O);
            List<int> insertedPositions = new List<int>(); Random r = new Random();
            int i = 0;
            while (i < insertedItemsNumber)
            {
                pos = r.Next(0, size);
                if (!insertedPositions.Contains(pos)) sortedList.Insert(pos, r.Next(0, 10));
                else i--;
                i++;
            }
            return sortedList;
        }
        public static List<double> InsertedNumbersSortedList(int size, int insertedItemsNumber, double min, double max)
        {
            if (insertedItemsNumber > size) throw new Exception("Don't chew on what you cannot swall");
            long O = 0; int pos;
            List<double> sortedList = Sorts.IntroSort(RandomDoublesList(size, min, max), out O);
            List<int> insertedPositions = new List<int>(); Random r = new Random();
            int i = 0;
            while (i < insertedItemsNumber)
            {
                pos = r.Next(0, size);
                if (!insertedPositions.Contains(pos)) sortedList.Insert(pos, r.NextDouble() * (max - min) + min);
                else i--;
                i++;
            }
            return sortedList;
        }
        public static List<string> InsertedStringsSortedList(int size, int insertedItemsNumber, int minLength, int maxLength)
        {
            if (insertedItemsNumber > size) throw new Exception("Don't chew on what you cannot swall");
            long O = 0; int pos;
            List<string> sortedList = StringSorts.IntroSort(RandomStringsList(size, minLength, maxLength), out O);
            List<int> insertedPositions = new List<int>(); Random r = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int i = 0;
            while (i < insertedItemsNumber)
            {
                pos = r.Next(0, size);
                if (!insertedPositions.Contains(pos)) sortedList.Insert(pos,
                    new string(Enumerable.Repeat(chars, r.Next(minLength, maxLength)).Select(s => s[r.Next(s.Length)]).ToArray()));
                else i--;
                i++;
            }
            return sortedList;
        }
        public static List<DateTime> InsertedDatesSortedList(int size, int insertedItemsNumber)
        {
            if (insertedItemsNumber > size) throw new Exception("Don't chew on what you cannot swall");
            long O = 0; int pos;
            List<DateTime> sortedList = DateSorts.IntroSort(RandomDatesList(size), out O);
            List<int> insertedPositions = new List<int>(); Random r = new Random(); TimeSpan ts;
            int i = 0;
            while (i < insertedItemsNumber)
            {
                pos = r.Next(0, size);
                ts = TimeSpan.FromSeconds(r.NextInt64(0, 315537897600));
                if (!insertedPositions.Contains(pos)) sortedList.Insert(pos,
                        new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc) + ts);
                else i--;
                i++;
            }
            return sortedList;
        }

        //Partially shuffled lists
        private static List<T> Shuffle<T>(List<T> listToShuffle, int numberOfShuffledParts, int shuffledPartLength) 
        {
            Random r = new Random();
            int n, startShufflePos, k;
            for (int i = 0; i < numberOfShuffledParts; i++)
            {
                startShufflePos = r.Next(0, listToShuffle.Count() - shuffledPartLength);
                n = startShufflePos + shuffledPartLength;
                while (n > startShufflePos)
                {
                    n--;
                    k = r.Next(startShufflePos, startShufflePos + shuffledPartLength);
                    (listToShuffle[n], listToShuffle[k]) = (listToShuffle[k], listToShuffle[n]);
                }
            }
            return listToShuffle;
        }
        public static List<double> PartiallyShuffledDigitsList(int size, int numberOfShuffledParts, int shuffledPartLength)
        {
            long O;
            if (numberOfShuffledParts * shuffledPartLength > size) throw new Exception("Number of elements to be shuffled exceeds that of an array's content");
            return Shuffle(Sorts.IntroSort(RandomDigitsList(size), out O), numberOfShuffledParts, shuffledPartLength); 
        }
        public static List<double> PartiallyShuffledDoublesList(int size, double min, double max, int numberOfShuffledParts, int shuffledPartLength)
        {
            long O;
            if (numberOfShuffledParts * shuffledPartLength > size) throw new Exception("Number of elements to be shuffled exceeds that of an array's content");
            return Shuffle(Sorts.IntroSort(RandomDoublesList(size, min, max), out O), numberOfShuffledParts, shuffledPartLength);
        }
        public static List<string> PartiallyShuffledStringsList(int size, int minStringLength, int maxStringLength, int numberOfShuffledParts, int shuffledPartLength)
        {
            long O;
            if (numberOfShuffledParts * shuffledPartLength > size) throw new Exception("Number of elements to be shuffled exceeds that of an array's content");
            return Shuffle(StringSorts.IntroSort(RandomStringsList(size, minStringLength, maxStringLength), out O), numberOfShuffledParts, shuffledPartLength);
        }
        public static List<DateTime> PartiallyShuffledDatesList(int size, int numberOfShuffledParts, int shuffledPartLength)
        {
            long O;
            if (numberOfShuffledParts * shuffledPartLength > size) throw new Exception("Number of elements to be shuffled exceeds that of an array's content");
            return Shuffle(DateSorts.IntroSort(RandomDatesList(size), out O), numberOfShuffledParts, shuffledPartLength); 
        }

        //Sorted lists with unsorted tail
        private static List<T> Entail<T>(List<T> listToEntail, List<T> tailList, bool isTailLeft, int tailLength)
        {
            if (isTailLeft) { tailList.AddRange(listToEntail); return tailList; }
            listToEntail.AddRange(tailList);
            return listToEntail;
        }
        public static List<double> UnsortedTailDigitsList(int size, bool isTailLeft, int tailLength)
        {
            long O;
            return Entail(Sorts.IntroSort(RandomDigitsList(size - tailLength), out O), RandomDigitsList(tailLength), isTailLeft, tailLength);
        }
        public static List<double> UnsortedTailDoublesList(int size, double min, double max, bool isTailLeft, int tailLength)
        {
            long O;
            return Entail(Sorts.IntroSort(RandomDoublesList(size - tailLength, min, max), out O), RandomDoublesList(tailLength, min, max), isTailLeft, tailLength);
        }
        public static List<string> UnsortedTailStringsList(int size, int minLength, int maxLength, bool isTailLeft, int tailLength)
        {
            long O;
            return Entail(StringSorts.IntroSort(RandomStringsList(size - tailLength, minLength, maxLength), out O), RandomStringsList(tailLength, minLength, maxLength), isTailLeft, tailLength);
        }
        public static List<DateTime> UnsortedTailDatesList(int size, bool isTailLeft, int tailLength)
        {
            long O;
            return Entail(DateSorts.IntroSort(RandomDatesList(size - tailLength), out O), RandomDatesList(tailLength), isTailLeft, tailLength);
        }

        //Thimbled lists
        private static List<T> Thimble<T>(List<T> listToThimble, int numberOfThimbles)
        {
            int partSize = listToThimble.Count() / numberOfThimbles;
            List<List<T>> thimbleRig = new List<List<T>>();
            for (int i = 0; i < numberOfThimbles - 1; i++) thimbleRig.Add(listToThimble.GetRange(i * partSize, partSize));
            thimbleRig.Add(listToThimble.GetRange((numberOfThimbles - 1) * partSize, listToThimble.Count() - (numberOfThimbles - 1) * partSize));
            thimbleRig = Shuffle(thimbleRig, 1, numberOfThimbles);
            listToThimble.Clear();
            thimbleRig.ForEach(t => listToThimble.AddRange(t));
            return listToThimble;
        }
        public static List<double> ThimbledDigitsList(int size, int numberOfThimbles) {
            long O; return Thimble(Sorts.IntroSort(RandomDigitsList(size), out O), numberOfThimbles);
        }
        public static List<double> ThimbledDoublesList(int size, double min, double max, int numberOfThimbles)
        {
            long O; return Thimble(Sorts.IntroSort(RandomDoublesList(size, min, max), out O), numberOfThimbles);
        }
        public static List<string> ThimbledStringsList(int size, int minLength, int maxLength, int numberOfThimbles)
        {
            long O; return Thimble(StringSorts.IntroSort(RandomStringsList(size, minLength, maxLength), out O), numberOfThimbles);
        }
        public static List<DateTime> ThimbledDatesList(int size, int numberOfThimbles)
        {
            long O; return Thimble(DateSorts.IntroSort(RandomDatesList(size), out O), numberOfThimbles);
        }


        //Lists with many copies of a few elements
        private static List<T> CopyPaste<T>(List<T> clusterBasis, int size)
        {
            List<T> randomDigitsList = new List<T>();
            int clusterSize = size / clusterBasis.Count();
            for (int i = 0; i < clusterBasis.Count() - 1; i++)
                for (int j = 0; j < size / clusterBasis.Count(); j++)
                    randomDigitsList.Add(clusterBasis[i]);
            for (int i = (clusterBasis.Count() - 1)*clusterSize; i < size; i++) randomDigitsList.Add(clusterBasis[clusterBasis.Count() - 1]);
            return randomDigitsList;
        }
        public static List<double> CopyPasteDigitsList(int size, int clustersNumber) => CopyPaste(RandomDigitsList(clustersNumber), size);
        public static List<double> CopyPasteDoublesList(int size, double min, double max, int clustersNumber) => CopyPaste(RandomDoublesList(clustersNumber, min, max), size);
        public static List<string> CopyPasteStringsList(int size, int minLength, int maxLength, int clustersNumber) => CopyPaste(RandomStringsList(clustersNumber, minLength, maxLength), size);
        public static List<DateTime> CopyPasteDatesList(int size, int clustersNumber) => CopyPaste(RandomDatesList(clustersNumber), size);
    }
}
