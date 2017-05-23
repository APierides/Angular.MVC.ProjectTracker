
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/23/2017 16:50:23
-- Generated from EDMX file: E:\Dev\Portfolio\Angular.MVC.ProjectTracker\Entity.SQL.ProjectTracker\DataModel\ProjectTracker.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProjectTracker];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dProjectdComponent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[dComponents] DROP CONSTRAINT [FK_dProjectdComponent];
GO
IF OBJECT_ID(N'[dbo].[FK_dComponentdTask]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[dTasks] DROP CONSTRAINT [FK_dComponentdTask];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[dProjects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dProjects];
GO
IF OBJECT_ID(N'[dbo].[dTasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dTasks];
GO
IF OBJECT_ID(N'[dbo].[dComponents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dComponents];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'dProjects'
CREATE TABLE [dbo].[dProjects] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [DueDate] datetime  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Priority] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'dTasks'
CREATE TABLE [dbo].[dTasks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Note] nvarchar(max)  NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Priority] nvarchar(max)  NOT NULL,
    [DueDate] datetime  NOT NULL,
    [DateCompleted] datetime  NULL,
    [LastUpdatedDate] datetime  NOT NULL,
    [dComponentId] int  NOT NULL
);
GO

-- Creating table 'dComponents'
CREATE TABLE [dbo].[dComponents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Coordinator] nvarchar(max)  NOT NULL,
    [dProjectId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'dProjects'
ALTER TABLE [dbo].[dProjects]
ADD CONSTRAINT [PK_dProjects]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'dTasks'
ALTER TABLE [dbo].[dTasks]
ADD CONSTRAINT [PK_dTasks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'dComponents'
ALTER TABLE [dbo].[dComponents]
ADD CONSTRAINT [PK_dComponents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [dProjectId] in table 'dComponents'
ALTER TABLE [dbo].[dComponents]
ADD CONSTRAINT [FK_dProjectdComponent]
    FOREIGN KEY ([dProjectId])
    REFERENCES [dbo].[dProjects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dProjectdComponent'
CREATE INDEX [IX_FK_dProjectdComponent]
ON [dbo].[dComponents]
    ([dProjectId]);
GO

-- Creating foreign key on [dComponentId] in table 'dTasks'
ALTER TABLE [dbo].[dTasks]
ADD CONSTRAINT [FK_dComponentdTask]
    FOREIGN KEY ([dComponentId])
    REFERENCES [dbo].[dComponents]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dComponentdTask'
CREATE INDEX [IX_FK_dComponentdTask]
ON [dbo].[dTasks]
    ([dComponentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------