using System;

namespace FizzSauce2TheSearchForMoreFizzSauce
{
    class FizzSauceGame
    {
        private static string nL = Environment.NewLine;


        public static void BeginNewGame()
        {
            string charName;

            var newCharacter = new Character();

            charName = newCharacter.PromptCharacterName();

            newCharacter.InitializeCharacter(charName);
        }

        public static void LoadGame()
        {
            Console.WriteLine("And this is where we would load your old game... IF YOU HAD ONE!");
        }

    }
}
