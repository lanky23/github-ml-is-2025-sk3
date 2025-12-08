string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** intervaly  ************");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 5.11.2025 *******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();


    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
    }

    Console.Write("Zadejte počet intervalů: ");
    int intervalCount;
    while (!int.TryParse(Console.ReadLine(), out intervalCount) || intervalCount <= 0)
    {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte počet intervalů znovu: ");
    }

    int dm = lowerBound;
    int hm = upperBound;

    Console.WriteLine("\n\n==========================================");
    Console.WriteLine("Uživatelský vstup: ");
    Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("==============================================");

    //deklarace pole 

       int[] myArray = new int[n];
       Random randomNumber = new Random();

    // pole pro počítání intervalů
    int[] intervalCounts = new int[intervalCount];
    double intervalSize = (hm - dm + 1) / (double)intervalCount;


    Console.WriteLine("\n\nNáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myArray[i] = randomNumber.Next(dm, hm + 1);
        Console.Write(myArray[i] + "; ");

        // výpočet do kterého intervalu číslo spadá
        int index = (int)((myArray[i] - dm) / intervalSize);
        if (index == intervalCount) index--; // oprava při horní mezi

        intervalCounts[index]++;
    }


        Console.WriteLine("\n\nVýsledné intervaly:");
    for (int i = 0; i < intervalCount; i++)
    {
        int start = dm + (int)(i * intervalSize);
        int end = dm + (int)((i + 1) * intervalSize) - 1;

        if (i == intervalCount - 1) end = hm;

        Console.WriteLine($"Interval <{start}; {end}>: {intervalCounts[i]}");
    }











    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}