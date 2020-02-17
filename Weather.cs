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
		private Random randomTemperatureGenerator;
		private Random randomConditionSelector;

		public Weather()
		{
			weatherConditions = new List<string>() { "Sunny", "Overcast", "foggy", "rainy", "stormy" };
			randomConditionSelector = new Random();
			randomTemperatureGenerator = new Random();
		}

		//methods
		public void GenerateRandomTemperature()
		{
			temperature = randomTemperatureGenerator.Next(50, 110);
		}
		public int GenerateRandomCondition()
		{
			int generatedCondition = randomConditionSelector.Next(0, 5);

			return generatedCondition;
		}
		public void SetWeatherCondition(int randomRoll)
		{
			if (randomRoll == 0)
			{
				condition = weatherConditions[0];
			}
			else if (randomRoll == 1)
			{
				condition = weatherConditions[1];

			}
			else if (randomRoll == 2)
			{
				condition = weatherConditions[2];

			}
			else if (randomRoll == 3)
			{
				condition = weatherConditions[3];

			}
			else if (randomRoll == 4)
			{
				condition = weatherConditions[4];

			}

		}

		//can i do this from the static class
		public void DisplayTheTemperature()
		{
			Console.WriteLine($"The temperature for today is {temperature}");
		}

	}
}
