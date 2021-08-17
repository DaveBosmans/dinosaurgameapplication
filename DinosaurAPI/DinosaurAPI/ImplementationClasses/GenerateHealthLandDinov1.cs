using DinosaurAPI.HelperClasses;
using DinosaurAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.ImplementationClasses
{
    public class GenerateHealthLandDinov1 : IStatsGenerator
    {
        public double GenerateStats()
        {
            GenerateRandomStatHelperLandDino generateHealth = new GenerateRandomStatHelperLandDino();

            double responseHealth = generateHealth.GenerateRandomHealthLandDino();

            return responseHealth;
        }
    }
}
