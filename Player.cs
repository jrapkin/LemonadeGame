using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Player
    {
        public Inventory inventory;
        public Wallet wallet;
        public string name;
        public Recipe recipe;
        public Pitcher pitcher;
        public int totalDailySales;
        

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }


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

            else if (itemToAddToRecipe == "4" || itemToAddToRecipe == "price per cup")
            {

                bool UserInputIsADouble = false;
                while (UserInputIsADouble == false || recipe.pricePerCup < 0)
                {
                    UserInterface.AskForPricePerCup();
                    UserInputIsADouble = double.TryParse(UserInterface.TakePlayerInput(), out recipe.pricePerCup);
                }

            }

            else
            {
                UserInterface.DisplayInvalidSelectionMessage();
            }
        }

        public bool CanCreatePitcher()
        {
            if (inventory.lemons.Count >= recipe.amountOfLemons && inventory.sugarCubes.Count >= recipe.amountOfSugarCubes && inventory.iceCubes.Count >= recipe.amountOfIceCubes && inventory.cups.Count >= pitcher.cupsInPitcher)
            {

                inventory.RemoveItemsFromInventory(recipe.amountOfLemons, inventory.lemons);
                inventory.RemoveItemsFromInventory(recipe.amountOfSugarCubes, inventory.sugarCubes);
                inventory.RemoveItemsFromInventory(recipe.amountOfIceCubes, inventory.iceCubes);
                inventory.RemoveItemsFromInventory(pitcher.cupsInPitcher, inventory.cups);

                return true;
            }
            else
            {

                return false;
            }

        }
    }

}
