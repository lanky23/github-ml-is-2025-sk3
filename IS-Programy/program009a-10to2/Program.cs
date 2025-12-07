string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** Převod z desítkové do binární (dvojkové) soustavy ************");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 7.12.2025 *******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();

    // Vstup hodnoty
    Console.Write("Zadejte přirozené číslo v desítkové soustavě: ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte přirozené číslo znovu: ");
    }

    // Ošetření výjimky: vstup je 0
    if (number10 == 0)
    {
        Console.WriteLine("Desítkové číslo 0 ve dvojkové soustavě = 0");
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();
        continue;
    }

    uint[] myArray = new uint[32];
    uint backupNumber10 = number10;

    uint zbytek;
    int i = 0;

    // převod
    while (number10 > 0 && i < myArray.Length)
    {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek) / 2;

        myArray[i] = zbytek;
        Console.WriteLine($"Celá část = {number10}; zbytek = {zbytek}");
        i++;
    }

    // výpis binárního čísla
    Console.Write($"Desítkové číslo {backupNumber10} ve dvojkové soustavě = ");

    for (int j = i - 1; j >= 0; j--)
    {
        Console.Write(myArray[j]);
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
