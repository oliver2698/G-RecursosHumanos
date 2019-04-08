namespace Proyectofinal.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Formulario : DbContext
    {
        public Formulario()
            : base("name=Formulario")
        {
        }

        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Licencia> Licencia { get; set; }
        public virtual DbSet<Nomina> Nomina { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Salida> Salida { get; set; }
        public virtual DbSet<Vacaciones> Vacaciones { get; set; }
        
        public virtual DbSet<Activos> Activos { get; set; }
        public virtual DbSet<calnomina> calnomina { get; set; }
        public virtual DbSet<Inactivos> Inactivos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo>()
                .Property(e => e.Cargo1)
                .IsUnicode(true);

            modelBuilder.Entity<Departamento>()
                .Property(e => e.Nombre)
                .IsUnicode(true);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Deparamento)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.salario)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Licencia)
                .WithOptional(e => e.Empleado1)
                .HasForeignKey(e => e.Codigo_Empleado);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Permisos)
                .WithOptional(e => e.Empleado1)
                .HasForeignKey(e => e.Codigo_Empleado);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Salida)
                .WithOptional(e => e.Empleado1)
                .HasForeignKey(e => e.Codigo_Empleado);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Vacaciones)
                .WithOptional(e => e.Empleado1)
                .HasForeignKey(e => e.Codigo_Empleado);

            modelBuilder.Entity<Licencia>()
                .Property(e => e.Empleado)
                .IsUnicode(false);

            modelBuilder.Entity<Licencia>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<Licencia>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.Año)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.Mes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.Monto_total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.Empleado)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Salida>()
                .Property(e => e.Empleado)
                .IsUnicode(false);

            modelBuilder.Entity<Salida>()
                .Property(e => e.TipoDesalida)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Salida>()
                .Property(e => e.motivo)
                .IsUnicode(false);

            modelBuilder.Entity<Vacaciones>()
                .Property(e => e.Empleado)
                .IsUnicode(false);

            modelBuilder.Entity<Vacaciones>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Activos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Activos>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Activos>()
                .Property(e => e.salario)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Activos>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<calnomina>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<calnomina>()
                .Property(e => e.salario)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inactivos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Inactivos>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Inactivos>()
                .Property(e => e.salario)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inactivos>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
