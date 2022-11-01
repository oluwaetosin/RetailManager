CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CashierId] NVARCHAR(128) NOT NULL,
	[SaleDate] datetime2 NOT NULL,
	[SubTotal] money not null,
	[Tax] money not null,
	[Total] money not null
)
