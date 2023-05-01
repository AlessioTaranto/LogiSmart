using LogiSmart.Api.Context;
using LogiSmart.Api.Models.Generics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LogiSmart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AziendeController : ControllerBase
    {
        private readonly MagazziniContext magazzinoContext;

        public AziendeController(MagazziniContext magazzinoContext)
        {
            this.magazzinoContext = magazzinoContext;
        }

        [HttpPost]
        [Route("InsertAzienda")]
        public IActionResult InsertAzienda(Azienda azienda)
        {
            if (ModelState.IsValid)
            {
                magazzinoContext.Aziende.Add(azienda);
                magazzinoContext.SaveChanges();
                return Ok(azienda);
            }

            IEnumerable<ModelError> allErrors = ModelState
                .Values
                .SelectMany(v => v.Errors);

            return BadRequest(allErrors.ToString());
        }

        [HttpGet]
        [Route("GetAziende")]
        public IActionResult GetAziende()
        {
            List<Azienda> aziendaList = magazzinoContext.Aziende
                .Select(az => az).ToList();

            return Ok(aziendaList);
        }
    }
}
