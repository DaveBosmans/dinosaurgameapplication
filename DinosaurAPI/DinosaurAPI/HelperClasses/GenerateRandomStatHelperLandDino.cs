using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.HelperClasses
{
    public class GenerateRandomStatHelperLandDino
    {
        //Generates Health for landdinosaur between two double numbers
        public double GenerateRandomHealthLandDino()
        {
            Random random = new Random();
            //Set number between 300 and 500 for the stats which will be generated
            return random.Next(300, 500);
        }

        //Generates Strenght for landdinosaur between two double numbers
        public double GenerateRandomStrenghtLandDino()
        {
            Random random = new Random();
            //Stat return between the two double numbers below
            return random.Next(50, 150);
        }

        //Generates Stamina for landdinosaur between two double numbers
        public double GenerateRandomStaminaLandDino()
        {
            Random random = new Random();
            //Stat return between the two double numbers below
            return random.Next(300, 800);
        }

        //Generates Defence for landdinosaur between two double numbers
        public double GenerateRandomDefenceLandDino()
        {
            Random random = new Random();
            //Stat return between the two double numbers below
            return random.Next(20, 100);
        }

        //Generates Intelligence for landdinosaur between two double numbers
        public double GenerateRandomIntelligenceLandDino()
        {
            Random random = new Random();
            //Stat return between the two double numbers below
            return random.Next(10, 30);
        }

        //Generates Food for landdinosaur between two double numbers
        public double GenerateRandomFoodLandDino()
        {
            Random random = new Random();
            //Stat return between the two double numbers below
            return random.Next(200, 300);
        }
    }
}
