using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Server.Model;
using ProyectoFinal.Shared.DTOs;

namespace ProyectoFinal.Server.Controllers
{
    [Route("api/ventas")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public VentasController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<VentaDTO>>> GetAlumnos()
        {
            var ventas = await context.Ventas.ToListAsync();

            var ventasDto = new List<VentaDTO>();

            foreach (var venta in ventas)
            {
                var ventaDTO = new VentaDTO();
                ventaDTO.Id = venta.Id;
                ventaDTO.IdProducto = venta.IdProducto;
                ventaDTO.FechaVenta = venta.FechaVenta;

                ventasDto.Add(ventaDTO);
            }
            return ventasDto;
        }
    }
}
