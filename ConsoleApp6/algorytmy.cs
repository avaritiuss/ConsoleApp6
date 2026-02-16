namespace ConsoleApp6
{
    public static class Algorytmy
    {
        // insert int
        public static int[] InsertionSort(int[] tablica)
        {
            int[] posortowana = new int[tablica.Length];
            
            for (int i = 0; i < tablica.Length; i++)
            {
                int element = tablica[i];
                int pozycja = i;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (posortowana[j] > element)
                    {
                        posortowana[j + 1] = posortowana[j];
                        pozycja = j;
                    }
                    else
                    {
                        break;
                    }
                }
                posortowana[pozycja] = element;
            }
            return posortowana;
        }

        // insert double
        public static double[] InsertionSort(double[] tablica)
        {
            double[] posortowana = new double[tablica.Length];

            for (int i = 0; i < tablica.Length; i++)
            {
                double element = tablica[i];
                int pozycja = i;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (posortowana[j] > element)
                    {
                        posortowana[j + 1] = posortowana[j];
                        pozycja = j;
                    }
                    else
                    {
                        break;
                    }
                }
                posortowana[pozycja] = element;
            }
            return posortowana;
        }

        // bubble int
        public static void BubbleSort(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        int tymczasowa = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tymczasowa;
                    }
                }
            }
        }

        // bubble double
        public static void BubbleSort(double[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        double tymczasowa = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tymczasowa;
                    }
                }
            }
        }
    }
}
