using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroDetalle_AP1.Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
    }
}