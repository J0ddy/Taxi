USE [master]
GO
/****** Object:  Database [TaxiDB]    Script Date: 3/20/2022 2:49:27 PM ******/
CREATE DATABASE [TaxiDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TaxiDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NEWSERVER\MSSQL\DATA\TaxiDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TaxiDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NEWSERVER\MSSQL\DATA\TaxiDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TaxiDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TaxiDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TaxiDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TaxiDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TaxiDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TaxiDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TaxiDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TaxiDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TaxiDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TaxiDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TaxiDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TaxiDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TaxiDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TaxiDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TaxiDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TaxiDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TaxiDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TaxiDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TaxiDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TaxiDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TaxiDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TaxiDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TaxiDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TaxiDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TaxiDB] SET RECOVERY FULL 
GO
ALTER DATABASE [TaxiDB] SET  MULTI_USER 
GO
ALTER DATABASE [TaxiDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TaxiDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TaxiDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TaxiDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TaxiDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TaxiDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TaxiDB', N'ON'
GO
ALTER DATABASE [TaxiDB] SET QUERY_STORE = OFF
GO
USE [TaxiDB]
GO
/****** Object:  Table [dbo].[caroptions]    Script Date: 3/20/2022 2:49:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[caroptions](
	[caroptions_id] [int] NOT NULL,
	[autopilot] [bit] NULL,
	[active_airbag] [bit] NULL,
	[usb_port] [bit] NULL,
	[multimedia] [bit] NULL,
	[engine_mode] [varchar](10) NULL,
 CONSTRAINT [PK_caroptions] PRIMARY KEY CLUSTERED 
(
	[caroptions_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cars]    Script Date: 3/20/2022 2:49:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cars](
	[car_id] [int] NOT NULL,
	[license] [varchar](10) NOT NULL,
	[make] [varchar](20) NOT NULL,
	[model] [varchar](20) NOT NULL,
	[color] [varchar](20) NOT NULL,
	[company_id] [int] NOT NULL,
	[year] [varchar](5) NOT NULL,
	[engine_id] [int] NOT NULL,
	[caroptions_id] [int] NOT NULL,
 CONSTRAINT [PK_cars] PRIMARY KEY CLUSTERED 
(
	[car_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[company]    Script Date: 3/20/2022 2:49:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[company](
	[company_id] [int] NOT NULL,
	[name] [varchar](20) NOT NULL,
	[admin_id] [int] NOT NULL,
	[telephone_number] [varchar](20) NOT NULL,
 CONSTRAINT [PK_company] PRIMARY KEY CLUSTERED 
(
	[company_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[driver]    Script Date: 3/20/2022 2:49:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[driver](
	[driver_id] [int] NOT NULL,
	[car_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[firstname] [varchar](25) NOT NULL,
	[lastname] [varchar](25) NOT NULL,
	[telephone_number] [varchar](20) NOT NULL,
 CONSTRAINT [PK_driver] PRIMARY KEY CLUSTERED 
(
	[driver_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[engine]    Script Date: 3/20/2022 2:49:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[engine](
	[engine_id] [int] NOT NULL,
	[cub] [int] NULL,
	[cylinders] [int] NULL,
	[fuel] [varchar](15) NULL,
	[kmtolitre] [int] NOT NULL,
 CONSTRAINT [PK_engine] PRIMARY KEY CLUSTERED 
(
	[engine_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trips]    Script Date: 3/20/2022 2:49:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trips](
	[trip_id] [int] NOT NULL,
	[driver_id] [int] NOT NULL,
	[car_id] [int] NOT NULL,
	[company_id] [int] NOT NULL,
	[triptype_id] [int] NOT NULL,
 CONSTRAINT [PK_trips] PRIMARY KEY CLUSTERED 
(
	[trip_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[triptype]    Script Date: 3/20/2022 2:49:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[triptype](
	[triptype_id] [int] NOT NULL,
	[Tleave_Tarive] [datetime] NOT NULL,
	[origin] [varchar](105) NOT NULL,
	[destinatin] [varchar](105) NOT NULL,
 CONSTRAINT [PK_triptype] PRIMARY KEY CLUSTERED 
(
	[triptype_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 3/20/2022 2:49:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] NOT NULL,
	[user_name] [varchar](25) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](225) NOT NULL,
	[driver_id] [int] NOT NULL,
	[company_id] [int] NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cars]  WITH CHECK ADD  CONSTRAINT [FK_cars_caroptions] FOREIGN KEY([caroptions_id])
REFERENCES [dbo].[caroptions] ([caroptions_id])
GO
ALTER TABLE [dbo].[cars] CHECK CONSTRAINT [FK_cars_caroptions]
GO
ALTER TABLE [dbo].[cars]  WITH CHECK ADD  CONSTRAINT [FK_cars_company] FOREIGN KEY([company_id])
REFERENCES [dbo].[company] ([company_id])
GO
ALTER TABLE [dbo].[cars] CHECK CONSTRAINT [FK_cars_company]
GO
ALTER TABLE [dbo].[cars]  WITH CHECK ADD  CONSTRAINT [FK_cars_engine] FOREIGN KEY([engine_id])
REFERENCES [dbo].[engine] ([engine_id])
GO
ALTER TABLE [dbo].[cars] CHECK CONSTRAINT [FK_cars_engine]
GO
ALTER TABLE [dbo].[driver]  WITH CHECK ADD  CONSTRAINT [FK_driver_car] FOREIGN KEY([car_id])
REFERENCES [dbo].[cars] ([car_id])
GO
ALTER TABLE [dbo].[driver] CHECK CONSTRAINT [FK_driver_car]
GO
ALTER TABLE [dbo].[trips]  WITH CHECK ADD  CONSTRAINT [FK_trips_car] FOREIGN KEY([car_id])
REFERENCES [dbo].[cars] ([car_id])
GO
ALTER TABLE [dbo].[trips] CHECK CONSTRAINT [FK_trips_car]
GO
ALTER TABLE [dbo].[trips]  WITH CHECK ADD  CONSTRAINT [FK_trips_company] FOREIGN KEY([company_id])
REFERENCES [dbo].[company] ([company_id])
GO
ALTER TABLE [dbo].[trips] CHECK CONSTRAINT [FK_trips_company]
GO
ALTER TABLE [dbo].[trips]  WITH CHECK ADD  CONSTRAINT [FK_trips_driver] FOREIGN KEY([driver_id])
REFERENCES [dbo].[driver] ([driver_id])
GO
ALTER TABLE [dbo].[trips] CHECK CONSTRAINT [FK_trips_driver]
GO
ALTER TABLE [dbo].[trips]  WITH CHECK ADD  CONSTRAINT [FK_trips_triptype] FOREIGN KEY([triptype_id])
REFERENCES [dbo].[triptype] ([triptype_id])
GO
ALTER TABLE [dbo].[trips] CHECK CONSTRAINT [FK_trips_triptype]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_driver_user] FOREIGN KEY([driver_id])
REFERENCES [dbo].[driver] ([driver_id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_driver_user]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_user_company] FOREIGN KEY([company_id])
REFERENCES [dbo].[company] ([company_id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_user_company]
GO
USE [master]
GO
ALTER DATABASE [TaxiDB] SET  READ_WRITE 
GO
