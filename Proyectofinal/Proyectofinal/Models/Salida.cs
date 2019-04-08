namespace Proyectofinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Salida")]
    public partial class Salida
    {
        public int id { get; set; }
        [Required]
        [StringLength(20)]
        public string Empleado { get; set; }

        [Required(ErrorMessage = "Renuncia, Despido, Desahucio")]
        [StringLength(9)]
        public string TipoDesalida { get; set; }
        [Required]
        [StringLength(50)]
        public string motivo { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? fechaDesalida { get; set; }

        public int? Codigo_Empleado { get; set; }
      
        public virtual Empleado Empleado1 { get; set; }
    }
}
