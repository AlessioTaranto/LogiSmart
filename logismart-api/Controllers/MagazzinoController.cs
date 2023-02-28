using LogiSmart.Api.Context;
using LogiSmart.Api.Models.Dto;
using LogiSmart.Api.Models.Generics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace LogiSmart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MagazzinoController : ControllerBase
    {
        private MagazziniContext magazzinoContext;

        public MagazzinoController(MagazziniContext ctx) 
        {
            magazzinoContext = ctx;
        }

        [HttpPost]
        [Route("InsertMagazzino")]
        public IActionResult InsertMagazzino([FromBody] MagazzinoDto magazzinoDto)
        {
            if (ModelState.IsValid)
            {
                Magazzino magazzino = magazzinoDto.ToDbEntity();

                magazzinoContext.Magazzini.RemoveRange(magazzinoContext.Magazzini);
                magazzinoContext.Magazzini.Add(magazzino);
                magazzinoContext.SaveChanges();

                return Ok(magazzino);
            }

            IEnumerable<ModelError> allErrors = ModelState
                .Values
                .SelectMany(v => v.Errors);

            return BadRequest(allErrors.ToString());
        }

        [HttpGet]
        [Route("GetMagazzino")]
        public IActionResult GetMagazzino()
            => Ok(magazzinoContext.Magazzini.FirstOrDefault());

        [HttpGet]
        [Route("IsMagazzinoRegistered")]
        public IActionResult IsMagazzinoRegistered() 
            => Ok(magazzinoContext.Magazzini.Any());
    }
}
