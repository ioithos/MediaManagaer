CREATE TABLE [dbo].[Books]
(
    [isbn] NCHAR(20) NOT NULL PRIMARY KEY,
	[seriesId] INT NULL
	FOREIGN KEY (seriesId)
	REFERENCES Series (seriesId),
    [publisherId] INT NOT NULL
	FOREIGN KEY (publisherId)
	REFERENCES Publishers (publisherId),
	[title] NCHAR(100) NOT NULL, 
	[volume] SMALLINT NULL, 
    [edition] SMALLINT NULL, 
    [coprightDate] DATE NULL, 
    [totalPages] SMALLINT NULL, 
    FOREIGN KEY (publisherId)
	REFERENCES Publishers (publisherId)
)
