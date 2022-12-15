USE [master]
GO
/****** Object:  Database [PerfumeWorld]    Script Date: 15.12.2022 18:30:21 ******/
CREATE DATABASE [PerfumeWorld]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PerfumeWorld', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.LOCAL\MSSQL\DATA\PerfumeWorld.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PerfumeWorld_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.LOCAL\MSSQL\DATA\PerfumeWorld_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PerfumeWorld] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PerfumeWorld].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PerfumeWorld] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PerfumeWorld] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PerfumeWorld] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PerfumeWorld] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PerfumeWorld] SET ARITHABORT OFF 
GO
ALTER DATABASE [PerfumeWorld] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PerfumeWorld] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PerfumeWorld] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PerfumeWorld] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PerfumeWorld] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PerfumeWorld] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PerfumeWorld] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PerfumeWorld] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PerfumeWorld] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PerfumeWorld] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PerfumeWorld] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PerfumeWorld] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PerfumeWorld] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PerfumeWorld] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PerfumeWorld] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PerfumeWorld] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PerfumeWorld] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PerfumeWorld] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PerfumeWorld] SET  MULTI_USER 
GO
ALTER DATABASE [PerfumeWorld] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PerfumeWorld] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PerfumeWorld] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PerfumeWorld] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PerfumeWorld] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PerfumeWorld] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PerfumeWorld] SET QUERY_STORE = OFF
GO
USE [PerfumeWorld]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 15.12.2022 18:30:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 15.12.2022 18:30:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[ManufacturerId] [int] IDENTITY(1,1) NOT NULL,
	[ManufacturerName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Manufacturer] PRIMARY KEY CLUSTERED 
