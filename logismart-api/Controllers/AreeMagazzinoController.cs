using LogiSmart.Api.Context;
using LogiSmart.Api.Models.Generics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LogiSmart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AreeMagazzinoController : ControllerBase
    {
        private readonly MagazziniContext magazzinoContext;

        public AreeMagazzinoController(MagazziniContext magazzinoContext)
        {
            this.magazzinoContext = magazzinoContext;
        }

        [HttpPost]
        [Route("InsertAreaMagazzino")]
        public IActionResult InsertAreaMagazzino(AreaMagazzino areaMagazzino)
        {
            if (ModelState.IsValid)
            {
                magazzinoContext.AreeMagazzino.Add(areaMagazzino);
                magazzinoContext.SaveChanges();
                return Ok();
            }

            IEnumerable<ModelError> allErrors = ModelState
                .Values
                .SelectMany(v => v.Errors);

            return BadRequest(allErrors.ToString());
        }

        [HttpGet]
        [Route("GetAreeMagazzino")]
        public IActionResult GetAreeMagazzino()
        {
            List<AreaMagazzino> areeLsit = magazzinoContext.AreeMagazzino
                .Select(ar => ar).ToList();

            return Ok(areeLsit);
        }

        [HttpGet]
        [Route("GetAreeMagazzinoByIdMagazzino")]
        public IActionResult GetAreeMagazzinoByIdMagazzino(long idMagazzino)
        {
            List<AreaMagazzino> aree = magazzinoContext.AreeMagazzino
                .Where(ar => ar.Id == idMagazzino).ToList();

            return Ok(aree);
        }
    }
}
