using System.Collections.Generic;
using System.Threading.Tasks;
using Covid19Api.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Covid19Api.Controllers
{
    [ApiController]
    [Route("CsvController")]
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

        [HttpGet]
        public IActionResult GetAllFileNames()
        {
            var list = new List<string>(){
                "test"
            };

            return Ok(list);
        }
    }

}