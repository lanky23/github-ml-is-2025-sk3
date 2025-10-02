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









    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a");
    Console.ReadLine();
    again = Console.ReadLine();
    
        
    









}



