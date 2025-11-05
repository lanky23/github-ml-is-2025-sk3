string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** vykreslení trojuhelniku************");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 5.11.2025 *******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();


    // Vstup HODNOTY DO PROGRAMU
    Console.Write("Zadejte výšku trojúhelníku (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku trojúhelníku znovu: ");
    }

    for (int i = 1; i <=height; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(500));
        }
            Console.WriteLine(); 

    }






            Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();



}