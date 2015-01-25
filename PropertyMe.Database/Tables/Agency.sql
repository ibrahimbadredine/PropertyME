CREATE TABLE [dbo].[Agency]
(
	[ID] INT NOT NULL , 
    [Name] NVARCHAR(50) NOT NULL, 
	[Description] NVARCHAR(300) NOT NULL,
    [PictureID] BIGINT NOT NULL, 
    [Phone] NVARCHAR(20) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Agency] PRIMARY KEY ([ID]), 
    CONSTRAINT [FK_Agency_Picture] FOREIGN KEY ([PictureID]) REFERENCES [dbo].[Picture] ([ID]) 
)
