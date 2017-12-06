CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Created] DATETIME2 NOT NULL DEFAULT getdate(), 
    [Updated] DATETIME2 NOT NULL DEFAULT getdate()
)
