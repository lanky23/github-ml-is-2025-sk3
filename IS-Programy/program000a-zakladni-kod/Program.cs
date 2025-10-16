string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** NÁZEV PROGRAMU **************");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 16.10.2025 *******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();


    // Vstup HODNOTY DO PROGRAMU
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }










    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();



}