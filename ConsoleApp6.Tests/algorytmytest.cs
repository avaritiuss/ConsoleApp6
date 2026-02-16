using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp6;

namespace ConsoleApp6.Tests
{
    [TestClass]
    public class algorytmytest
    {
        // nieposortowana
        [TestMethod]
        public void Test_Nieposortowana()
        {
            int[] tablica = { 5, 2, 8, 1, 9 };
            int[] oczekiwana = { 1, 2, 5, 8, 9 };

            int[] wynikInsert = Algorytmy.InsertionSort(tablica);
            CollectionAssert.AreEqual(oczekiwana, wynikInsert);

            int[] kopia = (int[])tablica.Clone();
            Algorytmy.BubbleSort(kopia);
            CollectionAssert.AreEqual(oczekiwana, kopia);
        }

        // posortowaa
        [TestMethod]
        public void Test_Posortowana()
        {
            int[] tablica = { 1, 2, 3, 4, 5 };
            int[] oczekiwana = { 1, 2, 3, 4, 5 };

            int[] wynikInsert = Algorytmy.InsertionSort(tablica);
            CollectionAssert.AreEqual(oczekiwana, wynikInsert);

            int[] kopia = (int[])tablica.Clone();
            Algorytmy.BubbleSort(kopia);
            CollectionAssert.AreEqual(oczekiwana, kopia);
        }

        // odwrotnie posortowana
        [TestMethod]
        public void Test_OdwrotniePosortowana()
        {
            int[] tablica = { 5, 4, 3, 2, 1 };
            int[] oczekiwana = { 1, 2, 3, 4, 5 };

            int[] wynikInsert = Algorytmy.InsertionSort(tablica);
            CollectionAssert.AreEqual(oczekiwana, wynikInsert);

            int[] kopia = (int[])tablica.Clone();
            Algorytmy.BubbleSort(kopia);
            CollectionAssert.AreEqual(oczekiwana, kopia);
        }

        // pusta
        [TestMethod]
        public void Test_Pusta()
        {
            int[] tablica = { };
            int[] oczekiwana = { };

            int[] wynikInsert = Algorytmy.InsertionSort(tablica);
            CollectionAssert.AreEqual(oczekiwana, wynikInsert);

            int[] kopia = (int[])tablica.Clone();
            Algorytmy.BubbleSort(kopia);
            CollectionAssert.AreEqual(oczekiwana, kopia);
        }

        // jednoelementowa
        [TestMethod]
        public void Test_JedenElement()
        {
            int[] tablica = { 42 };
            int[] oczekiwana = { 42 };

            int[] wynikInsert = Algorytmy.InsertionSort(tablica);
            CollectionAssert.AreEqual(oczekiwana, wynikInsert);

            int[] kopia = (int[])tablica.Clone();
            Algorytmy.BubbleSort(kopia);
            CollectionAssert.AreEqual(oczekiwana, kopia);
        }

        // duplikaty
        [TestMethod]
        public void Test_Duplikaty()
        {
            int[] tablica = { 3, 1, 3, 2, 1 };
            int[] oczekiwana = { 1, 1, 2, 3, 3 };

            int[] wynikInsert = Algorytmy.InsertionSort(tablica);
            CollectionAssert.AreEqual(oczekiwana, wynikInsert);

            int[] kopia = (int[])tablica.Clone();
            Algorytmy.BubbleSort(kopia);
            CollectionAssert.AreEqual(oczekiwana, kopia);
        }

        // identyczne ele
        [TestMethod]
        public void Test_Identyczne()
        {
            int[] tablica = { 7, 7, 7, 7 };
            int[] oczekiwana = { 7, 7, 7, 7 };

            int[] wynikInsert = Algorytmy.InsertionSort(tablica);
            CollectionAssert.AreEqual(oczekiwana, wynikInsert);

            int[] kopia = (int[])tablica.Clone();
            Algorytmy.BubbleSort(kopia);
            CollectionAssert.AreEqual(oczekiwana, kopia);
        }

        // -liczby
        [TestMethod]
        public void Test_Ujemne()
        {
            int[] tablica = { -5, -1, -10, 0, 5 };
            int[] oczekiwana = { -10, -5, -1, 0, 5 };

            int[] wynikInsert = Algorytmy.InsertionSort(tablica);
            CollectionAssert.AreEqual(oczekiwana, wynikInsert);

            int[] kopia = (int[])tablica.Clone();
            Algorytmy.BubbleSort(kopia);
            CollectionAssert.AreEqual(oczekiwana, kopia);
        }

        // duuuuuuuza tablica
        [TestMethod]
        public void Test_DuzaTablica()
        {
            // tablica 1000 elementow
            int[] tablica = new int[1000];
            int[] oczekiwana = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                tablica[i] = 1000 - i;
                oczekiwana[i] = i + 1;
            }

            int[] wynikInsert = Algorytmy.InsertionSort(tablica);
            CollectionAssert.AreEqual(oczekiwana, wynikInsert);

            int[] kopia = (int[])tablica.Clone();
            Algorytmy.BubbleSort(kopia);
            CollectionAssert.AreEqual(oczekiwana, kopia);
        }

        // double polimorfizm
        [TestMethod]
        public void Test_Double_Podstawowy()
        {
            double[] tablica = { 5.5, 2.2, 8.8 };
            double[] oczekiwana = { 2.2, 5.5, 8.8 };

            double[] wynikInsert = Algorytmy.InsertionSort(tablica);
            CollectionAssert.AreEqual(oczekiwana, wynikInsert);

            double[] kopia = (double[])tablica.Clone();
            Algorytmy.BubbleSort(kopia);
            CollectionAssert.AreEqual(oczekiwana, kopia);
        }
    }
}
