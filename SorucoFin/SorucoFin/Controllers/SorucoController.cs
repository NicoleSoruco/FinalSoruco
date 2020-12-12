using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SorucoFin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SorucoController : ControllerBase
    {
        [HttpGet]
        public string Operaciones (int numero)
        {
            if (numero > 0)
                return "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";
            else if (numero == 0)
                return "Realizado por Nicole Soruco";
            else return "ERROR";
        }
    }
}
