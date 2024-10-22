using Microsoft.EntityFrameworkCore;

public class RegistroContext:DbContext
{
  public DbSet<Actividad> Actividades {get; set;}
  public DbSet<Registro> Registros {get; set;}
  

  public RegistroContext(DbContextOptions<RegistroContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        modelBuilder.Entity<Actividad>(entity =>
        {
          entity.Property(a => a.Nombre).IsRequired();
           
        }       
        );

                modelBuilder.Entity<Registro>(entity =>
        {
          entity.Property(r => r.Actividad.Id).IsRequired().HasMaxLength(1);
          entity.Property(r => r.Fecha).IsRequired().HasMaxLength(10);
          entity.Property(r => r.Duracion).IsRequired().HasMaxLength(3);
          entity.Property(r => r.Distancia).IsRequired().HasMaxLength(100);
           entity.HasOne( a=>a.Actividad)
           .WithMany(a => a.Registros)
           .HasForeignKey(a => a.Actividad.Id).IsRequired();

            
            
        }
        );

      

    }


}