using logismart_api.Context;
using logismart_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace logismart_api.Controllers
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
