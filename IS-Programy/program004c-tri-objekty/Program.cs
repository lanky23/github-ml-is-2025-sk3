string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** vykreslení objektu************");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 5.11.2025 *******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();


    Console.WriteLine("Vyberte obrazec: ");
    Console.WriteLine("1 - diagonální Z");
    Console.WriteLine("2 - kosočtverec");
    Console.WriteLine("3 - přesýpací hodiny");
    Console.WriteLine("4 - konec programu");
    Console.Write("Vaše volba: ");
    int choice;
    while (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu číslo obrazce: ");

    }

    if (choice == 4)
    {
        Console.WriteLine("\nProgram bude ukončen...");
        break;
    }

    // Vstup HODNOTY DO PROGRAMU
    Console.Write("Zadejte velikost obrazce (celé číslo): ");
    int size;
    while (!int.TryParse(Console.ReadLine(), out size))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte velikost obrazce znovu: ");
    }

    Console.Clear();
    Console.WriteLine($"Vykresluji obrazec číslo {choice}...(velikost {size}) \n");

    switch (choice)
    {
        case 1:
            //obrazec 1: diagonální z

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || i + j == size - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));
                }
                Console.WriteLine();

            }
            break;

        case 2:

            //obrazec 2: kosočtverec

            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size - i - 1; k++)
                    Console.Write("  ");

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));

                }
                Console.WriteLine();

            }
            for (int i = size - 2; i >= 0; i--)
            {
                for (int k = 0; k < size - i - 1; k++)
                    Console.Write("  ");

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(60);
                }
                Console.WriteLine();
            }
            break;

        case 3:

            //obrazec 3: přesýpací hodiny

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i <= size / 2)
                    {
                        if (j >= i && j < size - i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");

                    }
                    else
                    {
                        if (j >= size - i - 1 && j <= i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");

                    }
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));

                }
                Console.WriteLine();

            }
            break;






    }
     


        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();
}