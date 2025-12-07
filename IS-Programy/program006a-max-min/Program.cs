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

    for (int i = 0; i < n; i++)
    {
        myRandNumbers[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbers[i]);
    }


    int max = myRandNumbers[0];
    int min = myRandNumbers[0];
    int posMax = 0;
    int posMin = 0;


    for (int i = 1; i < n; i++)
    {
        if (myRandNumbers[i] > max)
        {
            max = myRandNumbers[i];
            posMax = i;

        }

        if (myRandNumbers[i] < min)
        {
            min = myRandNumbers[i];
            posMin = i;
        }

        Console.WriteLine("========================================================");
        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine($"Pozice maxima: {posMax}");
        Console.WriteLine($"Minimum: {min}");
        Console.WriteLine($"Pozice minima: {posMin}");
        Console.WriteLine("========================================================");


        //vykreslení přesýpacích hodin 

        if (max >= 3)
        {
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine();
            Console.WriteLine($"Přesýpací hodiny o velikosti {max}");
            Console.WriteLine();



        }

        //tento cyklus se stará o to, aby se vykreslil správný počet řádků 

        for (int i = 0; i < max; i++)
        {
            int spaces, stars;
            if (i < max / 2)
            {
                //horní polovina obrazce - určit počet mezer 
                spaces = i;

                //horní polovina - určit počet hvězd
                stars = max - i * 2;
            }
            else

            {
                //dolní polovina - určit počet mezer
                spaces = max - i - 1;

                //dolní polovina - určit počet hvězd
                if (max % 2 == 1)
                {
                    stars = 2 * (i - max / 2) + 1;
                }

                else
                {
                    stars = 2 * (i - max / 2) + 2;
                }


            }





            //vykreslení správného počtu mezer pro každý řádek 
            //sp - space (1 mezera)

            for (int sp = 0; sp < spaces; sp++)
                Console.Write(" ");

            //vykreslení správného počtu hvězd pro každý řádek 
            //st - stars (1 hvězdička)

            for (int st = 0; st < stars; st++)
                Console.Write("*");

            Console.WriteLine();

        }






        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();


    }
}




