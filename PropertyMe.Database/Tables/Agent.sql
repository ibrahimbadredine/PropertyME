CREATE TABLE [dbo].[Agent]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [UserID] BIGINT NOT NULL, 
    [AgencyID] INT NOT NULL, 
    [AboutMe] NVARCHAR(300) NULL, 
    CONSTRAINT [FK_Agent_User] FOREIGN KEY ([UserID]) REFERENCES [User]([ID]), 
    CONSTRAINT [FK_Agent_Agency] FOREIGN KEY ([AgencyID]) REFERENCES [Agency]([ID])
)
