using DinosaurAPI.HelperClasses;
using DinosaurAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.ImplementationClasses
{
    public class GenerateIntelligenceLandDinov1 : IStatsGenerator
    {
        public double GenerateStats()
        {
            GenerateRandomStatHelperLandDino generateIntelligence = new GenerateRandomStatHelperLandDino();
            var intelligenceResponse = generateIntelligence.GenerateRandomIntelligenceLandDino();
            return intelligenceResponse;
        }
    }
}
