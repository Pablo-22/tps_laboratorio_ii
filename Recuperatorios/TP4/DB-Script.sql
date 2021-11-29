USE [master]
GO
/****** Object:  Database [CordobaPablo-TP4]    Script Date: 22/11/2021 16:50:01 ******/
CREATE DATABASE [CordobaPablo-TP4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CordobaPablo-TP4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CordobaPablo-TP4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CordobaPablo-TP4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CordobaPablo-TP4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CordobaPablo-TP4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CordobaPablo-TP4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CordobaPablo-TP4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET ARITHABORT OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CordobaPablo-TP4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CordobaPablo-TP4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CordobaPablo-TP4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CordobaPablo-TP4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CordobaPablo-TP4] SET  MULTI_USER 
GO
ALTER DATABASE [CordobaPablo-TP4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CordobaPablo-TP4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CordobaPablo-TP4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CordobaPablo-TP4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CordobaPablo-TP4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CordobaPablo-TP4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CordobaPablo-TP4] SET QUERY_STORE = OFF
GO
USE [CordobaPablo-TP4]
GO
/****** Object:  Table [dbo].[Movements]    Script Date: 22/11/2021 16:50:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movements](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TextInfo] [text] NULL,
	[Amount] [float] NULL,
	[IdWallet] [int] NULL,
	[MovementDate] [date] NULL,
	[Type] [int] NULL,
	[Category] [nvarchar](50) NULL,
 CONSTRAINT [PK_Movements] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 22/11/2021 16:50:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[TextInfo] [text] NULL,
	[WalletId] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wallets]    Script Date: 22/11/2021 16:50:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wallets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TextInfo] [text] NULL,
	[Balance] [float] NULL,
 CONSTRAINT [PK_Wallets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Movements] ON 
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (272, NULL, 22000.57, 5, CAST(N'2021-11-04' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (273, NULL, 2907.09, 3, CAST(N'2021-10-07' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (274, NULL, 24097.44, 5, CAST(N'2021-10-09' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (275, NULL, 29415.13, 4, CAST(N'2021-10-17' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (276, NULL, 273.78, 1, CAST(N'2021-10-14' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (277, NULL, 15311.54, 4, CAST(N'2021-10-06' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (278, NULL, 28186.14, 4, CAST(N'2021-10-18' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (279, NULL, 6243.33, 4, CAST(N'2021-11-09' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (280, NULL, 9781.83, 4, CAST(N'2021-10-18' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (281, NULL, 28311.68, 4, CAST(N'2021-10-24' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (282, NULL, 23947.2, 5, CAST(N'2021-10-08' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (283, NULL, 15546.11, 3, CAST(N'2021-10-01' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (284, NULL, 15868.2, 4, CAST(N'2021-10-13' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (285, NULL, 22486.75, 1, CAST(N'2021-10-15' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (286, NULL, 9676.62, 3, CAST(N'2021-10-30' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (287, NULL, 26314.81, 5, CAST(N'2021-10-18' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (288, NULL, 857.83, 2, CAST(N'2021-11-11' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (289, NULL, 29791.81, 1, CAST(N'2021-10-22' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (290, NULL, 20628.69, 4, CAST(N'2021-10-06' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (291, NULL, 17370.34, 5, CAST(N'2021-10-27' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (292, NULL, 11959.23, 5, CAST(N'2021-10-27' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (293, NULL, 26210.49, 4, CAST(N'2021-10-01' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (294, NULL, 6264.72, 2, CAST(N'2021-10-07' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (295, NULL, 8290.62, 5, CAST(N'2021-11-14' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (296, NULL, 20179.49, 3, CAST(N'2021-10-06' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (297, NULL, 8452.72, 1, CAST(N'2021-10-16' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (298, NULL, 6915.51, 4, CAST(N'2021-11-06' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (299, NULL, 3783.84, 1, CAST(N'2021-10-14' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (300, NULL, 3472.72, 4, CAST(N'2021-10-01' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (301, NULL, 5267.48, 4, CAST(N'2021-10-05' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (302, NULL, 28217.42, 2, CAST(N'2021-10-27' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (303, NULL, 7650.62, 3, CAST(N'2021-10-16' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (304, NULL, 10475.41, 2, CAST(N'2021-10-21' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (305, NULL, 22748.84, 1, CAST(N'2021-10-13' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (306, NULL, 15642.24, 5, CAST(N'2021-10-18' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (307, NULL, 539.02, 1, CAST(N'2021-10-17' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (308, NULL, 8095.31, 1, CAST(N'2021-10-31' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (309, NULL, 29343.36, 2, CAST(N'2021-10-25' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (310, NULL, 28241.17, 2, CAST(N'2021-10-19' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (311, NULL, 9309.3, 5, CAST(N'2021-11-08' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (312, NULL, 27980.01, 4, CAST(N'2021-10-30' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (313, NULL, 17946.36, 1, CAST(N'2021-10-03' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (314, NULL, 15259.1, 1, CAST(N'2021-10-04' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (315, NULL, 7509.98, 3, CAST(N'2021-10-20' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (316, NULL, 23543.9, 2, CAST(N'2021-10-14' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (317, NULL, 28910.48, 1, CAST(N'2021-10-08' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (318, NULL, 12341.64, 3, CAST(N'2021-11-15' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (319, NULL, 21487.2, 4, CAST(N'2021-10-30' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (320, NULL, 2132.04, 1, CAST(N'2021-10-27' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (321, NULL, 242.09, 2, CAST(N'2021-10-17' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (322, NULL, 3851.38, 4, CAST(N'2021-11-05' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (323, NULL, 1481.45, 3, CAST(N'2021-10-30' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (324, NULL, 29525.2, 3, CAST(N'2021-10-21' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (325, NULL, 20391.73, 3, CAST(N'2021-11-01' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (326, NULL, 24875.88, 1, CAST(N'2021-10-02' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (327, NULL, 5872.33, 3, CAST(N'2021-11-13' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (328, NULL, 28880.15, 2, CAST(N'2021-10-14' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (329, NULL, 23166.19, 3, CAST(N'2021-10-13' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (330, NULL, 29272.73, 3, CAST(N'2021-10-22' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (331, NULL, 2709.53, 3, CAST(N'2021-10-24' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (332, NULL, 7671.47, 4, CAST(N'2021-10-29' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (333, NULL, 27238.01, 2, CAST(N'2021-11-09' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (334, NULL, 18110.42, 3, CAST(N'2021-11-11' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (335, NULL, 17527.99, 3, CAST(N'2021-10-26' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (336, NULL, 9313.71, 5, CAST(N'2021-10-27' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (337, NULL, 29351.33, 4, CAST(N'2021-10-13' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (338, NULL, 24272.51, 1, CAST(N'2021-11-09' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (339, NULL, 5574.03, 1, CAST(N'2021-10-05' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (340, NULL, 6562.09, 5, CAST(N'2021-11-15' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (341, NULL, 11335.83, 5, CAST(N'2021-10-26' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (342, NULL, 24693.12, 5, CAST(N'2021-10-27' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (343, NULL, 15674.39, 2, CAST(N'2021-11-16' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (344, NULL, 19364.29, 5, CAST(N'2021-10-03' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (345, NULL, 28392.98, 2, CAST(N'2021-10-11' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (346, NULL, 12086.46, 1, CAST(N'2021-10-13' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (347, NULL, 18033.35, 2, CAST(N'2021-10-31' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (348, NULL, 18408.93, 5, CAST(N'2021-11-05' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (349, NULL, 18549.05, 2, CAST(N'2021-11-16' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (350, NULL, 13334.38, 5, CAST(N'2021-10-12' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (351, NULL, 8155.41, 2, CAST(N'2021-11-06' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (352, NULL, 18317.9, 1, CAST(N'2021-10-25' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (353, NULL, 1132.82, 4, CAST(N'2021-11-05' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (354, NULL, 17477.79, 4, CAST(N'2021-10-07' AS Date), 1, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (355, NULL, 22279.02, 5, CAST(N'2021-10-05' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (356, NULL, 18951.11, 3, CAST(N'2021-10-21' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (357, NULL, 24474.08, 1, CAST(N'2021-10-12' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (358, NULL, 28287.75, 5, CAST(N'2021-10-01' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (359, NULL, 24684.75, 4, CAST(N'2021-10-09' AS Date), 1, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (360, NULL, 24691.47, 4, CAST(N'2021-10-29' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (361, NULL, 22256.7, 4, CAST(N'2021-10-05' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (362, NULL, 23149.92, 1, CAST(N'2021-11-15' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (363, NULL, 23323.77, 3, CAST(N'2021-10-23' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (364, NULL, 9141.73, 3, CAST(N'2021-10-01' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (365, NULL, 26394.79, 2, CAST(N'2021-11-15' AS Date), 1, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (366, NULL, 8277.57, 1, CAST(N'2021-10-05' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (367, NULL, 23183.08, 3, CAST(N'2021-10-11' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (368, NULL, 19511.52, 3, CAST(N'2021-10-30' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (369, NULL, 28410.56, 3, CAST(N'2021-11-06' AS Date), 1, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (370, NULL, 22171.61, 1, CAST(N'2021-10-08' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (371, NULL, 18167.64, 4, CAST(N'2021-10-03' AS Date), 1, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (372, NULL, 23846.36, 2, CAST(N'2021-11-02' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (373, NULL, 17997.52, 3, CAST(N'2021-11-13' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (374, NULL, 5638.06, 2, CAST(N'2021-10-10' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (375, NULL, 2831.78, 3, CAST(N'2021-10-02' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (376, NULL, 13029.21, 4, CAST(N'2021-10-06' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (377, NULL, 3896.38, 1, CAST(N'2021-10-21' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (378, NULL, 16138.29, 2, CAST(N'2021-10-16' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (379, NULL, 23758.04, 3, CAST(N'2021-10-02' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (380, NULL, 28777.2, 5, CAST(N'2021-10-17' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (381, NULL, 7520.26, 2, CAST(N'2021-11-15' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (382, NULL, 17494.41, 4, CAST(N'2021-11-16' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (383, NULL, 17877.96, 2, CAST(N'2021-11-06' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (384, NULL, 19587.69, 2, CAST(N'2021-10-04' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (385, NULL, 20352.83, 4, CAST(N'2021-10-15' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (386, NULL, 23874.93, 1, CAST(N'2021-11-02' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (387, NULL, 6607.26, 3, CAST(N'2021-11-02' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (388, NULL, 11102.7, 5, CAST(N'2021-10-25' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (389, NULL, 24334.88, 4, CAST(N'2021-10-02' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (390, NULL, 23980.76, 1, CAST(N'2021-10-23' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (391, NULL, 3714.91, 2, CAST(N'2021-10-17' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (392, NULL, 3357.3, 3, CAST(N'2021-11-13' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (393, NULL, 6570.06, 5, CAST(N'2021-11-05' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (394, NULL, 28968, 1, CAST(N'2021-10-12' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (395, NULL, 4648.47, 3, CAST(N'2021-11-08' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (396, NULL, 3445.21, 1, CAST(N'2021-10-20' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (397, NULL, 24592.93, 4, CAST(N'2021-10-29' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (398, NULL, 6503.94, 2, CAST(N'2021-10-23' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (399, NULL, 2166.98, 3, CAST(N'2021-11-01' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (400, NULL, 24839.09, 1, CAST(N'2021-10-07' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (401, NULL, 19691.82, 1, CAST(N'2021-10-21' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (402, NULL, 17007.59, 1, CAST(N'2021-11-14' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (403, NULL, 27731.59, 5, CAST(N'2021-11-11' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (404, NULL, 3495.6, 3, CAST(N'2021-10-04' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (405, NULL, 14406.74, 4, CAST(N'2021-10-21' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (406, NULL, 23419.76, 1, CAST(N'2021-10-21' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (407, NULL, 23168.56, 4, CAST(N'2021-11-13' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (408, NULL, 2918.74, 1, CAST(N'2021-10-22' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (409, NULL, 28927.6, 1, CAST(N'2021-10-09' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (410, NULL, 22452.62, 4, CAST(N'2021-10-17' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (411, NULL, 25282.12, 1, CAST(N'2021-10-02' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (412, NULL, 17003.59, 3, CAST(N'2021-10-14' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (413, NULL, 3056.1, 1, CAST(N'2021-10-08' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (414, NULL, 11882.54, 2, CAST(N'2021-10-03' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (415, NULL, 12762.97, 2, CAST(N'2021-10-17' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (416, NULL, 25817.15, 2, CAST(N'2021-11-08' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (417, NULL, 22351.77, 4, CAST(N'2021-10-01' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (418, NULL, 26587.08, 3, CAST(N'2021-10-08' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (419, NULL, 26444.66, 2, CAST(N'2021-10-08' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (420, NULL, 15259.46, 5, CAST(N'2021-10-26' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (421, NULL, 12148.01, 5, CAST(N'2021-11-07' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (422, NULL, 21284.75, 5, CAST(N'2021-10-27' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (423, NULL, 23594.44, 1, CAST(N'2021-10-29' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (424, NULL, 23520.27, 2, CAST(N'2021-10-02' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (425, NULL, 10758, 3, CAST(N'2021-10-14' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (426, NULL, 147.87, 1, CAST(N'2021-11-10' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (427, NULL, 5738.93, 4, CAST(N'2021-10-04' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (428, NULL, 2564.84, 3, CAST(N'2021-10-17' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (429, NULL, 4509.96, 3, CAST(N'2021-10-24' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (430, NULL, 6724.65, 3, CAST(N'2021-10-11' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (431, NULL, 1511.21, 2, CAST(N'2021-11-10' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (432, NULL, 27888.25, 5, CAST(N'2021-10-19' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (433, NULL, 7603.22, 1, CAST(N'2021-11-03' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (434, NULL, 21938.89, 1, CAST(N'2021-11-03' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (435, NULL, 6918.27, 5, CAST(N'2021-10-21' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (436, NULL, 29833.28, 3, CAST(N'2021-10-10' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (437, NULL, 18959.96, 2, CAST(N'2021-11-15' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (438, NULL, 8156.41, 3, CAST(N'2021-10-04' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (439, NULL, 22292.51, 1, CAST(N'2021-10-16' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (440, NULL, 13708.69, 4, CAST(N'2021-10-16' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (441, NULL, 4370.51, 2, CAST(N'2021-10-15' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (442, NULL, 2183.01, 3, CAST(N'2021-10-17' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (443, NULL, 27946.01, 5, CAST(N'2021-10-27' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (444, NULL, 14438.52, 1, CAST(N'2021-11-11' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (445, NULL, 27671.2, 3, CAST(N'2021-10-22' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (446, NULL, 22849.34, 5, CAST(N'2021-10-06' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (447, NULL, 26376.11, 2, CAST(N'2021-11-10' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (448, NULL, 3645.63, 5, CAST(N'2021-10-29' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (449, NULL, 13196.62, 2, CAST(N'2021-10-23' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (450, NULL, 9805.87, 2, CAST(N'2021-10-02' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (451, NULL, 15771.86, 3, CAST(N'2021-11-04' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (452, NULL, 28640.89, 3, CAST(N'2021-11-02' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (453, NULL, 4244.25, 5, CAST(N'2021-10-31' AS Date), 0, N'Viajes')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (454, NULL, 28777.66, 2, CAST(N'2021-10-31' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (455, NULL, 5722.38, 3, CAST(N'2021-11-02' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (456, NULL, 25508.11, 2, CAST(N'2021-10-28' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (457, NULL, 23008.03, 2, CAST(N'2021-11-08' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (458, NULL, 14886.43, 3, CAST(N'2021-10-02' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (459, NULL, 23211.36, 4, CAST(N'2021-10-18' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (460, NULL, 9068.33, 4, CAST(N'2021-11-03' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (461, NULL, 17435.93, 5, CAST(N'2021-10-04' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (462, NULL, 25200.61, 4, CAST(N'2021-10-09' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (463, NULL, 18331.36, 3, CAST(N'2021-11-10' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (464, NULL, 13677, 3, CAST(N'2021-10-28' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (465, NULL, 5588.73, 4, CAST(N'2021-10-11' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (466, NULL, 18125.08, 1, CAST(N'2021-10-22' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (467, NULL, 19471.18, 3, CAST(N'2021-10-20' AS Date), 0, N'Alimentos')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (468, NULL, 12738.35, 2, CAST(N'2021-10-08' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (469, NULL, 3309.46, 1, CAST(N'2021-11-09' AS Date), 0, N'Servicios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (470, NULL, 9804.73, 1, CAST(N'2021-10-26' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (471, NULL, 28196.61, 1, CAST(N'2021-10-02' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (472, NULL, 800, 1, CAST(N'2021-11-19' AS Date), 0, N'Entretenimiento')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (473, NULL, 20000, 1, CAST(N'2021-11-21' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (474, NULL, 15642, 1, CAST(N'2021-11-21' AS Date), 0, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (475, NULL, 6823, 4, CAST(N'2021-11-21' AS Date), 1, N'Venta')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (476, NULL, 74232, 22, CAST(N'2021-11-21' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (477, NULL, 2500, 1, CAST(N'2021-11-22' AS Date), 0, N'Indumentaria')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (478, NULL, 500, 1, CAST(N'2021-11-22' AS Date), 1, N'Varios')
GO
INSERT [dbo].[Movements] ([Id], [TextInfo], [Amount], [IdWallet], [MovementDate], [Type], [Category]) VALUES (479, NULL, 220, 1, CAST(N'2021-11-22' AS Date), 0, N'Indumentaria')
GO
SET IDENTITY_INSERT [dbo].[Movements] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([Id], [Name], [Password], [TextInfo], [WalletId]) VALUES (1, N'Pablo', N'12345', N'Soy admin', 1)
GO
INSERT [dbo].[Users] ([Id], [Name], [Password], [TextInfo], [WalletId]) VALUES (2, N'Nazarena', N'Nazarena', NULL, 2)
GO
INSERT [dbo].[Users] ([Id], [Name], [Password], [TextInfo], [WalletId]) VALUES (3, N'Pedro', N'Pedro', NULL, 3)
GO
INSERT [dbo].[Users] ([Id], [Name], [Password], [TextInfo], [WalletId]) VALUES (4, N'Pepe', N'Pepe', NULL, 4)
GO
INSERT [dbo].[Users] ([Id], [Name], [Password], [TextInfo], [WalletId]) VALUES (5, N'Martin', N'Martin', NULL, 5)
GO
INSERT [dbo].[Users] ([Id], [Name], [Password], [TextInfo], [WalletId]) VALUES (7, N'julio', N'julio', N'-', 22)
GO
INSERT [dbo].[Users] ([Id], [Name], [Password], [TextInfo], [WalletId]) VALUES (8, N'Natalia', N'Natalia', N'-', 23)
GO
INSERT [dbo].[Users] ([Id], [Name], [Password], [TextInfo], [WalletId]) VALUES (10, N'Claudia', N'Claudia', N'-', 25)
GO
INSERT [dbo].[Users] ([Id], [Name], [Password], [TextInfo], [WalletId]) VALUES (11, N'hgfdghdf', N'65e65e', N'-', 26)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Wallets] ON 
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (-1, NULL, NULL)
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (1, NULL, 44583)
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (2, NULL, 66433)
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (3, NULL, 2226)
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (4, NULL, 9387)
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (5, NULL, 3245)
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (21, N'-', 0)
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (22, N'-', 74232)
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (23, N'-', 0)
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (24, N'-', 0)
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (25, N'-', 0)
GO
INSERT [dbo].[Wallets] ([Id], [TextInfo], [Balance]) VALUES (26, N'-', 0)
GO
SET IDENTITY_INSERT [dbo].[Wallets] OFF
GO
ALTER TABLE [dbo].[Movements]  WITH CHECK ADD  CONSTRAINT [FK_Movements_Wallets1] FOREIGN KEY([IdWallet])
REFERENCES [dbo].[Wallets] ([Id])
GO
ALTER TABLE [dbo].[Movements] CHECK CONSTRAINT [FK_Movements_Wallets1]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Wallets] FOREIGN KEY([WalletId])
REFERENCES [dbo].[Wallets] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Wallets]
GO
USE [master]
GO
ALTER DATABASE [CordobaPablo-TP4] SET  READ_WRITE 
GO


