CREATE VIEW [dbo].[View1]
-- missing WITH SCHEMABINDING attribute
	AS SELECT T1.c2, T2.Id as myCol FROM [dbo].[Table1] as T1, [dbo].[Table2] as T2
GO

-- Indexes aren't allowed on this table
CREATE UNIQUE CLUSTERED INDEX [IX_View1_myCol] on [dbo].[View1] (myCol)
GO

CREATE INDEX [IX_View1_c2] on [dbo].[View1] (c2)
GO

-- Valid View: Creating a view on Table1 should be OK if it specified schema binding
CREATE VIEW [dbo].[View2]
    WITH SCHEMABINDING
	AS SELECT T1.c2, T2.Id as myCol FROM [dbo].[Table1] as T1, [dbo].Table2 as T2
GO

-- Valid Indexes: Creating indexes on views that don't reference memory optimized tables is acceptable
CREATE VIEW [dbo].[View3]
    WITH SCHEMABINDING
	AS SELECT T2.Id as myCol FROM [dbo].Table2 as T2
GO
CREATE UNIQUE CLUSTERED INDEX [IX_View3_myCol] on [dbo].[View3] (myCol)
GO
