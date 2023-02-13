using logismart_api.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace logismart_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MagazzinoController : ControllerBase
    {
        private readonly MagazzinoContext _context;

       
        public MagazzinoController(MagazzinoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult TestChiamata()
        {
            _context.Attivita.Add(new Models.Attivita());
            return Ok(_context.Attivita.Count());
        }
    }
}
