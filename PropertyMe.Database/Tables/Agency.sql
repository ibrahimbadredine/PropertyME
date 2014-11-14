﻿CREATE TABLE [dbo].[Agency]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [PictureID] CHAR(36) NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL
)
