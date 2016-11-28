CREATE TABLE [dbo].[Contributions]
(
	[contributionId] INT NOT NULL,
    [authorId] INT NOT NULL,
	FOREIGN KEY (authorId)
	REFERENCES Authors (authorId),
    [isbn] NCHAR(20) NOT NULL
	FOREIGN KEY (isbn)
	REFERENCES Books (isbn)   
)
