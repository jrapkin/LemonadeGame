using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
	public class Customer
	{
		private List<string> names;
		public string name;
		public Customer(Random passedRandom)
		{
			names = new List<string>() { "George", "Georgia", "The Sundance Kid", "Justin", "Steve", "David", "Mia", "Sara", "Anastacia", "Hayley", "Katelyn", "Danielle" };
			SetCustomerName(passedRandom);
			
		}

		//This addresses the single responsibility principle. SetCustomerName has one purpose which is to set the customer name based on a list of string names.
		private void SetCustomerName(Random passedRandom)
		{
			int randomName = passedRandom.Next(0, names.Count);
			name = names[randomName];
		}

		public bool ChanceToBuy(Recipe recipe, Random passedRandom)
		{
			if (recipe.pricePerCup <= 1 && passedRandom.NextDouble() >= .4)
			{
				return true;
			}
			else if (recipe.pricePerCup >= 1 && passedRandom.NextDouble() <= .8)
			{
				return true;
			}

			else
			{
				return false;
			}

		}


	}
}
