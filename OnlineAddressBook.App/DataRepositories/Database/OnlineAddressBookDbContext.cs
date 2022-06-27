using Microsoft.EntityFrameworkCore;
using OnlineAddressBook.App.Entities;

namespace OnlineAddressBook.App.DataRepositories.Database
{
    public class OnlineAddressBookDbContext : DbContext
    {
        #region Fields
        private const string DevConnectionString = @"Data Source=.\DEVSERVER;Initial Catalog=OnlineAddressBookDB;Integrated Security=True";
        private readonly string _connectionString;
        #endregion

        #region Properties
        public DbSet<AddressBookEntity> AddressBook { get; set; }
        #endregion

        #region Constructor
        public OnlineAddressBookDbContext(string connectionString = "")
        {
            _connectionString = string.IsNullOrWhiteSpace(connectionString) ? DevConnectionString : connectionString;
            Database.SetConnectionString(_connectionString);
            Database.EnsureCreated();
        }
        #endregion

        #region Overridden Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DevConnectionString);

            base.OnConfiguring(optionsBuilder);
        }
        #endregion
    }
}