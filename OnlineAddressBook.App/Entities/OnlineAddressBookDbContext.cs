using Microsoft.EntityFrameworkCore;

namespace OnlineAddressBook.App.Entities
{
    class OnlineAddressBookDbContext : DbContext
    {
        private const string DevConnectionString = @"Data Source=.\DEVSERVER;Initial Catalog=OnlineAddressBookDB;Integrated Security=True";

        public OnlineAddressBookDbContext()
        {
            Database.SetConnectionString(DevConnectionString);
            Database.EnsureCreated();
        }

        public DbSet<AddressBookEntity> AddressBook { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DevConnectionString);
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}