CREATE TABLE [dbo].[MyProperty]
(
	[ID] BIGINT NOT NULL PRIMARY KEY,
	[Title] NVARCHAR(30) NOT NULL,
    [Price] DECIMAL(18, 2) NOT NULL, 
    [CategoryID] INT NOT NULL, 
    [Area] INT NOT NULL, 
    [Bedroom] INT NOT NULL, 
    [Bathroom] INT NOT NULL, 
    [ReferenceNumber] NVARCHAR(20) NOT NULL, 
    [Description] NVARCHAR(300) NULL, 
    [AgentID] INT NOT NULL, 
    [Location] [sys].[geography] NOT NULL, 
    [IsSale] BIT NOT NULL, 
    [IsRent] BIT NOT NULL,
	CONSTRAINT [FK_Property_Category] FOREIGN KEY ([CategoryID]) REFERENCES [Category]([ID]),
	CONSTRAINT [FK_Property_Agent] FOREIGN KEY ([AgentID]) REFERENCES [Agent]([ID])
)
