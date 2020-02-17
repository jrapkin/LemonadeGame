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
		public Weather weather;
		public Random random;
		public List<Day> days;
		//Constructor
		public Game()
		{	
			random = new Random();
			UserInterface.WelcomeMessage();
			days = new List<Day>() { new Day(random, "Monday"), new Day(random, "Tuesday"), new Day(random, "Wednsday"), new Day(random, "Thursday"), new Day(random, "Friday"), new Day(random, "Saturday"), new Day(random, "Sunday") };


		}
		//Member Methods
		//Main Method
		public void RunGame()
		{
			
			//welcome user to the game
			UserInterface.DisplayGameModeOptions();
			SetGameMode();

			foreach (Customer customer in days[0].customers)
			{
				for (int i = 0; i < days[0].customers.Count; i++)
				{
					Console.WriteLine(days[0].customers[i].name);
				}

			}
		

			//new players get $20 to start

			//set actual weather for the day


			//display the weather for the day	


			//player gets to buy inventory
			//what do they want to buy?
			//how much do they want to buy?
			//complete transaction (remove $$$ from their wallet)

			//create their recipie for the lemonade
			//how many lemons/cup
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
				string numberOfPlayers = UserInterface.PlayerInput();
				if (numberOfPlayers == "single player" || numberOfPlayers == "1")
				{
					UserInterface.DisplaySinglePlayerModeMessage();
					gameModeCheck = true;
				}
				else if (numberOfPlayers == "two player" || numberOfPlayers== "2")
				{
					UserInterface.DisplayMultiplayerModeMessage();
					SetPlayerType();
					gameModeCheck = true;
				}
				else
				{
					UserInterface.DisplayInvalidSelectionMessage();
				}
			}
			while (gameModeCheck == false);
		}
		
		private void SetPlayerType()
		{
			bool playerTypeCheck = false;
			do
			{
				string playerType = UserInterface.PlayerInput();
		
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
		}
		public bool CheckForNewGame()
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

	}
}
