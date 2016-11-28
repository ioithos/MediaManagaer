CREATE TABLE [dbo].[Publishers]
(
	[publisherId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [publisherName] NCHAR(50) NOT NULL, 
    [parentCompany] NCHAR(50) NOT NULL, 
    [country] NCHAR(50) NOT NULL
)
