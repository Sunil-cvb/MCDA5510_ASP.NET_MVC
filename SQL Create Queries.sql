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
	[priceInCAD] [int] NOT NULL,
	[roomURL] [varchar](128)
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
           ,[priceInCAD]
		   ,[roomURL])
     VALUES
           ('DELUXE'
           ,101
           ,'Single'
           ,90,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(1).jpg?alt=media&token=bbe1944b-7576-4e34-99d3-93939ab7e388')
		   ('LUXURY BALCONY'
           ,102
           ,'Double'
           ,120,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(10).jpg?alt=media&token=86c9b6d0-9dbf-4c24-b76b-cd9c5e5d123b'),
		   ('STANDARD'
           ,103
           ,'Triple'
           ,130,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(11).jpg?alt=media&token=c5e2818f-ce04-4a52-934a-bcf74a27fe08'),
		   ('STANDARD'
           ,104
           ,'Quad'
           ,150,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(12).jpg?alt=media&token=f4024417-274b-4881-9718-7b2735bc0258'),
		   ('DELUXE'
           ,105
           ,'Queen'
           ,140,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(13).jpg?alt=media&token=76756117-aec1-43b4-b464-126c5df6917a'),
		   ('DELUXE'
           ,201
           ,'King'
           ,160,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(14).jpg?alt=media&token=322c31a0-5686-4125-a848-0d458ed43777'),
		   ('LUXURY BALCONY'
           ,202
           ,'Twin'
           ,110,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(15).jpg?alt=media&token=d0e49421-db33-4034-a200-dd769862853c'),
		   ('STANDARD'
           ,203
           ,'Twin'
           ,110,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(17).jpg?alt=media&token=4db08bd3-f0df-417e-b30f-12c75479bd48'),
		   ('SPLIT LEVEL'
           ,204
           ,'Single'
           ,90,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(18).jpg?alt=media&token=056e5af6-2f84-49b7-86a3-6657d61745fe'),
		   ('LUXURY BALCONY'
           ,205
           ,'Single'
           ,90,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(19).jpg?alt=media&token=6af78fc0-1726-4500-8c80-3a3b2f81c26e'),
		   ('FAMILY'
           ,301
           ,'Master Suite'
           ,290,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(2).jpg?alt=media&token=124c59cf-5f2d-413c-b94f-3a0019d07b41'),
		   ('FAMILY'
           ,302
           ,'Queen'
           ,140,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(20).jpg?alt=media&token=e9c43ec7-ee76-43ad-99fe-e8b4db5dae90'),
		   ('STANDARD'
           ,303
           ,'King'
           ,160,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(21).jpg?alt=media&token=eb0dfc06-a73d-499e-b09d-f6520ba404ce'),
		   ('LUXURY BALCONY'
           ,304
           ,'Double'
           ,125,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(22).jpg?alt=media&token=2f07bf8f-13d1-4355-b3db-37e28d09845d'),
		   ('STANDARD'
           ,305
           ,'Triple'
           ,135,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(23).jpg?alt=media&token=ca08af31-fe02-4d2d-a04a-630fa3d80434'),
		   ('DELUXE'
           ,401
           ,'Double'
           ,100,
		   'https://firebasestorage.googleapis.com/v0/b/mcda-hotel.appspot.com/o/hotel-rooms%2FHotel-Room%20(24).jpg?alt=media&token=71e24001-e87f-4d0f-baf2-daeb425bf204')
GO


