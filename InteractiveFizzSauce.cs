using System;

namespace FizzSauce2TheSearchForMoreFizzSauce
{
    class InteractiveFizzSauce
    {
        static string nL = Environment.NewLine;
        static string charName;

        static void Main()
        {
            ConsoleKeyInfo cki;
            Console.Title = "Fizz Sauce 2: SMFS";

            Console.WriteLine(nL + " *****************************************************************************" +
                         nL + " *****************************************************************************" +
                         nL + " *************** FIZZ SAUCE 2: THE SEARCH FOR MORE FIZZ SAUCE ****************" + 
                         nL + " *****************************************************************************" +
                         nL + " *****************************************************************************" +
                         nL + nL + "               Prepare thine buttocks for a thorough exploration" + 
                         nL + nL + "                             of a bold new world." + 
                         nL + nL + nL);

            Console.WriteLine("                 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$$$              $$$$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$$$  START MENU  $$$$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$$$              $$$$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$                  $$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$   SELECT OPTION  $$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$__________________$$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$                  $$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$   L: LOAD GAME   $$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$                  $$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$   N: NEW  GAME   $$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$                  $$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$ ESC: EXIT GAME   $$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$                  $$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$" +
                         nL + "                 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$" +
                         nL + nL + nL);

            do
            {

                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.L)
                {
                    LoadGame();
                }
                else if (cki.Key == ConsoleKey.N)
                {
                    NewGame();
                }

            } while (cki.Key != ConsoleKey.Escape);

        }

        static void NewGame()
        {
            Console.WriteLine(nL + "Who are you?");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            charName = Console.ReadLine();

            Console.ResetColor();

            if (charName.Length <= 2)
            {

                Console.WriteLine(charName + "? K." + nL);
            }
            else if (charName.Length > 2 && charName.Length <= 5)
            {
                Console.WriteLine(charName + ". I've heard worse. Let's get on with it then." + nL);
            }
            else
            {
                Console.WriteLine(charName + "? Excellent to make your acquaintance." + nL);
            }
        }

        static void LoadGame()
        {

        }
    }
}
