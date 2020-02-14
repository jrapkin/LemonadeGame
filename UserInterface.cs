using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface
    {
		public static void WelcomeMessage()
		{

			Console.WriteLine("Welcome to Lemonade Stand\n \n");
			Console.WriteLine("Do you have the business chops to run a lemonade Stand?");
			Console.WriteLine("Do you want to start a new game and be an entrepenure?");
			Console.WriteLine("You can type new game, or press 1 to begin. Press 2, or say no to quit the game");
		}

		public static void DisplayGameModeOptions()
		{
			Console.WriteLine("This game can be played in single player mode, or multiplayer mode.");
			Console.WriteLine("Press 1, or enter single player to play on your own.");
			Console.WriteLine("Press 2, or enter two player mode.");

		}
		public static void SetGameMode()
		{
			bool gameModeCheck = false;
			do
			{
				string numberOfPlayers = UserInterface.PlayerInput();
				if (numberOfPlayers == "single player")
				{
					Console.WriteLine("You have selected Single Player Mode. Would you like to play by yourself, or with the computer?");
					gameModeCheck = true;
				}
				else if (numberOfPlayers == "two player")
				{
					Console.WriteLine("You have selected Multiplayer Mode. Would you like to play with a friend, or with the computer?");
					gameModeCheck = true;
				}
				else
				{
					Console.WriteLine("Please enter a valid selection. \n Enter single player if you want to play by yourself. \n Enter multiplayer if you want to play multiplayer mode.!");

				}
			}
			while (gameModeCheck == false);
		}

		public static void SetPlayerType()
		{
			bool  playerTypeCheck = false;
			do
			{
				string playerType = UserInterface.PlayerInput();
				if (playerType == "by myself" || playerType == "1")
				{

					playerOne = new Human();
					playerTypeCheck = true;
					break;
				}


				else if (playerType == "with the computer" || playerType == "2")
				{

					playerOne = new Human();
					playerTwo = new AI();
					playerTypeCheck = true;
					break;
				}

				else if (playerType == "with a friend" || playerType == "3")
				{
					playerOne = new Human();
					playerTwo = new Human();
					playerTypeCheck = true;
					break;
				}
				else
					Console.WriteLine("Please enter a valid selection.)"
			
				
			}
			while (playerTypeCheck == false);
		}

		public static bool CheckForNewGame()
		{
			bool newGameCheck = false;
			do
			{
				string userInput = UserInterface.PlayerInput();
				switch (userInput)
				{

					case "new game":
					case "New Game":
					case "1":
						newGameCheck = true;

						break;

					case "no":
					case "No":
					case "2":
						QuitGame();
						break;

					default:
						Console.WriteLine("Please make a valid selection. Press 1 to start a new game. Press 2 to exit the game.");
						return CheckForNewGame();
				}


			}
			while (newGameCheck == false);
			return newGameCheck;
		}
		public static void QuitGame()
		{
			Console.WriteLine("It's been fun!\n Play again soon.");
		}

		public static string PlayerInput()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }

        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }
        //take user input method?
    }
}
