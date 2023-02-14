using logismart_api.Context;
using logismart_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace logismart_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OperatoriController : ControllerBase
    {
        private readonly MagazzinoContext magazzinoContext;

        public OperatoriController(MagazzinoContext context) 
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
