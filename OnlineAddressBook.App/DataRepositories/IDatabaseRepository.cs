using OnlineAddressBook.App.Entities;
using System.Collections.Generic;

namespace OnlineAddressBook.App.DataRepositories
{
    public interface IDataRepository
    {
        void AddAddress(AddressBookEntity entity);
        ICollection<AddressBookEntity> GetAddresses();
        void Save();
    }
}