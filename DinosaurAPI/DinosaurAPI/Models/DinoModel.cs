using DinosaurAPI.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.Models
{
    //This is the model for the dinosaur which derrives from BaseUniqueID
    //This model will be stored into the database.
    public class DinoModel : BaseUniqueID
    {
        public int DinoLevel { get; set; }
        public string DinosaurName { get; set; }
        public string TypeOfDino { get; set; }
        public double Health { get; set; }
        public double Stamina { get; set; }
        public double Strenght { get; set; }
        public double Defence { get; set; }
        public double Food { get; set; }
        public double Intelligence { get; set; }
        public string ImageLink { get; set; }
    }
}
