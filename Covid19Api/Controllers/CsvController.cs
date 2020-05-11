using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19Api.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Covid19Api.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("CsvController")]
    public class CsvController : ControllerBase, ICsvController
    {
        private ICsvService _csvService;

        public CsvController(
            ICsvService csvService
        )
        {
            _csvService = csvService;
            // _csvService = new CsvService();
        }

        [HttpGet("GetAllDataFromCountriesAggregated")]
        public IActionResult GetAllDataFromCountriesAggregated()
        {
            try
            {
                var content = _csvService.GetAllDataFromCountriesAggregated();

                if (!content.Any())
                {
                    return NoContent() ;
                }
                
                return  Ok(content);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                 return StatusCode(500);
            }
        }
        
        [HttpGet("GetAllDataFromWorldWideAggregated")]
        public IActionResult GetAllDataFromWorldWideAggregated()
        {
            try
            {
                return  Ok(_csvService.GetAllDataFromWorldWideAggregated());

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }
        
        [HttpGet("GetAllDataFromKeyCountriesPivoted")]
        public IActionResult GetAllDataFromKeyCountriesPivoted()
        {
            try
            {
                return  Ok(_csvService.GetAllDataFromKeyCountriesPivoted());

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }
        
        [HttpGet("GetAllDataFromTimeSeries19CovidCombined")]
        public IActionResult GetAllDataFromTimeSeries19CovidCombined()
        {
            try
            {
                return  Ok(_csvService.GetAllDataFromTimeSeries19CovidCombined());

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }
    }
}