using OnlineAddressBook.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineAddressBook.App.DataRepositories.Database
{
    public class SQLDatabaseRepository : IDataRepository, IDisposable
    {
        #region Fields
        private OnlineAddressBookDbContext _context;
        #endregion

        #region Constructor
        public SQLDatabaseRepository(OnlineAddressBookDbContext dbContext)
        {
            _context = dbContext;
        }
        #endregion

        #region IDataRepository Implementation
        public ICollection<AddressBookEntity> GetAddresses()
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
        #endregion

        #region IDisposable Implementation
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion
    }
}