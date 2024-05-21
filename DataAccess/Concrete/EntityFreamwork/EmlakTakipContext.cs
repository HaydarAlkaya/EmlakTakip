using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EmlakTakipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@"Data Source=BRAINSTROME;Initial Catalog=Recorto;Integrated Security=True;Trust Server Certificate=True"
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=EmlakTakip;Integrated Security=True;Trust Server Certificate=True");
        }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Neighbourhood> Neighbourhoods { get; set; }
        public DbSet<ParselQuery> ParselQueries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OwnerShip> OwnerShips { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}