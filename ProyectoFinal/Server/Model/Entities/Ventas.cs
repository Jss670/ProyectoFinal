using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Server.Model.Entities
{
    public class Ventas
    {
        [Key]
       
        public int Id { get; set; }

        public int IdPruducto { get; set; }


        public int FechaVenta { get; set; }

        public List<Productos> Productos { get; set; }  
        public List<Registros> Registros { get; set; }

    }
}
