CREATE TABLE [dbo].[MyProperty]
(
	[ID] BIGINT NOT NULL PRIMARY KEY IDENTITY,
	[Title] NVARCHAR(30) NOT NULL,
    [Price] DECIMAL(18, 2) NOT NULL, 
    [PropertyCategoryID] INT NOT NULL, 
    [Area] INT NOT NULL, 
    [Bedroom] INT NOT NULL, 
    [Bathroom] INT NOT NULL, 
    [ReferenceNumber] NVARCHAR(20) NOT NULL, 
    [Description] NVARCHAR(300) NULL, 
    [PropertyUserID] BIGINT NOT NULL, 
    [Long] DECIMAL(18, 15) NOT NULL, 
    [Lat] DECIMAL(18, 15) NOT NULL, 
    [IsSale] BIT NOT NULL, 
    [IsRent] BIT NOT NULL,
	CONSTRAINT [FK_Property_PropertyCategory] FOREIGN KEY ([PropertyCategoryID]) REFERENCES [PropertyCategory]([ID]),
	CONSTRAINT [FK_Property_PropertyUser] FOREIGN KEY ([PropertyUserID]) REFERENCES [dbo].[PropertyUser]([ID])
)
