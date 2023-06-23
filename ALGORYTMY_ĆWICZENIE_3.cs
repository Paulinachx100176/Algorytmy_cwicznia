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

        SortowanieBabelkowe(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WyswietlTablice(tablica);

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }

    static void SortowanieBabelkowe(int[] tablica)
    {
        for (int i = 0; i < tablica.Length - 1; i++)
        {
            for (int j = 0; j < tablica.Length - i - 1; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    int temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;
                }
            }
        }
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
