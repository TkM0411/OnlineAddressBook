using OnlineAddressBook.App.DataRepositories;
using OnlineAddressBook.App.DataRepositories.CSVRepository;
using OnlineAddressBook.App.DataRepositories.Database;
using OnlineAddressBook.App.DataRepositories.MockRepository;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace OnlineAddressBook.App
{
    static class Program
    {
        #region Constants
        private const string RepositoryType = "RepositoryType";
        private const string SQLRepository = "SQL";
        private const string CSVRepository = "CSV";
        private const string MockRepository = "Mock";
        private const string DbConnection = "OnlineAddressBookDbConnection";
        private const string CSVFileKey = "CSVFileName";
        #endregion

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDataRepository dataRepository = GetRepositoryForApplication();
            Application.Run(new MainWindowForm(dataRepository));
        }

        private static IDataRepository GetRepositoryForApplication()
        {
            string repositoryType = ConfigurationManager.AppSettings[RepositoryType];
            switch (repositoryType)
            {
                case SQLRepository:
                    string connectionString = ConfigurationManager.ConnectionStrings[DbConnection].ConnectionString;
                    OnlineAddressBookDbContext context = new OnlineAddressBookDbContext(connectionString);
                    return new SQLDatabaseRepository(context);

                case CSVRepository:
                    string csvFileName = ConfigurationManager.AppSettings[CSVFileKey];
                    return new CSVDataRepository(csvFileName);

                case MockRepository:
                    return new MockDataRepository();

                default:
                    throw new NotImplementedException("Specified repository type is not implemented currently.");
            }
        }
    }
}