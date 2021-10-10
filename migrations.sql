IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Teacher] (
    [ID] int NOT NULL IDENTITY,
    [Name Class] nvarchar(450) NOT NULL,
    [Number of Class] int NOT NULL,
    CONSTRAINT [PK_Teacher] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [Students] (
    [ID] int NOT NULL IDENTITY,
    [Students Code] int NOT NULL,
    [Name] ntext NOT NULL,
    [Age] int NOT NULL,
    [Sex] nvarchar(max) NOT NULL,
    [Classroom] nvarchar(max),
    [ScoreMath] float NOT NULL,
    [ScoreChemical] float NOT NULL,
    [ScorePhysics] float NOT NULL,
    [ScoreAverage] float NOT NULL,
    [PhoneNumber] int NOT NULL,
    [TeacherID] int NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Students_Teacher_TeacherID] FOREIGN KEY ([TeacherID]) REFERENCES [Teacher] ([ID]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Students_Students Code] ON [Students] ([Students Code]);
GO

CREATE INDEX [IX_Students_TeacherID] ON [Students] ([TeacherID]);
GO

CREATE INDEX [IX_Teacher_Name Class] ON [Teacher] ([Name Class]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211008053804_v0', N'5.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DROP INDEX [IX_Teacher_Name Class] ON [Teacher];
GO

DROP INDEX [IX_Students_Students Code] ON [Students];
GO

CREATE UNIQUE INDEX [IX_Teacher_Name Class] ON [Teacher] ([Name Class]);
GO

CREATE UNIQUE INDEX [IX_Students_Students Code] ON [Students] ([Students Code]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211008060838_v1', N'5.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'Classroom');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Students] ALTER COLUMN [Classroom] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211009034358_v2', N'5.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211009042454_v3', N'5.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'Lesson');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Students] DROP COLUMN [Lesson];
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'ListAverageScore');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Students] DROP COLUMN [ListAverageScore];
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211009113021_v4', N'5.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DROP INDEX [IX_Students_Students Code] ON [Students];
DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'Students Code');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Students] ALTER COLUMN [Students Code] nvarchar(10) NOT NULL;
CREATE UNIQUE INDEX [IX_Students_Students Code] ON [Students] ([Students Code]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211009114849_v5', N'5.0.10');
GO

COMMIT;
GO

