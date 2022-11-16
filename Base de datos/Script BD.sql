USE [master]
GO
/****** Object:  Database [BDPav1TP]    Script Date: 15/11/2022 21:01:38 ******/
CREATE DATABASE [BDPav1TP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDPav1TP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BDPav1TP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDPav1TP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BDPav1TP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BDPav1TP] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDPav1TP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDPav1TP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDPav1TP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDPav1TP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDPav1TP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDPav1TP] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDPav1TP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDPav1TP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDPav1TP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDPav1TP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDPav1TP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDPav1TP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDPav1TP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDPav1TP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDPav1TP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDPav1TP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDPav1TP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDPav1TP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDPav1TP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDPav1TP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDPav1TP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDPav1TP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDPav1TP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDPav1TP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDPav1TP] SET  MULTI_USER 
GO
ALTER DATABASE [BDPav1TP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDPav1TP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDPav1TP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDPav1TP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDPav1TP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDPav1TP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BDPav1TP] SET QUERY_STORE = OFF
GO
USE [BDPav1TP]
GO
/****** Object:  Table [dbo].[Barrios]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrios](
	[idBarrio] [int] IDENTITY(1,1) NOT NULL,
	[nombreBarrio] [varchar](50) NULL,
	[idLocalidad] [int] NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Barrios] PRIMARY KEY CLUSTERED 
(
	[idBarrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[nroDoc] [int] NOT NULL,
	[tipoDoc] [int] NOT NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[fechaNacimiento] [date] NULL,
	[idSexo] [int] NOT NULL,
	[idBarrio] [int] NOT NULL,
	[telefono] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[nroDoc] ASC,
	[tipoDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[tipoFactura] [int] NOT NULL,
	[nroFactura] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[precioUnitario] [int] NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[tipoFactura] ASC,
	[nroFactura] ASC,
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[tipoFactura] [int] NOT NULL,
	[nroFactura] [int] IDENTITY(1,1) NOT NULL,
	[fechaEmision] [date] NULL,
	[idFormaPago] [int] NOT NULL,
	[total] [int] NULL,
	[tipoDocCl] [int] NOT NULL,
	[nroDocCl] [int] NOT NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[tipoFactura] ASC,
	[nroFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormasPago]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormasPago](
	[idFormaPago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_FormasPago] PRIMARY KEY CLUSTERED 
(
	[idFormaPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidades]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidades](
	[idLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[nombreLocalidad] [varchar](50) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[idLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoColor]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoColor](
	[idColor] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_ProductoColor] PRIMARY KEY CLUSTERED 
(
	[idColor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoMaterial]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoMaterial](
	[idMaterial] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_ProductoMaterial] PRIMARY KEY CLUSTERED 
(
	[idMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[precio] [int] NULL,
	[costo] [int] NULL,
	[idColor] [int] NULL,
	[idMaterial] [int] NULL,
	[peso] [int] NULL,
	[largo] [int] NULL,
	[ancho] [int] NULL,
	[alto] [int] NULL,
	[stock] [int] NULL,
	[idProveedor] [int] NULL,
	[idTipo] [int] NULL,
	[periodoGarantia] [date] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[razonSocial] [varchar](50) NULL,
	[telefono] [int] NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[idBarrio] [int] NOT NULL,
	[fechaAlta] [date] NULL,
	[fechaBaja] [date] NULL,
	[vigencia] [bit] NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[idTipo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoFactura]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoFactura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoFactura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoProductos]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoProductos](
	[idTipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_TipoProductos] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoSexo]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoSexo](
	[idSexo] [int] IDENTITY(1,1) NOT NULL,
	[descripcionS] [varchar](50) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[idSexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 15/11/2022 21:01:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
	[mail] [varchar](50) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Barrios] ON 
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (1, N'Villa Allende', 1, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (2, N'Alta Cordoba', 2, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (3, N'Arguello', 3, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (4, N'Barrio22', 4, 1)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (5, N'Barrio23', 2, 1)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (6, N'Empalme', 1, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (7, N'Cerveceros', 1, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (8, N'Nueva Córdoba', 1, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (9, N'Güemes', 1, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (10, N'Cerro de las Rosas', 1, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (11, N'San Martín', 2, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (12, N'Almirante Brown', 2, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (13, N'Belgrano', 2, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (14, N'Barrio Jardín', 1, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (15, N'Laguna Blanca', 10, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (16, N'Bariloche', 10, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (17, N'Villa Retiro', 20, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (18, N'Urca', 1, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (19, N'Alto Alberdi', 1, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (20, N'Alberdi', 8, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (21, N'Ituzaingo', 7, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (22, N'25 de Mayo', 15, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (23, N'Alejandro Centeno', 14, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (24, N'Altos de Villa Cabrera', 20, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (25, N'Ameghino Sud', 19, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (26, N'1 de Mayo', 17, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (27, N'Los Plátanos', 15, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (28, N'Pueyrredón', 13, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (29, N'Poeta Lugones', 12, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (30, N'Rosedal', 9, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (31, N'Vélez Sarsfield', 6, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (32, N'Yapeyu', 4, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (33, N'Boedo', 18, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (34, N'Cáceres', 11, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (35, N'Villa Pose', 8, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (36, N'Caseros', 7, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (37, N'Bella Vista', 8, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (38, N'Colón', 5, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (39, N'Congreso', 3, 0)
GO
INSERT [dbo].[Barrios] ([idBarrio], [nombreBarrio], [idLocalidad], [borrado]) VALUES (40, N'Cabildo', 7, 0)
GO
SET IDENTITY_INSERT [dbo].[Barrios] OFF
GO
INSERT [dbo].[Clientes] ([nroDoc], [tipoDoc], [apellido], [nombre], [fechaNacimiento], [idSexo], [idBarrio], [telefono]) VALUES (12345678, 1, N'Baudino', N'Martin', CAST(N'2003-11-13' AS Date), 2, 1, 35176)
GO
INSERT [dbo].[Clientes] ([nroDoc], [tipoDoc], [apellido], [nombre], [fechaNacimiento], [idSexo], [idBarrio], [telefono]) VALUES (15874956, 1, N'Perez', N'Damián', CAST(N'1994-06-15' AS Date), 2, 2, 351286571)
GO
INSERT [dbo].[Clientes] ([nroDoc], [tipoDoc], [apellido], [nombre], [fechaNacimiento], [idSexo], [idBarrio], [telefono]) VALUES (20082376, 1, N'Arriaga', N'Horacio', CAST(N'1968-05-07' AS Date), 2, 18, 89456)
GO
INSERT [dbo].[Clientes] ([nroDoc], [tipoDoc], [apellido], [nombre], [fechaNacimiento], [idSexo], [idBarrio], [telefono]) VALUES (21902249, 1, N'Gatica', N'Norma', CAST(N'1970-11-22' AS Date), 1, 6, 76630)
GO
INSERT [dbo].[Clientes] ([nroDoc], [tipoDoc], [apellido], [nombre], [fechaNacimiento], [idSexo], [idBarrio], [telefono]) VALUES (35646546, 3, N'Lopez', N'Marcos', CAST(N'2003-05-23' AS Date), 1, 2, 3435563)
GO
INSERT [dbo].[Clientes] ([nroDoc], [tipoDoc], [apellido], [nombre], [fechaNacimiento], [idSexo], [idBarrio], [telefono]) VALUES (37586039, 2, N'Juarez', N'Marco', CAST(N'1994-06-14' AS Date), 3, 10, 45657)
GO
INSERT [dbo].[Clientes] ([nroDoc], [tipoDoc], [apellido], [nombre], [fechaNacimiento], [idSexo], [idBarrio], [telefono]) VALUES (42356437, 2, N'Diaz', N'Santiago', CAST(N'2000-07-18' AS Date), 2, 2, 35136)
GO
INSERT [dbo].[Clientes] ([nroDoc], [tipoDoc], [apellido], [nombre], [fechaNacimiento], [idSexo], [idBarrio], [telefono]) VALUES (43273537, 2, N'Arriaga', N'Valentin', CAST(N'2001-03-05' AS Date), 2, 2, 35129)
GO
INSERT [dbo].[Clientes] ([nroDoc], [tipoDoc], [apellido], [nombre], [fechaNacimiento], [idSexo], [idBarrio], [telefono]) VALUES (45482076, 2, N'Pary', N'Ronald', CAST(N'2002-01-31' AS Date), 2, 1, 3808660)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (1, 1, 15, 1000, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (1, 9, 15, 1000, 1)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (1, 9, 17, 700, 4)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (1, 10, 15, 1000, 2)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (1, 10, 16, 5555, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (1, 12, 15, 1000, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (1, 4013, 15, 1000, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (1, 6013, 15, 1000, 34)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (1, 7012, 15, 1000, 18)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 4, 17, 700, 2)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 5, 15, 1000, 8)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 5, 16, 5555, 2)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 6, 15, 1000, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 6, 17, 700, 2)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 8, 16, 5555, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 11, 15, 1000, 4)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 11, 16, 5555, 1)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 1013, 15, 1000, 4)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 1017, 15, 1000, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 1018, 15, 1000, 4)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 1019, 15, 1000, 4)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 2013, 15, 1000, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 2014, 15, 1000, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 2016, 15, 1000, 4)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 2017, 16, 5555, 4)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 2018, 15, 1000, 4)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 3012, 15, 1000, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 4012, 15, 1000, 5)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 4014, 15, 1000, 23)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 4015, 16, 5555, 23)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 4016, 15, 1000, 2)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 5012, 15, 1000, 13)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 6012, 15, 1000, 45)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 7014, 24, 600, 18)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (2, 7014, 26, 2000, 34)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 3, 17, 700, 4)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 7, 15, 1000, 2)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 7, 17, 700, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 1016, 15, 1000, 2)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 2012, 15, 1000, 7)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 2015, 16, 5555, 5)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 2019, 16, 5555, 3)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 7013, 20, 1221, 9)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 7013, 23, 121, 4)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 7013, 25, 4000, 15)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 7013, 28, 6000, 5)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 7015, 22, 1322, 4)
GO
INSERT [dbo].[DetalleFactura] ([tipoFactura], [nroFactura], [idProducto], [precioUnitario], [cantidad]) VALUES (3, 7015, 23, 121, 6)
GO
SET IDENTITY_INSERT [dbo].[Facturas] ON 
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (1, 1, CAST(N'2022-10-12' AS Date), 1, 3000, 2, 45482076)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (1, 9, CAST(N'2022-10-12' AS Date), 3, 3800, 2, 43273537)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (1, 10, CAST(N'2022-10-12' AS Date), 2, 18665, 2, 43273537)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (1, 12, CAST(N'2022-10-17' AS Date), 1, 3000, 2, 42356437)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (1, 4013, CAST(N'2022-10-23' AS Date), 2, 3000, 2, 42356437)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (1, 6013, CAST(N'2022-10-29' AS Date), 1, 34000, 2, 43273537)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (1, 7012, CAST(N'2022-11-02' AS Date), 3, 18000, 3, 35646546)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 4, CAST(N'2022-10-12' AS Date), 2, 1400, 2, 45482076)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 5, CAST(N'2022-10-12' AS Date), 3, 19110, 2, 45482076)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 6, CAST(N'2022-10-12' AS Date), 2, 4400, 2, 45482076)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 8, CAST(N'2022-10-12' AS Date), 2, 16665, 2, 42356437)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 11, CAST(N'2022-10-12' AS Date), 3, 9555, 2, 43273537)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 1013, CAST(N'2022-10-18' AS Date), 3, 4000, 2, 43273537)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 1017, CAST(N'2022-10-18' AS Date), 2, 3000, 1, 12345678)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 1018, CAST(N'2022-10-18' AS Date), 3, 4000, 2, 45482076)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 1019, CAST(N'2022-10-18' AS Date), 3, 4000, 1, 12345678)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 2013, CAST(N'2022-10-19' AS Date), 2, 3000, 1, 12345678)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 2014, CAST(N'2022-10-19' AS Date), 3, 3000, 2, 45482076)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 2016, CAST(N'2022-10-19' AS Date), 2, 4000, 2, 45482076)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 2017, CAST(N'2022-10-19' AS Date), 3, 22220, 3, 35646546)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 2018, CAST(N'2022-10-19' AS Date), 3, 4000, 3, 35646546)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 3012, CAST(N'2022-10-20' AS Date), 3, 3000, 3, 35646546)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 4012, CAST(N'2022-10-23' AS Date), 2, 5000, 2, 42356437)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 4014, CAST(N'2022-10-23' AS Date), 3, 23000, 2, 42356437)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 4015, CAST(N'2022-10-23' AS Date), 2, 127765, 1, 12345678)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 4016, CAST(N'2022-10-23' AS Date), 2, 2000, 2, 45482076)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 5012, CAST(N'2022-10-28' AS Date), 2, 13000, 1, 12345678)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 6012, CAST(N'2022-10-29' AS Date), 2, 45000, 1, 12345678)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (2, 7014, CAST(N'2022-11-15' AS Date), 2, 78800, 1, 20082376)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (3, 3, CAST(N'2022-10-12' AS Date), 2, 2800, 2, 45482076)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (3, 7, CAST(N'2022-10-12' AS Date), 1, 4100, 2, 43273537)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (3, 1016, CAST(N'2022-10-18' AS Date), 1, 2000, 2, 42356437)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (3, 2012, CAST(N'2022-10-19' AS Date), 2, 7000, 1, 12345678)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (3, 2015, CAST(N'2022-10-19' AS Date), 2, 27775, 1, 12345678)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (3, 2019, CAST(N'2022-10-19' AS Date), 1, 16665, 2, 45482076)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (3, 7013, CAST(N'2022-11-15' AS Date), 3, 101473, 1, 21902249)
GO
INSERT [dbo].[Facturas] ([tipoFactura], [nroFactura], [fechaEmision], [idFormaPago], [total], [tipoDocCl], [nroDocCl]) VALUES (3, 7015, CAST(N'2022-11-15' AS Date), 1, 6014, 2, 37586039)
GO
SET IDENTITY_INSERT [dbo].[Facturas] OFF
GO
SET IDENTITY_INSERT [dbo].[FormasPago] ON 
GO
INSERT [dbo].[FormasPago] ([idFormaPago], [descripcion]) VALUES (1, N'Tarjeta')
GO
INSERT [dbo].[FormasPago] ([idFormaPago], [descripcion]) VALUES (2, N'Efectivo')
GO
INSERT [dbo].[FormasPago] ([idFormaPago], [descripcion]) VALUES (3, N'MercadoPago')
GO
SET IDENTITY_INSERT [dbo].[FormasPago] OFF
GO
SET IDENTITY_INSERT [dbo].[Localidades] ON 
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (1, N'Cordoba', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (2, N'Bouwer', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (3, N'Jesus Maria', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (4, N'Rio Ceballo', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (5, N'Mina Clavero', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (6, N'Cruz del Eje', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (7, N'Déan Fúnes', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (8, N'Cosquín', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (9, N'Bell Ville', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (10, N'Río Cuarto', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (11, N'La Carlota', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (12, N'Monte Buey', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (13, N'San Francisco', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (14, N'Villa Dolores', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (15, N'Oliva', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (16, N'Colonia Caroya', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (17, N'Cura Brochero', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (18, N'Oncativo', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (19, N'Canals', 0)
GO
INSERT [dbo].[Localidades] ([idLocalidad], [nombreLocalidad], [borrado]) VALUES (20, N'La Falda', 0)
GO
SET IDENTITY_INSERT [dbo].[Localidades] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductoColor] ON 
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (1, N'Azul')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (2, N'Rojo')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (3, N'Verde')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (4, N'Marron')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (5, N'Naranja')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (6, N'Gris')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (7, N'Blanco')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (8, N'Rosa')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (9, N'Amarillo')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (10, N'Violeta')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (11, N'Negro')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (12, N'Cian')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (13, N'Fucsia')
GO
INSERT [dbo].[ProductoColor] ([idColor], [descripcion]) VALUES (14, N'Beige')
GO
SET IDENTITY_INSERT [dbo].[ProductoColor] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductoMaterial] ON 
GO
INSERT [dbo].[ProductoMaterial] ([idMaterial], [descripcion]) VALUES (1, N'Madera')
GO
INSERT [dbo].[ProductoMaterial] ([idMaterial], [descripcion]) VALUES (2, N'Plastico')
GO
INSERT [dbo].[ProductoMaterial] ([idMaterial], [descripcion]) VALUES (3, N'Metal')
GO
INSERT [dbo].[ProductoMaterial] ([idMaterial], [descripcion]) VALUES (4, N'Ergonomica')
GO
INSERT [dbo].[ProductoMaterial] ([idMaterial], [descripcion]) VALUES (5, N'Melamina')
GO
INSERT [dbo].[ProductoMaterial] ([idMaterial], [descripcion]) VALUES (6, N'Chapa')
GO
INSERT [dbo].[ProductoMaterial] ([idMaterial], [descripcion]) VALUES (7, N'Vidrio')
GO
SET IDENTITY_INSERT [dbo].[ProductoMaterial] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (15, 1000, 700, 6, 1, 234, 123, 543, 234, 123, 1, 5, CAST(N'2022-07-11' AS Date))
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (16, 5555, 2222, 4, 1, 7444, 2522, 2353, 4554, 500, 1, 3, CAST(N'2022-10-30' AS Date))
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (17, 700, 200, 2, 2, 200, 500, 500, 300, 300, 1, 1, CAST(N'2022-10-27' AS Date))
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (20, 1221, 122, 1, 3, 12, 12, 121, 21, 3, 1, 3, CAST(N'2022-10-28' AS Date))
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (21, 1212, 1212, 1, 3, 12, 21, 2, 12, 12, 1, 3, CAST(N'2022-10-27' AS Date))
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (22, 1322, 12, 1, 1, 12, 12, 12, 12, 8, 1, 3, CAST(N'2022-10-26' AS Date))
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (23, 121, 1, 1, 1, 1, 1, 1, 1, -9, 1, 1, CAST(N'2022-11-24' AS Date))
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (24, 600, 260, 13, 2, 500, 45, 45, 80, 4982, 1, 11, CAST(N'2025-12-31' AS Date))
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (25, 4000, 3100, 4, 1, 4000, 50, 150, 110, 285, 1009, 7, CAST(N'2025-12-31' AS Date))
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (26, 2000, 1450, 8, 1, 3000, 40, 60, 80, 66, 1007, 12, CAST(N'2024-01-31' AS Date))
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (27, 6000, 4500, 7, 1, 8000, 200, 150, 80, 150, 3, 8, CAST(N'2024-06-01' AS Date))
GO
INSERT [dbo].[Productos] ([idProducto], [precio], [costo], [idColor], [idMaterial], [peso], [largo], [ancho], [alto], [stock], [idProveedor], [idTipo], [periodoGarantia]) VALUES (28, 6000, 4900, 11, 3, 3000, 60, 40, 150, 95, 6, 6, CAST(N'2024-01-31' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 
GO
INSERT [dbo].[Proveedores] ([idProveedor], [razonSocial], [telefono], [nombre], [apellido], [idBarrio], [fechaAlta], [fechaBaja], [vigencia]) VALUES (1, N'Flores SA', 2344548, N'Luis', N'Flores', 12, CAST(N'2018-07-07' AS Date), NULL, 1)
GO
INSERT [dbo].[Proveedores] ([idProveedor], [razonSocial], [telefono], [nombre], [apellido], [idBarrio], [fechaAlta], [fechaBaja], [vigencia]) VALUES (2, N'Juan Muebles', 2347778, N'Juan', N'Contreras', 2, CAST(N'2019-02-24' AS Date), NULL, 1)
GO
INSERT [dbo].[Proveedores] ([idProveedor], [razonSocial], [telefono], [nombre], [apellido], [idBarrio], [fechaAlta], [fechaBaja], [vigencia]) VALUES (3, N'Flia. Barrios ', 2337766, N'Lourdes', N'Barrios', 19, CAST(N'2010-03-30' AS Date), CAST(N'2020-03-12' AS Date), 0)
GO
INSERT [dbo].[Proveedores] ([idProveedor], [razonSocial], [telefono], [nombre], [apellido], [idBarrio], [fechaAlta], [fechaBaja], [vigencia]) VALUES (5, N'Vidriería López', 498221, N'Marcos', N'López', 25, CAST(N'2021-04-30' AS Date), NULL, 1)
GO
INSERT [dbo].[Proveedores] ([idProveedor], [razonSocial], [telefono], [nombre], [apellido], [idBarrio], [fechaAlta], [fechaBaja], [vigencia]) VALUES (6, N'Muebles Flores SA', 3435221, N'Martin', N'Flores', 35, CAST(N'2018-04-30' AS Date), CAST(N'2022-03-23' AS Date), 0)
GO
INSERT [dbo].[Proveedores] ([idProveedor], [razonSocial], [telefono], [nombre], [apellido], [idBarrio], [fechaAlta], [fechaBaja], [vigencia]) VALUES (7, N'Mesas Ávila', 4997332, N'Juana', N'Ávila', 33, CAST(N'2021-04-23' AS Date), NULL, 1)
GO
INSERT [dbo].[Proveedores] ([idProveedor], [razonSocial], [telefono], [nombre], [apellido], [idBarrio], [fechaAlta], [fechaBaja], [vigencia]) VALUES (1007, N'Gallardo y Cia.', 4654543, N'Marcos', N'Gallardo', 24, CAST(N'2020-09-03' AS Date), NULL, 1)
GO
INSERT [dbo].[Proveedores] ([idProveedor], [razonSocial], [telefono], [nombre], [apellido], [idBarrio], [fechaAlta], [fechaBaja], [vigencia]) VALUES (1008, N'Esther Tapizados', 474685, N'Esther', N'Arriaga', 26, CAST(N'2022-06-06' AS Date), NULL, 1)
GO
INSERT [dbo].[Proveedores] ([idProveedor], [razonSocial], [telefono], [nombre], [apellido], [idBarrio], [fechaAlta], [fechaBaja], [vigencia]) VALUES (1009, N'Maderas Díaz', 447812, N'Santiago', N'Díaz', 8, NULL, NULL, NULL)
GO
INSERT [dbo].[Proveedores] ([idProveedor], [razonSocial], [telefono], [nombre], [apellido], [idBarrio], [fechaAlta], [fechaBaja], [vigencia]) VALUES (1010, N'Cabrera S.A.', 469471, N'Esteban', N'Cabrera', 31, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoDocumento] ON 
GO
INSERT [dbo].[TipoDocumento] ([idTipo], [descripcion]) VALUES (1, N'Dni')
GO
INSERT [dbo].[TipoDocumento] ([idTipo], [descripcion]) VALUES (2, N'Pasaporte')
GO
INSERT [dbo].[TipoDocumento] ([idTipo], [descripcion]) VALUES (3, N'Libreta')
GO
SET IDENTITY_INSERT [dbo].[TipoDocumento] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoFactura] ON 
GO
INSERT [dbo].[TipoFactura] ([id], [descripcion]) VALUES (1, N'A')
GO
INSERT [dbo].[TipoFactura] ([id], [descripcion]) VALUES (2, N'B')
GO
INSERT [dbo].[TipoFactura] ([id], [descripcion]) VALUES (3, N'C')
GO
SET IDENTITY_INSERT [dbo].[TipoFactura] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoProductos] ON 
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (1, N'Silla')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (2, N'Mesa')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (3, N'Mesa Ratona')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (4, N'Sofa')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (5, N'Sillon')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (6, N'Mecedora')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (7, N'Escritorio')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (8, N'Cama')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (9, N'Cómoda')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (10, N'Biblioteca')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (11, N'Taburete')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (12, N'Mesa de luz')
GO
INSERT [dbo].[TipoProductos] ([idTipo], [nombre]) VALUES (13, N'Armario')
GO
SET IDENTITY_INSERT [dbo].[TipoProductos] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoSexo] ON 
GO
INSERT [dbo].[TipoSexo] ([idSexo], [descripcionS]) VALUES (1, N'Femenino')
GO
INSERT [dbo].[TipoSexo] ([idSexo], [descripcionS]) VALUES (2, N'Masculino')
GO
INSERT [dbo].[TipoSexo] ([idSexo], [descripcionS]) VALUES (3, N'Otro')
GO
SET IDENTITY_INSERT [dbo].[TipoSexo] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (5, N'ronald', N'123ro', N'ronaldpary780@gmail.com', 0)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (7, N'santiago ', N'123san', N'santiagodiaz1@gmail.com', 0)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (8, N'martin1', N'123mar', N'martinbaudino@gmail.com', 0)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (11, N'federico1', N'123fe', N'federicotorres@gmail.com', 0)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (2017, N'asdsadasdDFGDFG', N'asdasd', N'dfsdfsf', 0)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (2018, N'werfsf', N'sdfsdf', N'sdfsdf', 0)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (2019, N'sdfsd', N'sdf', N'sdff', 0)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (2020, N'sdfsdf', N'sdfsdf', N'sdfsdf', 0)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (3012, N'fAS', N'sdf', N'sdf', 0)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (3013, N'sdf', N'sdf', N'sdf', 0)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (3014, N'SDFSDFSDF', N'ASD', N'ASDAS', 0)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [contraseña], [mail], [borrado]) VALUES (3015, N'valentin', N'123', N'arriagavalen.03@gmail.com', 0)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Barrios]  WITH CHECK ADD  CONSTRAINT [FK_Barrios_Localidades] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Localidades] ([idLocalidad])
GO
ALTER TABLE [dbo].[Barrios] CHECK CONSTRAINT [FK_Barrios_Localidades]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Facturas] FOREIGN KEY([tipoFactura], [nroFactura])
REFERENCES [dbo].[Facturas] ([tipoFactura], [nroFactura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Facturas]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Productos] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Productos] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Productos]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY([nroDocCl], [tipoDocCl])
REFERENCES [dbo].[Clientes] ([nroDoc], [tipoDoc])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Clientes]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_FormasPago] FOREIGN KEY([idFormaPago])
REFERENCES [dbo].[FormasPago] ([idFormaPago])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_FormasPago]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [fk_productos_colores] FOREIGN KEY([idColor])
REFERENCES [dbo].[ProductoColor] ([idColor])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [fk_productos_colores]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [fk_productos_materiales] FOREIGN KEY([idMaterial])
REFERENCES [dbo].[ProductoMaterial] ([idMaterial])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [fk_productos_materiales]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Proveedores] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedores] ([idProveedor])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Proveedores]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_TipoProductos] FOREIGN KEY([idTipo])
REFERENCES [dbo].[TipoProductos] ([idTipo])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_TipoProductos]
GO
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_Proveedores_Barrios] FOREIGN KEY([idBarrio])
REFERENCES [dbo].[Barrios] ([idBarrio])
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_Barrios]
GO
USE [master]
GO
ALTER DATABASE [BDPav1TP] SET  READ_WRITE 
GO
