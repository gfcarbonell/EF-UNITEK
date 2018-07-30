namespace UNITEK.BaseDatos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Modelos;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }
        // Crear DbSet para las clases que seran mapeadas a Tablas
        public virtual DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
