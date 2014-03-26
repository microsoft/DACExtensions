/*
Given lowercase named objects expect problems to be detected.
Note that since dbo is not user-defined it won't be flagged
*/

CREATE TABLE [dbo].[lowercasetable]
(
	-- Id capitalized: no problem even though table is not capitalized
    [Id] INT NOT NULL PRIMARY KEY NONCLUSTERED HASH WITH (BUCKET_COUNT = 131072),
	-- c2 lowercase: expect problem
    [c2] nvarchar(30) COLLATE SQL_Latin1_General_CP850_BIN2 NOT NULL, 

    INDEX [IX_UPPERCASE] NONCLUSTERED HASH (c2) WITH (BUCKET_COUNT = 131072),
) WITH (MEMORY_OPTIMIZED = ON)

GO

-- v2, c2, id all should be flagged
CREATE VIEW lowercaseView 
    WITH SCHEMABINDING
    AS
    SELECT c2, c2 AS C3, Id as id FROM dbo.lowercasetable
GO

-- Procedure is flagged
CREATE PROCEDURE [dbo].[lowercaseProcedure]
    -- Parameters will be not be flagged as they do not start with a letter or digit.
    @param1 int = 0,
    @param2 int
AS
	SELECT @param1, @param2
RETURN 0

GO
/*

*/
/*
Given capitalized or uppercase named expect no problems
*/
CREATE TABLE [dbo].[CapitalizedTable]
(
    [Id] INT NOT NULL PRIMARY KEY NONCLUSTERED HASH WITH (BUCKET_COUNT = 131072),
    [C2] nvarchar(30) COLLATE SQL_Latin1_General_CP850_BIN2 NOT NULL, 

    INDEX [IX_UPPERCASE] NONCLUSTERED HASH (C2) WITH (BUCKET_COUNT = 131072),
) WITH (MEMORY_OPTIMIZED = ON)

GO

CREATE VIEW UPPERCASEVIEW AS
    SELECT C2, C2 AS C3 FROM [dbo].[CapitalizedTable]

GO

CREATE PROCEDURE [dbo].[CapitalizedProc]
	@Param1 int = 0,
	@Param2 int
AS
	SELECT @Param1, @Param2
RETURN 0
	