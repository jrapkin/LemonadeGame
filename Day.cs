using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
	class Day
	{
		//member variables
		public List<Customer> customers;
		public Weather weather;
		public string theDay;
		public Store theStore;


		//constructor
		public Day(Random random, string day)
		{
			weather = new Weather(random);
			theDay = day;
			customers = new List<Customer>();
			theStore = new Store();
			CreateListOfCustomers(random, DetermineNumberOfCustomers(random));
			//UserInterface.DisplayWeather(theDay, weather.condition, weather.temperature);
			
		}

		//Member method 

		public void RunDay(Player player, Random random)
		{
			theStore.PlayerIsInTheStore(player);
			DecideRecipeForTheDay(player);
			bool playerHasInventory = true;
			//start the day
			if (playerHasInventory == true)
			{
				player.CreatePitcher(player.pitcher, player.recipe);
				for (int i = 0; i < customers.Count; i++)
				{
					SellLemonade(player, customers[i], random);
				}
			}
			else
			{
				UserInterface.SoldOut();
			}
			
		}

		private void SellLemonade(Player player, Customer customer, Random random)
		{
			if (customer.ChanceToBuy(player.recipe, random) == true)
			{
				player.wallet.AddMoneyToWallet(player.recipe.pricePerCup);
				player.pitcher.cupsInPitcher--;
				UserInterface.DisplayCustomerBuys();
				UserInterface.DisplayMoneyHeld(player.wallet.Money);
				UserInterface.DisplayNumberOfCupsLeft(player.pitcher.cupsInPitcher);
			}
			else
			{
			
				UserInterface.DisplayNumberOfCupsLeft(player.pitcher.cupsInPitcher);
				
			}

		}
		private int DetermineNumberOfCustomers(Random rng)
		{
			int numberOfCustomersToCreate = 0;

			if (weather.condition == "Sunny" && (weather.temperature >= 80 || weather.temperature < 110))
			{
				 numberOfCustomersToCreate = rng.Next(20,65);
			}
			else if (weather.condition == "overcast" && (weather.temperature >= 66 || weather.temperature < 79))
			{
				numberOfCustomersToCreate = rng.Next(20, 50);
			}
			else if (weather.condition == "foggy" && (weather.temperature >= 55 || weather.temperature < 65))
			{
				numberOfCustomersToCreate = rng.Next(15,25);
			}
			else if (weather.condition == "rainy" && (weather.temperature >= 50 || weather.temperature < 79))
			{
				numberOfCustomersToCreate = rng.Next(6,15);
			}
			else if (weather.condition == "stormy" && (weather.temperature >= 65 || weather.temperature < 75))
			{
				numberOfCustomersToCreate = rng.Next(4, 12);
			}
			return numberOfCustomersToCreate;
		}		
		private void CreateListOfCustomers(Random random, int numberOfCustomers)
		{
			for (int i = 0; i < numberOfCustomers; i++)
			{
				customers.Add(new Customer(random));
			}

		}

		public void DecideRecipeForTheDay(Player player)
		{
			bool playerSettingRecipe = true;
			UserInterface.PromptUserForDesiredRecipe();
			do
			{
				UserInterface.DisplayCurrentInventory(player.inventory.lemons.Count, player.inventory.sugarCubes.Count, player.inventory.iceCubes.Count, player.inventory.cups.Count);
				UserInterface.DisplayRecipeOptions();
				//how many lemons/cup
				player.SetLemondadeRecipe(UserInterface.TakePlayerInput().ToLower());
				UserInterface.DoYouWantToContinueToSetRecipe();
				string input = UserInterface.TakePlayerInput().ToLower();
				if (input == "no")
				{
					playerSettingRecipe = false;
				}
				else if (input == "yes")
				{
					Console.Clear();
					continue;
				}
				else
				{
					UserInterface.DisplayInvalidSelectionMessage();
				}
			} while (playerSettingRecipe);
		}

	}
}
//sell lemonade
//customer chance to buy
//if true, add money to wallet, remove cup from pitcher