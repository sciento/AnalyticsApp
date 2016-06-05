
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/05/2016 13:09:13
-- Generated from EDMX file: D:\Cloud\Studium\Webservices\Projekt\AnalyticsApp\AnalyticsServer\Models\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [VWW4];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SiteVisit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Visits] DROP CONSTRAINT [FK_SiteVisit];
GO
IF OBJECT_ID(N'[dbo].[FK_UserSite]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sites] DROP CONSTRAINT [FK_UserSite];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Sites]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sites];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Visits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Visits];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Sites'
CREATE TABLE [dbo].[Sites] (
    [Id] uniqueidentifier  NOT NULL,
    [Url] nvarchar(max)  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] uniqueidentifier  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Username] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Visits'
CREATE TABLE [dbo].[Visits] (
    [Id] uniqueidentifier  NOT NULL,
    [Ip] nvarchar(max)  NOT NULL,
    [Browser] nvarchar(max)  NOT NULL,
    [PageUrl] nvarchar(max)  NOT NULL,
    [CallTime] nvarchar(max)  NOT NULL,
    [ExitTime] nvarchar(max)  NOT NULL,
    [Referral] nvarchar(max)  NOT NULL,
    [Os] nvarchar(max)  NOT NULL,
    [SiteId] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Sites'
ALTER TABLE [dbo].[Sites]
ADD CONSTRAINT [PK_Sites]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [PK_Visits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SiteId] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [FK_SiteVisit]
    FOREIGN KEY ([SiteId])
    REFERENCES [dbo].[Sites]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SiteVisit'
CREATE INDEX [IX_FK_SiteVisit]
ON [dbo].[Visits]
    ([SiteId]);
GO

-- Creating foreign key on [UserId] in table 'Sites'
ALTER TABLE [dbo].[Sites]
ADD CONSTRAINT [FK_UserSite]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserSite'
CREATE INDEX [IX_FK_UserSite]
ON [dbo].[Sites]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------