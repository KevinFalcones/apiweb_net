using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<MathController> _logger;

        public MathController(ILogger<MathController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return new OkObjectResult("Math Controller: Add(value1, value2), Substract(value1,value2), Multiply(value1, value2), Divide(value1, value2)");
        }

        [HttpGet("Add")]
        public IActionResult Add(decimal value1, decimal value2)
        {
            return new OkObjectResult(Math.Add(value1,value2));
        }

        [HttpGet("Substract")]
        public IActionResult Substract(decimal value1, decimal value2)
        {
            return new OkObjectResult(Math.Substract(value1, value2));
        }

        [HttpGet("Multiply")]
        public IActionResult Multiply(decimal value1, decimal value2)
        {
            return new OkObjectResult(Math.Multiply(value1, value2));
        }

        [HttpGet("Divide")]
        public IActionResult Divide(decimal value1, decimal value2)
        {
            return new OkObjectResult(Math.Divide(value1, value2));
        }

    }
}
