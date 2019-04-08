namespace Proyectofinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Departamento")]
    public partial class Departamento
    {
        public int id { get; set; }
       // [Required]
        public int? CodigoDepatamento { get; set; }
      //  [Required]
        [StringLength(20)]
        public string Nombre { get; set; }
    }
}
