/*
 * Algoritmo di ordinamento rapido ( Quick Sort Algorithm)
 * L'ordinamento rapido è un algoritmo di ordinamento popolare che è spesso più veloce nella pratica rispetto ad altri algortimi
 * di ordinamento. Utilizza una strategia di divisione e conquista per ordinare rapidamente gli elementi di dati dividendo un array
 * di grandi dimensioni in due array più piccoli
 */


class TestQuickSort
{
    public static void Main(String[] args)
    {
        int[] scores = { 90, 60, 50, 80, 70, 100 };
        QuickSort(scores);

        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write(scores[i] + ",");
        }
    }
    public static void QuickSort(int[] array)
    {
        if (array.Length > 0)
        {
            QuickSort(array, 0, array.Length - 1);
        }
    }
    private static void QuickSort(int[] array, int low, int high)
    {
        if (low > high)
        {
            return;
        }
        int i = low;
        int j = high;
        int threshold = array[low];  // Scansionato alternativamente da entrambe le estremità dell'elenco

        while (i < j)
        {
            // Trova la prima posizione inferiore alla soglia da destra a sinistra

            while (i < j && array[j] > threshold)
            {
                j--;

            }  // Sostituisci low con un numero più piccolo di threshold

            if (i < j) array[i++] = array[j];

            // Trova la prima posizione maggiore della soglia da sinistra a destra

            while (i < j && array[i] <= threshold)
            {
                i++;
            }  // Sostituisci high con un numero maggiore di threshold
            if (i < j)

                array[j--] = array[i];
        }

        array[i] = threshold;

        QuickSort(array, low, i - 1);

        // Ordinamento rapido ricorsivo a sinistra

        QuickSort(array, i + 1, high); // Ordinamento rapido ricorsivo a destra
    }
}

