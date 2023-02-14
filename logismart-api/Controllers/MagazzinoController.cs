using logismart_api.Context;
using logismart_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace logismart_api.Controllers
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
        public IActionResult InsertMagazzino(Magazzino magazzino)
        {
            if (ModelState.IsValid)
            {
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
    }
}
