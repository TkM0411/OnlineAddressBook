using System;

namespace OnlineAddressBook.App.CustomExceptions
{
    public class InvalidDataFormatException : Exception
    {
        #region Constructors
        public InvalidDataFormatException(string message) : base(message) { }
        public InvalidDataFormatException(string message, Exception innerException) : base(message, innerException) { } 
        #endregion
    }
}