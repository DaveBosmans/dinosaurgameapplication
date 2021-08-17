using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.HelperClasses
{
    //This class generates a random number
    public class GenerateRandomNumberHelper
    {

        //generates random number to pick a random image for land dinosaur. Increase number if more images/characters are added.
        public int GenerateRandomIntLandDinosaurImage()
        {
            var rand = new Random();
            int returnedNumber = rand.Next(0, 2);

            return returnedNumber;
        }
    }
}
