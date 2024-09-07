using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var stocks = _context.Stocks.ToList();
            return Ok(stocks);
        }
        [HttpGet("{id}")] //~getParameter
    public IActionResult GetById([FromRoute] int id)
    {
        var stockS = _context.Stocks.Find(id);
        if(stockS == null)
        {
            return NotFound();
        }
        return Ok(stockS);
    }

    }
}