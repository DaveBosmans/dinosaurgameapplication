using DinosaurAPI.DatabaseContext;
using DinosaurAPI.JSONInputClasses;
using DinosaurAPI.JSONOutputClasses;
using DinosaurAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.Interfaces
{
    interface IDinoGenerator
    {
        public DinoJSONResponse generateDino (DinoJSONInput dinoJSONInput, DinoDBContext _context);
    }
}
