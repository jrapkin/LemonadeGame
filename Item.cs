using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public abstract class Item
    {
        //the item class addresses the "L" in solid (Liskov substitution principle) as it is the parent class to Lemon, IceCube, Lemon etc. This allows all of the child classes to inherit the variables of this class and the associated parent (Item) and in this case all of the child classes inherit a "name" variable.
        public string name;

        static Item()
        {

        }

    }
}
