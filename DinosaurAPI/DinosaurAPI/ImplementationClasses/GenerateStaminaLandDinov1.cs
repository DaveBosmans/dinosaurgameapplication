using DinosaurAPI.HelperClasses;
using DinosaurAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.ImplementationClasses
{
    public class GenerateStaminaLandDinov1 : IStatsGenerator
    {
        //This Implementation Generates Stamina stats for Landdinosaur
        //Im keeping these implementations to each separate type of dino by choice so i got more control in the future to balance out the game for each type of dinosaur.
        public double GenerateStats()
        {
            GenerateRandomStatHelperLandDino generateStamina = new GenerateRandomStatHelperLandDino();

            double responseStamina = generateStamina.GenerateRandomStaminaLandDino();

            return responseStamina;
        }
    }
}
