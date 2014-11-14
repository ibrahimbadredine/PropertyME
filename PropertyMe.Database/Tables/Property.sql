CREATE TABLE [dbo].[Property]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Price] DECIMAL(18, 2) NOT NULL, 
    [LocationID] CHAR(36) NOT NULL, 
    [CategoryID] CHAR(36) NOT NULL, 
    [Size] INT NOT NULL, 
    [Bedroom] INT NULL, 
    [Bathroom] INT NULL, 
    [ReferenceNumber] NVARCHAR(20) NOT NULL, 
    [Description] NVARCHAR(150) NULL, 
    [AgentID] CHAR(36) NULL, 
    [Location] [sys].[geography] NULL
)
