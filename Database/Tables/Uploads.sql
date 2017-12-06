CREATE TABLE [dbo].[Uploads]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [Payload] TEXT NULL, 
    [Created] DATETIME2 NOT NULL DEFAULT getdate(), 
    [Updated] DATETIME2 NOT NULL DEFAULT getdate(), 
    CONSTRAINT [FK_Upload_User] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
)
