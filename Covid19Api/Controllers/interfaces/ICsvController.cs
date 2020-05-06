using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Covid19Api.Controllers
{
    public interface ICsvController
    {
        public IActionResult GetAllFileNames();
    }
}