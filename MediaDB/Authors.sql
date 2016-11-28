CREATE TABLE [dbo].[Authors]
(
	[authorId] INT NOT NULL PRIMARY KEY, 
    [firstName] NCHAR(50) NULL, 
    [lastName] NCHAR(50) NULL, 
    [middleNames] NCHAR(50) NULL, 
    [birthDate] DATE NULL
)
