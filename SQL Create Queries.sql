USE [HotelRsvp]
GO

/****** Object:  Table [dbo].[USER]    Script Date: 11/29/2018 3:48:48 PM ******/
DROP TABLE [dbo].[USER]
GO

/****** Object:  Table [dbo].[USER]    Script Date: 11/29/2018 3:48:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[USER](
	[userID] [bigint] NOT NULL,
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


USE [HotelRsvp]
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
	[roomID] [int] NOT NULL,
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
	[bookingID] [bigint] NOT NULL,
	[fromDate] [datetime] NOT NULL,
	[toDate] [datetime] NOT NULL,
	[bookedTime] [datetime] NOT NULL,
	[FK_UID] [bigint] NOT NULL,
	[FK_RID] [int] NOT NULL
) ON [PRIMARY]
GO


