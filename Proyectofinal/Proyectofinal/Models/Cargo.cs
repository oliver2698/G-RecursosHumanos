namespace Proyectofinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cargo")]
    public partial class Cargo
    {
        public int id { get; set; }

    //    [Required]
        [Column("Cargo")]
        [StringLength(20)]
        public string Cargo1 { get; set; }
    }
}
