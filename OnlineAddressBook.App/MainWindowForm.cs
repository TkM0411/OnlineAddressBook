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
        private OnlineAddressBookDbContext _context = null;
        private List<AddressBookEntity> addressBookEntityCollection = new List<AddressBookEntity>();
        private int counter = 0;
        #endregion

        #region Constructor
        public MainWindowForm()
        {
            InitializeComponent();
            _context = new OnlineAddressBookDbContext();
            addressBookEntityCollection = _context.AddressBook.ToList();
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
            _context.AddressBook.Add(entity);
            _context.SaveChanges();
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