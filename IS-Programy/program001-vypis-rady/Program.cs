// See https://aka.ms/new-console-template for more information


string again = "a";
while (again == "a")

{
    Console.Clear();
    Console.WriteLine("////////////////////////////////");
    Console.WriteLine("/////  Výpis číselné řady  /////");
    Console.WriteLine("////////////////////////////////");
    Console.WriteLine("////////  Martin Lankaš  ///////");
    Console.WriteLine("////////////////////////////////");
    Console.WriteLine();

    // VSTUP ČÍSELNÉ HODNOTY DO PROGRAMU - ŠPATNÉ ŘESŠENÍ 
    // Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // VSTUP ČÍSELNÉ HODNOTY DO PROGRAMU - lepší řešení  
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte první číslo celé řady znovu: ");
    
    }

    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte poslední číslo celé řady znovu: ");
    
    }

Console.Write("Zadejte diferenci (celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte diferenci: ");
    
    }

    //výpis zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine("Zadali jste tyto hodnoty: ");
    Console.WriteLine("První číslo řady: {0}", first);
    Console.WriteLine("Zadali jste poslední číslo: {0}", last);
    Console.WriteLine("Zadali jste diferenci: {0}", step);
    Console.WriteLine("===============================");
    Console.WriteLine("První číslo {0}; {1}; {2};", first,last,step);
    Console.WriteLine("===============================");


//










    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
    
        
    









}



