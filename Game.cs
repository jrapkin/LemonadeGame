using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
	class Game
	{
		Player playerOne;
		public Random random;
		public List<Day> days;


		public Game()
		{	
			random = new Random();
			days = new List<Day>() { new Day(random, "Monday"), new Day(random, "Tuesday"), new Day(random, "Wednsday"), new Day(random, "Thursday"), new Day(random, "Friday"), new Day(random, "Saturday"), new Day(random, "Sunday") };


		}

		public void RunGame()
		{
			UserInterface.WelcomeMessage();
			UserInterface.DisplaySinglePlayerModeMessage();
			playerOne = new Player();
			for (int i = 0; i < days.Count; i++)
			{
				UserInterface.DisplayWeather(days[i].theDay, days[i].weather.condition, days[i].weather.temperature);
				days[i].RunDay(playerOne, random);

			}
			CheckForNewGame();
		}
		
		private bool CheckForNewGame()
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
						UserInterface.QuitGameMessage();
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
