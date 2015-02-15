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
INSERT [dbo].[Role] ([ID], [Name]) VALUES (1, N'Admin')
GO
INSERT [dbo].[Role] ([ID], [Name]) VALUES (2, N'Agency')
GO
INSERT [dbo].[Role] ([ID], [Name]) VALUES (3, N'Agent')
GO
INSERT [dbo].[Role] ([ID], [Name]) VALUES (4, N'User')
GO
INSERT [dbo].[User] ([ID], [Name], [Password], [Tel], [Email], [Description], [PictureID], [RoleID], [isActive]) VALUES (1, N'Ibrahim Badredine', N'boomer', N'70683378', N'ibrahimbadredine@gmail.com', N'The administrator', NULL, 1, 1)
GO
INSERT [dbo].[Agency] ([ID], [UserID]) VALUES (1, 1)
GO
INSERT [dbo].[Agent] ([ID], [UserID], [AgencyID]) VALUES (1, 1, 1)
GO

