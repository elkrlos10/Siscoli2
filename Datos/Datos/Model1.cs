namespace Datos.Datos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Evaluador> Evaluador { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Propuesta> Propuesta { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Empresa>()
            //    .Property(e => e.Nombre)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Empresa>()
            //    .Property(e => e.Nit)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Empresa>()
            //    .Property(e => e.Correo)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Empresa>()
            //    .Property(e => e.Direccion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Empresa>()
            //    .HasMany(e => e.Propuesta)
            //    .WithRequired(e => e.Empresa)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Evaluador>()
            //    .Property(e => e.Nombre)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Evaluador>()
            //    .Property(e => e.Apellido)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Evaluador>()
            //    .Property(e => e.Telefono)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Evaluador>()
            //    .Property(e => e.Direccion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Evaluador>()
            //    .Property(e => e.Correo)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Evaluador>()
            //    .HasMany(e => e.Item)
            //    .WithRequired(e => e.Evaluador)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Item>()
            //    .Property(e => e.NombreItem)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Item>()
            //    .Property(e => e.Descripcion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Propuesta>()
            //    .Property(e => e.FechaEntrega)
            //    .IsUnicode(false);

            //modelBuilder.Entity<TipoUsuario>()
            //    .Property(e => e.Nombre)
            //    .IsUnicode(false);

            //modelBuilder.Entity<TipoUsuario>()
            //    .HasMany(e => e.Usuario)
            //    .WithRequired(e => e.TipoUsuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Usuario>()
            //    .Property(e => e.NombreUsuario)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Usuario>()
            //    .Property(e => e.Contrasena)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Usuario>()
            //    .HasMany(e => e.Evaluador)
            //    .WithRequired(e => e.Usuario)
            //    .WillCascadeOnDelete(false);
        }
    }
}
