CREATE TABLE [dbo].[Agent]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [UserID] BIGINT NOT NULL, 
    [Mobile] NVARCHAR(20) NOT NULL, 
    [PictureID] BIGINT NOT NULL, 
    [AgencyID] INT NOT NULL, 
    [Description] NVARCHAR(300) NULL, 
    CONSTRAINT [FK_Agent_User] FOREIGN KEY ([UserID]) REFERENCES [User]([ID]), 
    CONSTRAINT [FK_Agent_Picture] FOREIGN KEY ([PictureID]) REFERENCES [Picture]([ID]),
	CONSTRAINT [FK_Agent_Agency] FOREIGN KEY ([AgencyID]) REFERENCES [Agency]([ID])
)
