CREATE TABLE [dbo].[Perfumes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Designer] NVARCHAR(50) NOT NULL, 
    [Perfumer] NVARCHAR(50) NULL, 
    [Launched] NVARCHAR(MAX) NULL, 
    [Description] NVARCHAR(MAX) NULL
)
