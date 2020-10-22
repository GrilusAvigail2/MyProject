CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Direction] NCHAR(10) NULL, 
    [FloorId] INT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
)
