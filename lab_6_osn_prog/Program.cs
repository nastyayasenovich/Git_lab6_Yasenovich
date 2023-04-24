using System;

class Program
{
    [Flags]
    enum Cities
    {
        Not = 0b00000000,
        Kiev = 0b00000001,
        Lviv = 0b00000010,
        Madrid = 0b00000100,
        Barcelona = 0b00001000,
        Rome = 0b00010000,
        Milan = 0b00100000,
        Naples = 0b01000000,
        Venice = 0b10000000,
        Ukraine = Kiev | Lviv,
        Spain = Madrid | Barcelona,
        Italy = Rome | Milan | Naples | Venice
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Cities:");
        Console.WriteLine("1. Kiev");
        Console.WriteLine("2. Lviv");
        Console.WriteLine("3. Madrid");
        Console.WriteLine("4. Barcelona");
        Console.WriteLine("5. Rome");
        Console.WriteLine("6. Milan");
        Console.WriteLine("7. Naples");
        Console.WriteLine("8. Venice");

        Console.Write("Enter city numbers to visit (separated by commas): ");
        string[] input = Console.ReadLine().Split(',');
        int[] citiesToVisit = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            citiesToVisit[i] = Convert.ToInt16(input[i].Trim());
        }

        Console.WriteLine("Author: Yasenovych");

        Console.WriteLine("Cities to visit in Ukraine:");
        foreach (Cities city in Enum.GetValues(typeof(Cities)))
        {
            if ((city & Cities.Ukraine) != 0 && (Array.IndexOf(citiesToVisit, (int)city) != -1))
            {
                Console.WriteLine((int)city + ". " + city);
            }
        }

        Console.WriteLine("Cities to visit in Spain:");
        foreach (Cities city in Enum.GetValues(typeof(Cities)))
        {
            if ((city & Cities.Spain) != 0 && (Array.IndexOf(citiesToVisit, (int)city) != -1))
            {
                Console.WriteLine((int)city + ". " + city);
            }
        }

        Console.WriteLine("Cities to visit in Italy:");
        foreach (Cities city in Enum.GetValues(typeof(Cities)))
        {
            if ((city & Cities.Italy) != 0 && (Array.IndexOf(citiesToVisit, (int)city) != -1))
            {
                Console.WriteLine((int)city + ". " + city);
            }
        }

        Console.ReadLine();
    }
}
