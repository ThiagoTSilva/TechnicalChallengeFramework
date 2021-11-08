using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalChallengeFrameworkApi.Domain;
using TechnicalChallengeFrameworkApi.Services.Interfaces;

namespace TechnicalChallengeFrameworkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecomposeNumberController : ControllerBase
    {
        private readonly IDecomposeService service;

        public DecomposeNumberController(IDecomposeService service)
        {
            this.service = service;
        }

        [HttpGet("{number:int}")]
        public IActionResult Get(int number)
        {
            var result = service.KnowNumberDivisor(float.Parse(number.ToString()));

            return Ok(result);
        }
    }
}
