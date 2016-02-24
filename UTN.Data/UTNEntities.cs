using System.Data.Entity;
using UTN.Data.Configuration;
using UTN.Models.DTO;

namespace UTN.Data
{
    public class UTNEntities : DbContext
    {
        public UTNEntities() : base("UTNEntities") { }

        public DbSet<CountryDTO> Countries { set; get; }
        public DbSet<StudentDTO> Students { set; get; }

        public virtual void Commit() {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());
        }
    }
}
