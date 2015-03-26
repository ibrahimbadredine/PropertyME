/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

USE [Property365]
GO
INSERT [dbo].[PropertyRole] ([Name]) VALUES (N'Admin')
GO
INSERT [dbo].[PropertyRole] ([Name]) VALUES (N'Agency')
GO
INSERT [dbo].[PropertyRole] ([Name]) VALUES (N'Agent')
GO
INSERT [dbo].[PropertyRole] ([Name]) VALUES (N'User')
GO
INSERT [dbo].[PropertyUser] ([Name], [Password], [Tel], [Email], [Description], [PictureID], [PropertyRoleID], [isActive]) VALUES (N'Ibrahim Badredine', N'boomer', N'70683378', N'ibrahimbadredine@gmail.com', N'The administrator', NULL, 1, 1)
GO

