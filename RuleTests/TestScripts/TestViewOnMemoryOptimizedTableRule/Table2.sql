-- standard table
CREATE TABLE [dbo].[Table2] (
    [Id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CK_Table_Column2] CHECK ((2)=(2))
);

GO
ALTER TABLE [dbo].[Table2] ADD CONSTRAINT [CK_Table_Column] CHECK ((1)=(1))

GO
CREATE NONCLUSTERED INDEX [IX_Table_Column]
    ON [dbo].[Table2]([Id] ASC);

