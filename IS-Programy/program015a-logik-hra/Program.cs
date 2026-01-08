using System;

string again = "a";                 // proměnná pro opakování programu
while (again == "a")                // hlavní smyčka programu
{
    Console.Clear();

    // ===== HLAVIČKA PROGRAMU =====
    Console.WriteLine("************************************************");
    Console.WriteLine("************** LOGIK – konzolová hra ***********");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 2025 *************************");
    Console.WriteLine("************************************************");
    Console.WriteLine();

    // ===== VYTVOŘENÍ GENERÁTORU NÁHODNÝCH ČÍSEL =====
    Random rnd = new Random();

    // ===== DEKLARACE POLE PRO TAJNOU KOMBINACI =====
    // Pole bude obsahovat 4 čísla, která má hráč uhodnout
    int[] secret = new int[4];

    // ===== GENEROVÁNÍ TAJNÉ KOMBINACE =====
    // Každé číslo je z intervalu 1–6
    for (int i = 0; i < 4; i++)
    {
        secret[i] = rnd.Next(1, 7);
    }

    // Maximální počet pokusů
    int maxTries = 10;

    Console.WriteLine("Uhodni 4 čísla v rozsahu 1–6.");
    Console.WriteLine("Zadávej čísla oddělená mezerou.\n");

    // ===== HLAVNÍ HERNÍ SMYČKA =====
    for (int attempt = 1; attempt <= maxTries; attempt++)
    {
        // Výpis čísla pokusu
        Console.Write("Pokus " + attempt + ": ");

        // Načtení vstupu od uživatele
        string input = Console.ReadLine() ?? "";

        // Rozdělení vstupu podle mezer
        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Kontrola, zda uživatel zadal přesně 4 čísla
        if (parts.Length != 4)
        {
            Console.WriteLine("Musíš zadat přesně 4 čísla!");
            attempt--;              // pokus se nepočítá
            continue;
        }

        // ===== PŘEVOD VSTUPU NA ČÍSLA =====
        int[] guess = new int[4];
        for (int i = 0; i < 4; i++)
        {
            guess[i] = int.Parse(parts[i]);
        }

        // ===== PROMĚNNÉ PRO VYHODNOCENÍ =====
        int correctPlace = 0;       // správné číslo na správném místě
        int correctNumber = 0;      // správné číslo na špatném místě

        // Pomocná pole, aby se čísla nepočítala víckrát
        bool[] usedSecret = new bool[4];
        bool[] usedGuess = new bool[4];

        // ===== KONTROLA SPRÁVNÉ POZICE =====
        for (int i = 0; i < 4; i++)
        {
            if (guess[i] == secret[i])
            {
                correctPlace++;
                usedSecret[i] = true;
                usedGuess[i] = true;
            }
        }

        // ===== KONTROLA SPRÁVNÉHO ČÍSLA NA ŠPATNÉ POZICI =====
        for (int i = 0; i < 4; i++)
        {
            if (usedGuess[i]) continue;

            for (int j = 0; j < 4; j++)
            {
                if (!usedSecret[j] && guess[i] == secret[j])
                {
                    correctNumber++;
                    usedSecret[j] = true;
                    break;
                }
            }
        }

        // ===== VÝPIS VÝSLEDKU POKUSU =====
        Console.WriteLine($"Výsledek: ✔️ {correctPlace}  ○ {correctNumber}\n");

        // ===== KONTROLA VÝHRY =====
        if (correctPlace == 4)
        {
            Console.WriteLine("🎉 Gratuluji, vyhrál jsi!");
            break;
        }
    }

    // ===== OPĚTOVNÉ SPUŠTĚNÍ PROGRAMU =====
    Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
