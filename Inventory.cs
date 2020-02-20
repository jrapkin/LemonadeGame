﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Inventory
    {
        public List<Item> lemons;
        public List<Item> sugarCubes;
        public List<Item> iceCubes;
        public List<Item> cups;

        public Inventory()
        {
            lemons = new List<Item>();
            sugarCubes = new List<Item>();
            iceCubes = new List<Item>();
            cups = new List<Item>();
        }

        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for(int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }

        public void RemoveItemsFromInventory(int numberOfItemsToRemove, List<Item> item)
        {
            item.RemoveRange(0, numberOfItemsToRemove);
        }
    }
}
