using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProyectoFinal.Server.Model.Entities
{
    public class Clientes
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        public int Telefono { get; set; }

        public string Correo { get; set; }

        public DateOnly FechaRegistro;


        public List<Productos>? Productos { get; set; }
        public List<Registros>? Registros { get; set; }

    }
   
}
