using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    public class CoffeeMachine
    {
        private int waterAmount; //In milliLiters
        private int beansAmount; //in grams
        private bool isHeated;


        public CoffeeMachine(int water, int beans)
        {
            waterAmount = water;
            beansAmount = beans;
            isHeated = false;
        }

        private void Heatwater()
        {
            if (!isHeated)
            {
                Console.WriteLine("Heating water..");
                isHeated = true;
            }
        }

        private void GrindBeans(int amount)
        {
            if(beansAmount < amount)
            {
                throw new InvalidOperationException("Not enough coffe beans");
            }
            else
            {
                Console.WriteLine("Grinding coffe beans...");
            }
            beansAmount = beansAmount - amount;
        }

        //This is method will visible to User
        public void MakeEspresso()
        {
            Heatwater();
            GrindBeans(20);
            Console.WriteLine("Making Espresso...");
        }

        public void MakeLatte()
        {
            Heatwater();
            GrindBeans(25);
            Console.WriteLine("Making Latte..");
        }

        public int BeansLeft()
        {
            return beansAmount;
        }

        public int WaterLeft() 
        { 
            return beansAmount; 
        }


    }
}
