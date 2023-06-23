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

        int najmniejszy = tablica[0];
        int najwiekszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
            {
                najmniejszy = tablica[i];
            }

            if (tablica[i] > najwiekszy)
            {
                najwiekszy = tablica[i];
            }
        }

        Console.WriteLine($"Najmniejszy element: {najmniejszy}");
        Console.WriteLine($"Największy element: {najwiekszy}");

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}
