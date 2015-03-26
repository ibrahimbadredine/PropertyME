CREATE TABLE [dbo].[PropertyCategory]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [PictureID] BIGINT NULL,
	CONSTRAINT [FK_PropertyCategory_Picture] FOREIGN KEY ([PictureID]) REFERENCES [Picture]([ID])
)
