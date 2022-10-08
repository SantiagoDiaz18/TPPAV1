USE [master]
GO
/****** Object:  Database [BDPav1TP]    Script Date: 7/10/2022 10:59:29 ******/
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
/****** Object:  Table [dbo].[Barrios]    Script Date: 7/10/2022 10:59:29 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 7/10/2022 10:59:29 ******/
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
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 7/10/2022 10:59:29 ******/
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
/****** Object:  Table [dbo].[Facturas]    Script Date: 7/10/2022 10:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[tipoFactura] [int] NOT NULL,
	[nroFactura] [int] NOT NULL,
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
/****** Object:  Table [dbo].[FormasPago]    Script Date: 7/10/2022 10:59:29 ******/
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
/****** Object:  Table [dbo].[Localidades]    Script Date: 7/10/2022 10:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidades](
	[idLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[nombreLocalidad] [varchar](50) NULL,
	[idDepartamento] [int] NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[idLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoColor]    Script Date: 7/10/2022 10:59:29 ******/
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
/****** Object:  Table [dbo].[ProductoMaterial]    Script Date: 7/10/2022 10:59:29 ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 7/10/2022 10:59:29 ******/
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
	[periodoGarantia] [datetime] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 7/10/2022 10:59:29 ******/
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
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 7/10/2022 10:59:29 ******/
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
/****** Object:  Table [dbo].[TipoProductos]    Script Date: 7/10/2022 10:59:29 ******/
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
/****** Object:  Table [dbo].[TipoSexo]    Script Date: 7/10/2022 10:59:29 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/10/2022 10:59:29 ******/
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
