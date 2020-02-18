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


		//constructor
		public Day(Random random, string day)
		{
			weather = new Weather(random);
			theDay = day;
			customers = new List<Customer>();
			CreateListOfCustomers(random, DetermineNumberOfCustomers(random));
			//UserInterface.DisplayWeather(theDay, weather.condition, weather.temperature);
			
		}

		//Member method 
		private int DetermineNumberOfCustomers(Random rng)
		{
			int numberOfCustomersToCreate = 0;

			if (weather.condition == "Sunny" && (weather.temperature >= 80 || weather.temperature < 110))
			{
				 numberOfCustomersToCreate = rng.Next(1,15);
			}
			else if (weather.condition == "overcast" && (weather.temperature >= 66 || weather.temperature < 79))
			{
				numberOfCustomersToCreate = rng.Next(1, 10);
			}
			else if (weather.condition == "foggy" && (weather.temperature >= 55 || weather.temperature < 65))
			{
				numberOfCustomersToCreate = rng.Next(1,8);
			}
			else if (weather.condition == "rainy" && (weather.temperature >= 50 || weather.temperature < 79))
			{
				numberOfCustomersToCreate = rng.Next(1,5);
			}
			else if (weather.condition == "stormy" && (weather.temperature >= 65 || weather.temperature < 75))
			{
				numberOfCustomersToCreate = 0;
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

	}
}
