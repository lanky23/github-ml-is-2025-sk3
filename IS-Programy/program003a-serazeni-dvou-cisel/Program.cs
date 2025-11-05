string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** SEŘAZENÍ ČÍSEL DO ŘADY **********");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 16.10.2025 *******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();


    // Vstup HODNOTY DO PROGRAMU
    Console.Write("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo A znovu: ");
    }
    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo B znovu: ");
    }
    Console.Write("Zadejte celé číslo C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo C znovu: ");
    }



    Console.WriteLine();
    Console.WriteLine("==============================");
    

    if (a > b)
    {
        if (a > c)
        Console.WriteLine($"Největší je číslo A: {a}");
        else
        Console.WriteLine($"Největší je číslo C: {c}");
    }
    else
    {
        if (b > c)
        Console.WriteLine($"Největší je číslo B: {b}");
        else
        Console.WriteLine($"Největší je číslo C: {c}");

    }



    Console.WriteLine("==============================");
 






    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();



}