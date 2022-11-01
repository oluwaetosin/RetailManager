CREATE TABLE [dbo].[SaleDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[SaleId] int NOT NULL,
	ProductId int Not null,
	Quantity int not null default 1,
	[PurchasePrice] MONEY NOT NULL,
	[Tax] money NOT NULL dEFAULT 0
)
