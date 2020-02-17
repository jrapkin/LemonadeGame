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

		//constructor
		public Day()
		{
			weather = new Weather();
			weather.GenerateRandomTemperature();
		}

		//Member method

	}
}
