CREATE TABLE [dbo].[Readings]
(
	[redingId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [isbn] NCHAR(20) NOT NULL
	FOREIGN KEY (isbn)
	REFERENCES Books (isbn), 
    [finished] BIT NOT NULL
)
