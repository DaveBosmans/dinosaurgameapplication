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
        //This class generates the stamina for a landdinosaur
        public double GenerateStats()
        {
            GenerateRandomStatHelperLandDino generateStamina = new GenerateRandomStatHelperLandDino();

            double responseHealth = generateStamina.GenerateRandomStaminaLandDino();

            return responseHealth;
        }
    }
}
