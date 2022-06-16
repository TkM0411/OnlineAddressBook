using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineAddressBook.App
{
    public partial class MainWindowForm : Form
    {
        private const string dbConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\LocalDatabase\AddressBookDB.mdf;Integrated Security=True";

        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
