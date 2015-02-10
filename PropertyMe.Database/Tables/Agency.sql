CREATE TABLE [dbo].[Agency]
(
	[ID] INT NOT NULL , 
    [UserID] BIGINT NOT NULL, 
    CONSTRAINT [PK_Agency] PRIMARY KEY ([ID]), 
    CONSTRAINT [FK_Agency_User] FOREIGN KEY ([UserID]) REFERENCES [User]([ID]), 
)
