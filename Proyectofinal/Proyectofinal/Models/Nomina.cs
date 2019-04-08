namespace Proyectofinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nomina")]
    public partial class Nomina
    {
        public int id { get; set; }

        [StringLength(4)]
        public string Año { get; set; }

        [StringLength(2)]
        public string Mes { get; set; }

        [Column(TypeName = "money")]
        public decimal? Monto_total { get; set; }
    }
}
