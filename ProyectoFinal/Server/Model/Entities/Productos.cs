using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Server.Model.Entities
{
    public class Productos
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Lote { get; set; }

        public int PrecioVenta { get; set; }

        public int Pasillo { get; set; }

        public int NumeroFila { get; set; }

        public List<Clientes> Clientes { get; set;}

        public List<Ventas> Ventas { get; set; }



    }
}
