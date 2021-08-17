using DinosaurAPI.HelperClasses;
using DinosaurAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.ImplementationClasses
{
    public class GenerateFoodLandDinov1 : IStatsGenerator
    {
        public double GenerateStats()
        {
            GenerateRandomStatHelperLandDino generateFood = new GenerateRandomStatHelperLandDino();
            var responseFood = generateFood.GenerateRandomFoodLandDino();
            return responseFood;
        }
    }
}
