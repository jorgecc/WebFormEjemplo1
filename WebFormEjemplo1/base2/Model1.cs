namespace WebFormEjemplo1.base2
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

    public virtual DbSet<Usuario> usuarios { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>()
            .Property(e => e.NombreCuenta)
            .IsUnicode(false);

        modelBuilder.Entity<Usuario>()
            .Property(e => e.Clave)
            .IsUnicode(false);

        modelBuilder.Entity<Usuario>()
            .Property(e => e.NombreCompleto)
            .IsUnicode(false);
    }
}
}
