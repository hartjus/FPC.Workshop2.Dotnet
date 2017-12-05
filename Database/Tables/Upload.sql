CREATE TABLE [dbo].[Upload]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [Payload] TEXT NULL, 
    [Created] DATETIME NOT NULL DEFAULT getdate(), 
    [Updated] DATETIME NOT NULL DEFAULT getdate(), 
    CONSTRAINT [FK_Upload_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)
