using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Daily2
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeopleToFeedForAWeek = 25;
            int Fruit = 2;
            int Plant = 0;
            int FruitForPlanting = 1;
            int PlantsFruitCanMake = 2;
            int weeks = 20;

            WriteLine("Weeks " + " Fruit " + " Plant" + "       Fruits taken For Planting : " + FruitForPlanting + "       Plants, one fruit can make : 2");
            for (int i = 0; i < weeks; i++)
            {
                
                Fruit = Fruit + Plant;

                if (Fruit >= FruitForPlanting)
                {

                  Plant = (Plant + (FruitForPlanting * PlantsFruitCanMake));
                    
                    Fruit = Fruit - FruitForPlanting;
                }

                
                if (PeopleToFeedForAWeek <= Fruit)
                {
                    WriteLine(" " + i.ToString() + "       " + Fruit.ToString() + "       " + Plant.ToString() + " Enough for  " + PeopleToFeedForAWeek + " People to be supported for " + (Fruit / PeopleToFeedForAWeek) + " Weeks and " + (Fruit % PeopleToFeedForAWeek) + " Fruit rest." );
                }
                else
                { 
                    WriteLine(" " + i.ToString() + "       " + Fruit.ToString() + "       " + Plant.ToString());
                }
            }

            ReadLine();
        }
    }
}
