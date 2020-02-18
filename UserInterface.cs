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

		public static void DisplaySinglePlayerModeMessage()
		{
			Console.WriteLine("You have selected Single Player Mode.");
		}

		public static void DisplayMultiplayerModeMessage()
		{
			Console.WriteLine("You have selected Multiplayer Mode. You can press 1 to play with the computer, or press two to play with a friend.");

		}
		public static void DisplayMoneyHeld(double playerMoney)
		{
			Console.WriteLine($"You currently have ${playerMoney} in your wallet.");
		}

		public static void CheckForNewGame()
		{
			Console.WriteLine("Would you like to start a new game? Press 1 to start a new game. \n Press 2 to quit the game");
		}
		public static void QuitGame()
		{
			Console.WriteLine("It's been fun!\n Play again soon.");
		}

		public static string TakePlayerInput()
		{
			string userInput = Console.ReadLine();

			return userInput;
		}

		public static void DisplayInvalidSelectionMessage()
		{
			Console.WriteLine("Please enter a valid selection.");
		}

		public static void StorePurchaseMessage()
		{
			Console.WriteLine("Welcome to the store. You can buy anything you'd like... as long as you can show me the money! \nWhat items would you like to buy?\n");
		}
		public static void DisplayItemList()
		{
			Console.WriteLine("1: Lemon\n\n2: Sugar Cubes\n\n3:Ice Cubes\n\n4:Cups");
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

		public static void DisplayWeather(string day,string condition, int temperatureToDisplay)
		{
			Console.WriteLine($"Today is {day}. Today it will be {temperatureToDisplay} degrees and {condition}.");
		}
    }
}