CREATE TABLE [dbo].[Category]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [PictureID] BIGINT NULL,
	CONSTRAINT [FK_Category_Picture] FOREIGN KEY ([PictureID]) REFERENCES [Picture]([ID])
)
