namespace Proyectofinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            Licencia = new HashSet<Licencia>();
            Permisos = new HashSet<Permisos>();
            Salida = new HashSet<Salida>();
            Vacaciones = new HashSet<Vacaciones>();
        }

        public int id { get; set; }
      //  [Required]
        public int? Codigo_Empleado { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(20)]
        public string Apellido { get; set; }
        [Required]
        [StringLength(20)]
        public string Deparamento { get; set; }
        [Required]
        [StringLength(10)]
        public string telefono { get; set; }
        [Required]
        [StringLength(20)]
        public string Cargo { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? Fecha_de_ingreso { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal? salario { get; set; }

        [Required (ErrorMessage = " A (activo) , I (inactivo)") ]
        [StringLength(1)]
        public string Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licencia> Licencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permisos> Permisos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida> Salida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacaciones> Vacaciones { get; set; }
    }
}
