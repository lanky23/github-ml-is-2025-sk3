string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** Převod z desítkové do libovolné nižší soustavy ************");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 7.12.2025 *******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu
    Console.Write("Zadejte přirozené číslo v desítkové soustavě: ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte přirozené číslo v desítkové soustavě znovu: ");
    }

    // Vstup cílové soustavy (2–9)
    Console.Write("Zadejte základ cílové soustavy (2–9): ");
    uint baseN;
    while (!uint.TryParse(Console.ReadLine(), out baseN) || baseN < 2 || baseN > 9)
    {
        Console.Write("Neplatná soustava! Zadejte číslo 2–9: ");
    }

    uint[] myArray = new uint[32];
    uint backupNumber10 = number10;

    uint zbytek;
    uint i;

    // Zvláštní případ: 0
    if (number10 == 0)
    {
        Console.WriteLine($"Desítkové číslo 0 ve {baseN}-kové soustavě = 0");
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine() ?? "";
        continue;
    }

    // Výpočet v libovolné nižší soustavě
    for (i = 0; number10 > 0 && i < myArray.Length; i++)
    {
        zbytek = number10 % baseN;
        number10 = (number10 - zbytek) / baseN;
        myArray[i] = zbytek;

        Console.WriteLine("Celá část = {0}; zbytek = {1}", number10, zbytek);
    }

    // Zpětný výpis pole
    Console.Write("Desítkové číslo {0} ve {1}-kové soustavě = ", backupNumber10, baseN);
    for (int j = (int)i - 1; j >= 0; j--)
    {
        Console.Write(myArray[j]);
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine() ?? "";
}
