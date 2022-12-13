using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Shared.DTOs
{
    public class VentaDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int FechaVenta { get; set; }

    }
}
