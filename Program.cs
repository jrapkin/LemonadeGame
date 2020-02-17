using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Weather weather = new Weather();
            
            weather.SetWeatherCondition(weather.GenerateRandomCondition());


            Console.WriteLine(weather.condition);
            Console.ReadLine();
/*            bool newGame = game.CheckForNewGame();
            if (newGame == true)
            {
                game.RunGame();
            }*/


        }
    }
}
