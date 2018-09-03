using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace REST_WS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculadoraController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public string Index()
        {
            return "Este es un Get a la descripción de la Calculadora usando .NetCore 2.1.3 WebApi con GET";
        }
        [HttpPost]
        public int Suma([FromForm]string valor1, [FromForm]string valor2)
        {
            int resultado;
            return resultado = Convert.ToInt32(valor1) + Convert.ToInt32(valor2);

        }
        [HttpPost]
        public int Resta([FromForm]string valor1, [FromForm]string valor2)
        {
            int resultado;
            return resultado = Convert.ToInt32(valor1) - Convert.ToInt32(valor2);
        }
        [HttpPost]
        public int Multiplicacion([FromForm]string valor1, [FromForm]string valor2)
        {
            int resultado;
            return resultado = Convert.ToInt32(valor1) * Convert.ToInt32(valor2);
        }
        [HttpPost]
        public float Division([FromForm]string valor1, [FromForm]string valor2)
        {
            float resultado;
            return resultado = Convert.ToInt32(valor1) / Convert.ToInt32(valor2);
        }
    }
}
