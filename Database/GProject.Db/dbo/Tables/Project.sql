﻿CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(100, 100), 
    [StartDate] DATETIME NULL DEFAULT NULL, 
    [EndDate] DATETIME NULL DEFAULT NULL, 
    [Credits] INT NOT NULL DEFAULT 0
)