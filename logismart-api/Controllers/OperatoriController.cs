using LogiSmart.Api.Context;
using LogiSmart.Api.Models.Generics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LogiSmart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OperatoriController : ControllerBase
    {
        private readonly MagazziniContext magazzinoContext;

        public OperatoriController(MagazziniContext context) 
        {
            magazzinoContext = context;
        }


        [HttpPost]
        [Route("InsertOperatore")]
        public IActionResult InsertOperatore(Operatore operatore)
        {
            if (ModelState.IsValid)
            {
                magazzinoContext.Operatori.Add(operatore);
                magazzinoContext.SaveChanges();
                return Ok();
            }

            IEnumerable<ModelError> allErrors = ModelState
                .Values
                .SelectMany(v => v.Errors);
            
            return BadRequest(allErrors.ToString());
        }

        [HttpGet]
        [Route("GetOperatori")]
        public IActionResult GetOperatori()
        {
            List<Operatore> operatoriList = magazzinoContext.Operatori
                .Select(op => op).ToList();

            return Ok(operatoriList);
        }

        [HttpGet]
        [Route("GetOperatoriByAzienda")]
        public IActionResult GetOperatoriByAzienda(long IdAzienda)
        {
            List<Operatore> operatoreList = magazzinoContext.Operatori
                .Where(op => op.Azienda.Id == IdAzienda).ToList();

            return Ok(operatoreList);
        }
    }
}
