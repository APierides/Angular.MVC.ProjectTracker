
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/20/2017 13:05:21
-- Generated from EDMX file: e:\dev\portfolio\Angular.MVC.ProjectTracker\Entity.SQL.ProjectTracker\DataModel\ProjectTracker.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [dProjectId] int  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Note] nvarchar(max)  NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Priority] nvarchar(max)  NOT NULL,
    [DueDate] datetime  NOT NULL,
    [DateCompleted] datetime  NULL,
    [LastUpdatedDate] datetime  NOT NULL
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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [dProjectId] in table 'dTasks'
ALTER TABLE [dbo].[dTasks]
ADD CONSTRAINT [FK_dProjectdTask]
    FOREIGN KEY ([dProjectId])
    REFERENCES [dbo].[dProjects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dProjectdTask'
CREATE INDEX [IX_FK_dProjectdTask]
ON [dbo].[dTasks]
    ([dProjectId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------