namespace Proyectofinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("calnomina")]
    public partial class calnomina
    {
        public int id { get; set; }

        [StringLength(20)]
        public string Nombre { get; set; }

        [Column(TypeName = "money")]
        public decimal? salario { get; set; }
    }
}
