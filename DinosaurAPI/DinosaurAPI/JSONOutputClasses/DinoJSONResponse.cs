using DinosaurAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.JSONOutputClasses
{
    public class DinoJSONResponse : DinoModel
    {
        public string CreatedDinoMessage { get; set; }
    }
}
