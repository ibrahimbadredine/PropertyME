﻿CREATE TABLE [dbo].[PropertyPictures]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [PropertyID] CHAR(36) NOT NULL, 
    [PictureID] CHAR(36) NOT NULL
)
