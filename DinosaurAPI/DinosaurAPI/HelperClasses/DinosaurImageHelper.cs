using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.HelperClasses
{
    public class DinosaurImageHelper
    {
        //This will be a list of character images which will be assigned to the dinosaur randomly when created a dinosaur
        public string GenerateLandDinoImage()
        {
            string returnedLandDinoImage = "";

            List<string> ListOfImages = new List<string>();
            ListOfImages.Add("https://i.postimg.cc/MGKCFkj9/Tyrannosaurus-Rex-H03-2k.png");
            ListOfImages.Add("https://i.postimg.cc/6QfQdNxz/Triceratops-H15-2k.png");
            ListOfImages.Add("https://i.postimg.cc/4NpnJc2r/Brachiosaurus-Standing-Pose-H15-2k.png");

            //Generates a numebr between 0 and 2 to pick a random image.
            GenerateRandomNumberHelper generateRandomNumberHelper = new GenerateRandomNumberHelper();
            
            int pickRandomImageNumber = generateRandomNumberHelper.GenerateRandomIntLandDinosaurImage();

            returnedLandDinoImage = ListOfImages[pickRandomImageNumber];

            return returnedLandDinoImage;
        }

    }
}
