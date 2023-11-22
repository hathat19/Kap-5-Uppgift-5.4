using System;
namespace Uppgift5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //-------------------------------------------

            //variabler
            string[] names = { "Hugo", "Ivan", "Bert", "Håkon", "Emil", "John", "Max" };
            string first = "";
            bool firstLoop = true;

            //går igenom varje namn
            foreach (string name in names)
            {
                //Första loop?
                if (firstLoop)
                {
                    first = name;
                    firstLoop = false;
                }
                else
                {
                first = name.CompareTo(first) < 0 ? name : first;
                }
            }
            Console.WriteLine($"Namnet {first} kommer först i bokstavsordning.");

        }
    }
}
/*Skapa ett program som innehåller en array med minst 5 namn. Använd en loop för att
gå igenom arrayen och sedan skriva ut det namn som kommer först i
bokstavsordning.*/