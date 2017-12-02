using System.Data.Entity;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.DataAccess.Concrete
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(null);//migrationu engellemek için diyoruz ki dbyi biz hazırladık 
        }
        public DbSet<SecondHfUser> Users { get; set; }
        public DbSet<SecondHfRole> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Recommentation> Recommentations { get; set; }
        public DbSet<Vote> Votes { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Configurations.Add(new ProductMap());
        //} Mapping yapma sekli ama kullanmadik
    }
}
