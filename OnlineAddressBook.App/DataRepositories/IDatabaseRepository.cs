using OnlineAddressBook.App.Entities;
using System.Collections.Generic;

namespace OnlineAddressBook.App.DataRepositories
{
    public interface IDataRepository
    {
        void AddAddress(AddressBookEntity entity);
        List<AddressBookEntity> GetAddresses();
        void Save();
    }
}