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
		//Constructor
		public Game()
		{
			UserInterface.WelcomeMessage();
		}
		//Member Methods
		//Main Method
		public void RunGame()
		{
			//welcome user to the game
			UserInterface.DisplayGameModeOptions();
			UserInterface.SetGameMode();
			UserInterface.SetPlayerType();

			//set up new game in valid state (seven rounds AKA play for 7 days)
			//new players get $20 to start
			//display the weather for the day
			//set actual weather for the day

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

	}
}
