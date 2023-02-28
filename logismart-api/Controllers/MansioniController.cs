using LogiSmart.Api.Context;
using LogiSmart.Api.Models.Generics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LogiSmart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MansioniController : ControllerBase
    {
        private readonly MagazziniContext magazzinoContext;

        public MansioniController(MagazziniContext magazzinoContext)
        {
            this.magazzinoContext = magazzinoContext;
        }

        [HttpPost]
        [Route("InsertMansione")]
        public IActionResult InsertMansione(Mansione mansione)
        {
            if (ModelState.IsValid)
            {
                magazzinoContext.Mansioni.Add(mansione);
                magazzinoContext.SaveChanges();
                return Ok();
            }

            IEnumerable<ModelError> allErrors = ModelState
                .Values
                .SelectMany(v => v.Errors);

            return BadRequest(allErrors.ToString());
        }

        [HttpGet]
        [Route("GetMansioni")]
        public IActionResult GetMansioni()
        {
            List<Mansione> mansioniList = magazzinoContext.Mansioni
                .Select(ar => ar).ToList();

            return Ok(mansioniList);
        }
    }
}
