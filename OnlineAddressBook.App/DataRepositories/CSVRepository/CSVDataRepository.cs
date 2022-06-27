using Microsoft.VisualBasic.FileIO;
using OnlineAddressBook.App.CustomExceptions;
using OnlineAddressBook.App.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OnlineAddressBook.App.DataRepositories.CSVRepository
{
    public class CSVDataRepository : IDataRepository
    {
        #region Fields
        private string _csvDataFileName;
        private ICollection<AddressBookEntity> entityCollection;
        #endregion

        #region Constructor
        public CSVDataRepository(string csvDataFileName = "")
        {
            _csvDataFileName = string.IsNullOrWhiteSpace(csvDataFileName) ? $"{Application.ExecutablePath}\\Data.csv" : csvDataFileName;
            _csvDataFileName = csvDataFileName;
            entityCollection = new List<AddressBookEntity>();
        }
        #endregion

        #region IDataRepository Implementation
        public void AddAddress(AddressBookEntity entity)
        {
            entityCollection.Add(entity);
        }

        public ICollection<AddressBookEntity> GetAddresses()
        {
            if (File.Exists(_csvDataFileName))
            {
                string[] csvRecords = File.ReadAllLines(_csvDataFileName);
                if (csvRecords != null && csvRecords.Length > 0)
                {
                    ICollection<AddressBookEntity> addressBookEntities = new List<AddressBookEntity>();
                    TextFieldParser textFieldParser = null;
                    foreach (string record in csvRecords)
                    {
                        using (textFieldParser = new TextFieldParser(new StringReader(record)))
                        {
                            textFieldParser.HasFieldsEnclosedInQuotes = true;
                            textFieldParser.SetDelimiters(",");

                            string[] fields;
                            AddressBookEntity entity = new AddressBookEntity();
                            while (!textFieldParser.EndOfData)
                            {
                                fields = textFieldParser.ReadFields();
                                for (int i = 0; i < fields.Length; i++)
                                {
                                    switch (i)
                                    {
                                        case 0: entity.Id = Convert.ToInt32(fields[i]);
                                            break;
                                        case 1: entity.Name = fields[i];
                                            break;
                                        case 2: entity.PhoneNumber = fields[i];
                                            break;
                                        case 3: entity.Address = fields[i];
                                            break;
                                        default:
                                            throw new InvalidDataFormatException("Invalid CSV Field Specification");
                                    }
                                }
                            }
                            textFieldParser.Close();
                            return addressBookEntities;
                        }
                    }
                }
            }
            return null;
        }

        public void Save()
        {
            IEnumerable<string> csvLines = entityCollection.Select(c => c.ToString());
            File.WriteAllLines(_csvDataFileName, csvLines);
        }
        #endregion
    }
}