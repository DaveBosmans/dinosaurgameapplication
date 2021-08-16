using DinosaurAPI.JSONInputClasses;
using DinosaurAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.Interfaces
{
    interface IDinoGenerator
    {
        public DinoModel dinoModel(DinoJSONInput dinoJSONInput);
    }
}
