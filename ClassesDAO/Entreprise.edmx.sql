
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/20/2017 13:13:14
-- Generated from EDMX file: C:\Users\CDI14\Source\Repos\ABIEnCoucheTest\ClassesDAO\Entreprise.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ABIENCOUCHE];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CollaborateurEntityContratTypeE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratTypeESet] DROP CONSTRAINT [FK_CollaborateurEntityContratTypeE];
GO
IF OBJECT_ID(N'[dbo].[FK_CdiE_inherits_ContratTypeE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratTypeESet_CdiE] DROP CONSTRAINT [FK_CdiE_inherits_ContratTypeE];
GO
IF OBJECT_ID(N'[dbo].[FK_ContratTemporaireE_inherits_ContratTypeE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratTypeESet_ContratTemporaireE] DROP CONSTRAINT [FK_ContratTemporaireE_inherits_ContratTypeE];
GO
IF OBJECT_ID(N'[dbo].[FK_CddE_inherits_ContratTemporaireE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratTypeESet_CddE] DROP CONSTRAINT [FK_CddE_inherits_ContratTemporaireE];
GO
IF OBJECT_ID(N'[dbo].[FK_StageE_inherits_ContratTemporaireE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratTypeESet_StageE] DROP CONSTRAINT [FK_StageE_inherits_ContratTemporaireE];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CollaborateursESet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CollaborateursESet];
GO
IF OBJECT_ID(N'[dbo].[ContratTypeESet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratTypeESet];
GO
IF OBJECT_ID(N'[dbo].[ContratTypeESet_CdiE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratTypeESet_CdiE];
GO
IF OBJECT_ID(N'[dbo].[ContratTypeESet_ContratTemporaireE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratTypeESet_ContratTemporaireE];
GO
IF OBJECT_ID(N'[dbo].[ContratTypeESet_CddE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratTypeESet_CddE];
GO
IF OBJECT_ID(N'[dbo].[ContratTypeESet_StageE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratTypeESet_StageE];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CollaborateursESet'
CREATE TABLE [dbo].[CollaborateursESet] (
    [matriculeE] int  NOT NULL,
    [civiliteE] nchar(1)  NOT NULL,
    [nomE] nvarchar(20)  NOT NULL,
    [prenomE] nvarchar(20)  NOT NULL,
    [situationE] nvarchar(20)  NOT NULL,
    [photoE] nvarchar(100)  NULL,
    [actifE] bit  NOT NULL
);
GO

-- Creating table 'ContratTypeESet'
CREATE TABLE [dbo].[ContratTypeESet] (
    [idContratE] int  NOT NULL,
    [dateDebutE] datetime  NOT NULL,
    [qualificationE] nvarchar(20)  NOT NULL,
    [statutE] nvarchar(20)  NOT NULL,
    [salaireE] decimal(18,0)  NOT NULL,
    [finReelleE] datetime  NULL,
    [CollaborateurEntity_matriculeE] int  NOT NULL
);
GO

-- Creating table 'ContratTypeESet_CdiE'
CREATE TABLE [dbo].[ContratTypeESet_CdiE] (
    [idContratE] int  NOT NULL
);
GO

-- Creating table 'ContratTypeESet_ContratTemporaireE'
CREATE TABLE [dbo].[ContratTypeESet_ContratTemporaireE] (
    [dateFinE] datetime  NOT NULL,
    [motifE] nvarchar(100)  NOT NULL,
    [idContratE] int  NOT NULL
);
GO

-- Creating table 'ContratTypeESet_CddE'
CREATE TABLE [dbo].[ContratTypeESet_CddE] (
    [idContratE] int  NOT NULL
);
GO

-- Creating table 'ContratTypeESet_StageE'
CREATE TABLE [dbo].[ContratTypeESet_StageE] (
    [ecoleE] nvarchar(20)  NOT NULL,
    [missionE] nvarchar(max)  NOT NULL,
    [idContratE] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [matriculeE] in table 'CollaborateursESet'
ALTER TABLE [dbo].[CollaborateursESet]
ADD CONSTRAINT [PK_CollaborateursESet]
    PRIMARY KEY CLUSTERED ([matriculeE] ASC);
GO

-- Creating primary key on [idContratE] in table 'ContratTypeESet'
ALTER TABLE [dbo].[ContratTypeESet]
ADD CONSTRAINT [PK_ContratTypeESet]
    PRIMARY KEY CLUSTERED ([idContratE] ASC);
GO

-- Creating primary key on [idContratE] in table 'ContratTypeESet_CdiE'
ALTER TABLE [dbo].[ContratTypeESet_CdiE]
ADD CONSTRAINT [PK_ContratTypeESet_CdiE]
    PRIMARY KEY CLUSTERED ([idContratE] ASC);
GO

-- Creating primary key on [idContratE] in table 'ContratTypeESet_ContratTemporaireE'
ALTER TABLE [dbo].[ContratTypeESet_ContratTemporaireE]
ADD CONSTRAINT [PK_ContratTypeESet_ContratTemporaireE]
    PRIMARY KEY CLUSTERED ([idContratE] ASC);
GO

-- Creating primary key on [idContratE] in table 'ContratTypeESet_CddE'
ALTER TABLE [dbo].[ContratTypeESet_CddE]
ADD CONSTRAINT [PK_ContratTypeESet_CddE]
    PRIMARY KEY CLUSTERED ([idContratE] ASC);
GO

-- Creating primary key on [idContratE] in table 'ContratTypeESet_StageE'
ALTER TABLE [dbo].[ContratTypeESet_StageE]
ADD CONSTRAINT [PK_ContratTypeESet_StageE]
    PRIMARY KEY CLUSTERED ([idContratE] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CollaborateurEntity_matriculeE] in table 'ContratTypeESet'
ALTER TABLE [dbo].[ContratTypeESet]
ADD CONSTRAINT [FK_CollaborateurEntityContratTypeE]
    FOREIGN KEY ([CollaborateurEntity_matriculeE])
    REFERENCES [dbo].[CollaborateursESet]
        ([matriculeE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollaborateurEntityContratTypeE'
CREATE INDEX [IX_FK_CollaborateurEntityContratTypeE]
ON [dbo].[ContratTypeESet]
    ([CollaborateurEntity_matriculeE]);
GO

-- Creating foreign key on [idContratE] in table 'ContratTypeESet_CdiE'
ALTER TABLE [dbo].[ContratTypeESet_CdiE]
ADD CONSTRAINT [FK_CdiE_inherits_ContratTypeE]
    FOREIGN KEY ([idContratE])
    REFERENCES [dbo].[ContratTypeESet]
        ([idContratE])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idContratE] in table 'ContratTypeESet_ContratTemporaireE'
ALTER TABLE [dbo].[ContratTypeESet_ContratTemporaireE]
ADD CONSTRAINT [FK_ContratTemporaireE_inherits_ContratTypeE]
    FOREIGN KEY ([idContratE])
    REFERENCES [dbo].[ContratTypeESet]
        ([idContratE])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idContratE] in table 'ContratTypeESet_CddE'
ALTER TABLE [dbo].[ContratTypeESet_CddE]
ADD CONSTRAINT [FK_CddE_inherits_ContratTemporaireE]
    FOREIGN KEY ([idContratE])
    REFERENCES [dbo].[ContratTypeESet_ContratTemporaireE]
        ([idContratE])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idContratE] in table 'ContratTypeESet_StageE'
ALTER TABLE [dbo].[ContratTypeESet_StageE]
ADD CONSTRAINT [FK_StageE_inherits_ContratTemporaireE]
    FOREIGN KEY ([idContratE])
    REFERENCES [dbo].[ContratTypeESet_ContratTemporaireE]
        ([idContratE])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------