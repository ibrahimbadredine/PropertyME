CREATE TABLE [dbo].[PropertyPictures]
(
	[ID] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [PropertyID] BIGINT NOT NULL, 
    [PictureID] BIGINT NOT NULL
	CONSTRAINT [FK_PropertyPictures_Property] FOREIGN KEY ([PropertyID]) REFERENCES [MyProperty]([ID]),
	CONSTRAINT [FK_PropertyPictures_Picture] FOREIGN KEY ([PictureID]) REFERENCES [Picture]([ID])
)
