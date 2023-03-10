USE [master]
GO
/****** Object:  Database [PerfumeWorld]    Script Date: 15.12.2022 15:28:09 ******/
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
/****** Object:  Table [dbo].[Category]    Script Date: 15.12.2022 15:28:09 ******/
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
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 15.12.2022 15:28:09 ******/
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
/****** Object:  Table [dbo].[Product]    Script Date: 15.12.2022 15:28:09 ******/
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
/****** Object:  Table [dbo].[Provider]    Script Date: 15.12.2022 15:28:09 ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 15.12.2022 15:28:09 ******/
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
/****** Object:  Table [dbo].[Unit]    Script Date: 15.12.2022 15:28:09 ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 15.12.2022 15:28:09 ******/
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
