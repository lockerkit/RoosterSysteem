
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/10/2019 23:22:37
-- Generated from EDMX file: C:\Users\F. Wenteloo\Source\Repos\lockerkit\RoosterSysteem\RoosterSysteem\Models\LoginDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ZuydDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserUserInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserInfoes] DROP CONSTRAINT [FK_UserUserInfo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Classroom]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Classroom];
GO
IF OBJECT_ID(N'[dbo].[Education]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Education];
GO
IF OBJECT_ID(N'[dbo].[Teacher]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teacher];
GO
IF OBJECT_ID(N'[dbo].[UserInfoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfoes];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [UserName] varchar(50)  NULL,
    [Password] varchar(100)  NULL
);
GO

-- Creating table 'UserInfoes'
CREATE TABLE [dbo].[UserInfoes] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(50)  NULL,
    [LastName] nvarchar(50)  NULL,
    [MailAddress] nvarchar(50)  NULL,
    [Faculty] nvarchar(50)  NULL,
    [Module] nvarchar(50)  NULL,
    [AvailableHours] int  NULL,
    [UserUserID] int  NOT NULL
);
GO

-- Creating table 'Classrooms'
CREATE TABLE [dbo].[Classrooms] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [classroomNumber] varchar(50)  NULL,
    [capacityClassroom] int  NULL,
    [typeClassroom] varchar(50)  NULL,
    [linkedFaculty] varchar(50)  NULL
);
GO

-- Creating table 'Educations'
CREATE TABLE [dbo].[Educations] (
    [ID] int  NOT NULL,
    [educationName] varchar(45)  NULL,
    [linkedFaculty] varchar(45)  NULL,
    [courses] varchar(45)  NULL,
    [typeEducation] varchar(45)  NULL
);
GO

-- Creating table 'Teachers'
CREATE TABLE [dbo].[Teachers] (
    [ID] int  NOT NULL,
    [firstName] varchar(45)  NULL,
    [lastName] varchar(45)  NULL,
    [linkedFaculty] varchar(45)  NULL,
    [availableHours] float  NULL,
    [availableDays] varchar(45)  NULL,
    [availableWeeklyHours] float  NULL,
    [qualifiedCourse] varchar(45)  NULL,
    [email] varchar(45)  NULL,
    [note] varchar(100)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [ID] in table 'UserInfoes'
ALTER TABLE [dbo].[UserInfoes]
ADD CONSTRAINT [PK_UserInfoes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Classrooms'
ALTER TABLE [dbo].[Classrooms]
ADD CONSTRAINT [PK_Classrooms]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Educations'
ALTER TABLE [dbo].[Educations]
ADD CONSTRAINT [PK_Educations]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Teachers'
ALTER TABLE [dbo].[Teachers]
ADD CONSTRAINT [PK_Teachers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserUserID] in table 'UserInfoes'
ALTER TABLE [dbo].[UserInfoes]
ADD CONSTRAINT [FK_UserUserInfo]
    FOREIGN KEY ([UserUserID])
    REFERENCES [dbo].[Users]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserUserInfo'
CREATE INDEX [IX_FK_UserUserInfo]
ON [dbo].[UserInfoes]
    ([UserUserID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------