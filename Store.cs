using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Store
    {

        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;


        public Store()
        {
            pricePerLemon = .35;
            pricePerSugarCube = .1;
            pricePerIceCube = .01;
            pricePerCup = .2;
        }


        public void PlayerIsInTheStore(Player player)
        {
            UserInterface.StorePurchaseMessage();

            bool playerWantsToBuy = true;

            do
            {
                UserInterface.DisplayMoneyHeld(player.wallet.Money);
                UserInterface.DisplayStorePrices(pricePerLemon, pricePerSugarCube, pricePerIceCube, pricePerCup);
                UserInterface.DisplayCurrentInventory(player.inventory.lemons.Count, player.inventory.sugarCubes.Count, player.inventory.iceCubes.Count, player.inventory.cups.Count);
                UserInterface.DisplayItemList();
                WhatPlayerWantsToBuy(player);
                UserInterface.DoYouWantToContinueToBuy();
                string playerBuyingItems = UserInterface.TakePlayerInput().ToLower();
                if (playerBuyingItems == "no")
                {
                    playerWantsToBuy = false;
                }
                else if (playerBuyingItems == "yes")
                {
                    continue;
                }
                else
                {
                    UserInterface.DisplayInvalidSelectionMessage();
                }
            } while (playerWantsToBuy);
        }

        private bool WhatPlayerWantsToBuy(Player player)
        {
            bool validInput = false;
            //user picks item from list
            while (validInput == false)
            {

                switch (UserInterface.ValidateInput())
                {
                    case 1:
                    
                        SellLemons(player);
                        return validInput = true;

                    case 2:
                        SellSugarCubes(player);
                        return validInput = true;
                    case 3:
                    
                        SellIceCubes(player);
                        return validInput = true;
                    case 4:
                        SellCups(player);
                        return validInput = true;

                    case 0:
                        return validInput = true;

                    default:
                        UserInterface.DisplayInvalidSelectionMessage();
                        return WhatPlayerWantsToBuy(player);
                }
            }
            return validInput;
        }

        
        public void SellLemons(Player player)
        {
            int lemonsToPurchase = UserInterface.GetNumberOfItems("lemons");
            double transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddLemonsToInventory(lemonsToPurchase);
            }
        }

        public void SellSugarCubes(Player player)
        {
            int sugarToPurchase = UserInterface.GetNumberOfItems("sugar cubes");
            double transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerSugarCube);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddSugarCubesToInventory(sugarToPurchase);
            }
        }

        public void SellIceCubes(Player player)
        {
            int iceCubesToPurchase = UserInterface.GetNumberOfItems("ice cubes");
            double transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddIceCubesToInventory(iceCubesToPurchase);
            }
        }

        public void SellCups(Player player)
        {
            int cupsToPurchase = UserInterface.GetNumberOfItems("cups");
            double transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddCupsToInventory(cupsToPurchase);
            }
        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
        {
            double transactionAmount = itemCount * itemPricePerUnit;
            return transactionAmount;
        }

        private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }
    }
}
