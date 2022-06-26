using OnlineAddressBook.App.DataRepositories;
using OnlineAddressBook.App.DataRepositories.MockRepository;
using OnlineAddressBook.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnlineAddressBook.App
{
    public partial class MainWindowForm : Form
    {
        #region Fields
        private ICollection<AddressBookEntity> addressBookEntityCollection = new List<AddressBookEntity>();
        IDataRepository _repository = new MockDataRepository();
        private int counter = 0;
        #endregion

        #region Constructor
        public MainWindowForm()
        {
            InitializeComponent();
            addressBookEntityCollection = _repository.GetAddresses();
        }
        #endregion

        #region Event Handlers
        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            if (addressBookEntityCollection != null && addressBookEntityCollection.Count > 0)
            {
                BindEntityToControls();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                BindEntityToControls();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddressBookEntity entity = new AddressBookEntity
            {
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Address = rtbAddress.Text
            };
            addressBookEntityCollection.Add(entity);
            _repository.AddAddress(entity);
            _repository.Save();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (addressBookEntityCollection != null && addressBookEntityCollection.Count > 0 && counter < addressBookEntityCollection.Count - 1)
            {
                counter++;
                BindEntityToControls();
            }
        }
        #endregion

        #region Private Methods
        private void BindEntityToControls()
        {
            AddressBookEntity startingEntry = addressBookEntityCollection.ElementAt(counter);
            txtName.Text = startingEntry.Name;
            txtPhoneNumber.Text = startingEntry.PhoneNumber;
            rtbAddress.Text = startingEntry.Address;
        }
        #endregion
    }
}