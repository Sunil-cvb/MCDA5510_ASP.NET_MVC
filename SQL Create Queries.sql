USE [HotelReservationSystem]
GO

/****** Object:  Table [dbo].[USER]    Script Date: 12/1/2018 2:17:19 PM ******/
DROP TABLE [dbo].[USER]
GO

/****** Object:  Table [dbo].[USER]    Script Date: 12/1/2018 2:17:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[USER](
	[userID] [bigint] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[fName] [varchar](50) NOT NULL,
	[lName] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[street] [varchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[province] [varchar](50) NOT NULL,
	[country] [varchar](50) NOT NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO





USE [HotelReservationSystem]
GO

/****** Object:  Table [dbo].[ROOM]    Script Date: 11/29/2018 3:48:41 PM ******/
DROP TABLE [dbo].[ROOM]
GO

/****** Object:  Table [dbo].[ROOM]    Script Date: 11/29/2018 3:48:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ROOM](
	[roomID] [int] IDENTITY(1,1) NOT NULL,
	[roomName] [varchar](50) NOT NULL,
	[roomNum] [int] NOT NULL,
	[roomType] [varchar](50) NOT NULL,
	[price(in CAD)] [int] NOT NULL
) ON [PRIMARY]
GO







USE [HotelReservationSystem]
GO

/****** Object:  Table [dbo].[BOOKING]    Script Date: 11/29/2018 3:48:29 PM ******/
DROP TABLE [dbo].[BOOKING]
GO

/****** Object:  Table [dbo].[BOOKING]    Script Date: 11/29/2018 3:48:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BOOKING](
	[bookingID] [bigint] IDENTITY(1,1) NOT NULL,
	[fromDate] [datetime] NOT NULL,
	[toDate] [datetime] NOT NULL,
	[bookedTime] [datetime] NOT NULL,
	[FK_UID] [bigint] NOT NULL,
	[FK_RID] [int] NOT NULL
) ON [PRIMARY]
GO

USE [HotelReservationSystem]
GO

INSERT INTO [dbo].[ROOM]
           ([roomName]
           ,[roomNum]
           ,[roomType]
           ,[price(in CAD)])
     VALUES
           ('Apple'
           ,101
           ,'Single'
           ,90),
		   ('Banana'
           ,102
           ,'Double'
           ,120),
		   ('Cherry'
           ,103
           ,'Triple'
           ,130),
		   ('Damson'
           ,104
           ,'Quad'
           ,150),
		   ('Elderberry'
           ,105
           ,'Queen'
           ,140),
		   ('Fig'
           ,201
           ,'King'
           ,160),
		   ('Grape'
           ,202
           ,'Twin'
           ,110),
		   ('Hackberry'
           ,203
           ,'Twin'
           ,110),
		   ('Indian Prune'
           ,204
           ,'Single'
           ,90),
		   ('Jambolan'
           ,205
           ,'Single'
           ,90),
		   ('Kiwi'
           ,301
           ,'Master Suite'
           ,290),
		   ('Lime'
           ,302
           ,'Queen'
           ,140),
		   ('Mango'
           ,303
           ,'King'
           ,160),
		   ('Nectarine'
           ,304
           ,'Double'
           ,125),
		   ('Orange'
           ,305
           ,'Triple'
           ,135)
GO
