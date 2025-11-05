string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** vykreslení obdelníku ************");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 16.10.2025 *******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();


    // Vstup HODNOTY DO PROGRAMU
    Console.Write("Zadejte šířku obdelníka (celé číslo): ");
    int widht;
    while (!int.TryParse(Console.ReadLine(), out widht))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obdelníka znovu: ");
    }

  Console.Write("Zadejte výšku obdelníka (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obdelníka znovu: ");
    }

    for (int i = 1; i <=height; i++) {
        for (int j = 1; j <= widht; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
        }
            Console.WriteLine(); 

    }






            Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();



}