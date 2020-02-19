using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
	public class Pitcher
	{
		public int playerCupsOfLemonade;
		public int totalCupsPerPitcher;
		public int pitcherOfLemonade;

		public Pitcher(Player player, Recipe playerRecipe)
		{
			pitcherOfLemonade = 0;
			totalCupsPerPitcher = 10;
			playerCupsOfLemonade = pitcherOfLemonade * totalCupsPerPitcher;

		}

	}
}
