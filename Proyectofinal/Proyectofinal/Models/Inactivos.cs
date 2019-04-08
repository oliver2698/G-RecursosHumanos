namespace Proyectofinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inactivos
    {
        public int id { get; set; }

        [StringLength(20)]
        public string Nombre { get; set; }

        [StringLength(20)]
        public string Apellido { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha_de_ingreso { get; set; }

        [Column(TypeName = "money")]
        public decimal? salario { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }
    }
}
