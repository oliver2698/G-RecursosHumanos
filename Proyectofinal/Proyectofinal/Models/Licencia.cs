namespace Proyectofinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Licencia")]
    public partial class Licencia
    {
        public int id { get; set; }
        [Required]
        [StringLength(20)]
        public string Empleado { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? Desde { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? Hasta { get; set; }
        [Required]
        [StringLength(20)]
        public string Motivo { get; set; }
        [Required]
        [StringLength(20)]
        public string Comentario { get; set; }

        public int? Codigo_Empleado { get; set; }
    
        public virtual Empleado Empleado1 { get; set; }
    }
}
