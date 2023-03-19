USE [master]
GO
/****** Object:  Database [SalonDeBellezaCarlitos]    Script Date: 17/03/2023 15:48:31 ******/
CREATE DATABASE [SalonDeBellezaCarlitos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SalonDeBellezaCarlitos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVERLOCAL\MSSQL\DATA\SalonDeBellezaCarlitos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SalonDeBellezaCarlitos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVERLOCAL\MSSQL\DATA\SalonDeBellezaCarlitos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SalonDeBellezaCarlitos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET ARITHABORT OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET  MULTI_USER 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET QUERY_STORE = OFF
GO
USE [SalonDeBellezaCarlitos]
GO
/****** Object:  User [phynomo]    Script Date: 17/03/2023 15:48:31 ******/
CREATE USER [phynomo] FOR LOGIN [phynomo] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [phynomo]
GO
/****** Object:  Schema [acce]    Script Date: 17/03/2023 15:48:31 ******/
CREATE SCHEMA [acce]
GO
/****** Object:  Schema [gnrl]    Script Date: 17/03/2023 15:48:31 ******/
CREATE SCHEMA [gnrl]
GO
/****** Object:  Schema [salo]    Script Date: 17/03/2023 15:48:31 ******/
CREATE SCHEMA [salo]
GO
/****** Object:  Table [gnrl].[tbDepartamentos]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [gnrl].[tbDepartamentos](
	[depa_Id] [int] IDENTITY(1,1) NOT NULL,
	[depa_Descripcion] [nvarchar](200) NOT NULL,
	[depa_Codigo] [char](2) NOT NULL,
	[depa_FechaCreacion] [datetime] NOT NULL,
	[depa_UsuarioCreacion] [int] NOT NULL,
	[depa_FechaModificacion] [datetime] NULL,
	[depa_UsuarioModificacion] [int] NULL,
	[depa_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_gnrl_tbDepartamentos_depa_Id] PRIMARY KEY CLUSTERED 
(
	[depa_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [gnrl].[tbMunicipios]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [gnrl].[tbMunicipios](
	[muni_Id] [int] IDENTITY(1,1) NOT NULL,
	[muni_Descripcion] [nvarchar](200) NOT NULL,
	[muni_Codigo] [char](4) NOT NULL,
	[depa_Id] [int] NOT NULL,
	[muni_FechaCreacion] [datetime] NOT NULL,
	[muni_UsuarioCreacion] [int] NOT NULL,
	[muni_FechaModificacion] [datetime] NULL,
	[muni_UsuarioModificacion] [int] NULL,
	[muni_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_gnrl_tbMunicipios_muni_Id] PRIMARY KEY CLUSTERED 
(
	[muni_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [gnrl].[VW_tbMunicipios_View]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------Procedimiento Insert Municipios

CREATE   VIEW [gnrl].[VW_tbMunicipios_View]
as
SELECT [muni_Id]
      ,[muni_Descripcion]
      ,[muni_Codigo]
      ,T1.[depa_Id]
	  ,T2.depa_Codigo
	  ,T2.depa_Descripcion
      ,[muni_FechaCreacion]
      ,[muni_UsuarioCreacion]
      ,[muni_FechaModificacion]
      ,[muni_UsuarioModificacion]
      ,[muni_Estado]
  FROM [gnrl].[tbMunicipios] T1 INNER JOIN gnrl.tbDepartamentos T2
  ON T1.depa_Id = T2.depa_Id
  WHERE muni_Estado = 1

GO
/****** Object:  Table [gnrl].[tbMetodoPago]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [gnrl].[tbMetodoPago](
	[metp_Id] [int] IDENTITY(1,1) NOT NULL,
	[metp_Descripcion] [nvarchar](100) NOT NULL,
	[metp_FechaCreacion] [datetime] NOT NULL,
	[metp_UsuarioCreacion] [int] NOT NULL,
	[metp_FechaModificacion] [datetime] NULL,
	[metp_UsuarioModificacion] [int] NULL,
	[metp_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_gnrl_tbMetodoPagos_metp_Id] PRIMARY KEY CLUSTERED 
(
	[metp_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [salo].[tbEmpleados]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbEmpleados](
	[empl_Id] [int] IDENTITY(1,1) NOT NULL,
	[empl_Nombre] [nvarchar](150) NOT NULL,
	[empl_Apellido] [nvarchar](150) NOT NULL,
	[empl_Sexo] [char](1) NOT NULL,
	[muni_Id] [int] NOT NULL,
	[empl_DireccionExacta] [nvarchar](500) NOT NULL,
	[estc_Id] [int] NOT NULL,
	[empl_Telefono] [nvarchar](20) NOT NULL,
	[empl_CorreoElectronico] [nvarchar](100) NOT NULL,
	[empl_FechaNacimiento] [date] NOT NULL,
	[empl_FechaContratacion] [date] NOT NULL,
	[carg_Id] [int] NOT NULL,
	[empl_FechaCreacion] [datetime] NOT NULL,
	[empl_UsuarioCreacion] [int] NOT NULL,
	[empl_FechaModificacion] [datetime] NULL,
	[empl_UsuarioModificacion] [int] NULL,
	[empl_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbEmpleados_empl_Id] PRIMARY KEY CLUSTERED 
(
	[empl_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [salo].[tbClientes]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbClientes](
	[clie_Id] [int] IDENTITY(1,1) NOT NULL,
	[clie_Nombre] [nvarchar](150) NOT NULL,
	[clie_Apellido] [nvarchar](150) NOT NULL,
	[clie_Telefono] [nvarchar](20) NOT NULL,
	[clie_CorreoElectronico] [nvarchar](100) NULL,
	[clie_FechaCreacion] [datetime] NOT NULL,
	[clie_UsuarioCreacion] [int] NOT NULL,
	[clie_FechaModificacion] [datetime] NULL,
	[clie_UsuarioModificacion] [int] NULL,
	[clie_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbClientes_clie_Id] PRIMARY KEY CLUSTERED 
(
	[clie_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [salo].[tbFacturas]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbFacturas](
	[fact_Id] [int] IDENTITY(1,1) NOT NULL,
	[clie_Id] [int] NOT NULL,
	[empl_Id_Atendido] [int] NOT NULL,
	[empl_Id_Caja] [int] NOT NULL,
	[metp_Id] [int] NOT NULL,
	[fact_Fecha] [datetime] NOT NULL,
	[fact_FechaCreacion] [datetime] NOT NULL,
	[fact_UsuarioCreacion] [int] NOT NULL,
	[fact_FechaModificacion] [datetime] NULL,
	[fact_UsuarioModificacion] [int] NULL,
	[fact_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbFacturas_fact_Id] PRIMARY KEY CLUSTERED 
(
	[fact_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_tbFacturas_Listado]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   VIEW [dbo].[VW_tbFacturas_Listado]
AS
SELECT [fact_Id]
      ,T1.[clie_Id]
	  ,T2.clie_Nombre
	  ,T2.clie_Apellido
	  ,T2.clie_Telefono
      ,[empl_Id_Atendido]
	  ,ate.empl_Nombre AS NombreAtendido
	  ,ate.empl_Apellido AS ApellidoAtendido
	  ,ate.empl_Telefono AS TelefonoAtendido
      ,[empl_Id_Caja]
	  ,caja.empl_Nombre	AS NombreCaja
	  ,caja.empl_Apellido AS ApellidoCaja
	  ,caja.empl_Telefono AS TelefonoCaja
      ,T1.[metp_Id]
	  ,T3.metp_Descripcion
      ,[fact_Fecha]
      ,[fact_FechaCreacion]
      ,[fact_UsuarioCreacion]
      ,[fact_FechaModificacion]
      ,[fact_UsuarioModificacion]
      ,[fact_Estado]
  FROM [salo].[tbFacturas] T1 INNER JOIN salo.tbClientes T2
  ON T1.clie_Id = T2.clie_Id INNER JOIN gnrl.tbMetodoPago T3
  ON T3.metp_Id = T1.metp_Id INNER JOIN salo.tbEmpleados Ate
  ON Ate.empl_Id = t1.empl_Id_Atendido INNER JOIN salo.tbEmpleados caja
  ON caja.empl_Id = T1.empl_Id_Caja
GO
/****** Object:  Table [salo].[tbProductos]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbProductos](
	[prod_Id] [int] IDENTITY(1,1) NOT NULL,
	[prod_Nombre] [nvarchar](200) NOT NULL,
	[prod_Precio] [decimal](18, 2) NOT NULL,
	[cate_Id] [int] NOT NULL,
	[prod_Stock] [int] NOT NULL,
	[prov_id] [int] NULL,
	[prod_FechaCreacion] [datetime] NOT NULL,
	[prod_UsuarioCreacion] [int] NOT NULL,
	[prod_FechaModificacion] [datetime] NULL,
	[prod_UsuarioModificacion] [int] NULL,
	[prod_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbProductos_prod_Id] PRIMARY KEY CLUSTERED 
(
	[prod_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [salo].[tbServicios]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbServicios](
	[serv_Id] [int] IDENTITY(1,1) NOT NULL,
	[serv_Nombre] [nvarchar](150) NOT NULL,
	[serv_Descripcion] [nvarchar](500) NULL,
	[serv_Precio] [decimal](18, 2) NOT NULL,
	[serv_FechaCreacion] [datetime] NOT NULL,
	[serv_UsuarioCreacion] [int] NOT NULL,
	[serv_FechaModificacion] [datetime] NULL,
	[serv_UsuarioModificacion] [int] NULL,
	[serv_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbServicio_serv_Id] PRIMARY KEY CLUSTERED 
(
	[serv_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [salo].[tbFacturasDetalles]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbFacturasDetalles](
	[fade_Id] [int] IDENTITY(1,1) NOT NULL,
	[fact_Id] [int] NOT NULL,
	[prod_Id] [int] NULL,
	[serv_Id] [int] NULL,
	[fade_Cantidad] [int] NOT NULL,
	[fade_Precio] [decimal](18, 2) NOT NULL,
	[fade_FechaCreacion] [datetime] NOT NULL,
	[fade_UsuarioCreacion] [int] NOT NULL,
	[fade_FechaModificacion] [datetime] NULL,
	[fade_UsuarioModificacion] [int] NULL,
	[fade_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbFacturasDetalles_fade_Id] PRIMARY KEY CLUSTERED 
(
	[fade_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [salo].[VW_tbFacturaDetalle_View]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento Insert FacturasDetalle

CREATE   VIEW [salo].[VW_tbFacturaDetalle_View]
as
SELECT [fade_Id]
      ,[fact_Id]
	  ,T1.[prod_Id]
	  ,T1.[serv_Id]
      ,T2.prod_Nombre 
	  ,T3.serv_Nombre
	  ,[fade_Cantidad]
      ,[fade_Precio]
      ,[fade_FechaCreacion]
      ,[fade_UsuarioCreacion]
      ,[fade_FechaModificacion]
      ,[fade_UsuarioModificacion]
      ,[fade_Estado]
  FROM [salo].[tbFacturasDetalles] T1 LEFT JOIN salo.tbProductos T2
  ON t1.prod_Id = T2.prod_Id LEFT JOIN salo.tbServicios T3
  ON t3.serv_Id = T1.serv_Id
  WHERE fade_Estado = 1

GO
/****** Object:  Table [acce].[tbUsuarios]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [acce].[tbUsuarios](
	[usur_Id] [int] IDENTITY(1,1) NOT NULL,
	[usur_Usuario] [nvarchar](100) NOT NULL,
	[usur_Contrasenia] [nvarchar](max) NOT NULL,
	[empl_Id] [int] NOT NULL,
	[usur_UsuarioCreacion] [int] NOT NULL,
	[usur_FechaCreacion] [datetime] NOT NULL,
	[usur_UsuarioModificacion] [int] NULL,
	[usur_FechaModificacion] [datetime] NULL,
	[usur_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_acce_tbUsuarios_usur_Id] PRIMARY KEY CLUSTERED 
(
	[usur_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [gnrl].[tbEstadosCiviles]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [gnrl].[tbEstadosCiviles](
	[estc_Id] [int] IDENTITY(1,1) NOT NULL,
	[estc_Descripcion] [nvarchar](200) NOT NULL,
	[estc_FechaCreacion] [datetime] NOT NULL,
	[estc_UsuarioCreacion] [int] NOT NULL,
	[estc_FechaModificacion] [datetime] NULL,
	[estc_UsuarioModificacion] [int] NULL,
	[estc_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_gnrl_tbEstadosCiviles_estc_Id] PRIMARY KEY CLUSTERED 
(
	[estc_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [salo].[tbCargos]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbCargos](
	[carg_Id] [int] IDENTITY(1,1) NOT NULL,
	[carg_Descripcion] [nvarchar](200) NOT NULL,
	[carg_FechaCreacion] [datetime] NOT NULL,
	[carg_UsuarioCreacion] [int] NOT NULL,
	[carg_FechaModificacion] [datetime] NULL,
	[carg_UsuarioModificacion] [int] NULL,
	[carg_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbCargos_carg_Id] PRIMARY KEY CLUSTERED 
(
	[carg_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [salo].[tbCategorias]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbCategorias](
	[cate_Id] [int] IDENTITY(1,1) NOT NULL,
	[cate_Descripcion] [nvarchar](150) NOT NULL,
	[cate_FechaCreacion] [datetime] NOT NULL,
	[cate_UsuarioCreacion] [int] NOT NULL,
	[cate_FechaModificacion] [datetime] NULL,
	[cate_UsuarioModificacion] [int] NULL,
	[cate_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbCategoria_cate_Id] PRIMARY KEY CLUSTERED 
(
	[cate_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [salo].[tbProductosXServicio]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbProductosXServicio](
	[spro_Id] [int] IDENTITY(1,1) NOT NULL,
	[serv_Id] [int] NULL,
	[prod_Id] [int] NULL,
	[spro_FechaCreacion] [datetime] NOT NULL,
	[spro_UsuarioCreacion] [int] NOT NULL,
	[spro_FechaModificacion] [datetime] NULL,
	[spro_UsuarioModificacion] [int] NULL,
	[spro_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbProductosXServicio_serprod_Id] PRIMARY KEY CLUSTERED 
(
	[spro_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [salo].[tbProveedores]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbProveedores](
	[prov_Id] [int] IDENTITY(1,1) NOT NULL,
	[prov_NombreEmpresa] [nvarchar](150) NOT NULL,
	[prov_NombreContacto] [nvarchar](150) NOT NULL,
	[muni_Id] [int] NOT NULL,
	[prov_DireccionExacta] [nvarchar](500) NOT NULL,
	[prov_Telefono] [nvarchar](20) NOT NULL,
	[prov_FechaCreacion] [datetime] NOT NULL,
	[prov_UsuarioCreacion] [int] NOT NULL,
	[prov_FechaModificacion] [datetime] NULL,
	[prov_UsuarioModificacion] [int] NULL,
	[prov_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbProveedores_prov_Id] PRIMARY KEY CLUSTERED 
(
	[prov_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [salo].[tbReservaciones]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbReservaciones](
	[rese_Id] [int] IDENTITY(1,1) NOT NULL,
	[clie_Id] [int] NOT NULL,
	[sucu_Id] [int] NOT NULL,
	[rese_DiaReservado] [date] NOT NULL,
	[rese_HoraInicio] [time](7) NOT NULL,
	[rese_HoraFin] [time](7) NOT NULL,
	[rese_FechaCreacion] [datetime] NOT NULL,
	[rese_UsuarioCreacion] [int] NOT NULL,
	[rese_FechaModificacion] [datetime] NULL,
	[rese_UsuarioModificacion] [int] NULL,
	[rese_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbReservaciones_rese_Id] PRIMARY KEY CLUSTERED 
(
	[rese_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [salo].[tbSucursales]    Script Date: 17/03/2023 15:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [salo].[tbSucursales](
	[sucu_Id] [int] IDENTITY(1,1) NOT NULL,
	[sucu_Descripcion] [nvarchar](200) NOT NULL,
	[muni_Id] [int] NULL,
	[sucu_DireccionExacta] [nvarchar](500) NOT NULL,
	[sucu_FechaCreacion] [datetime] NOT NULL,
	[sucu_UsuarioCreacion] [int] NOT NULL,
	[sucu_FechaModificacion] [datetime] NULL,
	[sucu_UsuarioModificacion] [int] NULL,
	[sucu_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_salo_tbSucursales_sucu_Id] PRIMARY KEY CLUSTERED 
(
	[sucu_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [acce].[tbUsuarios] ON 

INSERT [acce].[tbUsuarios] ([usur_Id], [usur_Usuario], [usur_Contrasenia], [empl_Id], [usur_UsuarioCreacion], [usur_FechaCreacion], [usur_UsuarioModificacion], [usur_FechaModificacion], [usur_Estado]) VALUES (1, N'admin', N'귇쭄皭崪꒠勒哨쇽⪥ĸ⍟�錋퐝捲祉᳇仓㖼櫑﮷邊Ὲ冗혓叇욍�郞', 1, 1, CAST(N'2023-03-17T08:44:02.177' AS DateTime), NULL, NULL, 1)
SET IDENTITY_INSERT [acce].[tbUsuarios] OFF
GO
SET IDENTITY_INSERT [gnrl].[tbDepartamentos] ON 

INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (1, N'Atlantida', N'01', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (2, N'Colon', N'02', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (3, N'Comayagua', N'03', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (4, N'Copan', N'04', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (5, N'Cortes', N'05', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (6, N'Choluteca', N'06', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (7, N'El Paraiso', N'07', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (8, N'francisco Morazan', N'08', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (9, N'Gracias a Dios', N'09', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (10, N'Intibuca', N'10', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (11, N'Islas de la Bahia', N'11', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (12, N'La Paz', N'12', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (13, N'Lempira', N'13', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (14, N'Ocotepeque', N'14', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (15, N'Olancho', N'15', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (16, N'Santa Barbara', N'16', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (17, N'Valle', N'17', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (18, N'Yoro', N'18', CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (19, N'Esquizos', N'69', CAST(N'2023-03-17T08:47:13.783' AS DateTime), 1, CAST(N'2023-03-17T08:48:09.100' AS DateTime), 1, 0)
INSERT [gnrl].[tbDepartamentos] ([depa_Id], [depa_Descripcion], [depa_Codigo], [depa_FechaCreacion], [depa_UsuarioCreacion], [depa_FechaModificacion], [depa_UsuarioModificacion], [depa_Estado]) VALUES (20, N'Esquizo', N'19', CAST(N'2023-03-17T08:49:04.030' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [gnrl].[tbDepartamentos] OFF
GO
SET IDENTITY_INSERT [gnrl].[tbEstadosCiviles] ON 

INSERT [gnrl].[tbEstadosCiviles] ([estc_Id], [estc_Descripcion], [estc_FechaCreacion], [estc_UsuarioCreacion], [estc_FechaModificacion], [estc_UsuarioModificacion], [estc_Estado]) VALUES (1, N'Casado(a)', CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbEstadosCiviles] ([estc_Id], [estc_Descripcion], [estc_FechaCreacion], [estc_UsuarioCreacion], [estc_FechaModificacion], [estc_UsuarioModificacion], [estc_Estado]) VALUES (2, N'Soltero(a)', CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbEstadosCiviles] ([estc_Id], [estc_Descripcion], [estc_FechaCreacion], [estc_UsuarioCreacion], [estc_FechaModificacion], [estc_UsuarioModificacion], [estc_Estado]) VALUES (3, N'Divorciado(a)', CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbEstadosCiviles] ([estc_Id], [estc_Descripcion], [estc_FechaCreacion], [estc_UsuarioCreacion], [estc_FechaModificacion], [estc_UsuarioModificacion], [estc_Estado]) VALUES (4, N'Viudo(a)', CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbEstadosCiviles] ([estc_Id], [estc_Descripcion], [estc_FechaCreacion], [estc_UsuarioCreacion], [estc_FechaModificacion], [estc_UsuarioModificacion], [estc_Estado]) VALUES (5, N'Union libre', CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 0)
INSERT [gnrl].[tbEstadosCiviles] ([estc_Id], [estc_Descripcion], [estc_FechaCreacion], [estc_UsuarioCreacion], [estc_FechaModificacion], [estc_UsuarioModificacion], [estc_Estado]) VALUES (6, N'Nesecitadoss', CAST(N'2023-03-17T09:13:15.683' AS DateTime), 1, CAST(N'2023-03-17T09:29:26.743' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [gnrl].[tbEstadosCiviles] OFF
GO
SET IDENTITY_INSERT [gnrl].[tbMetodoPago] ON 

INSERT [gnrl].[tbMetodoPago] ([metp_Id], [metp_Descripcion], [metp_FechaCreacion], [metp_UsuarioCreacion], [metp_FechaModificacion], [metp_UsuarioModificacion], [metp_Estado]) VALUES (1, N'Efectivo', CAST(N'2023-03-17T08:44:02.233' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMetodoPago] ([metp_Id], [metp_Descripcion], [metp_FechaCreacion], [metp_UsuarioCreacion], [metp_FechaModificacion], [metp_UsuarioModificacion], [metp_Estado]) VALUES (2, N'Tarjeta de Credito', CAST(N'2023-03-17T08:44:02.233' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMetodoPago] ([metp_Id], [metp_Descripcion], [metp_FechaCreacion], [metp_UsuarioCreacion], [metp_FechaModificacion], [metp_UsuarioModificacion], [metp_Estado]) VALUES (3, N'Tarjeta de Debito', CAST(N'2023-03-17T08:44:02.233' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMetodoPago] ([metp_Id], [metp_Descripcion], [metp_FechaCreacion], [metp_UsuarioCreacion], [metp_FechaModificacion], [metp_UsuarioModificacion], [metp_Estado]) VALUES (4, N'Cuerpos', CAST(N'2023-03-17T08:45:51.260' AS DateTime), 1, NULL, NULL, 0)
INSERT [gnrl].[tbMetodoPago] ([metp_Id], [metp_Descripcion], [metp_FechaCreacion], [metp_UsuarioCreacion], [metp_FechaModificacion], [metp_UsuarioModificacion], [metp_Estado]) VALUES (5, N'Tities', CAST(N'2023-03-17T09:30:28.840' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [gnrl].[tbMetodoPago] OFF
GO
SET IDENTITY_INSERT [gnrl].[tbMunicipios] ON 

INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (1, N'La Ceiba ', N'0101', 1, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (2, N'El Porvenir', N'0102', 1, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (3, N'Jutiapa', N'0103', 1, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (4, N'Jutiapa', N'0104', 1, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (5, N'La Masica', N'0105', 1, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (6, N'Trujillo', N'0201', 2, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (7, N'Balfate', N'0202', 2, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (8, N'Iriona', N'0203', 2, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (9, N'Limon', N'0204', 2, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (10, N'Saba', N'0205', 2, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (11, N'Comayagua', N'0301', 3, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (12, N'Ajuterique', N'0302', 3, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (13, N'El Rosario', N'0303', 3, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (14, N'Esqueas', N'0304', 3, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (15, N'Humuya', N'0305', 3, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (16, N'Santa Rosa de Copan', N'0401', 4, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (17, N'Cabanias', N'0402', 4, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (18, N'Concepcion', N'0403', 4, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (19, N'Copan Ruinas', N'0404', 4, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (20, N'Corquan', N'0405', 4, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (21, N'San Pedro Sula ', N'0501', 5, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (22, N'Choloma ', N'0502', 5, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (23, N'Omoa', N'0503', 5, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (24, N'Pimienta', N'0504', 5, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (25, N'Potrerillos', N'0505', 5, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (26, N'Choluteca', N'0601', 6, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (27, N'Apacilagua', N'0602', 6, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (28, N'Concepcion de Maria', N'0603', 6, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (29, N'Duyure', N'0604', 6, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (30, N'El Corpus', N'0605', 7, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (31, N'Yuscaron', N'0701', 7, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (32, N'Alauca', N'0702', 7, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (33, N'Danli', N'0703', 7, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (34, N'El Paraiso', N'0704', 7, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (35, N'Giinope', N'0705', 7, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (36, N'Distrito Central (Comayagiela y Tegucigalpa)', N'0801', 8, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (37, N'Alubarun', N'0802', 8, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (38, N'Cedros', N'0803', 8, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (39, N'Curaran', N'0804', 8, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (40, N'El Porvenir', N'0805', 8, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (41, N'Puerto Lempira', N'0901', 9, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (42, N'Brus Laguna', N'0902', 9, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (43, N'Ahuas', N'0903', 9, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (44, N'Juan fabncisco Bulnes', N'0904', 9, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (45, N'Villeda Morales', N'0905', 9, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (46, N'La Esperanza', N'1001', 10, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (47, N'Camasca', N'1002', 10, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (48, N'Colomoncagua', N'1003', 10, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (49, N'Concepcion', N'1004', 10, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (50, N'Dolores', N'1005', 10, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (51, N'Roatan', N'1101', 11, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (52, N'Guanaja', N'1102', 11, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (53, N'Jose Santos Guardiola', N'1103', 11, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (54, N'Utila', N'1104', 11, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (55, N'La Paz', N'1201', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (56, N'Aguanqueterique', N'1202', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (57, N'Cabanias', N'1203', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (58, N'Cane', N'1204', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (59, N'Chinacla', N'1205', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (60, N'Gracias', N'1301', 13, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (61, N'Belen', N'1302', 13, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (62, N'Candelaria', N'1303', 13, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (63, N'Cololaca', N'1304', 13, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (64, N'Erandique', N'1305', 13, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (65, N'Ocotepeque', N'1401', 14, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (66, N'Belen Gualcho', N'1402', 14, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (67, N'Concepcion', N'1403', 14, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (68, N'Dolores Merendon', N'1404', 14, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (69, N'fabternidad', N'1405', 14, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (70, N'Juticalpa', N'1501', 15, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (71, N'Campamento', N'1502', 15, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (72, N'Catacamas', N'1503', 15, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (73, N'Concordia', N'1504', 15, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (74, N'Dulce Nombre de Culmo', N'1505', 15, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (75, N'Santa Barbara', N'1601', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (76, N'Arada', N'1602', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (77, N'Atima', N'1603', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (78, N'Azacualpa', N'1604', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (79, N'Ceguaca', N'1605', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (80, N'Nacaome', N'1701', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (81, N'Alianza', N'1702', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (82, N'Amapala', N'1703', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (83, N'Aramecina', N'1704', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (84, N'Caridad', N'1705', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (85, N'Yoro', N'1801', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (86, N'Arenal', N'1802', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (87, N'El Negrito', N'1803', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (88, N'El artgreso', N'1804', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (89, N'Jocon', N'1805', 12, CAST(N'2023-03-17T08:44:02.217' AS DateTime), 1, NULL, NULL, 1)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (90, N'EsquizoCity', N'0119', 20, CAST(N'2023-03-17T08:49:38.973' AS DateTime), 1, CAST(N'2023-03-17T08:49:55.020' AS DateTime), 1, 0)
INSERT [gnrl].[tbMunicipios] ([muni_Id], [muni_Descripcion], [muni_Codigo], [depa_Id], [muni_FechaCreacion], [muni_UsuarioCreacion], [muni_FechaModificacion], [muni_UsuarioModificacion], [muni_Estado]) VALUES (91, N'Esquizoland', N'0219', 20, CAST(N'2023-03-17T08:51:49.663' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [gnrl].[tbMunicipios] OFF
GO
SET IDENTITY_INSERT [salo].[tbCargos] ON 

INSERT [salo].[tbCargos] ([carg_Id], [carg_Descripcion], [carg_FechaCreacion], [carg_UsuarioCreacion], [carg_FechaModificacion], [carg_UsuarioModificacion], [carg_Estado]) VALUES (1, N'Jefe', CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbCargos] ([carg_Id], [carg_Descripcion], [carg_FechaCreacion], [carg_UsuarioCreacion], [carg_FechaModificacion], [carg_UsuarioModificacion], [carg_Estado]) VALUES (2, N'Gerenteeeee', CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, CAST(N'2023-03-17T08:50:49.230' AS DateTime), 1, 1)
INSERT [salo].[tbCargos] ([carg_Id], [carg_Descripcion], [carg_FechaCreacion], [carg_UsuarioCreacion], [carg_FechaModificacion], [carg_UsuarioModificacion], [carg_Estado]) VALUES (3, N'Repartidor', CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbCargos] ([carg_Id], [carg_Descripcion], [carg_FechaCreacion], [carg_UsuarioCreacion], [carg_FechaModificacion], [carg_UsuarioModificacion], [carg_Estado]) VALUES (4, N'Vendedor', CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbCargos] ([carg_Id], [carg_Descripcion], [carg_FechaCreacion], [carg_UsuarioCreacion], [carg_FechaModificacion], [carg_UsuarioModificacion], [carg_Estado]) VALUES (5, N'Recepcionista', CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbCargos] ([carg_Id], [carg_Descripcion], [carg_FechaCreacion], [carg_UsuarioCreacion], [carg_FechaModificacion], [carg_UsuarioModificacion], [carg_Estado]) VALUES (6, N'lupa', CAST(N'2023-03-17T08:44:02.280' AS DateTime), 1, NULL, NULL, 0)
INSERT [salo].[tbCargos] ([carg_Id], [carg_Descripcion], [carg_FechaCreacion], [carg_UsuarioCreacion], [carg_FechaModificacion], [carg_UsuarioModificacion], [carg_Estado]) VALUES (7, N'Prostituta', CAST(N'2023-03-17T08:50:52.560' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbCargos] ([carg_Id], [carg_Descripcion], [carg_FechaCreacion], [carg_UsuarioCreacion], [carg_FechaModificacion], [carg_UsuarioModificacion], [carg_Estado]) VALUES (8, N'GIGI', CAST(N'2023-03-17T08:50:57.343' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [salo].[tbCargos] OFF
GO
SET IDENTITY_INSERT [salo].[tbCategorias] ON 

INSERT [salo].[tbCategorias] ([cate_Id], [cate_Descripcion], [cate_FechaCreacion], [cate_UsuarioCreacion], [cate_FechaModificacion], [cate_UsuarioModificacion], [cate_Estado]) VALUES (1, N'Categoria 1', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbCategorias] ([cate_Id], [cate_Descripcion], [cate_FechaCreacion], [cate_UsuarioCreacion], [cate_FechaModificacion], [cate_UsuarioModificacion], [cate_Estado]) VALUES (2, N'Categoria 2', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbCategorias] ([cate_Id], [cate_Descripcion], [cate_FechaCreacion], [cate_UsuarioCreacion], [cate_FechaModificacion], [cate_UsuarioModificacion], [cate_Estado]) VALUES (3, N'Categoria 3', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbCategorias] ([cate_Id], [cate_Descripcion], [cate_FechaCreacion], [cate_UsuarioCreacion], [cate_FechaModificacion], [cate_UsuarioModificacion], [cate_Estado]) VALUES (4, N'Categoria 4', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbCategorias] ([cate_Id], [cate_Descripcion], [cate_FechaCreacion], [cate_UsuarioCreacion], [cate_FechaModificacion], [cate_UsuarioModificacion], [cate_Estado]) VALUES (5, N'Categoria 5', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbCategorias] ([cate_Id], [cate_Descripcion], [cate_FechaCreacion], [cate_UsuarioCreacion], [cate_FechaModificacion], [cate_UsuarioModificacion], [cate_Estado]) VALUES (6, N'Carnes', CAST(N'2023-03-17T08:55:02.067' AS DateTime), 1, NULL, NULL, 0)
INSERT [salo].[tbCategorias] ([cate_Id], [cate_Descripcion], [cate_FechaCreacion], [cate_UsuarioCreacion], [cate_FechaModificacion], [cate_UsuarioModificacion], [cate_Estado]) VALUES (7, N'Tu culo', CAST(N'2023-03-17T10:17:46.440' AS DateTime), 1, CAST(N'2023-03-17T10:17:53.427' AS DateTime), 1, 0)
INSERT [salo].[tbCategorias] ([cate_Id], [cate_Descripcion], [cate_FechaCreacion], [cate_UsuarioCreacion], [cate_FechaModificacion], [cate_UsuarioModificacion], [cate_Estado]) VALUES (8, N'Sexo', CAST(N'2023-03-17T11:04:07.340' AS DateTime), 1, NULL, NULL, 0)
INSERT [salo].[tbCategorias] ([cate_Id], [cate_Descripcion], [cate_FechaCreacion], [cate_UsuarioCreacion], [cate_FechaModificacion], [cate_UsuarioModificacion], [cate_Estado]) VALUES (9, N'EEEE''', CAST(N'2023-03-17T13:18:02.620' AS DateTime), 1, CAST(N'2023-03-17T13:18:20.080' AS DateTime), 1, 0)
INSERT [salo].[tbCategorias] ([cate_Id], [cate_Descripcion], [cate_FechaCreacion], [cate_UsuarioCreacion], [cate_FechaModificacion], [cate_UsuarioModificacion], [cate_Estado]) VALUES (10, N'asdasd,', CAST(N'2023-03-17T13:18:42.423' AS DateTime), 1, NULL, NULL, 0)
SET IDENTITY_INSERT [salo].[tbCategorias] OFF
GO
SET IDENTITY_INSERT [salo].[tbClientes] ON 

INSERT [salo].[tbClientes] ([clie_Id], [clie_Nombre], [clie_Apellido], [clie_Telefono], [clie_CorreoElectronico], [clie_FechaCreacion], [clie_UsuarioCreacion], [clie_FechaModificacion], [clie_UsuarioModificacion], [clie_Estado]) VALUES (1, N'Juan', N'Perez', N'555-1234', N'juanperez@example.com', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbClientes] ([clie_Id], [clie_Nombre], [clie_Apellido], [clie_Telefono], [clie_CorreoElectronico], [clie_FechaCreacion], [clie_UsuarioCreacion], [clie_FechaModificacion], [clie_UsuarioModificacion], [clie_Estado]) VALUES (2, N'Maria', N'Garcia', N'555-5678', N'mariagarcia@example.com', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbClientes] ([clie_Id], [clie_Nombre], [clie_Apellido], [clie_Telefono], [clie_CorreoElectronico], [clie_FechaCreacion], [clie_UsuarioCreacion], [clie_FechaModificacion], [clie_UsuarioModificacion], [clie_Estado]) VALUES (3, N'Pedro', N'Lopez', N'555-9876', N'pedrolopez@example.com', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbClientes] ([clie_Id], [clie_Nombre], [clie_Apellido], [clie_Telefono], [clie_CorreoElectronico], [clie_FechaCreacion], [clie_UsuarioCreacion], [clie_FechaModificacion], [clie_UsuarioModificacion], [clie_Estado]) VALUES (4, N'Ana', N'Martinez', N'555-4321', N'anamartinez@example.com', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbClientes] ([clie_Id], [clie_Nombre], [clie_Apellido], [clie_Telefono], [clie_CorreoElectronico], [clie_FechaCreacion], [clie_UsuarioCreacion], [clie_FechaModificacion], [clie_UsuarioModificacion], [clie_Estado]) VALUES (5, N'Luis', N'Gonzalez', N'555-8765', N'luisgonzalez@example.com', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbClientes] ([clie_Id], [clie_Nombre], [clie_Apellido], [clie_Telefono], [clie_CorreoElectronico], [clie_FechaCreacion], [clie_UsuarioCreacion], [clie_FechaModificacion], [clie_UsuarioModificacion], [clie_Estado]) VALUES (6, N'Sofia', N'Rodriguez', N'555-2468', N'sofiarodriguez@example.com', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbClientes] ([clie_Id], [clie_Nombre], [clie_Apellido], [clie_Telefono], [clie_CorreoElectronico], [clie_FechaCreacion], [clie_UsuarioCreacion], [clie_FechaModificacion], [clie_UsuarioModificacion], [clie_Estado]) VALUES (7, N'Ramon', N'Hernandez', N'555-1357', N'ramonhernandez@example.com', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbClientes] ([clie_Id], [clie_Nombre], [clie_Apellido], [clie_Telefono], [clie_CorreoElectronico], [clie_FechaCreacion], [clie_UsuarioCreacion], [clie_FechaModificacion], [clie_UsuarioModificacion], [clie_Estado]) VALUES (8, N'Elena', N'Sanchez', N'555-5793', N'elenasanchez@example.com', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbClientes] ([clie_Id], [clie_Nombre], [clie_Apellido], [clie_Telefono], [clie_CorreoElectronico], [clie_FechaCreacion], [clie_UsuarioCreacion], [clie_FechaModificacion], [clie_UsuarioModificacion], [clie_Estado]) VALUES (9, N'Carlos', N'Gomez', N'555-3698', N'carlosgomez@example.com', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbClientes] ([clie_Id], [clie_Nombre], [clie_Apellido], [clie_Telefono], [clie_CorreoElectronico], [clie_FechaCreacion], [clie_UsuarioCreacion], [clie_FechaModificacion], [clie_UsuarioModificacion], [clie_Estado]) VALUES (10, N'Laura', N'Diaz', N'555-8246', N'lauradiaz@example.com', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [salo].[tbClientes] OFF
GO
SET IDENTITY_INSERT [salo].[tbEmpleados] ON 

INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (1, N'Daniel', N'Espinoza', N'M', 10, N'Col. Municipal', 1, N'87756952', N'daniele09099@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (2, N'Selvin', N'Medina', N'M', 10, N'Rivera', 2, N'98552231', N'selvinmedi@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (3, N'Christpher', N'Aguilar', N'M', 10, N'Col. Satelite', 3, N'77450210', N'agilarchris@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (4, N'Alessia', N'Medina', N'F', 10, N'Col. Miguel Angel Pavon', 1, N'99864520', N'aless65@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (5, N'Axel', N'Gomez', N'M', 10, N'Bosques de Jucutuma', 2, N'50220345', N'Gomez03@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (6, N'Angie', N'Rolitas', N'F', 10, N'Col. Felipe', 1, N'88541230', N'rolitaAngie@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 0)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (7, N'Dua', N'Lipa', N'F', 10, N'Rio de piedras', 1, N'00000000', N'lipa1995@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (8, N'Pitbull', N'Perez', N'M', 10, N'Rio de piedras', 1, N'00000000', N'pitbull@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (9, N'Michael', N'Jackson', N'M', 10, N'Rio de piedras', 1, N'00000000', N'Jackson@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (10, N'Lady', N'Gaga', N'F', 10, N'Rio de piedras', 1, N'00000000', N'gaga@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (11, N'Lionel', N'Messi', N'M', 10, N'Rio de piedras', 1, N'00000000', N'Messi@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (12, N'Cristiano', N'Ronaldo', N'M', 10, N'Rio de piedras', 1, N'00000000', N'ElBicho@gmail.com', CAST(N'2023-03-17' AS Date), CAST(N'2023-03-17' AS Date), 1, CAST(N'2023-03-17T08:44:02.220' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (13, N'Francis', N'Antunez', N'M', 1, N'Gainasd', 2, N'885996123', N'', CAST(N'2000-10-10' AS Date), CAST(N'2022-10-10' AS Date), 1, CAST(N'2023-03-17T08:44:02.253' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbEmpleados] ([empl_Id], [empl_Nombre], [empl_Apellido], [empl_Sexo], [muni_Id], [empl_DireccionExacta], [estc_Id], [empl_Telefono], [empl_CorreoElectronico], [empl_FechaNacimiento], [empl_FechaContratacion], [carg_Id], [empl_FechaCreacion], [empl_UsuarioCreacion], [empl_FechaModificacion], [empl_UsuarioModificacion], [empl_Estado]) VALUES (14, N'Francisco Joel', N'Antunez Montenegro', N'F', 91, N'EL CULO DEL DIABLO UNA CUADRA ANTES DEL INFIERNO', 3, N'8745456612', N'Fansida@gmail.com  ', CAST(N'2023-03-15' AS Date), CAST(N'2023-03-15' AS Date), 2, CAST(N'2023-03-17T08:52:35.030' AS DateTime), 1, CAST(N'2023-03-17T08:52:54.130' AS DateTime), 1, 1)
SET IDENTITY_INSERT [salo].[tbEmpleados] OFF
GO
SET IDENTITY_INSERT [salo].[tbFacturas] ON 

INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (1, 4, 14, 12, 2, CAST(N'2023-03-17T08:58:02.117' AS DateTime), CAST(N'2023-03-17T08:58:02.117' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (2, 2, 13, 13, 1, CAST(N'2023-03-17T09:37:49.877' AS DateTime), CAST(N'2023-03-17T09:37:49.877' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (3, 3, 12, 12, 2, CAST(N'2023-03-17T09:59:22.370' AS DateTime), CAST(N'2023-03-17T09:59:22.370' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (4, 2, 13, 13, 1, CAST(N'2023-03-17T10:11:42.497' AS DateTime), CAST(N'2023-03-17T10:11:42.497' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (5, 1, 12, 13, 3, CAST(N'2023-03-17T10:15:33.633' AS DateTime), CAST(N'2023-03-17T10:15:33.633' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (6, 4, 12, 14, 1, CAST(N'2023-03-17T10:18:13.250' AS DateTime), CAST(N'2023-03-17T10:18:13.250' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (7, 2, 11, 12, 2, CAST(N'2023-03-17T10:59:29.213' AS DateTime), CAST(N'2023-03-17T10:59:29.213' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (8, 2, 10, 12, 1, CAST(N'2023-03-17T13:01:55.080' AS DateTime), CAST(N'2023-03-17T13:01:55.080' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (9, 2, 10, 12, 2, CAST(N'2023-03-17T13:05:12.200' AS DateTime), CAST(N'2023-03-17T13:05:12.200' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (10, 3, 9, 12, 2, CAST(N'2023-03-17T13:06:37.933' AS DateTime), CAST(N'2023-03-17T13:06:37.933' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (11, 2, 10, 12, 1, CAST(N'2023-03-17T13:17:05.877' AS DateTime), CAST(N'2023-03-17T13:17:05.877' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturas] ([fact_Id], [clie_Id], [empl_Id_Atendido], [empl_Id_Caja], [metp_Id], [fact_Fecha], [fact_FechaCreacion], [fact_UsuarioCreacion], [fact_FechaModificacion], [fact_UsuarioModificacion], [fact_Estado]) VALUES (12, 3, 14, 4, 3, CAST(N'2023-03-17T15:01:05.653' AS DateTime), CAST(N'2023-03-17T15:01:05.653' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [salo].[tbFacturas] OFF
GO
SET IDENTITY_INSERT [salo].[tbFacturasDetalles] ON 

INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (1, 1, 2, NULL, 7, CAST(59.99 AS Decimal(18, 2)), CAST(N'2023-03-17T08:58:23.113' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (2, 1, NULL, 2, 4, CAST(20.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:58:35.760' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (3, 1, 3, NULL, 4, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T08:58:35.770' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (4, 1, 9, NULL, 4, CAST(149.99 AS Decimal(18, 2)), CAST(N'2023-03-17T08:58:35.770' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (5, 1, 2, NULL, 4, CAST(59.99 AS Decimal(18, 2)), CAST(N'2023-03-17T08:58:50.927' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (6, 1, 5, NULL, 3, CAST(19.99 AS Decimal(18, 2)), CAST(N'2023-03-17T08:58:56.700' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (7, 1, NULL, 1, 1, CAST(25.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:59:10.877' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (8, 1, 3, NULL, 1, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T08:59:10.887' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (9, 1, 1, NULL, 1, CAST(25.99 AS Decimal(18, 2)), CAST(N'2023-03-17T08:59:10.887' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (10, 2, NULL, 1, -1, CAST(25.00 AS Decimal(18, 2)), CAST(N'2023-03-17T09:38:06.377' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (11, 2, 3, NULL, -1, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T09:38:06.377' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (12, 2, 1, NULL, -1, CAST(25.99 AS Decimal(18, 2)), CAST(N'2023-03-17T09:38:06.377' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (13, 3, NULL, 3, 7, CAST(30.00 AS Decimal(18, 2)), CAST(N'2023-03-17T09:59:28.100' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (15, 4, NULL, 1, 1, CAST(25.00 AS Decimal(18, 2)), CAST(N'2023-03-17T10:12:04.457' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (16, 4, 3, NULL, 1, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:12:04.457' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (19, 5, 3, NULL, 1, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:15:38.907' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (20, 5, NULL, 1, 1, CAST(25.00 AS Decimal(18, 2)), CAST(N'2023-03-17T10:15:42.860' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (21, 5, 3, NULL, 1, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:15:42.870' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (26, 6, 9, NULL, 1, CAST(149.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:18:32.360' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (27, 6, NULL, 1, -100, CAST(25.00 AS Decimal(18, 2)), CAST(N'2023-03-17T10:20:19.413' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (28, 6, 3, NULL, -100, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:20:19.413' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (29, 6, 1, NULL, -100, CAST(25.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:20:19.413' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (30, 6, NULL, 1, -100, CAST(25.00 AS Decimal(18, 2)), CAST(N'2023-03-17T10:21:11.997' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (31, 6, 3, NULL, -100, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:21:11.997' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (32, 6, 1, NULL, -100, CAST(25.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:21:11.997' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (33, 6, NULL, 1, -100, CAST(25.00 AS Decimal(18, 2)), CAST(N'2023-03-17T10:21:44.897' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (34, 6, 3, NULL, -100, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:21:44.907' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (35, 6, 1, NULL, -100, CAST(25.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:21:44.907' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (36, 7, 4, NULL, 1, CAST(129.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:59:34.567' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (37, 7, NULL, 2, 4, CAST(20.00 AS Decimal(18, 2)), CAST(N'2023-03-17T10:59:40.507' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (38, 7, 3, NULL, 4, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:59:40.517' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (39, 7, 9, NULL, 4, CAST(149.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:59:40.517' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (40, 7, NULL, 1, 10, CAST(25.00 AS Decimal(18, 2)), CAST(N'2023-03-17T10:59:52.133' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (41, 7, 3, NULL, 10, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:59:52.143' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (42, 7, 1, NULL, 10, CAST(25.99 AS Decimal(18, 2)), CAST(N'2023-03-17T10:59:52.143' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (43, 8, 2, NULL, 2, CAST(59.99 AS Decimal(18, 2)), CAST(N'2023-03-17T13:02:02.053' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (44, 8, 2, NULL, 1, CAST(59.99 AS Decimal(18, 2)), CAST(N'2023-03-17T13:03:03.777' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (45, 8, NULL, 4, 1, CAST(50.00 AS Decimal(18, 2)), CAST(N'2023-03-17T13:03:10.450' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (46, 8, 7, NULL, 1, CAST(49.99 AS Decimal(18, 2)), CAST(N'2023-03-17T13:03:10.450' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (47, 8, 2, NULL, 1, CAST(59.99 AS Decimal(18, 2)), CAST(N'2023-03-17T13:03:10.450' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (49, 10, 4, NULL, 1, CAST(129.99 AS Decimal(18, 2)), CAST(N'2023-03-17T13:06:49.260' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (50, 10, NULL, 3, 1, CAST(30.00 AS Decimal(18, 2)), CAST(N'2023-03-17T13:06:56.040' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (51, 10, 8, NULL, 1, CAST(69.99 AS Decimal(18, 2)), CAST(N'2023-03-17T13:06:56.040' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (52, 11, 4, NULL, 1, CAST(129.99 AS Decimal(18, 2)), CAST(N'2023-03-17T13:17:11.130' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (53, 11, NULL, 1, 1, CAST(25.00 AS Decimal(18, 2)), CAST(N'2023-03-17T13:17:16.433' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (54, 11, 3, NULL, 1, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T13:17:16.443' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (55, 11, 1, NULL, 1, CAST(25.99 AS Decimal(18, 2)), CAST(N'2023-03-17T13:17:16.443' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (56, 4, NULL, 9, 1, CAST(100.00 AS Decimal(18, 2)), CAST(N'2023-03-17T14:46:48.470' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (57, 4, 2, NULL, 7, CAST(59.99 AS Decimal(18, 2)), CAST(N'2023-03-17T14:46:55.683' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (58, 4, NULL, 2, 1, CAST(20.00 AS Decimal(18, 2)), CAST(N'2023-03-17T14:47:00.467' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (59, 4, 3, NULL, 1, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T14:47:00.477' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (60, 4, 9, NULL, 1, CAST(149.99 AS Decimal(18, 2)), CAST(N'2023-03-17T14:47:00.477' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (61, 12, 2, NULL, 1, CAST(59.99 AS Decimal(18, 2)), CAST(N'2023-03-17T15:01:50.703' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (62, 12, NULL, 2, 2, CAST(20.00 AS Decimal(18, 2)), CAST(N'2023-03-17T15:02:13.633' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (63, 12, 3, NULL, 2, CAST(89.99 AS Decimal(18, 2)), CAST(N'2023-03-17T15:02:13.633' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbFacturasDetalles] ([fade_Id], [fact_Id], [prod_Id], [serv_Id], [fade_Cantidad], [fade_Precio], [fade_FechaCreacion], [fade_UsuarioCreacion], [fade_FechaModificacion], [fade_UsuarioModificacion], [fade_Estado]) VALUES (64, 12, 9, NULL, 2, CAST(149.99 AS Decimal(18, 2)), CAST(N'2023-03-17T15:02:13.633' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [salo].[tbFacturasDetalles] OFF
GO
SET IDENTITY_INSERT [salo].[tbProductos] ON 

INSERT [salo].[tbProductos] ([prod_Id], [prod_Nombre], [prod_Precio], [cate_Id], [prod_Stock], [prov_id], [prod_FechaCreacion], [prod_UsuarioCreacion], [prod_FechaModificacion], [prod_UsuarioModificacion], [prod_Estado]) VALUES (1, N'Polo de algodón', CAST(25.99 AS Decimal(18, 2)), 1, 50, 1, CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductos] ([prod_Id], [prod_Nombre], [prod_Precio], [cate_Id], [prod_Stock], [prov_id], [prod_FechaCreacion], [prod_UsuarioCreacion], [prod_FechaModificacion], [prod_UsuarioModificacion], [prod_Estado]) VALUES (2, N'Vaqueros desgastados', CAST(59.99 AS Decimal(18, 2)), 2, 30, 2, CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductos] ([prod_Id], [prod_Nombre], [prod_Precio], [cate_Id], [prod_Stock], [prov_id], [prod_FechaCreacion], [prod_UsuarioCreacion], [prod_FechaModificacion], [prod_UsuarioModificacion], [prod_Estado]) VALUES (3, N'Zapatillas deportivas', CAST(89.99 AS Decimal(18, 2)), 3, 20, 1, CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductos] ([prod_Id], [prod_Nombre], [prod_Precio], [cate_Id], [prod_Stock], [prov_id], [prod_FechaCreacion], [prod_UsuarioCreacion], [prod_FechaModificacion], [prod_UsuarioModificacion], [prod_Estado]) VALUES (4, N'Abrigo de lana', CAST(129.99 AS Decimal(18, 2)), 4, 10, 3, CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductos] ([prod_Id], [prod_Nombre], [prod_Precio], [cate_Id], [prod_Stock], [prov_id], [prod_FechaCreacion], [prod_UsuarioCreacion], [prod_FechaModificacion], [prod_UsuarioModificacion], [prod_Estado]) VALUES (5, N'Gorra de béisbol', CAST(19.99 AS Decimal(18, 2)), 5, 100, 1, CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductos] ([prod_Id], [prod_Nombre], [prod_Precio], [cate_Id], [prod_Stock], [prov_id], [prod_FechaCreacion], [prod_UsuarioCreacion], [prod_FechaModificacion], [prod_UsuarioModificacion], [prod_Estado]) VALUES (6, N'Camisa de cuadros', CAST(39.99 AS Decimal(18, 2)), 1, 15, 1, CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductos] ([prod_Id], [prod_Nombre], [prod_Precio], [cate_Id], [prod_Stock], [prov_id], [prod_FechaCreacion], [prod_UsuarioCreacion], [prod_FechaModificacion], [prod_UsuarioModificacion], [prod_Estado]) VALUES (7, N'Pantalón chino', CAST(49.99 AS Decimal(18, 2)), 2, 25, 1, CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductos] ([prod_Id], [prod_Nombre], [prod_Precio], [cate_Id], [prod_Stock], [prov_id], [prod_FechaCreacion], [prod_UsuarioCreacion], [prod_FechaModificacion], [prod_UsuarioModificacion], [prod_Estado]) VALUES (8, N'Sudadera con capucha', CAST(69.99 AS Decimal(18, 2)), 3, 12, 2, CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductos] ([prod_Id], [prod_Nombre], [prod_Precio], [cate_Id], [prod_Stock], [prov_id], [prod_FechaCreacion], [prod_UsuarioCreacion], [prod_FechaModificacion], [prod_UsuarioModificacion], [prod_Estado]) VALUES (9, N'Bolso de cuero', CAST(149.99 AS Decimal(18, 2)), 4, 8, 1, CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductos] ([prod_Id], [prod_Nombre], [prod_Precio], [cate_Id], [prod_Stock], [prov_id], [prod_FechaCreacion], [prod_UsuarioCreacion], [prod_FechaModificacion], [prod_UsuarioModificacion], [prod_Estado]) VALUES (10, N'Jersey de lana', CAST(79.99 AS Decimal(18, 2)), 3, 18, 3, CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [salo].[tbProductos] OFF
GO
SET IDENTITY_INSERT [salo].[tbProductosXServicio] ON 

INSERT [salo].[tbProductosXServicio] ([spro_Id], [serv_Id], [prod_Id], [spro_FechaCreacion], [spro_UsuarioCreacion], [spro_FechaModificacion], [spro_UsuarioModificacion], [spro_Estado]) VALUES (1, 1, 3, CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductosXServicio] ([spro_Id], [serv_Id], [prod_Id], [spro_FechaCreacion], [spro_UsuarioCreacion], [spro_FechaModificacion], [spro_UsuarioModificacion], [spro_Estado]) VALUES (2, 2, 3, CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductosXServicio] ([spro_Id], [serv_Id], [prod_Id], [spro_FechaCreacion], [spro_UsuarioCreacion], [spro_FechaModificacion], [spro_UsuarioModificacion], [spro_Estado]) VALUES (3, 4, 7, CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductosXServicio] ([spro_Id], [serv_Id], [prod_Id], [spro_FechaCreacion], [spro_UsuarioCreacion], [spro_FechaModificacion], [spro_UsuarioModificacion], [spro_Estado]) VALUES (4, 3, 8, CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductosXServicio] ([spro_Id], [serv_Id], [prod_Id], [spro_FechaCreacion], [spro_UsuarioCreacion], [spro_FechaModificacion], [spro_UsuarioModificacion], [spro_Estado]) VALUES (5, 1, 1, CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductosXServicio] ([spro_Id], [serv_Id], [prod_Id], [spro_FechaCreacion], [spro_UsuarioCreacion], [spro_FechaModificacion], [spro_UsuarioModificacion], [spro_Estado]) VALUES (6, 6, 7, CAST(N'2023-03-17T08:44:02.397' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductosXServicio] ([spro_Id], [serv_Id], [prod_Id], [spro_FechaCreacion], [spro_UsuarioCreacion], [spro_FechaModificacion], [spro_UsuarioModificacion], [spro_Estado]) VALUES (7, 7, 5, CAST(N'2023-03-17T08:44:02.397' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductosXServicio] ([spro_Id], [serv_Id], [prod_Id], [spro_FechaCreacion], [spro_UsuarioCreacion], [spro_FechaModificacion], [spro_UsuarioModificacion], [spro_Estado]) VALUES (8, 4, 2, CAST(N'2023-03-17T08:44:02.397' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductosXServicio] ([spro_Id], [serv_Id], [prod_Id], [spro_FechaCreacion], [spro_UsuarioCreacion], [spro_FechaModificacion], [spro_UsuarioModificacion], [spro_Estado]) VALUES (9, 2, 9, CAST(N'2023-03-17T08:44:02.397' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProductosXServicio] ([spro_Id], [serv_Id], [prod_Id], [spro_FechaCreacion], [spro_UsuarioCreacion], [spro_FechaModificacion], [spro_UsuarioModificacion], [spro_Estado]) VALUES (10, 8, 6, CAST(N'2023-03-17T08:44:02.397' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [salo].[tbProductosXServicio] OFF
GO
SET IDENTITY_INSERT [salo].[tbProveedores] ON 

INSERT [salo].[tbProveedores] ([prov_Id], [prov_NombreEmpresa], [prov_NombreContacto], [muni_Id], [prov_DireccionExacta], [prov_Telefono], [prov_FechaCreacion], [prov_UsuarioCreacion], [prov_FechaModificacion], [prov_UsuarioModificacion], [prov_Estado]) VALUES (1, N'Empresa1', N'Contacto1', 1, N'Dirección1', N'123456789', CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProveedores] ([prov_Id], [prov_NombreEmpresa], [prov_NombreContacto], [muni_Id], [prov_DireccionExacta], [prov_Telefono], [prov_FechaCreacion], [prov_UsuarioCreacion], [prov_FechaModificacion], [prov_UsuarioModificacion], [prov_Estado]) VALUES (2, N'Empresa2', N'Contacto2', 2, N'Dirección2', N'234567890', CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProveedores] ([prov_Id], [prov_NombreEmpresa], [prov_NombreContacto], [muni_Id], [prov_DireccionExacta], [prov_Telefono], [prov_FechaCreacion], [prov_UsuarioCreacion], [prov_FechaModificacion], [prov_UsuarioModificacion], [prov_Estado]) VALUES (3, N'Empresa3', N'Contacto3', 3, N'Dirección3', N'345678901', CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProveedores] ([prov_Id], [prov_NombreEmpresa], [prov_NombreContacto], [muni_Id], [prov_DireccionExacta], [prov_Telefono], [prov_FechaCreacion], [prov_UsuarioCreacion], [prov_FechaModificacion], [prov_UsuarioModificacion], [prov_Estado]) VALUES (4, N'Empresa4', N'Contacto4', 4, N'Dirección4', N'456789012', CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProveedores] ([prov_Id], [prov_NombreEmpresa], [prov_NombreContacto], [muni_Id], [prov_DireccionExacta], [prov_Telefono], [prov_FechaCreacion], [prov_UsuarioCreacion], [prov_FechaModificacion], [prov_UsuarioModificacion], [prov_Estado]) VALUES (5, N'Empresa5', N'Contacto5', 5, N'Dirección5', N'567890123', CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProveedores] ([prov_Id], [prov_NombreEmpresa], [prov_NombreContacto], [muni_Id], [prov_DireccionExacta], [prov_Telefono], [prov_FechaCreacion], [prov_UsuarioCreacion], [prov_FechaModificacion], [prov_UsuarioModificacion], [prov_Estado]) VALUES (6, N'Empresa6', N'Contacto6', 6, N'Dirección6', N'678901234', CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProveedores] ([prov_Id], [prov_NombreEmpresa], [prov_NombreContacto], [muni_Id], [prov_DireccionExacta], [prov_Telefono], [prov_FechaCreacion], [prov_UsuarioCreacion], [prov_FechaModificacion], [prov_UsuarioModificacion], [prov_Estado]) VALUES (7, N'Empresa7', N'Contacto7', 7, N'Dirección7', N'789012345', CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProveedores] ([prov_Id], [prov_NombreEmpresa], [prov_NombreContacto], [muni_Id], [prov_DireccionExacta], [prov_Telefono], [prov_FechaCreacion], [prov_UsuarioCreacion], [prov_FechaModificacion], [prov_UsuarioModificacion], [prov_Estado]) VALUES (8, N'Empresa8', N'Contacto8', 8, N'Dirección8', N'890123456', CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProveedores] ([prov_Id], [prov_NombreEmpresa], [prov_NombreContacto], [muni_Id], [prov_DireccionExacta], [prov_Telefono], [prov_FechaCreacion], [prov_UsuarioCreacion], [prov_FechaModificacion], [prov_UsuarioModificacion], [prov_Estado]) VALUES (9, N'Empresa9', N'Contacto9', 9, N'Dirección9', N'901234567', CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbProveedores] ([prov_Id], [prov_NombreEmpresa], [prov_NombreContacto], [muni_Id], [prov_DireccionExacta], [prov_Telefono], [prov_FechaCreacion], [prov_UsuarioCreacion], [prov_FechaModificacion], [prov_UsuarioModificacion], [prov_Estado]) VALUES (10, N'Empresa10', N'Contacto10', 10, N'Dirección10', N'012345678', CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [salo].[tbProveedores] OFF
GO
SET IDENTITY_INSERT [salo].[tbReservaciones] ON 

INSERT [salo].[tbReservaciones] ([rese_Id], [clie_Id], [sucu_Id], [rese_DiaReservado], [rese_HoraInicio], [rese_HoraFin], [rese_FechaCreacion], [rese_UsuarioCreacion], [rese_FechaModificacion], [rese_UsuarioModificacion], [rese_Estado]) VALUES (1, 1, 2, CAST(N'2023-03-15' AS Date), CAST(N'14:00:00' AS Time), CAST(N'16:00:00' AS Time), CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbReservaciones] ([rese_Id], [clie_Id], [sucu_Id], [rese_DiaReservado], [rese_HoraInicio], [rese_HoraFin], [rese_FechaCreacion], [rese_UsuarioCreacion], [rese_FechaModificacion], [rese_UsuarioModificacion], [rese_Estado]) VALUES (2, 2, 3, CAST(N'2023-03-20' AS Date), CAST(N'10:30:00' AS Time), CAST(N'12:30:00' AS Time), CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbReservaciones] ([rese_Id], [clie_Id], [sucu_Id], [rese_DiaReservado], [rese_HoraInicio], [rese_HoraFin], [rese_FechaCreacion], [rese_UsuarioCreacion], [rese_FechaModificacion], [rese_UsuarioModificacion], [rese_Estado]) VALUES (3, 5, 1, CAST(N'2023-03-25' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbReservaciones] ([rese_Id], [clie_Id], [sucu_Id], [rese_DiaReservado], [rese_HoraInicio], [rese_HoraFin], [rese_FechaCreacion], [rese_UsuarioCreacion], [rese_FechaModificacion], [rese_UsuarioModificacion], [rese_Estado]) VALUES (4, 3, 2, CAST(N'2023-03-16' AS Date), CAST(N'09:00:00' AS Time), CAST(N'11:00:00' AS Time), CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbReservaciones] ([rese_Id], [clie_Id], [sucu_Id], [rese_DiaReservado], [rese_HoraInicio], [rese_HoraFin], [rese_FechaCreacion], [rese_UsuarioCreacion], [rese_FechaModificacion], [rese_UsuarioModificacion], [rese_Estado]) VALUES (5, 4, 3, CAST(N'2023-03-18' AS Date), CAST(N'12:30:00' AS Time), CAST(N'14:30:00' AS Time), CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbReservaciones] ([rese_Id], [clie_Id], [sucu_Id], [rese_DiaReservado], [rese_HoraInicio], [rese_HoraFin], [rese_FechaCreacion], [rese_UsuarioCreacion], [rese_FechaModificacion], [rese_UsuarioModificacion], [rese_Estado]) VALUES (6, 2, 1, CAST(N'2023-03-20' AS Date), CAST(N'15:00:00' AS Time), CAST(N'17:00:00' AS Time), CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbReservaciones] ([rese_Id], [clie_Id], [sucu_Id], [rese_DiaReservado], [rese_HoraInicio], [rese_HoraFin], [rese_FechaCreacion], [rese_UsuarioCreacion], [rese_FechaModificacion], [rese_UsuarioModificacion], [rese_Estado]) VALUES (7, 5, 2, CAST(N'2023-03-26' AS Date), CAST(N'11:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbReservaciones] ([rese_Id], [clie_Id], [sucu_Id], [rese_DiaReservado], [rese_HoraInicio], [rese_HoraFin], [rese_FechaCreacion], [rese_UsuarioCreacion], [rese_FechaModificacion], [rese_UsuarioModificacion], [rese_Estado]) VALUES (8, 4, 1, CAST(N'2023-03-22' AS Date), CAST(N'14:30:00' AS Time), CAST(N'16:30:00' AS Time), CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbReservaciones] ([rese_Id], [clie_Id], [sucu_Id], [rese_DiaReservado], [rese_HoraInicio], [rese_HoraFin], [rese_FechaCreacion], [rese_UsuarioCreacion], [rese_FechaModificacion], [rese_UsuarioModificacion], [rese_Estado]) VALUES (9, 3, 3, CAST(N'2023-03-19' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbReservaciones] ([rese_Id], [clie_Id], [sucu_Id], [rese_DiaReservado], [rese_HoraInicio], [rese_HoraFin], [rese_FechaCreacion], [rese_UsuarioCreacion], [rese_FechaModificacion], [rese_UsuarioModificacion], [rese_Estado]) VALUES (10, 1, 2, CAST(N'2023-03-23' AS Date), CAST(N'09:30:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [salo].[tbReservaciones] OFF
GO
SET IDENTITY_INSERT [salo].[tbServicios] ON 

INSERT [salo].[tbServicios] ([serv_Id], [serv_Nombre], [serv_Descripcion], [serv_Precio], [serv_FechaCreacion], [serv_UsuarioCreacion], [serv_FechaModificacion], [serv_UsuarioModificacion], [serv_Estado]) VALUES (1, N'Corte de cabello', N'Servicio de corte de cabello para hombres y mujeres', CAST(25.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbServicios] ([serv_Id], [serv_Nombre], [serv_Descripcion], [serv_Precio], [serv_FechaCreacion], [serv_UsuarioCreacion], [serv_FechaModificacion], [serv_UsuarioModificacion], [serv_Estado]) VALUES (2, N'Manicure', N'Servicio de cuidado de uñas para mujeres', CAST(20.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbServicios] ([serv_Id], [serv_Nombre], [serv_Descripcion], [serv_Precio], [serv_FechaCreacion], [serv_UsuarioCreacion], [serv_FechaModificacion], [serv_UsuarioModificacion], [serv_Estado]) VALUES (3, N'Pedicure', N'Servicio de cuidado de pies y uñas para mujeres', CAST(30.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbServicios] ([serv_Id], [serv_Nombre], [serv_Descripcion], [serv_Precio], [serv_FechaCreacion], [serv_UsuarioCreacion], [serv_FechaModificacion], [serv_UsuarioModificacion], [serv_Estado]) VALUES (4, N'Maquillaje', N'Servicio de maquillaje para eventos especiales', CAST(50.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbServicios] ([serv_Id], [serv_Nombre], [serv_Descripcion], [serv_Precio], [serv_FechaCreacion], [serv_UsuarioCreacion], [serv_FechaModificacion], [serv_UsuarioModificacion], [serv_Estado]) VALUES (5, N'Depilación', N'Servicio de depilación para mujeres', CAST(40.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbServicios] ([serv_Id], [serv_Nombre], [serv_Descripcion], [serv_Precio], [serv_FechaCreacion], [serv_UsuarioCreacion], [serv_FechaModificacion], [serv_UsuarioModificacion], [serv_Estado]) VALUES (6, N'Masaje relajante', N'Servicio de masaje relajante para hombres y mujeres', CAST(60.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbServicios] ([serv_Id], [serv_Nombre], [serv_Descripcion], [serv_Precio], [serv_FechaCreacion], [serv_UsuarioCreacion], [serv_FechaModificacion], [serv_UsuarioModificacion], [serv_Estado]) VALUES (7, N'Limpieza facial', N'Servicio de limpieza facial para mujeres', CAST(35.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbServicios] ([serv_Id], [serv_Nombre], [serv_Descripcion], [serv_Precio], [serv_FechaCreacion], [serv_UsuarioCreacion], [serv_FechaModificacion], [serv_UsuarioModificacion], [serv_Estado]) VALUES (8, N'Tratamiento capilar', N'Servicio de tratamiento para el cabello', CAST(80.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbServicios] ([serv_Id], [serv_Nombre], [serv_Descripcion], [serv_Precio], [serv_FechaCreacion], [serv_UsuarioCreacion], [serv_FechaModificacion], [serv_UsuarioModificacion], [serv_Estado]) VALUES (9, N'Peinado para novias', N'Servicio de peinado para novias', CAST(100.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbServicios] ([serv_Id], [serv_Nombre], [serv_Descripcion], [serv_Precio], [serv_FechaCreacion], [serv_UsuarioCreacion], [serv_FechaModificacion], [serv_UsuarioModificacion], [serv_Estado]) VALUES (10, N'Coloración de cabellos', N'Servicio de coloración de cabello para hombres y mujeres', CAST(50000.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:44:02.387' AS DateTime), 1, CAST(N'2023-03-17T08:57:11.030' AS DateTime), 1, 1)
INSERT [salo].[tbServicios] ([serv_Id], [serv_Nombre], [serv_Descripcion], [serv_Precio], [serv_FechaCreacion], [serv_UsuarioCreacion], [serv_FechaModificacion], [serv_UsuarioModificacion], [serv_Estado]) VALUES (12, N'Masale GOLD PREMIUM', N'No se que hace pero algo te hace ', CAST(1100101.00 AS Decimal(18, 2)), CAST(N'2023-03-17T08:56:50.363' AS DateTime), 1, NULL, NULL, 0)
SET IDENTITY_INSERT [salo].[tbServicios] OFF
GO
SET IDENTITY_INSERT [salo].[tbSucursales] ON 

INSERT [salo].[tbSucursales] ([sucu_Id], [sucu_Descripcion], [muni_Id], [sucu_DireccionExacta], [sucu_FechaCreacion], [sucu_UsuarioCreacion], [sucu_FechaModificacion], [sucu_UsuarioModificacion], [sucu_Estado]) VALUES (1, N'Sucursal 1', 1, N'Calle 1 #123', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbSucursales] ([sucu_Id], [sucu_Descripcion], [muni_Id], [sucu_DireccionExacta], [sucu_FechaCreacion], [sucu_UsuarioCreacion], [sucu_FechaModificacion], [sucu_UsuarioModificacion], [sucu_Estado]) VALUES (2, N'Sucursal 2', 2, N'Avenida 2 #456', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbSucursales] ([sucu_Id], [sucu_Descripcion], [muni_Id], [sucu_DireccionExacta], [sucu_FechaCreacion], [sucu_UsuarioCreacion], [sucu_FechaModificacion], [sucu_UsuarioModificacion], [sucu_Estado]) VALUES (3, N'Sucursal 3', 3, N'Calle 3 #789', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbSucursales] ([sucu_Id], [sucu_Descripcion], [muni_Id], [sucu_DireccionExacta], [sucu_FechaCreacion], [sucu_UsuarioCreacion], [sucu_FechaModificacion], [sucu_UsuarioModificacion], [sucu_Estado]) VALUES (4, N'Sucursal 4', 4, N'Avenida 4 #012', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbSucursales] ([sucu_Id], [sucu_Descripcion], [muni_Id], [sucu_DireccionExacta], [sucu_FechaCreacion], [sucu_UsuarioCreacion], [sucu_FechaModificacion], [sucu_UsuarioModificacion], [sucu_Estado]) VALUES (5, N'Sucursal 5', 5, N'Calle 5 #345', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbSucursales] ([sucu_Id], [sucu_Descripcion], [muni_Id], [sucu_DireccionExacta], [sucu_FechaCreacion], [sucu_UsuarioCreacion], [sucu_FechaModificacion], [sucu_UsuarioModificacion], [sucu_Estado]) VALUES (6, N'Sucursal 6', 6, N'Avenida 6 #678', CAST(N'2023-03-17T08:44:02.390' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbSucursales] ([sucu_Id], [sucu_Descripcion], [muni_Id], [sucu_DireccionExacta], [sucu_FechaCreacion], [sucu_UsuarioCreacion], [sucu_FechaModificacion], [sucu_UsuarioModificacion], [sucu_Estado]) VALUES (7, N'Sucursal 7', 7, N'Calle 7 #901', CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbSucursales] ([sucu_Id], [sucu_Descripcion], [muni_Id], [sucu_DireccionExacta], [sucu_FechaCreacion], [sucu_UsuarioCreacion], [sucu_FechaModificacion], [sucu_UsuarioModificacion], [sucu_Estado]) VALUES (8, N'Sucursal 8', 8, N'Avenida 8 #234', CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbSucursales] ([sucu_Id], [sucu_Descripcion], [muni_Id], [sucu_DireccionExacta], [sucu_FechaCreacion], [sucu_UsuarioCreacion], [sucu_FechaModificacion], [sucu_UsuarioModificacion], [sucu_Estado]) VALUES (9, N'Sucursal 9', 9, N'Calle 9 #567', CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
INSERT [salo].[tbSucursales] ([sucu_Id], [sucu_Descripcion], [muni_Id], [sucu_DireccionExacta], [sucu_FechaCreacion], [sucu_UsuarioCreacion], [sucu_FechaModificacion], [sucu_UsuarioModificacion], [sucu_Estado]) VALUES (10, N'Sucursal 10', 10, N'Avenida 10 #890', CAST(N'2023-03-17T08:44:02.393' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [salo].[tbSucursales] OFF
GO
/****** Object:  Index [UQ__tbUsuari__4772AE30625D9416]    Script Date: 17/03/2023 15:48:32 ******/
ALTER TABLE [acce].[tbUsuarios] ADD UNIQUE NONCLUSTERED 
(
	[empl_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbUsuari__FD066E38D95EDA2D]    Script Date: 17/03/2023 15:48:32 ******/
ALTER TABLE [acce].[tbUsuarios] ADD UNIQUE NONCLUSTERED 
(
	[usur_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbDepart__CCD74A041C61F26A]    Script Date: 17/03/2023 15:48:32 ******/
ALTER TABLE [gnrl].[tbDepartamentos] ADD UNIQUE NONCLUSTERED 
(
	[depa_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbDepart__D4C398403347D287]    Script Date: 17/03/2023 15:48:32 ******/
ALTER TABLE [gnrl].[tbDepartamentos] ADD UNIQUE NONCLUSTERED 
(
	[depa_Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbEstado__01777E3B8D72435A]    Script Date: 17/03/2023 15:48:32 ******/
ALTER TABLE [gnrl].[tbEstadosCiviles] ADD UNIQUE NONCLUSTERED 
(
	[estc_Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbMunici__3C7692E1FE759011]    Script Date: 17/03/2023 15:48:32 ******/
ALTER TABLE [gnrl].[tbMunicipios] ADD UNIQUE NONCLUSTERED 
(
	[muni_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbCargos__F3099AE0E911F3AA]    Script Date: 17/03/2023 15:48:32 ******/
ALTER TABLE [salo].[tbCargos] ADD UNIQUE NONCLUSTERED 
(
	[carg_Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbCatego__55D9A7796AED81DB]    Script Date: 17/03/2023 15:48:32 ******/
ALTER TABLE [salo].[tbCategorias] ADD UNIQUE NONCLUSTERED 
(
	[cate_Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbProvee__9302DE55012A3431]    Script Date: 17/03/2023 15:48:32 ******/
ALTER TABLE [salo].[tbProveedores] ADD UNIQUE NONCLUSTERED 
(
	[prov_NombreEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [acce].[tbUsuarios] ADD  DEFAULT (getdate()) FOR [usur_FechaCreacion]
GO
ALTER TABLE [acce].[tbUsuarios] ADD  DEFAULT ((1)) FOR [usur_Estado]
GO
ALTER TABLE [gnrl].[tbDepartamentos] ADD  DEFAULT (getdate()) FOR [depa_FechaCreacion]
GO
ALTER TABLE [gnrl].[tbDepartamentos] ADD  DEFAULT ((1)) FOR [depa_Estado]
GO
ALTER TABLE [gnrl].[tbEstadosCiviles] ADD  DEFAULT (getdate()) FOR [estc_FechaCreacion]
GO
ALTER TABLE [gnrl].[tbEstadosCiviles] ADD  DEFAULT ((1)) FOR [estc_Estado]
GO
ALTER TABLE [gnrl].[tbMetodoPago] ADD  DEFAULT (getdate()) FOR [metp_FechaCreacion]
GO
ALTER TABLE [gnrl].[tbMetodoPago] ADD  DEFAULT ((1)) FOR [metp_Estado]
GO
ALTER TABLE [gnrl].[tbMunicipios] ADD  DEFAULT (getdate()) FOR [muni_FechaCreacion]
GO
ALTER TABLE [gnrl].[tbMunicipios] ADD  DEFAULT ((1)) FOR [muni_Estado]
GO
ALTER TABLE [salo].[tbCargos] ADD  DEFAULT (getdate()) FOR [carg_FechaCreacion]
GO
ALTER TABLE [salo].[tbCargos] ADD  DEFAULT ((1)) FOR [carg_Estado]
GO
ALTER TABLE [salo].[tbCategorias] ADD  DEFAULT (getdate()) FOR [cate_FechaCreacion]
GO
ALTER TABLE [salo].[tbCategorias] ADD  DEFAULT ((1)) FOR [cate_Estado]
GO
ALTER TABLE [salo].[tbClientes] ADD  DEFAULT (getdate()) FOR [clie_FechaCreacion]
GO
ALTER TABLE [salo].[tbClientes] ADD  DEFAULT ((1)) FOR [clie_Estado]
GO
ALTER TABLE [salo].[tbEmpleados] ADD  DEFAULT (getdate()) FOR [empl_FechaCreacion]
GO
ALTER TABLE [salo].[tbEmpleados] ADD  DEFAULT ((1)) FOR [empl_Estado]
GO
ALTER TABLE [salo].[tbFacturas] ADD  DEFAULT (getdate()) FOR [fact_Fecha]
GO
ALTER TABLE [salo].[tbFacturas] ADD  DEFAULT (getdate()) FOR [fact_FechaCreacion]
GO
ALTER TABLE [salo].[tbFacturas] ADD  DEFAULT ((1)) FOR [fact_Estado]
GO
ALTER TABLE [salo].[tbFacturasDetalles] ADD  DEFAULT (getdate()) FOR [fade_FechaCreacion]
GO
ALTER TABLE [salo].[tbFacturasDetalles] ADD  DEFAULT ((1)) FOR [fade_Estado]
GO
ALTER TABLE [salo].[tbProductos] ADD  DEFAULT (getdate()) FOR [prod_FechaCreacion]
GO
ALTER TABLE [salo].[tbProductos] ADD  DEFAULT ((1)) FOR [prod_Estado]
GO
ALTER TABLE [salo].[tbProductosXServicio] ADD  DEFAULT (getdate()) FOR [spro_FechaCreacion]
GO
ALTER TABLE [salo].[tbProductosXServicio] ADD  DEFAULT ((1)) FOR [spro_Estado]
GO
ALTER TABLE [salo].[tbProveedores] ADD  DEFAULT (getdate()) FOR [prov_FechaCreacion]
GO
ALTER TABLE [salo].[tbProveedores] ADD  DEFAULT ((1)) FOR [prov_Estado]
GO
ALTER TABLE [salo].[tbReservaciones] ADD  DEFAULT (getdate()) FOR [rese_FechaCreacion]
GO
ALTER TABLE [salo].[tbReservaciones] ADD  DEFAULT ((1)) FOR [rese_Estado]
GO
ALTER TABLE [salo].[tbServicios] ADD  DEFAULT (getdate()) FOR [serv_FechaCreacion]
GO
ALTER TABLE [salo].[tbServicios] ADD  DEFAULT ((1)) FOR [serv_Estado]
GO
ALTER TABLE [salo].[tbSucursales] ADD  DEFAULT (getdate()) FOR [sucu_FechaCreacion]
GO
ALTER TABLE [salo].[tbSucursales] ADD  DEFAULT ((1)) FOR [sucu_Estado]
GO
ALTER TABLE [acce].[tbUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_acce_tbUsuarios_acce_tbUsuarios_usur_UsuarioCreacion_usur_Id] FOREIGN KEY([usur_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [acce].[tbUsuarios] CHECK CONSTRAINT [FK_acce_tbUsuarios_acce_tbUsuarios_usur_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [acce].[tbUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_acce_tbUsuarios_acce_tbUsuarios_usur_UsuarioModificacion_usur_Id] FOREIGN KEY([usur_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [acce].[tbUsuarios] CHECK CONSTRAINT [FK_acce_tbUsuarios_acce_tbUsuarios_usur_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [acce].[tbUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_acce_tbUsuarios_salo_tbEmpleados_empl_Id] FOREIGN KEY([empl_Id])
REFERENCES [salo].[tbEmpleados] ([empl_Id])
GO
ALTER TABLE [acce].[tbUsuarios] CHECK CONSTRAINT [FK_acce_tbUsuarios_salo_tbEmpleados_empl_Id]
GO
ALTER TABLE [gnrl].[tbDepartamentos]  WITH CHECK ADD  CONSTRAINT [FK_gnrl_tbDepartamentos_acce_tbUsuarios_depa_UsuarioCreacion_usur_Id] FOREIGN KEY([depa_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [gnrl].[tbDepartamentos] CHECK CONSTRAINT [FK_gnrl_tbDepartamentos_acce_tbUsuarios_depa_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [gnrl].[tbDepartamentos]  WITH CHECK ADD  CONSTRAINT [FK_gnrl_tbDepartamentos_acce_tbUsuarios_depa_UsuarioModificacion_usur_Id] FOREIGN KEY([depa_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [gnrl].[tbDepartamentos] CHECK CONSTRAINT [FK_gnrl_tbDepartamentos_acce_tbUsuarios_depa_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [gnrl].[tbEstadosCiviles]  WITH CHECK ADD  CONSTRAINT [FK_gnrl_tbEstadosCiviles_acce_tbUsuarios_estc_UsuarioCreacion_usur_Id] FOREIGN KEY([estc_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [gnrl].[tbEstadosCiviles] CHECK CONSTRAINT [FK_gnrl_tbEstadosCiviles_acce_tbUsuarios_estc_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [gnrl].[tbEstadosCiviles]  WITH CHECK ADD  CONSTRAINT [FK_gnrl_tbEstadosCiviles_acce_tbUsuarios_estc_UsuarioModificacion_usur_Id] FOREIGN KEY([estc_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [gnrl].[tbEstadosCiviles] CHECK CONSTRAINT [FK_gnrl_tbEstadosCiviles_acce_tbUsuarios_estc_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [gnrl].[tbMetodoPago]  WITH CHECK ADD  CONSTRAINT [FK_gnrl_tbMetodoPagos_acce_tbUsuarios_metp_UsuarioCreacion_usur_Id] FOREIGN KEY([metp_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [gnrl].[tbMetodoPago] CHECK CONSTRAINT [FK_gnrl_tbMetodoPagos_acce_tbUsuarios_metp_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [gnrl].[tbMetodoPago]  WITH CHECK ADD  CONSTRAINT [FK_gnrl_tbMetodoPagos_acce_tbUsuarios_metp_UsuarioModificacion_usur_Id] FOREIGN KEY([metp_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [gnrl].[tbMetodoPago] CHECK CONSTRAINT [FK_gnrl_tbMetodoPagos_acce_tbUsuarios_metp_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [gnrl].[tbMunicipios]  WITH CHECK ADD  CONSTRAINT [FK_gnrl_tbMunicipios_acce_tbUsuarios_muni_UsuarioCreacion_usur_Id] FOREIGN KEY([muni_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [gnrl].[tbMunicipios] CHECK CONSTRAINT [FK_gnrl_tbMunicipios_acce_tbUsuarios_muni_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [gnrl].[tbMunicipios]  WITH CHECK ADD  CONSTRAINT [FK_gnrl_tbMunicipios_acce_tbUsuarios_muni_UsuarioModificacion_usur_Id] FOREIGN KEY([muni_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [gnrl].[tbMunicipios] CHECK CONSTRAINT [FK_gnrl_tbMunicipios_acce_tbUsuarios_muni_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [gnrl].[tbMunicipios]  WITH CHECK ADD  CONSTRAINT [FK_tbMunicipios_tbDepartamentos_depa_Id] FOREIGN KEY([depa_Id])
REFERENCES [gnrl].[tbDepartamentos] ([depa_Id])
GO
ALTER TABLE [gnrl].[tbMunicipios] CHECK CONSTRAINT [FK_tbMunicipios_tbDepartamentos_depa_Id]
GO
ALTER TABLE [salo].[tbCargos]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbCargos_acce_tbUsuarios_carg_UsuarioCreacion_usur_Id] FOREIGN KEY([carg_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbCargos] CHECK CONSTRAINT [FK_salo_tbCargos_acce_tbUsuarios_carg_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [salo].[tbCargos]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbCargos_acce_tbUsuarios_carg_UsuarioModificacion_usur_Id] FOREIGN KEY([carg_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbCargos] CHECK CONSTRAINT [FK_salo_tbCargos_acce_tbUsuarios_carg_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [salo].[tbCategorias]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbCategoria_acce_tbUsuarios_cate_UsuarioCreacion_usur_Id] FOREIGN KEY([cate_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbCategorias] CHECK CONSTRAINT [FK_salo_tbCategoria_acce_tbUsuarios_cate_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [salo].[tbCategorias]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbCategoria_acce_tbUsuarios_cate_UsuarioModificacion_usur_Id] FOREIGN KEY([cate_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbCategorias] CHECK CONSTRAINT [FK_salo_tbCategoria_acce_tbUsuarios_cate_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [salo].[tbClientes]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbClientes_acce_tbUsuarios_clie_UsuarioCreacion_usur_Id] FOREIGN KEY([clie_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbClientes] CHECK CONSTRAINT [FK_salo_tbClientes_acce_tbUsuarios_clie_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [salo].[tbClientes]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbClientes_acce_tbUsuarios_clie_UsuarioModificacion_usur_Id] FOREIGN KEY([clie_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbClientes] CHECK CONSTRAINT [FK_salo_tbClientes_acce_tbUsuarios_clie_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [salo].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbEmpleados_acce_tbUsuarios_empl_UsuarioCreacion_usur_Id] FOREIGN KEY([empl_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbEmpleados] CHECK CONSTRAINT [FK_salo_tbEmpleados_acce_tbUsuarios_empl_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [salo].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbEmpleados_acce_tbUsuarios_empl_UsuarioModificacion_usur_Id] FOREIGN KEY([empl_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbEmpleados] CHECK CONSTRAINT [FK_salo_tbEmpleados_acce_tbUsuarios_empl_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [salo].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbEmpleados_gnrl_tbEstadosCiviles_estc_Id] FOREIGN KEY([estc_Id])
REFERENCES [gnrl].[tbEstadosCiviles] ([estc_Id])
GO
ALTER TABLE [salo].[tbEmpleados] CHECK CONSTRAINT [FK_salo_tbEmpleados_gnrl_tbEstadosCiviles_estc_Id]
GO
ALTER TABLE [salo].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbEmpleados_gnrl_tbMunicipios_muni_Id] FOREIGN KEY([muni_Id])
REFERENCES [gnrl].[tbMunicipios] ([muni_Id])
GO
ALTER TABLE [salo].[tbEmpleados] CHECK CONSTRAINT [FK_salo_tbEmpleados_gnrl_tbMunicipios_muni_Id]
GO
ALTER TABLE [salo].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbEmpleados_salo_tbCargos_carg_Id] FOREIGN KEY([carg_Id])
REFERENCES [salo].[tbCargos] ([carg_Id])
GO
ALTER TABLE [salo].[tbEmpleados] CHECK CONSTRAINT [FK_salo_tbEmpleados_salo_tbCargos_carg_Id]
GO
ALTER TABLE [salo].[tbFacturas]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbFacturas_acce_tbUsuarios_ped_UsuarioCreacion_usur_Id] FOREIGN KEY([fact_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbFacturas] CHECK CONSTRAINT [FK_salo_tbFacturas_acce_tbUsuarios_ped_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [salo].[tbFacturas]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbFacturas_acce_tbUsuarios_ped_UsuarioModificacion_usur_Id] FOREIGN KEY([fact_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbFacturas] CHECK CONSTRAINT [FK_salo_tbFacturas_acce_tbUsuarios_ped_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [salo].[tbFacturas]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbFacturas_salo_tbEmpleados_empl_Id_Atendido] FOREIGN KEY([empl_Id_Atendido])
REFERENCES [salo].[tbEmpleados] ([empl_Id])
GO
ALTER TABLE [salo].[tbFacturas] CHECK CONSTRAINT [FK_salo_tbFacturas_salo_tbEmpleados_empl_Id_Atendido]
GO
ALTER TABLE [salo].[tbFacturas]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbFacturas_salo_tbEmpleados_empl_Id_Caja] FOREIGN KEY([empl_Id_Caja])
REFERENCES [salo].[tbEmpleados] ([empl_Id])
GO
ALTER TABLE [salo].[tbFacturas] CHECK CONSTRAINT [FK_salo_tbFacturas_salo_tbEmpleados_empl_Id_Caja]
GO
ALTER TABLE [salo].[tbFacturas]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbFacturas_tbClientes_clie_id] FOREIGN KEY([clie_Id])
REFERENCES [salo].[tbClientes] ([clie_Id])
GO
ALTER TABLE [salo].[tbFacturas] CHECK CONSTRAINT [FK_salo_tbFacturas_tbClientes_clie_id]
GO
ALTER TABLE [salo].[tbFacturas]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbFacturas_tbMetodoPago_metp_id] FOREIGN KEY([metp_Id])
REFERENCES [gnrl].[tbMetodoPago] ([metp_Id])
GO
ALTER TABLE [salo].[tbFacturas] CHECK CONSTRAINT [FK_salo_tbFacturas_tbMetodoPago_metp_id]
GO
ALTER TABLE [salo].[tbFacturasDetalles]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbFacturasDetalles_acce_tbUsuarios_fade_UsuarioCreacion_usur_Id] FOREIGN KEY([fade_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbFacturasDetalles] CHECK CONSTRAINT [FK_salo_tbFacturasDetalles_acce_tbUsuarios_fade_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [salo].[tbFacturasDetalles]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbFacturasDetalles_acce_tbUsuarios_fade_UsuarioModificacion_usur_Id] FOREIGN KEY([fade_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbFacturasDetalles] CHECK CONSTRAINT [FK_salo_tbFacturasDetalles_acce_tbUsuarios_fade_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [salo].[tbFacturasDetalles]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbFacturasDetalles_tbFacturas_fact_id] FOREIGN KEY([fact_Id])
REFERENCES [salo].[tbFacturas] ([fact_Id])
GO
ALTER TABLE [salo].[tbFacturasDetalles] CHECK CONSTRAINT [FK_salo_tbFacturasDetalles_tbFacturas_fact_id]
GO
ALTER TABLE [salo].[tbFacturasDetalles]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbFacturasDetalles_tbProductos_prod_id] FOREIGN KEY([prod_Id])
REFERENCES [salo].[tbProductos] ([prod_Id])
GO
ALTER TABLE [salo].[tbFacturasDetalles] CHECK CONSTRAINT [FK_salo_tbFacturasDetalles_tbProductos_prod_id]
GO
ALTER TABLE [salo].[tbFacturasDetalles]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbFacturasDetalles_tbServicios_serv_id] FOREIGN KEY([serv_Id])
REFERENCES [salo].[tbServicios] ([serv_Id])
GO
ALTER TABLE [salo].[tbFacturasDetalles] CHECK CONSTRAINT [FK_salo_tbFacturasDetalles_tbServicios_serv_id]
GO
ALTER TABLE [salo].[tbProductos]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbProductos_acce_tbUsuarios_prod_UsuarioCreacion_usur_Id] FOREIGN KEY([prod_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbProductos] CHECK CONSTRAINT [FK_salo_tbProductos_acce_tbUsuarios_prod_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [salo].[tbProductos]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbProductos_acce_tbUsuarios_prod_UsuarioModificacion_usur_Id] FOREIGN KEY([prod_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbProductos] CHECK CONSTRAINT [FK_salo_tbProductos_acce_tbUsuarios_prod_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [salo].[tbProductos]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbProductos_tbCategoria_cate_Id] FOREIGN KEY([cate_Id])
REFERENCES [salo].[tbCategorias] ([cate_Id])
GO
ALTER TABLE [salo].[tbProductos] CHECK CONSTRAINT [FK_salo_tbProductos_tbCategoria_cate_Id]
GO
ALTER TABLE [salo].[tbProductos]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbProductos_tbProveedores_prov_Id] FOREIGN KEY([prov_id])
REFERENCES [salo].[tbProveedores] ([prov_Id])
GO
ALTER TABLE [salo].[tbProductos] CHECK CONSTRAINT [FK_salo_tbProductos_tbProveedores_prov_Id]
GO
ALTER TABLE [salo].[tbProductosXServicio]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbProductosXServicio_acce_tbUsuarios_serprod_UsuarioCreacion_usur_Id] FOREIGN KEY([spro_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbProductosXServicio] CHECK CONSTRAINT [FK_salo_tbProductosXServicio_acce_tbUsuarios_serprod_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [salo].[tbProductosXServicio]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbProductosXServicio_acce_tbUsuarios_serprod_UsuarioModificacion_usur_Id] FOREIGN KEY([spro_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbProductosXServicio] CHECK CONSTRAINT [FK_salo_tbProductosXServicio_acce_tbUsuarios_serprod_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [salo].[tbProductosXServicio]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbProductosXServicio_salo_tbProductos_prod_Id] FOREIGN KEY([prod_Id])
REFERENCES [salo].[tbProductos] ([prod_Id])
GO
ALTER TABLE [salo].[tbProductosXServicio] CHECK CONSTRAINT [FK_salo_tbProductosXServicio_salo_tbProductos_prod_Id]
GO
ALTER TABLE [salo].[tbProductosXServicio]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbProductosXServicio_salo_tbServicios_serv_Id] FOREIGN KEY([serv_Id])
REFERENCES [salo].[tbServicios] ([serv_Id])
GO
ALTER TABLE [salo].[tbProductosXServicio] CHECK CONSTRAINT [FK_salo_tbProductosXServicio_salo_tbServicios_serv_Id]
GO
ALTER TABLE [salo].[tbProveedores]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbProveedores_tbMunicipio_muni_id] FOREIGN KEY([muni_Id])
REFERENCES [gnrl].[tbMunicipios] ([muni_Id])
GO
ALTER TABLE [salo].[tbProveedores] CHECK CONSTRAINT [FK_salo_tbProveedores_tbMunicipio_muni_id]
GO
ALTER TABLE [salo].[tbReservaciones]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbReservaciones_acce_tbUsuarios_rese_UsuarioCreacion_usur_Id] FOREIGN KEY([rese_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbReservaciones] CHECK CONSTRAINT [FK_salo_tbReservaciones_acce_tbUsuarios_rese_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [salo].[tbReservaciones]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbReservaciones_acce_tbUsuarios_rese_UsuarioModificacion_usur_Id] FOREIGN KEY([rese_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbReservaciones] CHECK CONSTRAINT [FK_salo_tbReservaciones_acce_tbUsuarios_rese_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [salo].[tbReservaciones]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbReservaciones_tbClientes_clie_id] FOREIGN KEY([clie_Id])
REFERENCES [salo].[tbClientes] ([clie_Id])
GO
ALTER TABLE [salo].[tbReservaciones] CHECK CONSTRAINT [FK_salo_tbReservaciones_tbClientes_clie_id]
GO
ALTER TABLE [salo].[tbReservaciones]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbReservaciones_tbSucursales_sucu_id] FOREIGN KEY([sucu_Id])
REFERENCES [salo].[tbSucursales] ([sucu_Id])
GO
ALTER TABLE [salo].[tbReservaciones] CHECK CONSTRAINT [FK_salo_tbReservaciones_tbSucursales_sucu_id]
GO
ALTER TABLE [salo].[tbServicios]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbServicios_acce_tbUsuarios_serv_UsuarioCreacion_usur_Id] FOREIGN KEY([serv_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbServicios] CHECK CONSTRAINT [FK_salo_tbServicios_acce_tbUsuarios_serv_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [salo].[tbServicios]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbServicios_acce_tbUsuarios_serv_UsuarioModificacion_usur_Id] FOREIGN KEY([serv_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbServicios] CHECK CONSTRAINT [FK_salo_tbServicios_acce_tbUsuarios_serv_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [salo].[tbSucursales]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbSucursales_acce_tbUsuarios_sucu_UsuarioCreacion_usur_Id] FOREIGN KEY([sucu_UsuarioCreacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbSucursales] CHECK CONSTRAINT [FK_salo_tbSucursales_acce_tbUsuarios_sucu_UsuarioCreacion_usur_Id]
GO
ALTER TABLE [salo].[tbSucursales]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbSucursales_acce_tbUsuarios_sucu_UsuarioModificacion_usur_Id] FOREIGN KEY([sucu_UsuarioModificacion])
REFERENCES [acce].[tbUsuarios] ([usur_Id])
GO
ALTER TABLE [salo].[tbSucursales] CHECK CONSTRAINT [FK_salo_tbSucursales_acce_tbUsuarios_sucu_UsuarioModificacion_usur_Id]
GO
ALTER TABLE [salo].[tbSucursales]  WITH CHECK ADD  CONSTRAINT [FK_salo_tbSucursales_gnrl_tbMunicipios_muni_Id] FOREIGN KEY([muni_Id])
REFERENCES [gnrl].[tbMunicipios] ([muni_Id])
GO
ALTER TABLE [salo].[tbSucursales] CHECK CONSTRAINT [FK_salo_tbSucursales_gnrl_tbMunicipios_muni_Id]
GO
/****** Object:  StoredProcedure [acce].[_RecuperarContrasenia]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE      PROCEDURE [acce].[_RecuperarContrasenia]
@usur_Usuario VARCHAR(100),
@usur_Contrasenia NVARCHAR(MAX)

as
BEGIN

BEGIN TRY

Declare @Password Nvarchar(max) = (HASHBYTES('SHA2_512',@usur_Contrasenia))

UPDATE [acce].[tbUsuarios]
   SET [usur_Contrasenia] = @Password
 WHERE usur_Usuario = @usur_Usuario

SELECT 1 as Proceso

END TRY
BEGIN CATCH

SELECT 0 as Proceso
END CATCH

END
GO
/****** Object:  StoredProcedure [acce].[UDP_Login]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [acce].[UDP_Login]
	@usur_Usuario Nvarchar(100),
	@usur_Contrasenia Nvarchar(Max)
AS
BEGIN

        BEGIN TRY
        Declare @Password Nvarchar(max) = (HASHBYTES('SHA2_512',@usur_Contrasenia))
        SELECT	 [usur_Id]
                ,[usur_Usuario]
                ,[usur_Contrasenia]
                ,T1.[empl_Id]
                ,t2.empl_Nombre + ' ' + t2.empl_Apellido as empl_Nombre 
                ,[usur_UsuarioCreacion]
                ,[usur_FechaCreacion]
                ,[usur_UsuarioModificacion]
                ,[usur_FechaModificacion]
                ,[usur_Estado]
        FROM    acce.[tbUsuarios] T1 INNER JOIN [salo].[tbEmpleados] T2
        ON      T1.empl_Id = T2.empl_Id
        WHERE   t1.usur_Contrasenia = @Password 
        AND     t1.usur_Usuario = @usur_Usuario

        --SELECT 1 as Proceso
        END TRY
        BEGIN CATCH

        SELECT 0 as Proceso
        END CATCH

END
GO
/****** Object:  StoredProcedure [acce].[UDP_tbUsuario_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--borrar Usuario
CREATE   PROCEDURE [acce].[UDP_tbUsuario_Delete]
	@usur_Id INT
AS
BEGIN

BEGIN TRY

UPDATE [acce].[tbUsuarios]
   SET [usur_Estado] = 0
 WHERE usur_Id = @usur_Id


SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [acce].[UDP_tbUsuarios_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [acce].[UDP_tbUsuarios_Insert]
	@usur_Usuario Nvarchar(100),
	@usur_Contrasenia Nvarchar(max),
	@empl_Id int,
	@usur_UsuarioCreacion int

AS
BEGIN

BEGIN TRY
Declare @Password Nvarchar(max) = (HASHBYTES('SHA2_512',@usur_Contrasenia))

INSERT INTO [acce].[tbUsuarios]
           ([usur_Usuario]
           ,[usur_Contrasenia]
           ,[empl_Id]
           ,[usur_UsuarioCreacion]
           ,[usur_FechaCreacion]
           ,[usur_UsuarioModificacion]
           ,[usur_FechaModificacion]
           ,[usur_Estado])
     VALUES
           (@usur_Usuario
           ,@Password
           ,@empl_Id
           ,@usur_UsuarioCreacion
           ,GetDate()
           ,null
           ,null
           ,1)

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [acce].[UDP_tbUsuarios_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [acce].[UDP_tbUsuarios_Listado]
AS
BEGIN

        SELECT	 [usur_Id]
                ,[usur_Usuario]
                ,[usur_Contrasenia]
                ,T1.[empl_Id]
                ,t2.empl_Nombre + ' ' + t2.empl_Apellido as empl_NombreCompleto 
				,t2.empl_Nombre
				,t2.empl_Apellido
                ,[usur_UsuarioCreacion]
                ,[usur_FechaCreacion]
                ,[usur_UsuarioModificacion]
                ,[usur_FechaModificacion]
                ,[usur_Estado]
        FROM    acce.[tbUsuarios] T1 INNER JOIN [salo].[tbEmpleados] T2
        ON      T1.empl_Id = T2.empl_Id


END

GO
/****** Object:  StoredProcedure [acce].[UDP_tbUsuarios_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [acce].[UDP_tbUsuarios_Update]
	@usur_Id INT,
	@empl_Id int,
	@usuarioModificacion int
AS
BEGIN

BEGIN TRY

UPDATE [acce].[tbUsuarios]
   SET [empl_Id] = @empl_Id
      ,[usur_UsuarioModificacion] = @usuarioModificacion
      ,[usur_FechaModificacion] = GetDate()
      ,[usur_Estado] = 1
 WHERE usur_Id = @usur_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbDepartamentos_Buscar]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [gnrl].[UDP_tbDepartamentos_Buscar]
	@depa_Id	INT
AS
BEGIN


SELECT [depa_Id]
      ,[depa_Descripcion]
      ,[depa_Codigo]
      ,[depa_FechaCreacion]
      ,[depa_UsuarioCreacion]
      ,[depa_FechaModificacion]
      ,[depa_UsuarioModificacion]
      ,[depa_Estado]
  FROM [gnrl].[tbDepartamentos]
  WHERE depa_Estado = 1
  And [depa_Id] = @depa_Id


END

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbDepartamentos_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------Procedimiento Delete Departamentos

CREATE   PROCEDURE [gnrl].[UDP_tbDepartamentos_Delete]
	@depa_Id INT
AS
BEGIN
BEGIN TRY

UPDATE [gnrl].[tbDepartamentos]
   SET [depa_Estado] = 0
 WHERE [depa_Id] = @depa_Id


SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END
GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbDepartamentos_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [gnrl].[UDP_tbDepartamentos_Insert]
    @depa_Descripcion NVARCHAR(150),
	@depa_Codigo		CHAR(2),
	@depa_UsuarioCreacion INT

AS
BEGIN
BEGIN TRY


    INSERT INTO gnrl.tbDepartamentos(   [depa_Descripcion], 
                                        depa_Codigo, 
                                        [depa_FechaCreacion], 
                                        [depa_UsuarioCreacion], 
                                        [depa_FechaModificacion], 
                                        [depa_UsuarioModificacion], 
                                        [depa_Estado]) 
    VALUES (@depa_Descripcion,
            @depa_Codigo, 
            GETDATE(), 
            @depa_UsuarioCreacion, 
            NULL, 
            NULL, 
            1);

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbDepartamentos_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [gnrl].[UDP_tbDepartamentos_Listado]
AS
BEGIN


SELECT [depa_Id]
      ,[depa_Descripcion]
      ,[depa_Codigo]
      ,[depa_FechaCreacion]
      ,[depa_UsuarioCreacion]
      ,[depa_FechaModificacion]
      ,[depa_UsuarioModificacion]
      ,[depa_Estado]
  FROM [gnrl].[tbDepartamentos]
  WHERE depa_Estado = 1


END

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbDepartamentos_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------Procedimiento Update Departamentos
CREATE PROCEDURE [gnrl].[UDP_tbDepartamentos_Update]
    @depa_Id INT,
    @depa_Descripcion NVARCHAR(200),
	@depa_Codigo		CHAR(2),
    @depa_UsuarioModificacion INT
AS
BEGIN
BEGIN TRY

    UPDATE gnrl.tbDepartamentos
    SET depa_Descripcion = @depa_Descripcion,
		depa_Codigo = @depa_Codigo,
        depa_FechaModificacion = GETDATE(),
        depa_UsuarioModificacion = @depa_UsuarioModificacion
    WHERE depa_Id = @depa_Id;

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END


GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbEstadoCiviles_Buscar]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [gnrl].[UDP_tbEstadoCiviles_Buscar]
	@estc_Id	INT
AS
BEGIN

SELECT [estc_Id]
      ,[estc_Descripcion]
      ,[estc_FechaCreacion]
      ,[estc_UsuarioCreacion]
      ,[estc_FechaModificacion]
      ,[estc_UsuarioModificacion]
      ,[estc_Estado]
  FROM [gnrl].[tbEstadosCiviles]
  WHERE estc_Estado = 1
  AND [estc_Id] = @estc_Id

END

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbEstadoCiviles_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------Procedimiento Delete EstadoCiviles
CREATE    PROCEDURE [gnrl].[UDP_tbEstadoCiviles_Delete]
@estc_Id  INT

as
begin
BEGIN TRY

UPDATE [gnrl].[tbEstadosCiviles]
   SET estc_Estado = 0
 WHERE estc_Id = @estc_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

end

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbEstadoCiviles_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE    PROCEDURE [gnrl].[UDP_tbEstadoCiviles_Insert]
@estc_Descripcion Varchar(200),
@estc_UsuarioCreacion INT
as
begin
BEGIN TRY

INSERT INTO [gnrl].[tbEstadosCiviles]
           ([estc_Descripcion]
           ,[estc_FechaCreacion]
           ,[estc_UsuarioCreacion]
           ,[estc_FechaModificacion]
           ,[estc_UsuarioModificacion]
           ,[estc_Estado])
     VALUES
           (@estc_Descripcion
           ,GETDATE()
           ,@estc_UsuarioCreacion
           ,NULL
           ,NULL
           ,1)

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

END

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbEstadoCiviles_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [gnrl].[UDP_tbEstadoCiviles_Listado]
AS
BEGIN

SELECT [estc_Id]
      ,[estc_Descripcion]
      ,[estc_FechaCreacion]
      ,[estc_UsuarioCreacion]
      ,[estc_FechaModificacion]
      ,[estc_UsuarioModificacion]
      ,[estc_Estado]
  FROM [gnrl].[tbEstadosCiviles]
  WHERE estc_Estado = 1 

END

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbEstadoCiviles_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------Procedimiento Update EstadoCiviles
CREATE    PROCEDURE [gnrl].[UDP_tbEstadoCiviles_Update]
@estc_Id  INT,
@estc_Descripcion Varchar(200),
@estc_UsuarioModificacion INT
as
begin
BEGIN TRY

UPDATE [gnrl].[tbEstadosCiviles]
   SET[estc_Descripcion] = @estc_Descripcion
		,estc_UsuarioModificacion = @estc_UsuarioModificacion
		,estc_FechaModificacion = GETDATE()
 WHERE estc_Id = @estc_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

END
GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbMetodoPago_Buscar]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [gnrl].[UDP_tbMetodoPago_Buscar]
	@metp_Id	INT
AS
BEGIN

SELECT [metp_Id]
      ,[metp_Descripcion]
      ,[metp_FechaCreacion]
      ,[metp_UsuarioCreacion]
      ,[metp_FechaModificacion]
      ,[metp_UsuarioModificacion]
      ,[metp_Estado]
  FROM [gnrl].[tbMetodoPago]
  WHERE metp_Estado = 1
  AND metp_Id = @metp_Id		

END

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbMetodoPago_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [gnrl].[UDP_tbMetodoPago_Delete] (
    @metp_Id INT
)
AS
BEGIN
BEGIN TRY

    UPDATE gnrl.tbMetodoPago
    SET metp_Estado = 0
    WHERE  metp_Id = @metp_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbMetodoPago_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [gnrl].[UDP_tbMetodoPago_Insert]
(
    @metp_Descripcion             NVARCHAR (100),
    @metp_UsuarioCreacion         INT
)
AS
BEGIN
BEGIN TRY

INSERT INTO gnrl.tbMetodoPago ( [metp_Descripcion], 
                                [metp_FechaCreacion], 
                                [metp_UsuarioCreacion], 
                                [metp_FechaModificacion], 
                                [metp_UsuarioModificacion], 
                                [metp_Estado])
    VALUES (@metp_Descripcion, 
            GETDATE(), 
            @metp_UsuarioCreacion, 
            NULL, 
            NULL, 
            1);

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
    
END

-----------Procedimiento Update MetodoPago
GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbMetodoPago_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [gnrl].[UDP_tbMetodoPago_Listado]
AS
BEGIN

SELECT [metp_Id]
      ,[metp_Descripcion]
      ,[metp_FechaCreacion]
      ,[metp_UsuarioCreacion]
      ,[metp_FechaModificacion]
      ,[metp_UsuarioModificacion]
      ,[metp_Estado]
  FROM [gnrl].[tbMetodoPago]
  WHERE metp_Estado = 1
END

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbMetodoPago_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [gnrl].[UDP_tbMetodoPago_Update]
	@metp_Id                      INT,
	@metp_Descripcion             NVARCHAR (100)
AS
BEGIN
BEGIN TRY

	UPDATE gnrl.tbMetodoPago
	SET metp_Descripcion = @metp_Descripcion
	WHERE metp_Id = @metp_Id;

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END

-----------Procedimiento Delete MetodoPago
GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbMunicipios_Buscar]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [gnrl].[UDP_tbMunicipios_Buscar]
@muni_Id		INT
AS
BEGIN

select * from gnrl.VW_tbMunicipios_View
WHERE muni_Id = @muni_Id

END
GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbMunicipios_Departamento]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [gnrl].[UDP_tbMunicipios_Departamento]
@depa_Id	INT
AS
BEGIN

SELECT [muni_Id]
      ,[muni_Descripcion]
      ,[muni_Codigo]
      ,T1.[depa_Id]
	  ,T2.depa_Codigo
	  ,T2.depa_Descripcion
      ,[muni_FechaCreacion]
      ,[muni_UsuarioCreacion]
      ,[muni_FechaModificacion]
      ,[muni_UsuarioModificacion]
      ,[muni_Estado]
  FROM [gnrl].[tbMunicipios] T1 INNER JOIN gnrl.tbDepartamentos T2
  ON T1.depa_Id = T2.depa_Id
  WHERE muni_Estado = 1 and t1.depa_Id = @depa_Id

END

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbMunicipios_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create   Procedure [gnrl].[UDP_tbMunicipios_Insert]
@muni_Descripcion Nvarchar(150),
@muni_Codigo Char(4),
@depa_Id INT,
@muni_UsuarioCreacion INT
as
begin
BEGIN TRY

INSERT INTO [gnrl].[tbMunicipios]
           ([muni_Descripcion]
		   ,muni_Codigo
           ,[depa_Id]
           ,[muni_FechaCreacion]
           ,[muni_UsuarioCreacion]
           ,[muni_FechaModificacion]
           ,[muni_UsuarioModificacion]
           ,[muni_Estado])
     VALUES
           (@muni_Descripcion
		   ,@muni_Codigo
           ,@depa_Id
           ,GETDATE()
           ,@muni_UsuarioCreacion
           ,NULL
           ,NULL
           ,1)

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

end 

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbMunicipios_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [gnrl].[UDP_tbMunicipios_Listado]
AS
BEGIN

select * from gnrl.VW_tbMunicipios_View

END

GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbMunicipios_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------Procedimiento Update Municipios
Create Procedure [gnrl].[UDP_tbMunicipios_Update]
@muni_Id INT,
@muni_Descripcion Nvarchar(150),
@muni_Codigo CHAR(4),
@depa_Id INT,
@muni_UsuarioModificacion INT
as
begin
BEGIN TRY

UPDATE gnrl.tbMunicipios
   SET [depa_Id] = @depa_Id
      ,muni_Descripcion = @muni_Descripcion
	  ,muni_Codigo = @muni_Codigo
      ,[muni_FechaModificacion] = GETDATE()
      ,[muni_UsuarioModificacion] = @muni_UsuarioModificacion
 WHERE muni_Id = @muni_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

end 
GO
/****** Object:  StoredProcedure [gnrl].[UDP_tbMunicipiosDelete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------Procedimiento Delete Municipios
Create Procedure [gnrl].[UDP_tbMunicipiosDelete]
@muni_Id INT
as
begin
BEGIN TRY

UPDATE [gnrl].[tbMunicipios]
   SET muni_Estado = 0
 WHERE muni_Id = @muni_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH



end 
GO
/****** Object:  StoredProcedure [salo].[UDP_salo_FacturaDetalle_Buscar]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_salo_FacturaDetalle_Buscar]
@fact_Id int
AS
BEGIN
 
 Select * from salo.VW_tbFacturaDetalle_View
 WHERE fact_Id = @fact_Id

END


GO
/****** Object:  StoredProcedure [salo].[UDP_salo_FacturaDetalle_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_salo_FacturaDetalle_Insert]
    @fact_Id                INT,
    @prod_Id                INT null,
	@serv_Id				INT null,
    @fade_Cantidad          INT,
    @fade_UsuarioCreacion   INT
AS
BEGIN
BEGIN TRY

DECLARE @precio DECIMAL(18,2)

	IF (@serv_Id = 0)
		BEGIN

		SET @precio = (SELECT prod_Precio FROM salo.tbProductos WHERE prod_Id = @prod_Id)
    
    INSERT INTO salo.tbFacturasDetalles
                ([fact_Id],
                 [prod_Id],
				 [serv_Id],
                 [fade_Cantidad],
                 [fade_Precio],
                 [fade_FechaCreacion],
                 [fade_UsuarioCreacion],
                 [fade_FechaModificacion],
                 [fade_UsuarioModificacion],
                 [fade_Estado])
        VALUES (@fact_Id,
                @prod_Id,
				NULL,
                @fade_Cantidad,
                @precio,
                GETDATE(),
                @fade_UsuarioCreacion,
                NULL,
                NULL,
                1);
		END
	ELSE
		BEGIN
		
		SET @precio = (SELECT serv_Precio FROM salo.tbServicios WHERE serv_Id = @serv_Id)
    
    INSERT INTO salo.tbFacturasDetalles
                ([fact_Id],
                 [prod_Id],
				 [serv_Id],
                 [fade_Cantidad],
                 [fade_Precio],
                 [fade_FechaCreacion],
                 [fade_UsuarioCreacion],
                 [fade_FechaModificacion],
                 [fade_UsuarioModificacion],
                 [fade_Estado])
        VALUES (@fact_Id,
                NULL,
				@serv_Id,
                @fade_Cantidad,
                @precio,
                GETDATE(),
                @fade_UsuarioCreacion,
                NULL,
                NULL,
                1);

				INSERT INTO salo.tbFacturasDetalles
                ([fact_Id],
                 [prod_Id],
				 [serv_Id],
                 [fade_Cantidad],
                 [fade_Precio],
                 [fade_FechaCreacion],
                 [fade_UsuarioCreacion],
                 [fade_FechaModificacion],
                 [fade_UsuarioModificacion],
                 [fade_Estado])	
				 SELECT @fact_Id,
						T1.[prod_Id],
						NULL,
						1 * @fade_Cantidad,
						T2.prod_Precio,
						GETDATE(),
						@fade_UsuarioCreacion,
						NULL,
						NULL,
						1
				FROM [salo].[tbProductosXServicio] T1 INNER JOIN [salo].[tbProductos] T2
				ON T1.prod_Id = T2.prod_Id
				Where T1.serv_Id = @serv_Id



			END

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
	
END
GO
/****** Object:  StoredProcedure [salo].[UDP_salo_FacturaDetalle_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_salo_FacturaDetalle_Listado]
AS
BEGIN
 
 Select * from salo.VW_tbFacturaDetalle_View

END
GO
/****** Object:  StoredProcedure [salo].[UDP_salo_tbFacturaDetalle_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [salo].[UDP_salo_tbFacturaDetalle_Update]
    @fade_Id                    INT,
    @fact_Id                    INT,
    @prod_Id                    INT,
	@serv_Id					INT,
    @fade_Cantidad              INT,
    @fade_Precio                DECIMAL(18, 2),
    @fade_UsuarioModificacion   INT
AS
BEGIN
BEGIN TRY

    UPDATE  salo.tbFacturasDetalles
    SET     fact_Id = @fact_Id,
            prod_Id = @prod_Id,
			serv_Id = @serv_Id,
            fade_Cantidad = @fade_Cantidad,
            fade_Precio = @fade_Precio,
            fade_FechaModificacion = GETDATE(),
            fade_UsuarioModificacion = @fade_UsuarioModificacion
    WHERE   fade_Id = @fade_Id;

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END

--Procedimiento Delete FacturasDetalle
GO
/****** Object:  StoredProcedure [salo].[UDP_salo_tbFacturas_Buscar]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_salo_tbFacturas_Buscar]
@fact_Id int
AS
BEGIN
	SELECT * FROM VW_tbFacturas_Listado
	WHERE fact_Id = @fact_Id
END

GO
/****** Object:  StoredProcedure [salo].[UDP_salo_tbFacturas_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [salo].[UDP_salo_tbFacturas_Delete] (
    @fact_Id                    INT
)
AS
BEGIN
BEGIN TRY

    UPDATE  salo.tbFActuras
    SET     fact_Estado = 0
    WHERE   fact_Id = @fact_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END
GO
/****** Object:  StoredProcedure [salo].[UDP_salo_tbFacturas_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_salo_tbFacturas_Insert]
    @clie_Id                INT,
    @empl_Id_Atendido       INT,
	@empl_Id_Caja			INT,
    @metp_Id                INT,
    @fact_UsuarioCreacion   INT
AS
BEGIN
BEGIN TRY

    INSERT INTO salo.tbFacturas
                ([clie_Id],
                [empl_Id_Atendido],
				[empl_Id_Caja],
                [metp_Id],
				[fact_fecha],
                [fact_FechaCreacion],
                [fact_UsuarioCreacion],
                [fact_FechaModificacion],
                [fact_UsuarioModificacion],
                [fact_Estado])
        VALUES  (@clie_Id,
                @empl_Id_Atendido,
				@empl_Id_Caja,
                @metp_Id,
				GETDATE(),
                GETDATE(),
                @fact_UsuarioCreacion,
                NULL,
                NULL,
                1);

SELECT SCOPE_IDENTITY() as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END
GO
/****** Object:  StoredProcedure [salo].[UDP_salo_tbFacturas_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_salo_tbFacturas_Listado]
AS
BEGIN
	SELECT * FROM VW_tbFacturas_Listado

END

GO
/****** Object:  StoredProcedure [salo].[UDP_salo_tbFacturas_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_salo_tbFacturas_Update]
    @fact_Id                    INT,
    @clie_Id                    INT,
    @empl_Id_Atendido			INT,
	@empl_Id_Caja				INT,
    @metp_Id                    INT,
    @fact_UsuarioModificacion   INT
AS
BEGIN
BEGIN TRY

    UPDATE  salo.tbFacturas
    SET     clie_Id = @clie_Id,
            empl_Id_Atendido = @empl_Id_Atendido,
			empl_Id_Caja = @empl_Id_Caja,
            metp_Id = @metp_Id,
            fact_FechaModificacion = GETDATE(),
            fact_UsuarioModificacion = @fact_UsuarioModificacion
    WHERE   fact_Id = @fact_Id;

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END
GO
/****** Object:  StoredProcedure [salo].[UDP_salo_tbFacturasDetalle_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_salo_tbFacturasDetalle_Delete] 
    @fade_Id                    INT
AS
BEGIN
BEGIN TRY

DELETE FROM [salo].[tbFacturasDetalles]
      WHERE fade_Id = @fade_Id


SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END
GO
/****** Object:  StoredProcedure [salo].[UDP_salo_tbServiciosXProducto_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento Delete ServiciosXProducto

CREATE   PROCEDURE [salo].[UDP_salo_tbServiciosXProducto_Delete]
    @spro_Id				INT
AS
BEGIN
BEGIN TRY

    UPDATE  salo.tbProductosXServicio
    SET     spro_Estado = 0
    WHERE   spro_Id = @spro_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END
GO
/****** Object:  StoredProcedure [salo].[UDP_salo_tbServiciosXProducto_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_salo_tbServiciosXProducto_Insert]
    @serv_Id                    INT,
    @prod_Id                    INT,
    @spro_UsuarioCreacion	    INT
AS
    BEGIN
    BEGIN TRY

    INSERT INTO salo.tbProductosXServicio
                ([serv_Id],
                 [prod_Id],
                 [spro_FechaCreacion],
                 [spro_UsuarioCreacion],
                 [spro_FechaModificacion],
                 [spro_UsuarioModificacion],
                 [spro_Estado])
        VALUES (@serv_Id,
                @prod_Id,
                GETDATE(),
                @spro_UsuarioCreacion,
                NULL,
                NULL,
                1);

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
    END
GO
/****** Object:  StoredProcedure [salo].[UDP_salo_tbServiciosXProducto_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_salo_tbServiciosXProducto_Listado]
AS
BEGIN

SELECT [spro_Id]
      ,[serv_Id]
      ,T1.[prod_Id]
	  ,T2.prod_Nombre
	  ,T2.prod_Precio
      ,[spro_FechaCreacion]
      ,[spro_UsuarioCreacion]
      ,[spro_FechaModificacion]
      ,[spro_UsuarioModificacion]
      ,[spro_Estado]
  FROM [salo].[tbProductosXServicio] T1 INNER JOIN salo.tbProductos T2
  ON t1.prod_Id = T2.prod_Id
  WHERE spro_Estado = 1
END
GO
/****** Object:  StoredProcedure [salo].[UDP_salo_tbServiciosXProducto_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento Update ServiciosXProducto

CREATE   PROCEDURE [salo].[UDP_salo_tbServiciosXProducto_Update]
    @spro_Id                    INT,
    @serv_Id                    INT,
    @prod_Id                    INT,
    @spro_UsuarioModificacion   INT
AS
BEGIN
BEGIN TRY

    UPDATE  salo.tbProductosXServicio
    SET     serv_Id = @serv_Id,
            prod_Id = @prod_Id,
            spro_FechaModificacion = GETDATE(),
            spro_UsuarioModificacion = @spro_UsuarioModificacion
    WHERE   spro_Id  = @spro_Id;

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbCargos_Buscar]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbCargos_Buscar]
@carg_Id INT
AS
BEGIN

SELECT [carg_Id]
      ,[carg_Descripcion]
      ,[carg_FechaCreacion]
      ,[carg_UsuarioCreacion]
      ,[carg_FechaModificacion]
      ,[carg_UsuarioModificacion]
      ,[carg_Estado]
  FROM [salo].[tbCargos]
  WHERE carg_Estado = 1
  AND carg_Id = @carg_Id

END

GO
/****** Object:  StoredProcedure [salo].[UDP_tbCargos_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbCargos_Delete]
	@carg_Id INT
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbCargos]
   SET [carg_Estado] = 0
 WHERE carg_Id = @carg_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbCargos_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbCargos_Insert]
	@carg_Descripcion Nvarchar(150),
	@carg_UsuarioCreacion int

AS
BEGIN
BEGIN TRY

INSERT INTO [salo].[tbCargos]
           ([carg_Descripcion]
           ,[carg_FechaCreacion]
           ,[carg_UsuarioCreacion]
           ,[carg_FechaModificacion]
           ,[carg_UsuarioModificacion]
           ,[carg_Estado])
     VALUES
           (@carg_Descripcion
           ,GETDATE()
           ,@carg_UsuarioCreacion
           ,null
           ,null
           ,1)

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbCargos_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbCargos_Listado]
AS
BEGIN

SELECT [carg_Id]
      ,[carg_Descripcion]
      ,[carg_FechaCreacion]
      ,[carg_UsuarioCreacion]
      ,[carg_FechaModificacion]
      ,[carg_UsuarioModificacion]
      ,[carg_Estado]
  FROM [salo].[tbCargos]
  WHERE carg_Estado = 1

END

GO
/****** Object:  StoredProcedure [salo].[UDP_tbCargos_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbCargos_Update]
	@carg_Id INT,
	@carg_Descripcion Nvarchar(150),
	@carg_UsuarioModificacion int
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbCargos]
   SET [carg_Descripcion] = @carg_Descripcion
      ,[carg_FechaModificacion] = GETDATE()
      ,[carg_UsuarioModificacion] = @carg_UsuarioModificacion
 WHERE carg_Id = @carg_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbCategorias_Buscar]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [salo].[UDP_tbCategorias_Buscar]
    @cate_Id    INT
AS
BEGIN


SELECT [cate_Id]
      ,[cate_Descripcion]
      ,[cate_FechaCreacion]
      ,[cate_UsuarioCreacion]
      ,[cate_FechaModificacion]
      ,[cate_UsuarioModificacion]
      ,[cate_Estado]
  FROM [salo].[tbCategorias]
  WHERE cate_Estado = 1
  AND [cate_Id] = @cate_Id

END

GO
/****** Object:  StoredProcedure [salo].[UDP_tbCategorias_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbCategorias_Delete]
	@cate_Id INT
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbCategorias]
   SET [cate_Estado] = 0
 WHERE cate_Id = @cate_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbCategorias_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbCategorias_Insert]
	@cate_Descripcion Nvarchar(150),
	@cate_UsuarioCreacion int

AS
BEGIN
BEGIN TRY

INSERT INTO [salo].tbCategorias
           ([cate_Descripcion]
           ,[cate_FechaCreacion]
           ,[cate_UsuarioCreacion]
           ,[cate_FechaModificacion]
           ,[cate_UsuarioModificacion]
           ,[cate_Estado])
     VALUES
           (@cate_Descripcion
           ,GETDATE()
           ,@cate_UsuarioCreacion
           ,null
           ,null
           ,1)

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbCategorias_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbCategorias_Listado]
AS
BEGIN


SELECT [cate_Id]
      ,[cate_Descripcion]
      ,[cate_FechaCreacion]
      ,[cate_UsuarioCreacion]
      ,[cate_FechaModificacion]
      ,[cate_UsuarioModificacion]
      ,[cate_Estado]
  FROM [salo].[tbCategorias]
  WHERE cate_Estado = 1

END

GO
/****** Object:  StoredProcedure [salo].[UDP_tbCategorias_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbCategorias_Update]
	@cate_Id INT,
	@cate_Descripcion Nvarchar(200),
	@cate_UsuarioModificacion int
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbCategorias]
   SET [cate_Descripcion] = @cate_Descripcion
      ,[cate_FechaModificacion] = GETDATE()
      ,[cate_UsuarioModificacion] = @cate_UsuarioModificacion
 WHERE cate_Id = @cate_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbClientes_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [salo].[UDP_tbClientes_Delete] (
    @clie_Id INT
)
AS
BEGIN

BEGIN TRY
UPDATE		salo.tbClientes
    SET		clie_Estado = 0
    WHERE	clie_Id = @clie_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

    
END



--Procedimientos almacenados de Empleados
GO
/****** Object:  StoredProcedure [salo].[UDP_tbClientes_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbClientes_Insert]
    @clie_Nombre NVARCHAR(100),
    @clie_Apellido NVARCHAR(100),
    @clie_Telefono NVARCHAR(20),
    @clie_CorreoElectronico NVARCHAR(100),
    @clie_UsuarioCreacion INT
AS
BEGIN

BEGIN TRY
INSERT INTO salo.tbClientes( [clie_Nombre], 
                            [clie_Apellido], 
                            [clie_Telefono], 
                            [clie_CorreoElectronico],
                            [clie_FechaCreacion], 
                            [clie_UsuarioCreacion], 
                            [clie_FechaModificacion], 
                            [clie_UsuarioModificacion], 
                            [clie_Estado])
    VALUES (    @clie_Nombre, 
                @clie_Apellido, 
                @clie_Telefono, 
                @clie_CorreoElectronico, 
                GETDATE(), 
                @clie_UsuarioCreacion, 
                NULL,  
                NULL, 
                1)

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

    
END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbClientes_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbClientes_Listado]
AS
BEGIN

SELECT [clie_Id]
      ,[clie_Nombre]
      ,[clie_Apellido]
      ,[clie_Telefono]
      ,[clie_CorreoElectronico]
      ,[clie_FechaCreacion]
      ,[clie_UsuarioCreacion]
      ,[clie_FechaModificacion]
      ,[clie_UsuarioModificacion]
      ,[clie_Estado]
  FROM [salo].[tbClientes]
  WHERE clie_Estado = 1

END

GO
/****** Object:  StoredProcedure [salo].[UDP_tbClientes_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [salo].[UDP_tbClientes_Update]
    @clie_Id INT,
    @clie_Nombre NVARCHAR(100),
    @clie_Apellido NVARCHAR(100),
    @clie_Telefono NVARCHAR(20),
    @clie_CorreoElectronico NVARCHAR(100),
    @clie_UsuarioModificacion INT
AS
BEGIN

BEGIN TRY
UPDATE salo.tbClientes
    SET clie_Nombre = @clie_Nombre,
        clie_Apellido = @clie_Apellido,
        clie_Telefono = @clie_Telefono,
        clie_CorreoElectronico = @clie_CorreoElectronico,
        clie_FechaModificacion = GETDATE(),
        clie_UsuarioModificacion = @clie_UsuarioModificacion
    WHERE clie_Id = @clie_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

    
END

--Procedimiento almacenado Delete tbClientes
GO
/****** Object:  StoredProcedure [salo].[UDP_tbEmpleados_Buscar]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [salo].[UDP_tbEmpleados_Buscar]
@empl_Id INT
AS
BEGIN

SELECT	empl_Id, 
		empl_Nombre, 
		empl_Apellido, 
		empl_Sexo, 
		T1.muni_Id, 
		T2.muni_Codigo,
		T2.muni_Descripcion,
		T3.depa_Codigo,
		T3.depa_Descripcion,
		T3.depa_Id,
		empl_DireccionExacta, 
		T1.estc_Id,
		T4.estc_Descripcion,
		empl_Telefono, 
		empl_CorreoElectronico, 
		empl_FechaNacimiento, 
		empl_FechaContratacion, 
		T1.carg_Id,
		T5.carg_Descripcion,
		empl_FechaCreacion, 
		empl_UsuarioCreacion, 
		empl_FechaModificacion, 
		empl_UsuarioModificacion, 
		empl_Estado
FROM salo.tbEmpleados T1 INNER JOIN gnrl.tbMunicipios T2 
ON t1.muni_Id = t2.muni_Id INNER JOIN gnrl.tbDepartamentos T3
ON T3.depa_Id = t2.depa_Id INNER JOIN gnrl.tbEstadosCiviles T4
ON T4.estc_Id = T1.estc_Id INNER JOIN salo.tbCargos T5
ON t5.carg_Id = t1.carg_Id
WHERE empl_Estado = 1 AND T1.empl_Id = @empl_Id

END


--Procedimientos almacenados de categorias
GO
/****** Object:  StoredProcedure [salo].[UDP_tbEmpleados_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbEmpleados_Delete]
	@empl_Id INT
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbEmpleados]
   SET empl_Estado = 0
 WHERE empl_Id = @empl_Id


SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbEmpleados_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbEmpleados_Insert]
	@empl_Nombre Nvarchar(150),
	@empl_Apellido Nvarchar(150),
	@empl_Sexo char(1),
	@muni_Id INT,
	@empl_DireccionExacta Nvarchar(500),
	@estc_Id INT,
	@empl_Telefono Nvarchar(20),
	@empl_CorreoElectronico Nvarchar(100),
	@empl_FechaNacimiento Nvarchar(100),
	@empl_FechaContratacion Nvarchar(100),
	@carg_Id INT,
	@empl_UsuarioCreacion INT
AS
BEGIN

BEGIN TRY

INSERT INTO [salo].[tbEmpleados]
           ([empl_Nombre]
           ,[empl_Apellido]
           ,[empl_Sexo]
           ,[muni_Id]
           ,[empl_DireccionExacta]
           ,[estc_Id]
           ,[empl_Telefono]
           ,[empl_CorreoElectronico]
           ,[empl_FechaNacimiento]
           ,[empl_FechaContratacion]
           ,[carg_Id]
           ,[empl_FechaCreacion]
           ,[empl_UsuarioCreacion]
           ,[empl_FechaModificacion]
           ,[empl_UsuarioModificacion]
           ,[empl_Estado])
     VALUES
           (@empl_Nombre
           ,@empl_Apellido
           ,@empl_Sexo
           ,@muni_Id
           ,@empl_DireccionExacta
           ,@estc_Id
           ,@empl_Telefono
           ,@empl_CorreoElectronico
           ,@empl_FechaNacimiento
           ,@empl_FechaContratacion
           ,@carg_Id
           ,GETDATE()
           ,@empl_UsuarioCreacion
           ,null
           ,null
           ,1)

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH




END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbEmpleados_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbEmpleados_Listado]
AS
BEGIN

SELECT	empl_Id, 
		empl_Nombre, 
		empl_Apellido, 
		empl_Sexo, 
		T1.muni_Id, 
		T2.muni_Codigo,
		T2.muni_Descripcion,
		T3.depa_Codigo,
		T3.depa_Descripcion,
		T3.depa_Id,
		empl_DireccionExacta, 
		T1.estc_Id,
		T4.estc_Descripcion,
		empl_Telefono, 
		empl_CorreoElectronico, 
		empl_FechaNacimiento, 
		empl_FechaContratacion, 
		T1.carg_Id,
		T5.carg_Descripcion,
		empl_FechaCreacion, 
		empl_UsuarioCreacion, 
		empl_FechaModificacion, 
		empl_UsuarioModificacion, 
		empl_Estado
FROM salo.tbEmpleados T1 INNER JOIN gnrl.tbMunicipios T2 
ON t1.muni_Id = t2.muni_Id INNER JOIN gnrl.tbDepartamentos T3
ON T3.depa_Id = t2.depa_Id INNER JOIN gnrl.tbEstadosCiviles T4
ON T4.estc_Id = T1.estc_Id INNER JOIN salo.tbCargos T5
ON t5.carg_Id = t1.carg_Id
WHERE empl_Estado = 1

END



GO
/****** Object:  StoredProcedure [salo].[UDP_tbEmpleados_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbEmpleados_Update]
	@empl_Id INT,
	@empl_Nombre Nvarchar(150),
	@empl_Apellido Nvarchar(150),
	@empl_Sexo char(1),
	@muni_Id INT,
	@empl_DireccionExacta Nvarchar(500),
	@estc_Id INT,
	@empl_Telefono Nvarchar(20),
	@empl_CorreoElectronico Nvarchar(100),
	@empl_FechaNacimiento Nvarchar(100),
	@empl_FechaContratacion Nvarchar(100),
	@carg_Id INT,
	@empl_UsuarioModificacion int
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbEmpleados]
   SET [empl_Nombre] = @empl_Nombre
      ,[empl_Apellido] = @empl_Apellido
      ,[empl_Sexo] = @empl_Sexo
      ,[muni_Id] = @muni_Id
      ,[empl_DireccionExacta] = @empl_DireccionExacta
      ,[estc_Id] = @estc_Id
      ,[empl_Telefono] = @empl_Telefono
      ,[empl_CorreoElectronico] = @empl_CorreoElectronico
      ,[empl_FechaNacimiento] = @empl_FechaNacimiento
      ,[empl_FechaContratacion] = @empl_FechaContratacion
      ,[carg_Id] = @carg_Id
      ,[empl_FechaModificacion] = GETDATE()
      ,[empl_UsuarioModificacion] = @empl_UsuarioModificacion
 WHERE empl_Id = @empl_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbProductos_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [salo].[UDP_tbProductos_Delete] (
    @prod_Id INT
)
AS
BEGIN
BEGIN TRY

    UPDATE salo.tbProductos
    SET prod_Estado = 0
    WHERE prod_Id = @prod_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END

GO
/****** Object:  StoredProcedure [salo].[UDP_tbProductos_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbProductos_Insert]
    @prod_Nombre NVARCHAR(200),
    @prod_Precio DECIMAL(18, 2),
    @cate_Id INT,
    @prod_Stock INT,
    @prov_Id INT,
    @prod_UsuarioCreacion INT

AS
BEGIN
BEGIN TRY

    INSERT INTO salo.tbProductos ([prod_Nombre], 
                            [prod_Precio], 
                            [cate_Id],  
                            [prov_Id], 
                            [prod_Stock], 
                            [prod_FechaCreacion], 
                            [prod_UsuarioCreacion], 
                            [prod_FechaModificacion], 
                            [prod_UsuarioModificacion], 
                            [prod_Estado] )
    VALUES (@prod_Nombre, 
            @prod_Precio, 
            @cate_Id, 
            @prod_Stock, 
            @prov_Id,  
            GETDATE(), 
            @prod_UsuarioCreacion, 
            NULL, 
            NULL, 
            1);

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END


GO
/****** Object:  StoredProcedure [salo].[UDP_tbProductos_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbProductos_Listado]
AS
BEGIN


SELECT [prod_Id]
      ,[prod_Nombre]
      ,[prod_Precio]
      ,T1.[cate_Id]
	  ,T2.cate_Descripcion
      ,[prod_Stock]
      ,T1.[prov_id]
	  ,T3.prov_NombreEmpresa
      ,[prod_FechaCreacion]
      ,[prod_UsuarioCreacion]
      ,[prod_FechaModificacion]
      ,[prod_UsuarioModificacion]
      ,[prod_Estado]
  FROM [salo].[tbProductos] T1 INNER JOIN salo.tbCategorias T2
  ON t1.cate_Id = T2.cate_Id INNER JOIN salo.tbProveedores T3
  ON T3.prov_Id = T1.prov_id
  WHERE prod_Estado = 1


END

GO
/****** Object:  StoredProcedure [salo].[UDP_tbProductos_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbProductos_Update]
    @prod_Id INT,
    @prod_Nombre NVARCHAR(200),
    @prod_Precio DECIMAL(18, 2),
    @cate_Id INT,
    @prod_Stock INT,
    @prov_Id INT,
    @prod_UsuarioModificacion INT
AS
BEGIN

BEGIN TRY
UPDATE salo.tbProductos
    SET prod_Nombre = @prod_Nombre,
        prod_Precio = @prod_Precio,
        cate_Id    = @cate_id,
        prod_Stock = @prod_Stock,
        prov_Id = @prov_Id,
        prod_FechaModificacion = GETDATE(),
        prod_UsuarioModificacion =  @prod_UsuarioModificacion 
    WHERE prod_Id = @prod_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

    
END


GO
/****** Object:  StoredProcedure [salo].[UDP_tbProveedores_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbProveedores_Delete]
	@prov_Id INT
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbProveedores]
   SET [prov_Estado] = 0
 WHERE prov_Id = @prov_Id


SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbProveedores_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbProveedores_Insert]
	@prov_NombreEmpresa Nvarchar(150),
	@prov_NombreContacto Nvarchar(150),
	@muni_Id INT,
	@prov_DireccionExacta Nvarchar(500),
	@prov_Telefono Varchar(20),
	@prov_UsuarioCreacion INT
AS
BEGIN

BEGIN TRY



SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

INSERT INTO [salo].[tbProveedores]
           ([prov_NombreEmpresa]
           ,[prov_NombreContacto]
           ,[muni_Id]
           ,[prov_DireccionExacta]
           ,[prov_Telefono]
           ,[prov_FechaCreacion]
           ,[prov_UsuarioCreacion]
           ,[prov_FechaModificacion]
           ,[prov_UsuarioModificacion]
           ,[prov_Estado])
     VALUES
           (@prov_NombreEmpresa
           ,@prov_NombreContacto
           ,@muni_Id
           ,@prov_DireccionExacta
           ,@prov_Telefono
           ,GETDATE()
           ,@prov_UsuarioCreacion
           ,null
           ,null
           ,1)

END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbProveedores_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbProveedores_Listado]
AS
BEGIN

SELECT [prov_Id]
      ,[prov_NombreEmpresa]
      ,[prov_NombreContacto]
      ,T1.[muni_Id]
	  ,T2.muni_Descripcion
	  ,T2.muni_Codigo
	  ,T3.depa_Id
	  ,T3.depa_Descripcion
	  ,T3.depa_Codigo
      ,[prov_DireccionExacta]
      ,[prov_Telefono]
      ,[prov_FechaCreacion]
      ,[prov_UsuarioCreacion]
      ,[prov_FechaModificacion]
      ,[prov_UsuarioModificacion]
      ,[prov_Estado]
  FROM [salo].[tbProveedores] T1 INNER JOIN gnrl.tbMunicipios T2
  ON t1.muni_Id = t2.muni_Id INNER JOIN gnrl.tbDepartamentos T3
  ON t3.depa_Id = T2.depa_Id
  WHERE T1.prov_Estado = 1


END



GO
/****** Object:  StoredProcedure [salo].[UDP_tbProveedores_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbProveedores_Update]
	@prov_Id INT,
	@prov_NombreEmpresa Nvarchar(150),
	@prov_NombreContacto Nvarchar(150),
	@muni_Id INT,
	@prov_DireccionExacta Nvarchar(500),
	@prov_Telefono Varchar(20),
	@prov_UsuarioModificacion INT
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbProveedores]
   SET [prov_NombreEmpresa] = @prov_NombreEmpresa
      ,[prov_NombreContacto] = @prov_NombreContacto
      ,[muni_Id] = @muni_Id
      ,[prov_DireccionExacta] = @prov_DireccionExacta
      ,[prov_Telefono] = @prov_Telefono
      ,[prov_FechaModificacion] = GETDATE()
      ,[prov_UsuarioModificacion] = @prov_UsuarioModificacion
 WHERE prov_Id = @prov_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbReservaciones_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [salo].[UDP_tbReservaciones_Delete]
@rese_Id                    INT
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbReservaciones]
   SET [rese_Estado] = 0
 WHERE rese_Id = @rese_Id


END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbReservaciones_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbReservaciones_Insert]
@clie_Id				INT,
@sucu_Id                INT,
@rese_DiaReservado      VARCHAR(100),
@rese_HoraInicio        VARCHAR(100),
@rese_HoraFin           VARCHAR(100),
@rese_UsuarioCreacion   INT
AS
BEGIN
BEGIN TRY

INSERT INTO [salo].[tbReservaciones]
           ([clie_Id]
           ,[sucu_Id]
           ,[rese_DiaReservado]
           ,[rese_HoraInicio]
           ,[rese_HoraFin]
           ,[rese_FechaCreacion]
           ,[rese_UsuarioCreacion]
           ,[rese_FechaModificacion]
           ,[rese_UsuarioModificacion]
           ,[rese_Estado])
     VALUES
           (@clie_Id
           ,@sucu_Id
           ,@rese_DiaReservado
           ,@rese_HoraInicio
           ,@rese_HoraFin
           ,GETDATE()
           ,@rese_UsuarioCreacion
           ,NULL
           ,NULL
           ,1)


END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbReservaciones_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbReservaciones_Listado]
AS
BEGIN


SELECT [rese_Id]
      ,T1.[clie_Id]
	  ,T2.clie_Nombre
	  ,T2.clie_Apellido
	  ,T2.clie_Telefono
      ,T1.[sucu_Id]
	  ,T3.sucu_Descripcion
	  ,T3.sucu_DireccionExacta
      ,[rese_DiaReservado]
      ,[rese_HoraInicio]
      ,[rese_HoraFin]
      ,[rese_FechaCreacion]
      ,[rese_UsuarioCreacion]
      ,[rese_FechaModificacion]
      ,[rese_UsuarioModificacion]
      ,[rese_Estado]
  FROM [salo].[tbReservaciones] T1 INNER JOIN salo.tbClientes T2
  ON t1.clie_Id = T2.clie_Id INNER JOIN salo.tbSucursales T3
  ON t3.sucu_Id = T1.sucu_Id
  WHERE rese_Estado = 1

END

GO
/****** Object:  StoredProcedure [salo].[UDP_tbReservaciones_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [salo].[UDP_tbReservaciones_Update]
@rese_Id                    INT,
@clie_Id                    INT,
@sucu_Id                    INT,
@rese_DiaReservado          VARCHAR(100),
@rese_HoraInicio            VARCHAR(100),
@rese_HoraFin               VARCHAR(100),
@rese_UsuarioModificacion   INT
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbReservaciones]
   SET [clie_Id] = @clie_Id
      ,[sucu_Id] = @sucu_Id
      ,[rese_DiaReservado] = @rese_DiaReservado
      ,[rese_HoraInicio] = @rese_HoraInicio
      ,[rese_HoraFin] = @rese_HoraFin
      ,[rese_FechaModificacion] = GETDATE()
      ,[rese_UsuarioModificacion] = @rese_UsuarioModificacion
 WHERE rese_Id = @rese_Id

END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbServicios_Buscar]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbServicios_Buscar]
	@serv_Id	INT
AS
BEGIN

SELECT [serv_Id]
      ,[serv_Nombre]
      ,[serv_Descripcion]
      ,[serv_Precio]
      ,[serv_FechaCreacion]
      ,[serv_UsuarioCreacion]
      ,[serv_FechaModificacion]
      ,[serv_UsuarioModificacion]
      ,[serv_Estado]
  FROM [salo].[tbServicios]
  WHERE serv_Estado = 1 
  AND serv_Id = @serv_Id		

END

GO
/****** Object:  StoredProcedure [salo].[UDP_tbServicios_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE   PROCEDURE [salo].[UDP_tbServicios_Delete]
	@serv_Id INT
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbServicios]
   SET [serv_Estado] = 0
 WHERE serv_Id = @serv_Id

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbServicios_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [salo].[UDP_tbServicios_Insert]
	@serv_Nombre Nvarchar(150),
	@serv_Descripcion Nvarchar(500),
	@serv_Precio Nvarchar(150),
	@serv_UsuarioCreacion int

AS
BEGIN
BEGIN TRY

INSERT INTO [salo].[tbServicios]
           ([serv_Nombre]
           ,[serv_Descripcion]
           ,[serv_Precio]
           ,[serv_FechaCreacion]
           ,[serv_UsuarioCreacion]
           ,[serv_FechaModificacion]
           ,[serv_UsuarioModificacion]
           ,[serv_Estado])
     VALUES
           (@serv_Nombre
           ,@serv_Descripcion
           ,@serv_Precio
           ,GETDATE()
           ,@serv_UsuarioCreacion
           ,NULL
           ,NULL
           ,1)

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH


END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbServicios_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbServicios_Listado]
AS
BEGIN

SELECT [serv_Id]
      ,[serv_Nombre]
      ,[serv_Descripcion]
      ,[serv_Precio]
      ,[serv_FechaCreacion]
      ,[serv_UsuarioCreacion]
      ,[serv_FechaModificacion]
      ,[serv_UsuarioModificacion]
      ,[serv_Estado]
  FROM [salo].[tbServicios]
  WHERE serv_Estado = 1

END

GO
/****** Object:  StoredProcedure [salo].[UDP_tbServicios_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbServicios_Update]
	@serv_Id INT,
	@serv_Nombre Nvarchar(150),
	@serv_Descripcion Nvarchar(500),
	@serv_Precio Nvarchar(150),
	@serv_UsuarioModificacion int
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbServicios]
   SET [serv_Nombre] = @serv_Nombre
      ,[serv_Descripcion] = @serv_Descripcion
      ,[serv_Precio] = @serv_Precio
      ,[serv_FechaModificacion] = GETDATE()
      ,[serv_UsuarioModificacion] = @serv_UsuarioModificacion
 WHERE serv_Id = @serv_Id


SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

 END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbSucuesales_Delete]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbSucuesales_Delete]
@sucu_Id        INT
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbSucursales]
   SET sucu_Estado = 0
 WHERE sucu_Id = @sucu_Id

END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbSucursales_Insert]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE   PROCEDURE [salo].[UDP_tbSucursales_Insert]
@sucu_Decripcion        NVARCHAR(200),
@muni_Id                INT,
@sucu_DireccionExacta   NVARCHAR(500),
@sucu_UsuarioCreacion   INT
AS
BEGIN
BEGIN TRY

INSERT INTO [salo].[tbSucursales]
           ([sucu_Descripcion]
           ,[muni_Id]
           ,[sucu_DireccionExacta]
           ,[sucu_FechaCreacion]
           ,[sucu_UsuarioCreacion]
           ,[sucu_FechaModificacion]
           ,[sucu_UsuarioModificacion]
           ,[sucu_Estado])
     VALUES
           (@sucu_Decripcion
           ,@muni_Id
           ,@sucu_DireccionExacta
           ,GETDATE()
           ,@sucu_UsuarioCreacion
           ,NULL
           ,NULL
           ,1)

SELECT 1 as Proceso
END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH

END
GO
/****** Object:  StoredProcedure [salo].[UDP_tbSucursales_Listado]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbSucursales_Listado]
AS
BEGIN


SELECT [sucu_Id]
      ,[sucu_Descripcion]
      ,T1.[muni_Id]
	  ,T2.muni_Codigo
	  ,T2.muni_Descripcion
	  ,T3.depa_Id
	  ,T3.depa_Codigo
	  ,T3.depa_Descripcion
      ,[sucu_DireccionExacta]
      ,[sucu_FechaCreacion]
      ,[sucu_UsuarioCreacion]
      ,[sucu_FechaModificacion]
      ,[sucu_UsuarioModificacion]
      ,[sucu_Estado]
  FROM [salo].[tbSucursales] T1 INNER JOIN gnrl.tbMunicipios T2
  ON T1.muni_Id = T2.muni_Id INNER JOIN gnrl.tbDepartamentos T3
  ON T3.depa_Id = T2.depa_Id
  WHERE sucu_Estado = 1

END

GO
/****** Object:  StoredProcedure [salo].[UDP_tbSucursales_Update]    Script Date: 17/03/2023 15:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [salo].[UDP_tbSucursales_Update]
@sucu_Id                    INT,
@sucu_Decripcion            NVARCHAR(200),
@muni_Id                    INT,
@sucu_DireccionExacta       NVARCHAR(500),
@sucu_UsuarioModificacion   INT
AS
BEGIN
BEGIN TRY

UPDATE [salo].[tbSucursales]
   SET [sucu_Descripcion] = @sucu_Decripcion
      ,[muni_Id] = @muni_Id
      ,sucu_DireccionExacta = @sucu_DireccionExacta
      ,[sucu_FechaModificacion] = GETDATE()
      ,[sucu_UsuarioModificacion] = @sucu_UsuarioModificacion
 WHERE sucu_Id = @sucu_Id

END TRY
BEGIN CATCH
SELECT 0 as Proceso
END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [SalonDeBellezaCarlitos] SET  READ_WRITE 
GO
