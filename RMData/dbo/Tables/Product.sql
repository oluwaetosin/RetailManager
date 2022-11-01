CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ProductName] nvarchar(100) NOT NULL,
	[Description] nvarchar(MAX) NOT NULL,
	[RetailPrice] money NOT NULL,
	[CreateDate] datetime2(7) NOT NULL DEFAULT getutcdate(),
	[LastModified] datetime2(7) NOT NULL DEFAULT getutcdate(),
)
