CREATE TABLE [dbo].[AddressBookTable]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(40) NOT NULL,
	[PhoneNumber] VARCHAR(15) NULL,
	[Address] VARCHAR(100) NOT NULL
)

ALTER TABLE [dbo].[AddressBookTable]
ADD CONSTRAINT [PK_AddressBookTable]
PRIMARY KEY CLUSTERED ([Id])