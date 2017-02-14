CREATE TABLE [dbo].[Artists] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (60)  NOT NULL,
    [Picture]     NVARCHAR (MAX) NULL,
    [BirthDate]   DATETIME2       NOT NULL,
    [Nationality] NVARCHAR (30)  NOT NULL,
    [ArtStyle]    NVARCHAR (MAX) NULL,
    [Info]        NVARCHAR (MAX) NULL,
    [Rating]      NVARCHAR (5)   NULL,
    [Artwork1]    NVARCHAR (MAX) NULL,
    [Artwork2]    NVARCHAR (MAX) NULL,
    [Artwork3]    NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Artists] PRIMARY KEY CLUSTERED ([ID] ASC)
);

