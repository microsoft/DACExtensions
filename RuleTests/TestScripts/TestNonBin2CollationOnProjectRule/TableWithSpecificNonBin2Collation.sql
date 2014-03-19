/*
If column has specific non-BIN2 collation a problem should be detected 
*/
CREATE TABLE [dbo].[TableWithSpecificNonBin2Collation]
(
	[Id] INT NOT NULL PRIMARY KEY NONCLUSTERED HASH WITH (BUCKET_COUNT = 131072),
	[c2] nvarchar(30) COLLATE SQL_Latin1_General_CP1250_CS_AS NOT NULL , 
    INDEX [IX_TableWithSpecificNonBin2Collation_Column] NONCLUSTERED HASH (c2) WITH (BUCKET_COUNT = 131072)
) WITH (MEMORY_OPTIMIZED = ON)

GO
