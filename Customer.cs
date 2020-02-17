using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
	class Customer
	{
		private List<string> names;
		public string name;
		public Customer(Random passedRandom)
		{
			names = new List<string>() { "George", "Georgia", "Justin", "Steve", "David", "Mia", "Sara", "Anastacia", "Hayley", "Katelyn", "Danielle" };
			SetCustomerName(passedRandom);
		}

		public void SetCustomerName(Random passedRandom)
		{
			int randomName = passedRandom.Next(0, names.Count);
			name = names[randomName];
			

		}
	}
}
