using System;
using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** insertion sort ************");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 20.11.2025 *******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n < 3)
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (min 3): ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
    }

    Console.WriteLine("\n\n==========================================");
    Console.WriteLine("Uživatelský vstup: ");
    Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("==============================================");

    // deklarace pole
    int[] myRandNumbers = new int[n];
    Random myRandNumb = new Random();

    Console.WriteLine("Náhodná čísla: ");

    for (int i = 0; i < n; i++)
    {
        myRandNumbers[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbers[i]);
    }

    int compare = 0; // počet porovnání
    int change = 0;  // počet posunů (změn)

    Stopwatch myStopwatch = new Stopwatch();

    //insertion sort              

    myStopwatch.Start();
    for (int i = 1; i < n; i++)
    {
        int key = myRandNumbers[i];
        int j = i - 1;

        while (j >= 0)
        {
            compare++;

            if (myRandNumbers[j] > key)
            {
                myRandNumbers[j + 1] = myRandNumbers[j];
                j--;
                change++;
            }
            else
            {
                break;
            }
        }
        myRandNumbers[j + 1] = key;
    }
    myStopwatch.Stop();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==========================================");
    Console.WriteLine("Seřazené pole pomocí insertion sort: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", myRandNumbers[i]);
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Počet porovnání: {compare}");
    Console.WriteLine($"Počet změn: {change}");
    Console.WriteLine($"Čas potřebný na seřazení čísel pomocí IS: {myStopwatch.Elapsed}");

    //stromeček
    

    int height = myRandNumbers[n - 3]; // třetí největší číslo
    int width = 0;

    for (int i = 0; i < n; i++)
        width += myRandNumbers[i];

    width = width / n; // průměr

    Console.WriteLine("\nSTROMEČEK:");

    // Větve
    for (int i = 1; i <= height; i++)
    {
        int stars = 1 + (i - 1) * 2;
        int spaces = width - i;

        if (spaces < 0) spaces = 0;

        for (int s = 0; s < spaces; s++)
            Console.Write(" ");

        for (int st = 0; st < stars; st++)
            Console.Write("*");

        Console.WriteLine();
    }

    // Kmen
    int trunkSpaces = width - 1;
    if (trunkSpaces < 0) trunkSpaces = 0;

    for (int s = 0; s < trunkSpaces; s++)
        Console.Write(" ");
    Console.WriteLine("*");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
