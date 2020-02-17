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
			
		}

		//Member method

	}
}
