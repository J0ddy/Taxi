/*USE [master]
GO
/****** Object:  Database [TaxiDB]    Script Date: 3/20/2022 2:51:53 PM ******/

CREATE DATABASE [TaxiDB]
/* CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TaxiDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NEWSERVER\MSSQL\DATA\TaxiDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TaxiDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NEWSERVER\MSSQL\DATA\TaxiDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
*/
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
/****** Object:  Table [dbo].[caroptions]    Script Date: 3/20/2022 2:51:53 PM ******/
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
/****** Object:  Table [dbo].[cars]    Script Date: 3/20/2022 2:51:53 PM ******/
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
/****** Object:  Table [dbo].[company]    Script Date: 3/20/2022 2:51:53 PM ******/
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
/****** Object:  Table [dbo].[driver]    Script Date: 3/20/2022 2:51:53 PM ******/
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
/****** Object:  Table [dbo].[engine]    Script Date: 3/20/2022 2:51:53 PM ******/
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
/****** Object:  Table [dbo].[trips]    Script Date: 3/20/2022 2:51:53 PM ******/
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
/****** Object:  Table [dbo].[triptype]    Script Date: 3/20/2022 2:51:53 PM ******/
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
/****** Object:  Table [dbo].[users]    Script Date: 3/20/2022 2:51:53 PM ******/
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
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (1, 1, 0, 1, 1, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (2, 0, 0, 0, 0, N'high usage')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (3, 1, 1, 1, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (4, 0, 1, 1, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (5, 0, 1, 1, 0, N'high usage')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (6, 0, 1, 1, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (7, 0, 1, 1, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (8, 0, 1, 0, 0, N'high usage')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (9, 0, 1, 1, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (10, 0, 1, 1, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (11, 0, 1, 0, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (12, 0, 1, 1, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (13, 0, 1, 0, 0, N'high usage')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (14, 0, 1, 1, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (15, 0, 1, 1, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (16, 0, 1, 0, 0, N'high usage')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (17, 0, 1, 1, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (18, 0, 1, 1, 0, N'standard')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (19, 1, 1, 1, 1, N'eco')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (20, 0, 1, 0, 0, N'high usage')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (21, 0, 1, 0, 0, N'high usage')
INSERT [dbo].[caroptions] ([caroptions_id], [autopilot], [active_airbag], [usb_port], [multimedia], [engine_mode]) VALUES (22, 0, 1, 1, 0, N'standard')
GO
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (1, N'CT2640AP', N'Opel', N'Vauxhall Astra', N'yellow', 1, N'2010', 1, 1)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (2, N'CT9707KT', N'Renault', N'Scenic', N'yellow', 1, N'1996', 2, 2)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (3, N'CT9477BH', N'Toyota', N'ETIOS', N'green', 1, N'2010', 3, 3)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (4, N'CT9920HP', N'Opel', N'Vauxhall Astra', N'yellow', 1, N'2010', 4, 4)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (5, N'CT3688TT', N'VW', N'Passat', N'yellow', 1, N'2002', 5, 5)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (6, N'CT4694BM', N'Toyota', N'ETIOS', N'yellow', 1, N'2010', 6, 6)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (7, N'CT3088MX', N'Shkoda', N'Vauxhall Astra', N'green', 1, N'2010', 7, 7)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (8, N'CT3347HP', N'Dacia', N'Solenza', N'yellow', 1, N'2004', 8, 8)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (9, N'CT1199PM', N'Hyundai', N'i40', N'green', 1, N'2011', 9, 9)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (10, N'CT9791TP', N'Opel', N'Vauxhall Astra', N'yellow', 1, N'2010', 10, 10)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (11, N'CT7053BC', N'Renault', N'Scenic', N'yellow', 1, N'1996', 11, 11)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (12, N'PB6682KS', N'Toyota', N'ETIOS', N'yellow', 2, N'2010', 12, 12)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (13, N'PB6025CM', N'Opel', N'Vauxhall Astra', N'yellow', 2, N'2010', 13, 13)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (14, N'PB6311CA', N'Dacia', N'Solenza', N'yellow', 2, N'2004', 14, 14)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (15, N'PB8252HM', N'Hyundai', N'i40', N'yellow', 2, N'2011', 15, 15)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (16, N'PB5780TX', N'Opel', N'Vauxhall Astra', N'green', 2, N'2010', 16, 16)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (17, N'PB7877PM', N'Renault', N'Scenic', N'yellow', 2, N'1996', 17, 17)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (18, N'PB8148MB', N'Toyota', N'ETIOS', N'yellow', 2, N'1996', 18, 18)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (19, N'PB4769KT', N'Tesla', N'Model 3', N'black', 2, N'2017', 19, 19)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (20, N'PB7244KC', N'VW', N'Passat', N'yellow', 2, N'2002', 20, 20)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (21, N'PB5773PC', N'Renault', N'Scenic', N'yellow', 2, N'1996', 21, 21)
INSERT [dbo].[cars] ([car_id], [license], [make], [model], [color], [company_id], [year], [engine_id], [caroptions_id]) VALUES (22, N'PB7887KA', N'Toyota', N'ETIOS', N'yellow', 2, N'2010', 22, 22)
GO
INSERT [dbo].[company] ([company_id], [name], [admin_id], [telephone_number]) VALUES (1, N'TaxiHub', 1, N'+359886759674')
INSERT [dbo].[company] ([company_id], [name], [admin_id], [telephone_number]) VALUES (2, N'SmoothTaxi', 2, N'+359881509313')
GO
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (1, 1, 1, N'Dobrin', N'Vitanov', N'+359893976866')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (2, 2, 2, N'Aleksander', N'Manolov', N'+359899186995')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (3, 3, 3, N'Anton', N'Hadjiivanov', N'+359872014587')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (4, 4, 4, N'Kamen', N'Svetoslavov', N'+359885544615')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (5, 5, 5, N'Stoyan', N'Dobrev', N'+359898354498')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (6, 6, 6, N'Yosif', N'Zhelev', N'+359892079389')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (7, 7, 7, N'Miladin', N'Tsetkov', N'+359891438100')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (8, 8, 8, N'Penio', N'Yankov', N'+359898341024')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (9, 9, 9, N'Ivailo', N'Kochanov', N'+359893186031')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (10, 10, 10, N'Dragan', N'Kynev', N'+359884269008')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (11, 11, 11, N'Rumen', N'Dobrev', N'+359887447863')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (12, 12, 12, N'Zhelyazko', N'Borisov', N'+359897364278')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (13, 13, 13, N'Spas', N'Paskalev', N'+359893312800')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (14, 14, 14, N'Georgi', N'Rusinov', N'+359896192355')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (15, 15, 15, N'Ivan', N'Nikolov', N'+359881412524')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (16, 16, 16, N'Boyko', N'Alexov', N'+359892500723')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (17, 17, 17, N'Angel', N'Zhelev', N'+359898222344')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (18, 18, 18, N'Stefan', N'Glavchev', N'+359894392128')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (19, 19, 19, N'Miroslav', N'Bakalov', N'+359887745469')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (20, 20, 20, N'Geogri', N'Ivanov', N'+359895918514')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (21, 21, 21, N'Georgi', N'Radulov', N'+359985673145')
INSERT [dbo].[driver] ([driver_id], [car_id], [user_id], [firstname], [lastname], [telephone_number]) VALUES (22, 22, 22, N'Alexander', N'Filipov', N'+359987320986')
GO
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (1, 2000, 4, N'Diesel', 12)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (2, 1800, 4, N'Petrol', 20)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (3, 1500, 4, N'Diesel', 16)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (4, 2000, 4, N'Petrol', 12)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (5, 4000, 8, N'Petrol', 13)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (6, 1500, 4, N'Diesel', 16)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (7, 2000, 4, N'Diesel', 12)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (8, 1400, 4, N'Petrol', 14)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (9, 2000, 4, N'Petrol', 13)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (10, 2000, 8, N'Diesel', 12)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (11, 1800, 4, N'Petrol', 20)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (12, 1500, 4, N'Diesel', 16)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (13, 2000, 6, N'Diesel', 12)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (14, 1400, 4, N'Petrol', 14)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (15, 2000, 4, N'Petrol', 13)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (16, 1800, 4, N'Petrol', 12)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (17, 1500, 4, N'Diesel', 16)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (18, 4000, 0, N'Electricity', 0)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (19, 4000, 8, N'Petrol', 13)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (20, 1800, 4, N'Petrol', 20)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (21, 1500, 4, N'Diesel', 16)
INSERT [dbo].[engine] ([engine_id], [cub], [cylinders], [fuel], [kmtolitre]) VALUES (22, 1400, 4, N'Petrol', 14)
GO
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (1, 1, 1, 1, 1)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (2, 2, 2, 1, 2)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (3, 3, 3, 1, 3)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (4, 4, 4, 1, 4)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (5, 5, 5, 1, 5)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (6, 6, 6, 1, 6)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (7, 7, 7, 1, 7)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (8, 8, 8, 1, 8)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (9, 9, 9, 1, 9)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (10, 10, 10, 1, 10)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (11, 11, 11, 1, 11)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (12, 12, 12, 2, 12)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (13, 13, 13, 2, 13)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (14, 14, 14, 2, 14)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (15, 15, 15, 2, 15)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (16, 16, 16, 2, 16)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (17, 17, 17, 2, 17)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (18, 18, 18, 2, 18)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (19, 19, 19, 2, 19)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (20, 20, 20, 2, 20)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (21, 21, 21, 2, 21)
INSERT [dbo].[trips] ([trip_id], [driver_id], [car_id], [company_id], [triptype_id]) VALUES (22, 22, 22, 2, 22)
GO
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (1, CAST(N'2022-03-19T04:30:00.000' AS DateTime), N'ул. "Герасим Папазчев" 20, Stara Zagora, 6000, Bulgaria', N'ул. "Августа Траяна" 44, Stara Zagora, 6000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (2, CAST(N'2022-03-19T00:00:00.000' AS DateTime), N'ул. "Хан Аспарух" 27, Stara Zagora, 6000, Bulgaria', N'бул. "Никола Петков" 49, Stara Zagora, 6000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (3, CAST(N'2022-03-18T00:00:00.000' AS DateTime), N'бул. "Цар Симеон Освободител" 15, Stara Zagora, 6000, Bulgaria', N'ул. "Августа Траява" 13, Stara Zagora, 6000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (4, CAST(N'2022-03-18T00:00:00.000' AS DateTime), N'ул. "Христо Ботев" 34, Stara Zagora, 6000, Bulgaria', N'ул. "Марица" 16, Stara Zagora, 6000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (5, CAST(N'2022-03-18T00:00:00.000' AS DateTime), N'ул. "Асен Втори" 3, Stara Zagora, 6000, Bulgaria', N'бул. "Шести септември" 7, Stara Zagora, 6000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (6, CAST(N'2022-03-18T00:00:00.000' AS DateTime), N'бул. "Алеко Константинов" 6, Stara Zagora, 6000, Bulgaria', N'ул. "Александър Стамболийски" 27, Stara Zagora, 6000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (7, CAST(N'2022-03-16T00:00:00.000' AS DateTime), N'ул. "Стефан Стамболов" 13, Stara Zagora, 6000, Bulgaria', N'ул. "Свети Княз Борис" 17, Stara Zagora, 6000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (8, CAST(N'2022-03-16T00:00:00.000' AS DateTime), N'бул. "Трети март" 29, Stara Zagora, 6000, Bulgaria', N'ул. "Никола Икономов" 14, Stara Zagora, 6000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (9, CAST(N'2022-03-15T00:00:00.000' AS DateTime), N'ул. "Вишнева" 19, Stara Zagora, 6000, Bulgaria', N'ул. "Дунав" 33, Stara Zagora, 6000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (10, CAST(N'2022-03-15T00:00:00.000' AS DateTime), N'ул. "Пейо Яворов" 4, Stara Zagora, 6000, Bulgaria', N'ул. "Васил Левски" 5, Stara Zagora, 6000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (11, CAST(N'2022-03-15T00:00:00.000' AS DateTime), N'ул. "Иван Шишман" 17, Stara Zagora, 6000, Bulgaria', N'ул. "Генерал Стоилов" 26, Stara Zagora, 6000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (12, CAST(N'2022-03-12T00:00:00.000' AS DateTime), N'бул. "В. Априлов" 15, Plovdiv, 4000, Bulgaria', N'ул. "Гагарин" 6, Plovdiv, 4000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (13, CAST(N'2022-03-11T00:00:00.000' AS DateTime), N'ул. "Съединение" 13, Plovdiv, 4000, Bulgaria', N'ул. "Генерал Кутузов" 4, Plovdiv, 4000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (14, CAST(N'2022-03-11T00:00:00.000' AS DateTime), N'ул. "Огоста" 26, Plovdiv, 4000, Bulgaria', N'бул. "Христо Ботев" 46, Plovdiv, 4000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (15, CAST(N'2022-03-09T00:00:00.000' AS DateTime), N'ул. "Лайпциг" 10, Plovdiv, 4000, Bulgaria', N'ул. "Гладстон" 23, Plovdiv, 4000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (16, CAST(N'2022-03-09T00:00:00.000' AS DateTime), N'бул. "6-ти Септември" 141, Plovdiv, 4000, Bulgaria', N'ул. "Поручик Боян Ботев" 12, Plovdiv, 4000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (17, CAST(N'2022-03-09T00:00:00.000' AS DateTime), N'ул. "Иван Стефанов Гешев" 6, Plovdiv, 4000, Bulgaria', N'ул. "Д-р Георги Странски" 3, Plovdiv, 4000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (18, CAST(N'2022-03-09T00:00:00.000' AS DateTime), N'ул. "Никола Петков" 10, Plovdiv, 4000, Bulgaria', N'ул. "Перущица" 8, Plovdiv, 4000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (19, CAST(N'2022-03-09T00:00:00.000' AS DateTime), N'ул. "Хан Крум" 9, Plovdiv, 4000, Bulgaria', N'бул. "Цар Борис III Обединител" 93, Plovdiv, 4000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (20, CAST(N'2022-03-09T00:00:00.000' AS DateTime), N'ул. "Филипово" 34, Plovdiv, 4000, Bulgaria', N'ул. "Ален мак" 40, Plovdiv, 4000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (21, CAST(N'2022-03-02T00:00:00.000' AS DateTime), N'ул. "Просвета" 28, Plovdiv, 4000, Bulgaria', N'бул. "България" 234, Plovdiv, 4000, Bulgaria')
INSERT [dbo].[triptype] ([triptype_id], [Tleave_Tarive], [origin], [destinatin]) VALUES (22, CAST(N'2022-03-08T00:00:00.000' AS DateTime), N'бул. "Христо Ботев" 42, Plovdiv, 4000, Bulgaria', N'ул. "Перущица" 8, Plovdiv, 4000, Bulgaria')
GO
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (1, N'dobrinvittt', N'dobrinvitanovv71@abv.bg', N'FFGvbrCvUhDL', 1, 1)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (2, N'mnlalekxandr', N'manolovalexdrov@gmail.com', N'MljCXt0HdFsr', 2, 2)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (3, N'hadjianton', N'antonhadjivanov@abv.bg', N'qoqHal52G48o', 3, 2)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (4, N'kamensvetss', N'svetoslavov_kamen@mail.bg', N'605PcrRKnv3F', 4, 1)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (5, N'stoyandobrev1', N'dobrevstoyan@yahoo.com', N'W50Hu5guG8k5', 5, 1)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (6, N'yosiffzheleff', N'zhelevyosiff@mail.bg', N'R8yRT321ZvNJ', 6, 2)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (7, N'miladintsvetkov', N'miladinsvetkov@abv.bg', N'GPJY3cRKIDtA', 7, 1)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (8, N'penyankov76', N'penio.yankov@gmail.com', N'wCrPjxNc1zck', 8, 2)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (9, N'ikochanov', N'ivankochanov@gmail.com', N'JWEDI7D78ktx', 9, 1)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (10, N'dragannkanev', N'dragankanav@gmail.com', N'cuB9JmMNCNTj', 10, 1)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (11, N'dobrevrumenn', N'rumen_dobrev@abv.bg', N'O0crfYrMnF0e', 11, 2)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (12, N'zhelyazkoborisoff', N'borisov.zhelqzko@mail.bg', N'NN5r3y3NG33b', 12, 2)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (13, N'spaskalev', N'spaskalev.68@abv.bg', N'SYLz5tRclV8W', 13, 1)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (14, N'georgirusinovv', N'rusinovgeorgi5@gmail.com', N'A18I7QsHEleY', 14, 1)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (15, N'ivanokolov94', N'ivankolov94@abv.bg', N'k5tnSmoimKiu', 15, 2)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (16, N'alexovboyko', N'alexov.boyko@gmail.com', N'xKPfGriuLJJb', 16, 1)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (17, N'angelzhelev', N'angelzhelev@mail.bg', N'NyFv35e6EOmE', 17, 2)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (18, N'steffanglavchev56', N'56stefanglavchev@abv.bg', N'FFGvbrCvUhDL', 18, 2)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (19, N'mirroslvbklv
', N'bakalovmiroslav@gmail.com', N'wfJWvShGiJ55', 19, 1)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (20, N'georgiivanov', N'ivanovgeorgi16@abv.bg', N'SxnYjuX8w1sU', 20, 1)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (21, N'radulof', N'radulov.georgi@gmail.com', N'sVfJ6hWl1Nop', 21, 2)
INSERT [dbo].[users] ([user_id], [user_name], [email], [password], [driver_id], [company_id]) VALUES (22, N'filippovalexander', N'alex.filipov@gmail.com', N'sYUNr7Z3kTAF', 22, 2)
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
