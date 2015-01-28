CREATE TABLE [dbo].[User]
(
	[ID] BIGINT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(20) NOT NULL, 
    [LastName] NVARCHAR(20) NOT NULL, 
    [Password] NVARCHAR(20) NOT NULL, 
	[Mobile] NVARCHAR(20) NOT NULL, 
    [Email] NVARCHAR(50) NULL, 
	[PictureID] bigint NULL,
    [RoleID] INT NOT NULL
	CONSTRAINT [FK_User_Role] FOREIGN KEY ([RoleID]) REFERENCES [Role]([ID]),
)
