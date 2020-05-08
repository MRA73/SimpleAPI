using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching1"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 10).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        // [HttpGet("{Id}")]
        // public ActionResult<WeatherForecast> Get(string Id)
        // {
        //     var rng = new Random();
        //     var result = Enumerable.Range(1, 10).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray().FirstOrDefault(x => x.Summary.Equals(Id));

        //     if(result == null) return NotFound();
            
        //     return Ok(result);
        // }

        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> Get(int Id)
        {
            if(Summaries.Length > Id)
            {
                return Summaries[Id];
                 //return Ok(result);
            }

            return NotFound(); 
        }

        // [HttpGet("{Id}")]
        // public ActionResult<string> Get(string Id)
        // {
        //     var rng = new Random();
        //     var result = Enumerable.Range(1, 10).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray().FirstOrDefault(x => x.Summary.Equals(Id));

        //     if(result == null) return NotFound();
            
        //     return Ok(result.Summary);
        // }
    }
}
