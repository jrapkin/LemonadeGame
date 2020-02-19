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
            recipe = new Recipe();
        }

        // member methods (CAN DO)


        public void SetLemondadeRecipe(string itemToAddToRecipe)
        {
            

            if (itemToAddToRecipe == "1" || itemToAddToRecipe == "lemons")
            {
                recipe.amountOfLemons = UserInterface.PromptForNumberOfItemsInRecipe("lemons");
            }
            else if (itemToAddToRecipe == "2" || itemToAddToRecipe == "sugar cubes")
            {
                recipe.amountOfSugarCubes = UserInterface.PromptForNumberOfItemsInRecipe("sugar cubes");
            }
            else if (itemToAddToRecipe == "3" || itemToAddToRecipe == "ice cubes")
            {
                recipe.amountOfIceCubes = UserInterface.PromptForNumberOfItemsInRecipe("ice cubes");
            }
            else if (itemToAddToRecipe == "4" || itemToAddToRecipe == "cups")
            {
                
                UserInterface.AskForPricePerCup();
                bool UserInputIsADouble = false;
                while (UserInputIsADouble == false || recipe.pricePerCup < 0 )
                {
                    UserInputIsADouble = double.TryParse(UserInterface.TakePlayerInput(), out recipe.pricePerCup);
                }
                 

            }
            else
            {
                UserInterface.DisplayInvalidSelectionMessage();
            }
        }

       /* public void CreatePitcherOfLemonade()
        {
            inventory.RemoveItemsFromInventory(Convert.ToInt32(UserInterface.TakePlayerInput()), inventory.lemons);
            inventory.RemoveItemsFromInventory(Convert.ToInt32(UserInterface.TakePlayerInput()), inventory.sugarCubes);
            inventory.RemoveItemsFromInventory(Convert.ToInt32(UserInterface.TakePlayerInput()), inventory.iceCubes);
            inventory.RemoveItemsFromInventory(Convert.ToInt32(UserInterface.TakePlayerInput()), inventory.cups);

        }*/
    }
}
