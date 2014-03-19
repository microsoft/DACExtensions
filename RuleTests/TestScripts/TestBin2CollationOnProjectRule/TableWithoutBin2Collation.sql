/*
Given the overall project has BIN2 collation, even character columns without a specific collation
should be fine - no problems will be detected. 
*/

CREATE TABLE [dbo].[TableWithoutBin2Collation]
(
	[Id] INT NOT NULL PRIMARY KEY NONCLUSTERED HASH WITH (BUCKET_COUNT = 131072),
	[c2] nvarchar(30) NOT NULL, 
	[c3] varchar(30) NOT NULL, 
	[c4] char(30) NOT NULL, 
	[c5] nchar(30) NOT NULL, 
	[cWithCollation] nchar(30) COLLATE SQL_Latin1_General_CP850_BIN2 NOT NULL,  
	[int5] int NOT NULL, 
    INDEX [IX_T1_C2] NONCLUSTERED HASH (c2) WITH (BUCKET_COUNT = 131072),
    INDEX [IX_T1_MultipleIndexes] NONCLUSTERED HASH (c3, c4) WITH (BUCKET_COUNT = 131072),
    INDEX [IX_T1_c5] NONCLUSTERED HASH (c5) WITH (BUCKET_COUNT = 131072),	
    INDEX [IX_T1_int5] NONCLUSTERED HASH (int5) WITH (BUCKET_COUNT = 131072),
    INDEX [IX_T1_MultipleIndexesOneWithBin2] NONCLUSTERED HASH (c3, cWithCollation) WITH (BUCKET_COUNT = 131072),
    INDEX [IX_T1_MultipleIndexesAllValid] NONCLUSTERED HASH (cWithCollation, int5) WITH (BUCKET_COUNT = 131072)
) WITH (MEMORY_OPTIMIZED = ON)

GO