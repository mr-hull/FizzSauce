using System;

namespace FizzSauce2TheSearchForMoreFizzSauce
{
    class Character
    {
        private string nL = Environment.NewLine;
        private string charName;


        public string PromptCharacterName()
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

            return charName;
        }

        public void InitializeCharacter(string charName)
        {
            Console.WriteLine(nL + nL + "Very well then, " + charName + "." + " Let's begin.");

        }

    }
}
