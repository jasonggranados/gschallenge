CREATE TABLE [dbo].[UserProject] (
    [UserId]       INT      NOT NULL,
    [ProjectId]    INT      NOT NULL,
    [IsActive]     BIT      DEFAULT ('false') NOT NULL,
    [AssignedDate] DATETIME DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ProjectId], [UserId]),
    CONSTRAINT [FK_UserProject_Project] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project] ([Id]),
    CONSTRAINT [FK_UserProject_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);


