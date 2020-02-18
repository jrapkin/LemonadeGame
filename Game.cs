using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
	class Game
	{
		//Member Variables
		Player playerOne;
		Player playerTwo;
		public Random random;
		public List<Day> days;
		Store theStore;


		//Constructor
		public Game()
		{	
			random = new Random();
			UserInterface.WelcomeMessage();
			days = new List<Day>() { new Day(random, "Monday"), new Day(random, "Tuesday"), new Day(random, "Wednsday"), new Day(random, "Thursday"), new Day(random, "Friday"), new Day(random, "Saturday"), new Day(random, "Sunday") };
			theStore = new Store();

		}
		//Member Methods
		//Main Method
		public void RunGame()
		{
			
			//welcome user to the game
			UserInterface.DisplayGameModeOptions();
			SetGameMode();
			 
			/*for (int i = 0; i < days.Count; i++)
			{*/
			    //display the weather for the day	
				//UserInterface.DisplayWeather(days[i].theDay, days[i].weather.condition, days[i].weather.temperature);
				//player gets to buy inventory
				UserInterface.StorePurchaseMessage();

			bool playerWantsToBuy = true;
			
			do
			{
				UserInterface.DisplayMoneyHeld(playerOne.wallet.Money);
				UserInterface.DisplayCurrentInventory(playerOne.inventory.lemons.Count, playerOne.inventory.sugarCubes.Count, playerOne.inventory.iceCubes.Count, playerOne.inventory.cups.Count);
				UserInterface.DisplayItemList();
				//is deciding what they want to buy and also how much they want and then performing the transaction
				//figure out how to break this up
				WhatPlayerWantsToBuy();
				UserInterface.DoYouWantToContinueToBuy();
				string playerBuyingItems = UserInterface.TakePlayerInput().ToLower();
				if (playerBuyingItems == "no") 
				{
					Console.Clear();
					playerWantsToBuy = false;
				}
				else if (playerBuyingItems == "yes")
				{
					Console.Clear();
					continue;
				}
				else
				{
					Console.Clear();
					UserInterface.DisplayInvalidSelectionMessage();
				}
			} while (playerWantsToBuy);

			//create their recipie for the lemonade
			bool playerSettingRecipe = true;
			UserInterface.PromptUserForDesiredRecipe();
			do
			{
				UserInterface.DisplayCurrentInventory(playerOne.inventory.lemons.Count, playerOne.inventory.sugarCubes.Count, playerOne.inventory.iceCubes.Count, playerOne.inventory.cups.Count);
				UserInterface.DisplayItemList();			
				//how many lemons/cup
				playerOne.SetLemondadeRecipe(UserInterface.TakePlayerInput().ToLower());
				UserInterface.DoYouWantToContinueToSetRecipe();
				string input = UserInterface.TakePlayerInput().ToLower();
				if (input =="no")
				{
					 playerSettingRecipe = false;
				}
				else if(input == "yes")
				{
					Console.Clear();
					continue;
				}
				else
				{ UserInterface.DisplayInvalidSelectionMessage();
				}
			} while (playerSettingRecipe);	
		
					//how much sugar/cup
					//how many ice cubes
					//price per cup

					//begin day
					//random customers purchase cups until the set time is over with
					//price too high & weather affect demand

					//display how many cups sold, how much money made/ day
					//track how much made over the week?

			}
		private void SetGameMode()
		{
			
			bool gameModeCheck = false;
			do
			{
				string numberOfPlayers = UserInterface.TakePlayerInput();
				if (numberOfPlayers == "single player" || numberOfPlayers == "1")
				{
					UserInterface.DisplaySinglePlayerModeMessage();
					playerOne = new Player();
					gameModeCheck = true;
				}
				else if (numberOfPlayers == "two player" || numberOfPlayers== "2")
				{
					UserInterface.DisplayMultiplayerModeMessage();
					//SetPlayerType();
					gameModeCheck = true;
				}
				else
				{
					UserInterface.DisplayInvalidSelectionMessage();
				}
			}
			while (gameModeCheck == false);
		}
/*		 private void SetPlayerType()
		{
			bool playerTypeCheck = false;
			do
			{
				string playerType = UserInterface.TakePlayerInput();
		
				if (playerType == "with the computer" || playerType == "1")
				{

					playerOne = new Human();
					playerTwo = new AI();
					playerTypeCheck = true;
					break;
				}

				else if (playerType == "with a friend" || playerType == "2")
				{
					playerOne = new Human();
					playerTwo = new Human();
					playerTypeCheck = true;
					break;
				}
				else
					UserInterface.DisplayInvalidSelectionMessage();


			}
			while (playerTypeCheck == false);
		}*/
		public bool CheckForNewGame()
		{
			bool newGameCheck = false;
			do
			{
				string userInput = UserInterface.TakePlayerInput();
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
						UserInterface.QuitGame();
						newGameCheck = true;
						break;

					default:
						UserInterface.DisplayInvalidSelectionMessage();
							return CheckForNewGame();
				}


			}
			while (newGameCheck == false);
			return newGameCheck;
		}
		private bool WhatPlayerWantsToBuy()
		{
			string userInput = UserInterface.TakePlayerInput().ToLower();
			bool validInput = false;
			//user picks item from list
			while (validInput == false) 
			{

				switch (userInput)
				{
					case "1":
					case "lemons":
						theStore.SellLemons(playerOne);
						return validInput = true;

					case "2":
					case "sugar cubes":
						theStore.SellSugarCubes(playerOne);
						return validInput = true;
					case "3":
					case "ice cubes":
						theStore.SellIceCubes(playerOne);
						return validInput = true;
					case "4":
					case "cups":
						theStore.SellCups(playerOne);
						return validInput = true;

					default:
						UserInterface.DisplayInvalidSelectionMessage();
						return WhatPlayerWantsToBuy();
				}
			}
			return validInput;
		}

	}
}
