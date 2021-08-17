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

        public double GenerateRandomStrenghtLandDino()
        {
            Random random = new Random();
            //Stat return between the two double numbers below
            return random.Next(50, 150);
        }

        public double GenerateRandomStaminaLandDino()
        {
            Random random = new Random();
            //Stat return between the two double numbers below
            return random.Next(300, 800);
        }

        public double GenerateRandomDefenceLandDino()
        {
            Random random = new Random();
            //Stat return between the two double numbers below
            return random.Next(20, 100);
        }

        public double GenerateRandomIntelligenceLandDino()
        {
            Random random = new Random();
            //Stat return between the two double numbers below
            return random.Next(10, 30);
        }

        public double GenerateRandomFoodLandDino()
        {
            Random random = new Random();
            //Stat return between the two double numbers below
            return random.Next(200, 300);
        }
    }
}
