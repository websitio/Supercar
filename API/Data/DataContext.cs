using Microsoft.EntityFrameworkCore;
using API.Entities;
namespace API.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions options) : base(options){}
     
        public DbSet<AppUser> Users {get; set;}

        public DbSet<Island> Islands{get; set;}


          public DbSet<Make> Makes { get; set; }
          public DbSet<Feature> Features { get; set; }

          public DbSet<Vehicle> Vehicles    {get; set;}
          public DbSet<Model> Models {get;set;}


  protected override void OnModelCreating(ModelBuilder builder)
        {
                    base.OnModelCreating(builder);
              
              
                         builder.Entity<VehicleFeature>()
                        .HasKey(vf => new { vf.VehicleId, vf.FeatureId });

        }
    }
}   


