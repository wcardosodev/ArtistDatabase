CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Picture] VARCHAR(MAX) NULL, 
    [BirthDate] DATETIME NULL, 
    [Nationality] NVARCHAR(50) NOT NULL, 
    [ArtStyle] NVARCHAR(50) NULL, 
    [Info] NVARCHAR(MAX) NULL, 
    [Rating] NCHAR(10) NULL, 
    [Artwork1] NVARCHAR(MAX) NULL, 
    [Artwork2] NVARCHAR(MAX) NULL, 
    [Artwork3] NVARCHAR(MAX) NULL
)
