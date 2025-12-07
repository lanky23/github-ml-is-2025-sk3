string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** Reverze pole ************");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 7.12.2025 *******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();


     Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet znovu: ");
    }

    Console.Write("Zadejte počet dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte počet horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("==========================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("==========================================================");
    Console.WriteLine();

    //deklarace pole - abychom měli čísla kam ukládat
    int[] myRandNumbs = new int[n];

    //příprava pro generování náhodných čísel
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(10);

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");

    for(int i=0; i < n ;i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0}; ",myRandNumbs[i]);
    }
    
    // reverze pole
    for(int i=0; i < n /2;i++) {
        int tmp = myRandNumbs[i];
        myRandNumbs[i] = myRandNumbs[n - i - 1];
        myRandNumbs[n - i - 1] = tmp;
    }

    Console.WriteLine();
    Console.WriteLine("=======================================================");
    Console.WriteLine("Pole po reverzi: ");
    for(int i=0; i < n ;i++)
    {
        Console.Write("{0}; ",myRandNumbs[i]);
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}