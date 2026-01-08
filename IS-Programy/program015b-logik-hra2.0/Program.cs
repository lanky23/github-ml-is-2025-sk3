using System;

string again = "a";
while (again == "a")
{
    Console.Clear();

    // ===== HLAVIČKA PROGRAMU (TVŮJ STYL) =====
    Console.WriteLine("************************************************");
    Console.WriteLine("************** LOGIK – pokročilá verze *********");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Lankaš *****************");
    Console.WriteLine("***************** 2025 *************************");
    Console.WriteLine("************************************************");
    Console.WriteLine();

    // ===== GENERÁTOR NÁHODNÝCH ČÍSEL =====
    Random rnd = new Random();

    // ===== TAJNÁ KOMBINACE =====
    int[] secret = new int[4];
    for (int i = 0; i < 4; i++)
    {
        // čísla 1–6 (klasický LOGIK)
        secret[i] = rnd.Next(1, 7);
    }

    int maxTries = 10;

    // ===== POLE PRO ULOŽENÍ HISTORIE POKUSŮ =====
    int[,] history = new int[maxTries, 4];
    int[] historyCorrectPlace = new int[maxTries];
    int[] historyCorrectNumber = new int[maxTries];

    Console.WriteLine("Uhodni 4 čísla v rozsahu 1–6.");
    Console.WriteLine("Vysvětlivky:");
Console.WriteLine("✔  = správné číslo na správné pozici");
Console.WriteLine("○  = správné číslo, ale na špatné pozici");
Console.WriteLine();


    bool win = false;

    // ===== HLAVNÍ HERNÍ SMYČKA =====
    for (int attempt = 0; attempt < maxTries; attempt++)
    {
        Console.Write($"Pokus {attempt + 1}: ");
        string input = Console.ReadLine() ?? "";
        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // kontrola počtu zadaných čísel
        if (parts.Length != 4)
        {
            Console.WriteLine("Musíš zadat přesně 4 čísla!");
            attempt--;
            continue;
        }

        // ===== NAČTENÍ TIPU HRÁČE =====
        int[] guess = new int[4];
        for (int i = 0; i < 4; i++)
        {
            guess[i] = int.Parse(parts[i]);
            history[attempt, i] = guess[i]; // uložení do historie
        }

        int correctPlace = 0;
        int correctNumber = 0;

        bool[] usedSecret = new bool[4];
        bool[] usedGuess = new bool[4];

        // ===== SPRÁVNÉ ČÍSLO NA SPRÁVNÉ POZICI =====
        for (int i = 0; i < 4; i++)
        {
            if (guess[i] == secret[i])
            {
                correctPlace++;
                usedSecret[i] = true;
                usedGuess[i] = true;
            }
        }

        // ===== SPRÁVNÉ ČÍSLO NA ŠPATNÉ POZICI =====
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

        // uložení výsledků do historie
        historyCorrectPlace[attempt] = correctPlace;
        historyCorrectNumber[attempt] = correctNumber;

        // ===== VÝHRA =====
        if (correctPlace == 4)
        {
            Console.WriteLine("🎉 Gratuluji! Uhodl jsi kombinaci!");
            win = true;
            break;
        }
    }

    // ===== PROHRA =====
    if (!win)
    {
        Console.WriteLine("\n❌ Došly pokusy.");
        Console.Write("Tajná kombinace byla: ");
        for (int i = 0; i < 4; i++)
            Console.Write(secret[i] + " ");
        Console.WriteLine();
    }

    Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
