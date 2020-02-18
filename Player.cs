using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public string name;
        public Recipe recipe;
        public Pitcher pitcher;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        // member methods (CAN DO)

       
        public void BuyItems()
        {
			string userInput = UserInterface.TakePlayerInput().ToLower();

			//user picks item from list
			do
			{
				bool validInput = false;

				switch (userInput)
				{
					case "1":
					case "lemon":

						int numberOfLemons = UserInterface.GetNumberOfItems("lemons");
						inventory.AddLemonsToInventory(numberOfLemons);
						validInput = true;
						break;

					case "2":
					case "sugar cubes":
						int numberOfSugarCubes = UserInterface.GetNumberOfItems("sugar cubes");
						inventory.AddLemonsToInventory(numberOfSugarCubes);
						validInput = true;
						break;
					case "3":
					case "ice cubes":
						int numberOfIceCubes = UserInterface.GetNumberOfItems("ice cubes");
						inventory.AddLemonsToInventory(numberOfIceCubes);
						validInput = true;
						break;
					case "4":
					case "cups":
						int numberOfCups = UserInterface.GetNumberOfItems("cups");
						inventory.AddLemonsToInventory(numberOfCups);
						validInput = true;
						break;


					default:
						UserInterface.DisplayInvalidSelectionMessage();
						break;
						
				}
			} while (false);
		}
    }
}
