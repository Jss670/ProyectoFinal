using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Server.Model.Entities
{
    public class Registros
    {
        [Key]

        public int Id { get; set; }

        public string NombreEmpleado { get; set; }

        public string NombreCliente { get; set; }

        public int IdEmpleado { get; set; }

        public int IdCliente { get; set; }

        public string Puesto { get; set; }

        public string Correo { get; set; }

        public int Telefono { get; set; }

        public int Edad { get; set; }

        public List<Clientes> Clientes { get; set;}
        public List<Ventas> Ventas { get; set; }



    }
}