(
	[ManufacturerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 15.12.2022 18:30:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[OrderDateDelivery] [date] NOT NULL,
	[PointId] [int] NOT NULL,
	[OrderClientName] [nvarchar](max) NULL,
	[OrderCode] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderProduct]    Script Date: 15.12.2022 18:30:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProduct](
	[OrderId] [int] NOT NULL,
	[ProductArticle] [nvarchar](100) NOT NULL,
	[OrderProductCount] [int] NOT NULL,
 CONSTRAINT [PK_OrderProduct] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductArticle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Point]    Script Date: 15.12.2022 18:30:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Point](
	[PointId] [int] IDENTITY(1,1) NOT NULL,
	[PointName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Point] PRIMARY KEY CLUSTERED 
(
	[PointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 15.12.2022 18:30:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductArticle] [nvarchar](100) NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[UnitId] [int] NOT NULL,
	[ProductCost] [float] NOT NULL,
	[ProductMaxSale] [int] NOT NULL,
	[ManufacturerId] [int] NOT NULL,
	[ProviderId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductSale] [int] NOT NULL,
	[ProductCount] [int] NOT NULL,
	[ProductDescription] [nvarchar](max) NULL,
	[ProductPhoto] [nvarchar](max) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductArticle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 15.12.2022 18:30:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[ProviderId] [int] IDENTITY(1,1) NOT NULL,
	[ProviderName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[ProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 15.12.2022 18:30:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 15.12.2022 18:30:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 15.12.2022 18:30:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitId] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 15.12.2022 18:30:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[UserFullName] [nvarchar](max) NOT NULL,
	[UserLogin] [nvarchar](max) NOT NULL,
	[UserPassword] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Женский парфюм')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'Мужской парфюм')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Manufacturer] ON 

INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (1, N'Chanel')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (2, N'Lsncoma')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (3, N'Lanvin')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (4, N'Dolce & Gabbana')
SET IDENTITY_INSERT [dbo].[Manufacturer] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (1, CAST(N'2022-05-16' AS Date), CAST(N'2022-05-22' AS Date), 10, N'Анохин Арсений Андреевич', 911, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (2, CAST(N'2022-05-17' AS Date), CAST(N'2022-05-23' AS Date), 5, N'Козлов Максим Максимович', 912, 2)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (3, CAST(N'2022-05-18' AS Date), CAST(N'2022-05-24' AS Date), 11, N'Черных Марк Кириллович', 913, 2)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (4, CAST(N'2022-05-19' AS Date), CAST(N'2022-05-25' AS Date), 10, N'', 914, 2)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (5, CAST(N'2022-05-20' AS Date), CAST(N'2022-05-26' AS Date), 1, N'', 915, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (6, CAST(N'2022-05-21' AS Date), CAST(N'2022-05-27' AS Date), 32, N'', 916, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (7, CAST(N'2022-05-22' AS Date), CAST(N'2022-05-28' AS Date), 20, N'Козлов Давид Александрович', 917, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (8, CAST(N'2022-05-23' AS Date), CAST(N'2022-05-29' AS Date), 34, N'', 918, 2)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (9, CAST(N'2022-05-24' AS Date), CAST(N'2022-05-30' AS Date), 25, N'', 919, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (10, CAST(N'2022-05-25' AS Date), CAST(N'2022-05-31' AS Date), 36, N'', 920, 2)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (11, CAST(N'2022-12-15' AS Date), CAST(N'2022-12-21' AS Date), 12, NULL, 424, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (12, CAST(N'2022-12-15' AS Date), CAST(N'2022-12-21' AS Date), 12, NULL, 108, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (13, CAST(N'2022-12-15' AS Date), CAST(N'2022-12-21' AS Date), 12, NULL, 770, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (14, CAST(N'2022-12-15' AS Date), CAST(N'2022-12-21' AS Date), 1, N'Никитин Артур Алексеевич', 285, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (15, CAST(N'2022-12-15' AS Date), CAST(N'2022-12-21' AS Date), 2, NULL, 229, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (16, CAST(N'2022-12-15' AS Date), CAST(N'2022-12-21' AS Date), 1, NULL, 749, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (17, CAST(N'2022-12-15' AS Date), CAST(N'2022-12-21' AS Date), 1, NULL, 165, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (18, CAST(N'2022-12-15' AS Date), CAST(N'2022-12-21' AS Date), 1, NULL, 905, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (19, CAST(N'2022-12-15' AS Date), CAST(N'2022-12-21' AS Date), 1, NULL, 880, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (20, CAST(N'2022-12-15' AS Date), CAST(N'2022-12-21' AS Date), 1, NULL, 292, 1)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [OrderDateDelivery], [PointId], [OrderClientName], [OrderCode], [StatusId]) VALUES (21, CAST(N'2022-12-15' AS Date), CAST(N'2022-12-21' AS Date), 1, NULL, 642, 1)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (1, N'H782T5', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (1, N'А112Т4', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (2, N'F635R4', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (2, N'G783F5', 3)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (3, N'D572U8', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (3, N'J384T6', 5)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (4, N'B320R5', 4)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (4, N'D329H3', 6)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (5, N'G432E4', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (5, N'S213E3', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (6, N'K345R4', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (6, N'S634B5', 3)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (7, N'G531F4', 5)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (7, N'J542F5', 4)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (8, N'C436G5', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (8, N'P764G4', 3)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (9, N'D364R4', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (9, N'S326R5', 3)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (10, N'D268G5', 5)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (10, N'M542T5', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (11, N'D329H3', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (11, N'E482R4', 3)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (11, N'fas', 5)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (11, N'K358H6', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (12, N'D329H3', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (12, N'E482R4', 3)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (12, N'fas', 5)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (12, N'K358H6', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (13, N'D329H3', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (13, N'E482R4', 3)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (13, N'fas', 5)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (13, N'K358H6', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (14, N'fas', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (14, N'J542F5', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (15, N'fas', 5)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (15, N'J542F5', 6)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (15, N'K358H6', 7)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (16, N'fas', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (16, N'J542F5', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (16, N'K358H6', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (17, N'fas', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (17, N'J542F5', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (17, N'K358H6', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (18, N'fas', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (18, N'J542F5', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (18, N'K358H6', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (19, N'fas', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (19, N'J542F5', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (19, N'K358H6', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (20, N'fas', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (20, N'J542F5', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (20, N'K358H6', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticle], [OrderProductCount]) VALUES (21, N'fas', 1)
GO
SET IDENTITY_INSERT [dbo].[Point] ON 

INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (1, N'344288, г. Москва, ул. Чехова, 1')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (2, N'614164, г.Москва,  ул. Степная, 30')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (3, N'394242, г. Москва, ул. Коммунистическая, 43')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (4, N'660540, г. Москва, ул. Солнечная, 25')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (5, N'125837, г. Москва, ул. Шоссейная, 40')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (6, N'125703, г. Москва, ул. Партизанская, 49')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (7, N'625283, г. Москва, ул. Победы, 46')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (8, N'614611, г. Москва, ул. Молодежная, 50')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (9, N'454311, г.Москва, ул. Новая, 19')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (10, N'660007, г.Москва, ул. Октябрьская, 19')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (11, N'603036, г. Москва, ул. Садовая, 4')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (12, N'450983, г.Москва, ул. Комсомольская, 26')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (13, N'394782, г. Москва, ул. Чехова, 3')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (14, N'603002, г. Москва, ул. Дзержинского, 28')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (15, N'450558, г. Москва, ул. Набережная, 30')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (16, N'394060, г.Москва, ул. Фрунзе, 43')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (17, N'410661, г. Москва, ул. Школьная, 50')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (18, N'625590, г. Москва, ул. Коммунистическая, 20')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (19, N'625683, г. Москва, ул. 8 Марта')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (20, N'400562, г. Москва, ул. Зеленая, 32')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (21, N'614510, г. Москва, ул. Маяковского, 47')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (22, N'410542, г. Москва, ул. Светлая, 46')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (23, N'620839, г. Москва, ул. Цветочная, 8')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (24, N'443890, г. Москва, ул. Коммунистическая, 1')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (25, N'603379, г. Москва, ул. Спортивная, 46')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (26, N'603721, г. Москва, ул. Гоголя, 41')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (27, N'410172, г. Москва, ул. Северная, 13')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (28, N'420151, г. Москва, ул. Вишневая, 32')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (29, N'125061, г. Москва, ул. Подгорная, 8')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (30, N'630370, г. Москва, ул. Шоссейная, 24')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (31, N'614753, г. Москва, ул. Полевая, 35')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (32, N'426030, г. Москва, ул. Маяковского, 44')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (33, N'450375, г. Москва ул. Клубная, 44')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (34, N'625560, г. Москва, ул. Некрасова, 12')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (35, N'630201, г. Москва, ул. Комсомольская, 17')
INSERT [dbo].[Point] ([PointId], [PointName]) VALUES (36, N'190949, г. Москва, ул. Мичурина, 26')
SET IDENTITY_INSERT [dbo].[Point] OFF
GO
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'B320R5', N'Духи', 1, 4300, 15, 2, 2, 1, 2, 6, N'Цветочный аромат', N'B320R5.jpg')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'B431R5', N'Одеколон', 1, 2700, 10, 4, 2, 2, 2, 5, N'Входит в набор', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'C436G5', N'Духи', 1, 10200, 15, 4, 3, 1, 2, 9, N'Объекм 100 мл', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'D268G5', N'Одеколон', 1, 4399, 10, 1, 1, 2, 3, 12, N'Ванильный аромат', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'D329H3', N'Туалетная вода', 1, 1890, 10, 4, 2, 1, 4, 4, N'Туалетная вода для женщин', N'D329H3.jpg')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'D364R4', N'Духи', 1, 12400, 10, 1, 3, 1, 2, 5, N'Аромат чайной розы', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'D572U8', N'Духи', 1, 4100, 5, 4, 3, 1, 3, 6, N'Аромат чайной розы', N'D572U8.jpg')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'E482R4', N'Одеколон', 1, 1800, 15, 2, 1, 2, 2, 14, N'Оформление в красивой упаковке', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'F427R5', N'Одеколон', 1, 11800, 10, 1, 3, 2, 4, 11, N'Поставляется вместе с галстуком', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'F572H7', N'Одеколон', 1, 2700, 15, 3, 1, 2, 2, 14, N'Объекм 100 мл', N'F572H7.jpg')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'F635R4', N'Туалетная вода', 1, 3244, 20, 2, 2, 1, 2, 13, N'Туалетная вода 100 мл', N'F635R4.jpg')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'fas', N'123', 1, 123.12, 15, 4, 4, 2, 15, 0, N'asd', N'fas.jpg')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'G432E4', N'Спрей', 1, 2800, 10, 1, 1, 2, 3, 15, N'Терпкий аромат для мужщин', N'G432E4.jpg')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'G531F4', N'Туалетная вода', 1, 6600, 5, 3, 4, 2, 2, 9, N'Подарочный вариант', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'G783F5', N'Спрей', 1, 5900, 25, 1, 3, 1, 2, 8, N'Легкий спрей', N'G783F5.jpg')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'H535R5', N'Спрей', 1, 2300, 25, 1, 2, 2, 2, 7, N'Аромат морской волны', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'H782T5', N'Одеколон', 1, 4499, 30, 3, 2, 2, 4, 5, N'Насыщенный аромат', N'H782T5.jpg')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'J384T6', N'Духи', 1, 3800, 10, 1, 4, 1, 2, 16, N'Концентрированные дихи', N'J384T6.jpg')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'J542F5', N'Спрей', 1, 500, 5, 1, 3, 2, 3, 12, N'Объекм 100 мл', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'K345R4', N'Духи', 1, 2100, 15, 1, 3, 1, 2, 3, N'Цветочный аромат', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'K358H6', N'Духи', 1, 599, 5, 2, 4, 1, 3, 2, N'Концентрированные дихи', N'K358H6.jpg')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'L754R4', N'Одеколон', 1, 1700, 10, 2, 2, 2, 2, 7, N'Аромат морской волны', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'M542T5', N'Духи', 1, 2800, 5, 2, 3, 1, 5, 3, N'Сладкий аромат', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'N457T5', N'Одеколон', 1, 4600, 5, 3, 2, 2, 3, 13, N'Максимальный объем', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'O754F4', N'Духи', 1, 5400, 10, 4, 3, 1, 4, 18, N'Насыщенный аромат', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'P764G4', N'Духи', 1, 6800, 30, 3, 3, 1, 3, 15, N'Концентрированные дихи', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'S213E3', N'Туалетная вода', 1, 2156, 5, 4, 2, 2, 3, 6, N'Аромат морской волны', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'S326R5', N'Туалетная вода', 1, 9900, 15, 3, 1, 1, 3, 15, N'Концентрированные дихи', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'S634B5', N'Спрей', 1, 5500, 20, 1, 4, 2, 3, 6, N'Объекм 100 мл', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'T324F5', N'Туалетная вода', 1, 4699, 15, 3, 3, 1, 2, 5, N'Цветочный аромат', N'')
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [UnitId], [ProductCost], [ProductMaxSale], [ManufacturerId], [ProviderId], [CategoryId], [ProductSale], [ProductCount], [ProductDescription], [ProductPhoto]) VALUES (N'А112Т4', N'Духи', 1, 4990, 30, 1, 1, 1, 3, 6, N'Женские духи с толким ароматом', N'A112T4.jpg')
GO
SET IDENTITY_INSERT [dbo].[Provider] ON 

INSERT [dbo].[Provider] ([ProviderId], [ProviderName]) VALUES (1, N'NDK PARFUM')
INSERT [dbo].[Provider] ([ProviderId], [ProviderName]) VALUES (2, N'Парфюм для дома')
INSERT [dbo].[Provider] ([ProviderId], [ProviderName]) VALUES (3, N'Elivero')
INSERT [dbo].[Provider] ([ProviderId], [ProviderName]) VALUES (4, N'GN-GROUP')
SET IDENTITY_INSERT [dbo].[Provider] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (1, N'Администратор')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (2, N'Менеджер')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (3, N'Клиент')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([StatusId], [StatusName]) VALUES (1, N'Новый ')
INSERT [dbo].[Status] ([StatusId], [StatusName]) VALUES (2, N'Завершен')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([UnitId], [UnitName]) VALUES (1, N'шт.')
SET IDENTITY_INSERT [dbo].[Unit] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (1, 1, N'Федоров Глеб Михайлович', N'o@outlook.com', N'2L6KZG')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (2, 1, N'Семенова Софья Дмитриевна', N'hr6zdl@yandex.ru', N'uzWC67')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (3, 1, N'Васильев Егор Германович', N'kaft93x@outlook.com', N'8ntwUp')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (4, 2, N'Смирнова Ирина Александровна', N'dcu@yandex.ru', N'YOyhfR')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (5, 2, N'Петров Андрей Владимирович', N'19dn@outlook.com', N'RSbvHv')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (6, 2, N'Егоров Максим Андреевич', N'pa5h@mail.ru', N'rwVDh9')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (7, 3, N'Никитин Артур Алексеевич', N'281av0@gmail.com', N'LdNyos')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (8, 3, N'Киселев Максим Сергеевич', N'8edmfh@outlook.com', N'gynQMT')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (9, 3, N'Борисов Тимур Егорович', N'sfn13i@mail.ru', N'AtnDjr')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (10, 3, N'Климов Арсений Тимурович', N'g0orc3x1@outlook.com', N'JlFRCZ')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Point] FOREIGN KEY([PointId])
REFERENCES [dbo].[Point] ([PointId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Point]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Status]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Order]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Product] FOREIGN KEY([ProductArticle])
REFERENCES [dbo].[Product] ([ProductArticle])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Manufacturer] FOREIGN KEY([ManufacturerId])
REFERENCES [dbo].[Manufacturer] ([ManufacturerId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Manufacturer]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Provider] FOREIGN KEY([ProviderId])
REFERENCES [dbo].[Provider] ([ProviderId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Provider]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Unit] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Unit] ([UnitId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Unit]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [PerfumeWorld] SET  READ_WRITE 
GO
