/*
Given indexes on a column with specific Bin2 collation, no problem should be found
*/

CREATE TABLE [dbo].[TableWithBin2Collation]
(
	[Id] INT NOT NULL PRIMARY KEY NONCLUSTERED HASH WITH (BUCKET_COUNT = 131072),
	[c2] nvarchar(30) COLLATE SQL_Latin1_General_CP850_BIN2 NOT NULL , 
    INDEX [IX_TableWithoutBin2Collation_Column] NONCLUSTERED HASH (c2) WITH (BUCKET_COUNT = 131072)
) WITH (MEMORY_OPTIMIZED = ON)

GO
