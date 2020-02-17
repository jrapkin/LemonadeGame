using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
	class Weather
	{
		//member variables
		public string condition;
		public int temperature;
		private List<string> weatherConditions;
		Random randomRoll;


		public Weather(Random passedRandom)
		{

			weatherConditions = new List<string>() { "sunny", "overcast", "foggy", "rainy", "stormy" };
			randomRoll = passedRandom;
			GenerateRandomCondition();
			temperature = GenerateRandomTemperature();

		}

		//methods
		private void GenerateRandomCondition()
		{
			int generatedCondition = randomRoll.Next(0, weatherConditions.Count);
			condition = weatherConditions[generatedCondition];

		}
		private int GenerateRandomTemperature()
		{
			int randomTemperature = 0;
			switch (condition)
			{
				case "sunny":
					randomTemperature = randomRoll.Next(75, 111);
					break;

				case "overcast":
					randomTemperature = randomRoll.Next(60, 76);
					break;
				case "foggy":
					randomTemperature = randomRoll.Next(55, 66);
					break;
				case "rainy":
					randomTemperature = randomRoll.Next(50, 70);
					break;
				case "stormy":
					randomTemperature = randomRoll.Next(65, 76);
					break;
				default:
					break;
			}

			return randomTemperature;
		}
		

		//can i do this from the static class
/*		public void DisplayTheDailyWeather()
		{
			Console.WriteLine($"It is {temperature} degrees and {condition} today.");
		}*/


	}
}
