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

CREATE TABLE [funcionario] (
    [id] int NOT NULL IDENTITY,
    [nome] nvarchar(255) NOT NULL,
    [idade] int NOT NULL,
    [funcao] int NOT NULL,
    CONSTRAINT [PK_funcionario] PRIMARY KEY ([id])
);
GO

CREATE TABLE [produtos] (
    [id] int NOT NULL IDENTITY,
    [nome] nvarchar(255) NOT NULL,
    [descricao] nvarchar(1000) NOT NULL,
    [quantidade] int NOT NULL,
    [valor] int NOT NULL,
    CONSTRAINT [PK_produtos] PRIMARY KEY ([id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230615134209_InitialDB', N'7.0.5');
GO

COMMIT;
GO

