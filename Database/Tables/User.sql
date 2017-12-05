CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Created] DATETIME NOT NULL DEFAULT getdate(), 
    [Updated] DATETIME NOT NULL DEFAULT getdate()
)
