string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** generator pseudonáhodných čísel************");
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

    Console.WriteLine("\n\n==========================================");
    Console.WriteLine("Uživatelský vstup: ");
    Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("==============================================");

    //deklarace pole 

    int[] myRandNumbers = new int[n];

    //příprava pro generování náhodných čísel 

    Random myRandNumb = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i = 0; i < n; i++) {
                myRandNumbers[i] = myRandNumb.Next(lowerBound, upperBound + 1);
                Console.Write("{0}; ", myRandNumbers[i]);
            }












    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}