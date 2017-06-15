
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/14/2017 21:36:51
-- Generated from EDMX file: C:\Users\ALYSON\Source\Repos\INICIO\Oficina\Oficina\Models\Mecanica.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OficinaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [SobreNome] nvarchar(max)  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Carros'
CREATE TABLE [dbo].[Carros] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Placa] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Defeito] nvarchar(max)  NOT NULL,
    [ClienteId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Carros'
ALTER TABLE [dbo].[Carros]
ADD CONSTRAINT [PK_Carros]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteId] in table 'Carros'
ALTER TABLE [dbo].[Carros]
ADD CONSTRAINT [FK_ClienteCarro]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCarro'
CREATE INDEX [IX_FK_ClienteCarro]
ON [dbo].[Carros]
    ([ClienteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------