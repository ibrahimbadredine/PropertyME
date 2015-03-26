CREATE TABLE [dbo].[PropertyUser]
(
	[ID] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(20) NOT NULL, 
	[Tel] NVARCHAR(20) NOT NULL, 
    [Email] NVARCHAR(50) NULL, 
	[Description] NVARCHAR(300) NULL,
	[PictureID] bigint NULL,
    [PropertyRoleID] INT NOT NULL,
	[isActive] BIT NOT NULL DEFAULT 0
CONSTRAINT [FK_PropertyUser_PropertyRole] FOREIGN KEY ([PropertyRoleID]) REFERENCES [PropertyRole]([ID]),
)
