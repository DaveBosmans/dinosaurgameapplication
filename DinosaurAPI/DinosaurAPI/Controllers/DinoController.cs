using DinosaurAPI.DatabaseContext;
using DinosaurAPI.ImplementationClasses;
using DinosaurAPI.Interfaces;
using DinosaurAPI.JSONInputClasses;
using DinosaurAPI.JSONOutputClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinoController : ControllerBase
    {
        private DinoDBContext _context;
        public DinoController(DinoDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("GenerateDinosaurWithDatabasev1")]
        //This POST endpoint will create a random LANDDinosaur
        public ActionResult<DinoJSONResponse> GenerateDinoWithDataBase(DinoJSONInput dinoJSONInput)
        {
            //Initiate the response
            var tempGeneratedDinosaur = new DinoJSONResponse();

            //Initiate the implementation
            IDinoGenerator dinoGenerator = new GenerateLandDinov1();

            //Calling the generate dino function from implementation
            tempGeneratedDinosaur = dinoGenerator.generateDino(dinoJSONInput, _context);

            //Dinosaur is returned, this is a land dinosaur for now later on there will be various dinos.
            return tempGeneratedDinosaur;

        }

    }
}
