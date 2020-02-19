using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
	static class UserInterface
	{
		//game related messages and functions
		public static void WelcomeMessage()
		{

			Console.WriteLine("Welcome to Lemonade Stand\n \n");
			Console.WriteLine("Do you have the business chops to run a lemonade Stand?");
			Console.WriteLine("Do you want to start a new game and be an entrepenure?");
			Console.WriteLine("You can type new game, or press 1 to begin. Press 2, or say no to quit the game");

		}

		public static void CheckForNewGame()
		{
			Console.WriteLine("Would you like to start a new game? Press 1 to start a new game. \n Press 2 to quit the game");
		}
		public static void QuitGame()
		{
			Console.WriteLine("It's been fun!\n Play again soon.");
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
		public static string TakePlayerInput()
		{
			string userInput = Console.ReadLine();

			return userInput;
		}
		public static void DisplayInvalidSelectionMessage()
		{
			Console.WriteLine("Please enter a valid selection.");
		}
		public static void DisplayWeather(string day,string condition, int temperatureToDisplay)
		{
			Console.WriteLine($"Today is {day}. Today it will be {temperatureToDisplay} degrees and {condition}.");
		}
		//player related messages
		public static void DisplayMoneyHeld(double playerMoney)
		{
			
			Console.WriteLine($"You currently have ${playerMoney} in your wallet.");
		}
		public static void DisplayCurrentInventory (int numberOfLemons, int numberOfSugarCubes, int numberOfIceCubes, int numberOfCups)
		{
			Console.WriteLine($"You currently have {numberOfLemons} lemons.\nYou currently have {numberOfSugarCubes} sugar cubes.\nYou currently have {numberOfIceCubes} ice cubes.\nYou currently have {numberOfCups} cups.");
		}
		public static void StorePurchaseMessage()
		{
			Console.WriteLine("Welcome to the store. You can buy anything you'd like... as long as you can show me the money! \nWhat items would you like to buy?\n");
		}
		public static void DisplayItemList()
		{
			
			Console.WriteLine("1: Lemons\n\n2: Sugar Cubes\n\n3:Ice Cubes\n\n4:Cups");
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
		public static void PromptUserForDesiredRecipe()
		{
			Console.WriteLine("What would you like to set your lemonade recipe to? This will affect the recipe of your pitcher. \nYou can set your price per cup as well.");
		}

		public static void DisplayRecipeOptions()
		{
			Console.WriteLine("1: Lemons\n\n2: Sugar Cubes\n\n3:Ice Cubes\n\n4:Price Per Cup");

		}

		public static int PromptForNumberOfItemsInRecipe(string item)
		{
			bool userInputIsValid = false;
			int itemQuantity = -1;

			while (userInputIsValid == false || itemQuantity < 0)
			{
				Console.WriteLine($"How many {item} would you like to add to your recipe?");
				Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

				userInputIsValid = Int32.TryParse(Console.ReadLine(), out itemQuantity);

			}
			return itemQuantity;
		}

		public static void DoYouWantToContinueToBuy()
		{
			Console.WriteLine("Do you want to continue buying items for your inventory?");
		}
		public static void DoYouWantToContinueToSetRecipe()
		{
			Console.WriteLine("Do you want to continue setting your recipe?");

		}
		public static void AskForPricePerCup()
		{
			Console.WriteLine("How much would you like to charge per cup of lemonade? Press 0 to cancel.");
		}

		public static void SoldOut()
		{
			Console.WriteLine("You don't have enough inventory to make pitchers. You sold out for the day. Please head back to the store to buy inventory!");
		}
		public static void DisplayNumberOfCupsLeft(int cupsLeftInPitcher)
		{
			Console.WriteLine($"You have {cupsLeftInPitcher} left in this pitcher.");
		}

		public static void DisplayCustomerBuys()
		{
			Console.WriteLine("A customer decided to buy your lemonade! Show me the money!");
			Console.ReadLine();
			Console.Clear();
		}
		public static void DisplayCustomerPass()
		{
			Console.WriteLine($"A customer decided not to buy your lemonade. Bummer!");
		}
	}
}