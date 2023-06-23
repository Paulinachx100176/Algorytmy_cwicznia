using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int rozmiar = int.Parse(Console.ReadLine());

        int[] tablica = new int[rozmiar];

        Console.WriteLine("Wprowadź elementy tablicy:");

        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write($"Element {i}: ");
            tablica[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Tablica przed sortowaniem:");
        WyswietlTablice(tablica);

        for (int i = 0; i < tablica.Length - 1; i++)
        {
            int indeksMinimum = i;

            for (int j = i + 1; j < tablica.Length; j++)
            {
                if (tablica[j] < tablica[indeksMinimum])
                {
                    int temp = tablica[j];
                    tablica[j] = tablica[indeksMinimum];
                    tablica[indeksMinimum] = temp;
                }
            }
        }

        Console.WriteLine("Tablica po sortowaniu:");
        WyswietlTablice(tablica);

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }

    static void WyswietlTablice(int[] tablica)
    {
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }
}
