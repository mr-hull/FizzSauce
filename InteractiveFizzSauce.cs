using System;

namespace FizzSauce2TheSearchForMoreFizzSauce
{
    class InteractiveFizzSauce
    {
        static void Main()
        {
            ConsoleKeyInfo cki;
            Console.Title = "Fizz Sauce 2: SMFS";
            string nL = Environment.NewLine;
            string charName;

            Console.WriteLine(nL + " *****************************************************************************" +
                         nL + " *****************************************************************************" +
                         nL + " *************** FIZZ SAUCE 2: THE SEARCH FOR MORE FIZZ SAUCE ****************" + 
                         nL + " *****************************************************************************" +
                         nL + " *****************************************************************************" +
                         nL + nL + "               Prepare thine buttocks for a thorough exploration" + 
                         nL + nL + "                             of a bold new world." + 
                         nL + nL + nL);
            Console.WriteLine(nL + "Who are you?");
            charName = Console.ReadLine();

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

            do
            {
                cki = Console.ReadKey(true);




            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
