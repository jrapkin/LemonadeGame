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

		public Weather(Random random)
		{

			weatherConditions = new List<string>() { "sunny", "overcast", "foggy", "rainy", "stormy" };
			GenerateRandomCondition(random);
			temperature = GenerateRandomTemperature(random);
		}

		//methods
		private void GenerateRandomCondition(Random passedRandom)
		{
			int generatedCondition = passedRandom.Next(0, weatherConditions.Count);
			condition = weatherConditions[generatedCondition];

		}
		private int GenerateRandomTemperature(Random passedRandom)
		{
			int randomTemperature = 0;
			switch (condition)
			{
				case "sunny":
					randomTemperature = passedRandom.Next(80, 111);
					break;

				case "overcast":
					randomTemperature = passedRandom.Next(66, 80);
					break;
				case "foggy":
					randomTemperature = passedRandom.Next(55, 66);
					break;
				case "rainy":
					randomTemperature = passedRandom.Next(50, 70);
					break;
				case "stormy":
					randomTemperature = passedRandom.Next(65, 76);
					break;
				default:
					break;
			}

			return randomTemperature;
		}
		



	}
}
