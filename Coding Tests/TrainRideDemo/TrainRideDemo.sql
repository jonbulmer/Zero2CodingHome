USE [master]
GO
/****** Object:  Database [TrainRideDemo]    Script Date: 03/02/2019 19:42:32 ******/
CREATE DATABASE [TrainRideDemo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TrainRideDemo', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TrainRideDemo.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TrainRideDemo_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TrainRideDemo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TrainRideDemo] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TrainRideDemo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TrainRideDemo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TrainRideDemo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TrainRideDemo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TrainRideDemo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TrainRideDemo] SET ARITHABORT OFF 
GO
ALTER DATABASE [TrainRideDemo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TrainRideDemo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TrainRideDemo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TrainRideDemo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TrainRideDemo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TrainRideDemo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TrainRideDemo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TrainRideDemo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TrainRideDemo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TrainRideDemo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TrainRideDemo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TrainRideDemo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TrainRideDemo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TrainRideDemo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TrainRideDemo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TrainRideDemo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TrainRideDemo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TrainRideDemo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TrainRideDemo] SET  MULTI_USER 
GO
ALTER DATABASE [TrainRideDemo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TrainRideDemo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TrainRideDemo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TrainRideDemo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TrainRideDemo]
GO
/****** Object:  Table [dbo].[ArrivalTime]    Script Date: 03/02/2019 19:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArrivalTime](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArrivalTime] [datetime] NOT NULL,
	[StopMatrixId] [int] NOT NULL,
 CONSTRAINT [PK_ArrivalTime] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Route]    Script Date: 03/02/2019 19:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Route](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Route] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stop]    Script Date: 03/02/2019 19:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stop](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Stop] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StopMaxtrix]    Script Date: 03/02/2019 19:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StopMaxtrix](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RouteId] [int] NOT NULL,
	[StopProximityId] [int] NOT NULL,
	[PositionIndex] [int] NOT NULL,
 CONSTRAINT [PK_StopMaxtrix] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StopProcedure]    Script Date: 03/02/2019 19:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StopProcedure](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StopId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ActionTime] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_StopProcedure] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StopProximity]    Script Date: 03/02/2019 19:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StopProximity](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StopMaxtrixId] [int] NOT NULL,
	[StopId] [int] NOT NULL,
	[DestinationStopId] [int] NOT NULL,
	[Distance] [decimal](18, 2) NOT NULL,
	[DegreesOfNorth] [int] NOT NULL,
 CONSTRAINT [PK_StopProximity] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Timetable]    Script Date: 03/02/2019 19:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Timetable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RouteId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[StartStopTime] [datetime] NOT NULL,
	[TrainId] [int] NOT NULL,
 CONSTRAINT [PK_Timetable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Train]    Script Date: 03/02/2019 19:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Train](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TimeableId] [int] NOT NULL,
	[TrainPositionId] [int] NOT NULL,
 CONSTRAINT [PK_Train] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrainPosition]    Script Date: 03/02/2019 19:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrainPosition](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TrainId] [int] NULL,
	[Vehicle] [int] NULL,
 CONSTRAINT [PK_TrainPosition] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 03/02/2019 19:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nmae] [varbinary](50) NOT NULL,
	[VehicleTypeId] [int] NOT NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VehicleType]    Script Date: 03/02/2019 19:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_VehicleType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ArrivalTime]  WITH CHECK ADD  CONSTRAINT [FK_ArrivalTime_StopMaxtrix] FOREIGN KEY([StopMatrixId])
REFERENCES [dbo].[StopMaxtrix] ([id])
GO
ALTER TABLE [dbo].[ArrivalTime] CHECK CONSTRAINT [FK_ArrivalTime_StopMaxtrix]
GO
ALTER TABLE [dbo].[StopMaxtrix]  WITH CHECK ADD  CONSTRAINT [FK_StopMaxtrix_Route] FOREIGN KEY([RouteId])
REFERENCES [dbo].[Route] ([Id])
GO
ALTER TABLE [dbo].[StopMaxtrix] CHECK CONSTRAINT [FK_StopMaxtrix_Route]
GO
ALTER TABLE [dbo].[StopProcedure]  WITH CHECK ADD  CONSTRAINT [FK_StopProcedure_Stop] FOREIGN KEY([StopId])
REFERENCES [dbo].[Stop] ([Id])
GO
ALTER TABLE [dbo].[StopProcedure] CHECK CONSTRAINT [FK_StopProcedure_Stop]
GO
ALTER TABLE [dbo].[StopProximity]  WITH CHECK ADD  CONSTRAINT [FK_StopProximity_Stop] FOREIGN KEY([StopId])
REFERENCES [dbo].[Stop] ([Id])
GO
ALTER TABLE [dbo].[StopProximity] CHECK CONSTRAINT [FK_StopProximity_Stop]
GO
ALTER TABLE [dbo].[StopProximity]  WITH CHECK ADD  CONSTRAINT [FK_StopProximity_StopMaxtrix] FOREIGN KEY([StopId])
REFERENCES [dbo].[StopMaxtrix] ([id])
GO
ALTER TABLE [dbo].[StopProximity] CHECK CONSTRAINT [FK_StopProximity_StopMaxtrix]
GO
ALTER TABLE [dbo].[Timetable]  WITH CHECK ADD  CONSTRAINT [FK_Timetable_Route] FOREIGN KEY([RouteId])
REFERENCES [dbo].[Route] ([Id])
GO
ALTER TABLE [dbo].[Timetable] CHECK CONSTRAINT [FK_Timetable_Route]
GO
ALTER TABLE [dbo].[Timetable]  WITH CHECK ADD  CONSTRAINT [FK_Timetable_Train] FOREIGN KEY([TrainId])
REFERENCES [dbo].[Train] ([Id])
GO
ALTER TABLE [dbo].[Timetable] CHECK CONSTRAINT [FK_Timetable_Train]
GO
ALTER TABLE [dbo].[Train]  WITH CHECK ADD  CONSTRAINT [FK_Train_TrainPosition] FOREIGN KEY([TrainPositionId])
REFERENCES [dbo].[TrainPosition] ([Id])
GO
ALTER TABLE [dbo].[Train] CHECK CONSTRAINT [FK_Train_TrainPosition]
GO
USE [master]
GO
ALTER DATABASE [TrainRideDemo] SET  READ_WRITE 
GO
