using DinosaurAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.ImplementationClasses
{
    public class CreateUniqueIDv1 : ICreateUniqueID
    {
        public string CreateUniqueID()
        {
            var idResponse = "";
            //Creating a simple unique ID using GUID.
            Guid g = Guid.NewGuid();

            var gString = g.ToString();

            //Adding Date.
            DateTime thisDate = DateTime.Now;
            var day = thisDate.Day.ToString();
            var month = thisDate.Month.ToString();
            var year = thisDate.Year.ToString();

            idResponse = gString + day + month + year;

            return idResponse;
        }
    }
}
