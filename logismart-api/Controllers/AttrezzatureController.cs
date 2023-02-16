using LogiSmart.Api.Context;
using LogiSmart.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LogiSmart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AttrezzatureController : ControllerBase
    {
        private readonly MagazziniContext magazzinoContext;

        public AttrezzatureController(MagazziniContext magazzinoContext)
        {
            this.magazzinoContext = magazzinoContext;
        }

        [HttpPost]
        [Route("InsertAttrezzatura")]
        public IActionResult InsertAttrezzatura(Attrezzatura attrezzatura)
        {
            if (ModelState.IsValid)
            {
                magazzinoContext.Attrezzature.Add(attrezzatura);
                magazzinoContext.SaveChanges();
                return Ok();
            }

            IEnumerable<ModelError> allErrors = ModelState
                .Values
                .SelectMany(v => v.Errors);

            return BadRequest(allErrors.ToString());
        }

        [HttpGet]
        [Route("GetAttrezzature")]
        public IActionResult GetAttrezzature()
        {
            List<Attrezzatura> attrezzaturaList = magazzinoContext.Attrezzature
                .Select(at => at).ToList();

            return Ok(attrezzaturaList);
        }

        [HttpGet]
        [Route("GetAttrezzatureByIdMansione")]
        public IActionResult GetAttrezzatureoByIdMansione(long idMansione)
        {
            List<Attrezzatura> attrezzaturaList = magazzinoContext.Attrezzature
                .Where(at => at.Id == idMansione).ToList();

            return Ok(attrezzaturaList);
        }
    }
}
