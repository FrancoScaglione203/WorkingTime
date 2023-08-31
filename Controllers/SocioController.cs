using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkingTime.Entities;
using WorkingTime.DTOs;

namespace WorkingTime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocioController : ControllerBase
    {
        [HttpGet]
        [Route("Socios")]
        public IActionResult Socios()
        {
            return Ok("Todos los socios");
        }


        [HttpPost]
        [Route("Agregar")]
        public IActionResult Agregar(SocioDto socio)
        {
            return Unauthorized("No se pudo agregar socio");
        }


        [HttpPut]
        [Route("Editar")]
        public IActionResult EditarSocio(SocioDto socio)
        {
            return Ok(socio);
        }


        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult EliminarSocio(int id)
        {
            return Ok($"Se elimino el elemento {id} correctamente");
        }
    }
}
