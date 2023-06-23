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

        SortowaniePrzezWstawianie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WyswietlTablice(tablica);

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }

    static void SortowaniePrzezWstawianie(int[] tablica)
    {
        for (int i = 1; i < tablica.Length; i++)
        {
            int klucz = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }

            tablica[j + 1] = klucz;
        }
    }

    static void WyswietlTablice(int[] tablica)
    {
        foreach (int element in tablica)
            Console.Write(element + " ");

        Console.WriteLine();
    }
}
