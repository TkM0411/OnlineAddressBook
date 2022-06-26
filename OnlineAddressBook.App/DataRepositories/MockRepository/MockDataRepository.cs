using OnlineAddressBook.App.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OnlineAddressBook.App.DataRepositories.MockRepository
{
    public class MockDataRepository : IDataRepository
    {
        #region Fields
        private List<AddressBookEntity> _mockRepository; 
        #endregion

        #region Constructor
        public MockDataRepository()
        {
            _mockRepository = new AddressBookEntity[]
            {
                new AddressBookEntity
                {
                    Id = 1,
                    Name = "Tushar Kanti Mishra",
                    PhoneNumber = "+919999999999",
                    Address = "Gayathri Residency, Kukatpally, Hyderabad-500072"
                },
                new AddressBookEntity
                {
                    Id = 2,
                    Name = "Manoj Sinha",
                    PhoneNumber = "+919876543210",
                    Address = "Flat No. 3C, Sumeru Cyberlife, Lingampalli, Hyderabad-500019"
                },
                new AddressBookEntity
                {
                    Id = 3,
                    Name = "John Doe",
                    PhoneNumber = "+447676675443",
                    Address = "221B, Baker Street, Greater London-3C2617"
                }
            }.ToList();
        } 
        #endregion

        #region IDataRepository Implementation
        public List<AddressBookEntity> GetAddresses()
        {
            return _mockRepository;
        }

        public void AddAddress(AddressBookEntity entity)
        {
            // Not implemented
        }

        public void Save()
        {
            // Not implemented
        } 
        #endregion
    }
}