using System;

namespace ProvSänkaSkepp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where is the ship?\nPlease pick a number between 1 and 10:");

            int correct;
            //initialize ship variable
            string ship = Console.ReadLine().ToLower();

            while (ship != "4")
            {

                try
                {
                    correct = int.Parse(ship);
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Please use numbers.");
                    Console.ReadLine();
                    throw;
                }

            }

            /* if (ship == "4")
             {
                 System.Console.WriteLine("Hit!");
             }
 */
            switch (ship)
            {
                case "1":
                case "7":
                case "8":
                case "9":
                case "10":

                    System.Console.WriteLine(
                        "Miss!"
                    );

                    break;

                case "2":
                case "3":
                case "5":
                case "6":

                    System.Console.WriteLine("Near miss!");

                    break;

                case "4":

                    System.Console.WriteLine("Hit!");

                    break;

                default:
                    System.Console.WriteLine("please use numbers.");
                    break;
            }
            //Försökte me en while loop och innuti switch men av nån anledning ville den 
            //inte göra det korrekt så jag raderade all den koden och 
            //nu blev det bajs för ett error meddelande kommer upp som 
            //jag inte förstår och det är bara 10 min kvar men den säger till en gång om det
            //inte är en int iallafall, nu gjorde ja en switch fast utan loop men den funkar ju inte
            //oh well it is what it is.

            Console.ReadLine();
        }
    }
}
