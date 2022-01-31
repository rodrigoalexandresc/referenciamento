using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using referenciamento.api.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace referenciamento.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProntuarioController : ControllerBase
    {
        private readonly ReferenciamentoDbContext _dbContext;

        public ProntuarioController(ReferenciamentoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var prontuarios = await _dbContext.Prontuarios.ToListAsync();
            return Ok(prontuarios);
        }

        [HttpPost]
        public async Task<IActionResult> Import()
        {

        }
    }
}
