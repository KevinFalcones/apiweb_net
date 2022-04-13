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
    [Route("[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<SettingsController> _logger;
        public ActionResult Index()
        {
            IEnumerable<IConfigurationSection> settings = _configuration.GetSection("Settings").GetChildren();
            return new OkObjectResult(JsonSerializer.Serialize(settings));
        }

        public SettingsController(ILogger<SettingsController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
    }
}
