using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cellopark_server.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cellopark_server.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CheesesController : ControllerBase
    {
        private readonly ICheeseContext m_cheeseContext;
        public CheesesController(ICheeseContext cheeseContext)
        {
            m_cheeseContext = cheeseContext;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("prices")]
        public async Task<IActionResult> Prices()
        {
            var result = m_cheeseContext.GetCheeses();
            
            return Ok(result);
        }
    }
}
