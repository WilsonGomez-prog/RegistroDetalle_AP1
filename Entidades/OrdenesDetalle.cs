using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroDetalle_AP1.Entidades
{
    public class OrdenesDetalle
    {
        [Key]
        public int Id { get; set; }
        public int OrdenId { get; set; }
        public int ArticuloId { get; set; }
        public float Cantidad { get; set; }
        public float Precio { get; set; }
    }
}