CREATE TABLE [dbo].[Permission]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PropertyRoleID] INT NOT NULL, 
    [PermissionTypeID] INT NOT NULL, 
    [Quantity] INT NOT NULL,
	CONSTRAINT [FK_Permission_Role] FOREIGN KEY ([PropertyRoleID]) REFERENCES [PropertyRole]([ID]),
	CONSTRAINT [FK_Permission_PermissionType] FOREIGN KEY ([PermissionTypeID]) REFERENCES [PermissionType]([ID])
)
