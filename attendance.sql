
--Table dbo.serviceNumber

USE [attendance]
GO

--Create table and its columns
CREATE TABLE [dbo].[serviceNumber] (
	[id] [int] NOT NULL IDENTITY (1, 1),
	[serviceNus] [nvarchar](MAX) NULL);
GO

--Table dbo.staffIdNumber

USE [attendance]
GO

--Create table and its columns
CREATE TABLE [dbo].[staffIdNumber] (
	[id] [int] NOT NULL IDENTITY (1, 1),
	[staffIdNus] [nvarchar](MAX) NULL);
GO

--Table dbo.tbAttendance

USE [attendance]
GO

--Create table and its columns
CREATE TABLE [dbo].[tbAttendance] (
	[id] [int] NOT NULL IDENTITY (1, 1),
	[serviceNus] [int] NOT NULL,
	[staffIdNus] [int] NOT NULL,
	[isPresent] [nchar](3) NULL,
	[logIn] [datetime] NULL,
	[logOut] [datetime] NULL,
	[date] [date] NOT NULL,
	[picture] [image] NULL,
	[shift] [int] NULL,
	[otherGatherings] [int] NOT NULL,
	[schedule] [int] NULL);
GO

--Table dbo.tbDropdowns

USE [attendance]
GO

--Create table and its columns
CREATE TABLE [dbo].[tbDropdowns] (
	[id] [int] NOT NULL IDENTITY (1, 1),
	[narrations] [nvarchar](MAX) NULL,
	[type] [nchar](10) NULL);
GO

SET IDENTITY_INSERT [dbo].[tbDropdowns] ON
GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (1, N'REINFORCEMENT', N'Gathering ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (2, N'GENERAL MEETING', N'Gathering ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (3, N'CLEAN UP EXERCISE ', N'Gathering ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (4, N'BEING ANNUAL LEAVE', N'Reason    ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (5, N'BEING APPLICATION FOR PASS', N'Reason    ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (6, N'BEING TRANSFER TO OUTPOST', N'Reason    ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (7, N'ALPHA', N'Shift     ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (8, N'BRAVO', N'Shift     ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (9, N'CHARLI', N'Shift     ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (11, N'COMPTROLLER-GENERAL', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (12, N'DEPUTY COMPTROLLER-GENERAL', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (13, N'COMMISSIONAL', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (14, N'DEPUTY COMMISSIONAL', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (15, N'ASSISTANT COMMISSIONAL', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (16, N'SUPRINTENDENT', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (17, N'CHIEF SUPRINTENDENT', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (18, N'DEPUTY SUPRINTENDENT', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (19, N'ASSISTANT SUPRINTENDENT', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (20, N'SENIOR INSPECTOR', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (21, N'INSPECTOR', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (22, N'ASSISTANT INSPECTOR', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (23, N'ICO', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (24, N'ICO l', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (25, N'ICO ll', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (26, N'NONE', N'Rank      ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (27, N'MALE', N'Gender    ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (28, N'FEMALE', N'Gender    ')

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (29, N'ATTENDANCE', NULL)

GO
INSERT INTO [dbo].[tbDropdowns] ([id], [narrations], [type])
	VALUES (10, N'DELTA', N'Shift     ')

GO
SET IDENTITY_INSERT [dbo].[tbDropdowns] OFF
GO

--Table dbo.tbLeave

USE [attendance]
GO

--Create table and its columns
CREATE TABLE [dbo].[tbLeave] (
	[id] [int] NOT NULL IDENTITY (1, 1),
	[serviceNus] [int] NOT NULL,
	[staffIdNus] [int] NOT NULL,
	[reason] [int] NOT NULL,
	[date] [date] NULL,
	[isActive] [nchar](3) NULL CONSTRAINT [DF_tbLeave_isActive] DEFAULT (N'NO'),
	[officer] [int] NULL,
	[authorizer] [int] NULL);
GO

--Table dbo.TbOtherGathering

USE [attendance]
GO

--Create table and its columns
CREATE TABLE [dbo].[TbOtherGathering] (
	[id] [int] NOT NULL IDENTITY (1, 1),
	[narration] [int] NULL,
	[date] [datetime] NULL,
	[officer] [int] NULL,
	[authorizer] [int] NULL);
GO

--Table dbo.tbOutpost

USE [attendance]
GO

--Create table and its columns
CREATE TABLE [dbo].[tbOutpost] (
	[id] [int] NOT NULL IDENTITY (1, 1),
	[post] [nvarchar](MAX) NULL);
GO

--Table dbo.tbStaffDetails

USE [attendance]
GO

--Create table and its columns
CREATE TABLE [dbo].[tbStaffDetails] (
	[id] [int] NOT NULL IDENTITY (1, 1),
	[serviceNus] [int] NOT NULL,
	[staffIdNus] [int] NOT NULL,
	[firstName] [nvarchar](MAX) NOT NULL,
	[surName] [nvarchar](MAX) NOT NULL,
	[otherName] [nvarchar](MAX) NULL,
	[dateOfBirth] [date] NULL,
	[rank] [int] NOT NULL,
	[gender] [int] NOT NULL,
	[dateEmployed] [date] NULL,
	[dateAtBPC] [date] NULL,
	[picture] [image] NULL,
	[isActive] [nchar](3) NULL CONSTRAINT [DF_tbStaffDetails_isActive] DEFAULT (N'NO'),
	[userRole] [int] NULL,
	[shift] [int] NOT NULL,
	[schedule] [int] NULL,
	[leave_pass] [nchar](3) NULL CONSTRAINT [DF_tbStaffDetails_leave_pass] DEFAULT (N'NO'),
	[authorizer] [int] NULL,
	[pcAuthentication] [nvarchar](MAX) NULL);
GO

--Table dbo.userRole

USE [attendance]
GO

--Create table and its columns
CREATE TABLE [dbo].[userRole] (
	[id] [int] NOT NULL,
	[role] [nvarchar](MAX) NULL);
GO

INSERT INTO [dbo].[userRole] ([id], [role])
	VALUES (1, N'ADMINISTRATOR')

GO
INSERT INTO [dbo].[userRole] ([id], [role])
	VALUES (2, N'SUPERVICER')

GO
INSERT INTO [dbo].[userRole] ([id], [role])
	VALUES (3, N'SHIFT LEADER')

GO
INSERT INTO [dbo].[userRole] ([id], [role])
	VALUES (4, N'FRONT LINE')

GO
