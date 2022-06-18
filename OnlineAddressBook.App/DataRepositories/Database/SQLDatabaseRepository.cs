using OnlineAddressBook.App.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OnlineAddressBook.App.DataRepositories.Database
{
    public class SQLDatabaseRepository
    {
        private OnlineAddressBookDbContext _context;

        public SQLDatabaseRepository()
        {
            _context = new OnlineAddressBookDbContext();
        }

        public List<AddressBookEntity> GetAddresses()
        {
            return _context.AddressBook.ToList();
        }

        public void AddAddress(AddressBookEntity entity)
        {
            _context.AddressBook.Add(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}