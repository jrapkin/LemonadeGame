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


        public void SetLemondadeRecipe(string itemToAddToRecipe)
        {
            
            if (itemToAddToRecipe == "1" || itemToAddToRecipe == "lemons")
            {
                UserInterface.PromptForNumberOfItems("lemons");

                inventory.RemoveItemsFromInventory(Convert.ToInt32(UserInterface.TakePlayerInput()), inventory.lemons);
            }
            else if (itemToAddToRecipe == "2" || itemToAddToRecipe == "sugar cubes")
            {
                UserInterface.PromptForNumberOfItems("sugar cubes");

                inventory.RemoveItemsFromInventory(Convert.ToInt32(UserInterface.TakePlayerInput()), inventory.sugarCubes);

            }
            else if (itemToAddToRecipe == "3" || itemToAddToRecipe == "ice cubes")
            {
                UserInterface.PromptForNumberOfItems("ice cubes");

                inventory.RemoveItemsFromInventory(Convert.ToInt32(UserInterface.TakePlayerInput()), inventory.iceCubes);
            }
            else if (itemToAddToRecipe == "4" || itemToAddToRecipe == "cups")
            {
                UserInterface.PromptForNumberOfItems("cups");

                inventory.RemoveItemsFromInventory(Convert.ToInt32(UserInterface.TakePlayerInput()), inventory.cups);

            }
            else
            {
                UserInterface.DisplayInvalidSelectionMessage();
            }
        }
    }
}
