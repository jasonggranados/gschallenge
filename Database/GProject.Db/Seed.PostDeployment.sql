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

USE [GProjectDb]
GO
SET IDENTITY_INSERT [dbo].[Project] ON 
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (100, CAST(N'2018-10-24T00:00:00.000' AS DateTime), CAST(N'2021-08-30T00:00:00.000' AS DateTime), 59)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (200, CAST(N'2019-06-25T00:00:00.000' AS DateTime), CAST(N'2020-12-22T00:00:00.000' AS DateTime), 34)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (300, CAST(N'2018-07-31T00:00:00.000' AS DateTime), CAST(N'2020-06-17T00:00:00.000' AS DateTime), 35)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (400, CAST(N'2019-11-13T00:00:00.000' AS DateTime), CAST(N'2021-10-04T00:00:00.000' AS DateTime), 75)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (500, CAST(N'2019-05-28T00:00:00.000' AS DateTime), CAST(N'2022-10-27T00:00:00.000' AS DateTime), 28)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (600, CAST(N'2018-05-11T00:00:00.000' AS DateTime), CAST(N'2021-08-05T00:00:00.000' AS DateTime), 39)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (700, CAST(N'2016-01-01T00:00:00.000' AS DateTime), CAST(N'2022-09-16T00:00:00.000' AS DateTime), 21)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (800, CAST(N'2018-12-24T00:00:00.000' AS DateTime), CAST(N'2021-07-02T00:00:00.000' AS DateTime), 87)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (900, CAST(N'2018-11-13T00:00:00.000' AS DateTime), CAST(N'2021-02-05T00:00:00.000' AS DateTime), 100)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (1000, CAST(N'2019-04-24T00:00:00.000' AS DateTime), CAST(N'2021-09-03T00:00:00.000' AS DateTime), 78)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (1100, CAST(N'2018-03-28T00:00:00.000' AS DateTime), CAST(N'2020-10-16T00:00:00.000' AS DateTime), 47)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (1200, CAST(N'2018-01-18T00:00:00.000' AS DateTime), CAST(N'2022-08-25T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (1300, CAST(N'2019-01-03T00:00:00.000' AS DateTime), CAST(N'2021-12-22T00:00:00.000' AS DateTime), 4)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (1400, CAST(N'2018-02-08T00:00:00.000' AS DateTime), CAST(N'2021-02-05T00:00:00.000' AS DateTime), 33)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (1500, CAST(N'2019-08-29T00:00:00.000' AS DateTime), CAST(N'2022-10-27T00:00:00.000' AS DateTime), 94)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (1600, CAST(N'2018-05-02T00:00:00.000' AS DateTime), CAST(N'2020-06-17T00:00:00.000' AS DateTime), 18)
GO
SET IDENTITY_INSERT [dbo].[Project] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([Id], [Firstname], [Lastname]) VALUES (1, N'Bonny', N'Boddy')
GO
INSERT [dbo].[User] ([Id], [Firstname], [Lastname]) VALUES (2, N'Genaro', N'Gamez')
GO
INSERT [dbo].[User] ([Id], [Firstname], [Lastname]) VALUES (3, N'Hilaria', N'Hipple')
GO
INSERT [dbo].[User] ([Id], [Firstname], [Lastname]) VALUES (4, N'Wallace', N'Wageman')
GO
INSERT [dbo].[User] ([Id], [Firstname], [Lastname]) VALUES (5, N'Jamal', N'Jara')
GO
INSERT [dbo].[User] ([Id], [Firstname], [Lastname]) VALUES (6, N'Kaila', N'Koo')
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (1, 100, 1, CAST(N'2019-01-14T13:47:20.710' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (2, 200, 1, CAST(N'2019-03-23T13:47:43.740' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (3, 300, 1, CAST(N'2019-01-05T13:47:47.703' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (4, 400, 1, CAST(N'2019-01-19T13:47:52.617' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (5, 500, 1, CAST(N'2019-02-24T13:47:52.617' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (1, 600, 1, CAST(N'2019-03-30T13:47:20.710' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (2, 700, 1, CAST(N'2019-02-26T13:47:43.740' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (3, 800, 1, CAST(N'2019-07-10T13:47:47.703' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (4, 900, 1, CAST(N'2019-02-11T13:47:52.617' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (5, 1000, 1, CAST(N'2019-01-22T13:47:52.617' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (1, 1100, 1, CAST(N'2019-05-05T13:47:20.710' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (2, 1200, 0, CAST(N'2019-08-04T13:47:43.740' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (3, 1300, 0, CAST(N'2019-01-26T13:47:47.703' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (4, 1400, 0, CAST(N'2019-04-08T13:47:52.617' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (5, 1500, 0, CAST(N'2019-03-14T13:47:52.617' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (1, 1600, 0, CAST(N'2019-05-18T13:47:52.617' AS DateTime))
GO