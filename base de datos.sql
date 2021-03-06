USE [master]
GO
/****** Object:  Database [CXP]    Script Date: 29/10/2021 18:33:40 ******/
CREATE DATABASE [CXP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CXP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CXP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CXP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CXP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CXP] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CXP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CXP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CXP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CXP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CXP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CXP] SET ARITHABORT OFF 
GO
ALTER DATABASE [CXP] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CXP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CXP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CXP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CXP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CXP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CXP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CXP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CXP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CXP] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CXP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CXP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CXP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CXP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CXP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CXP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CXP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CXP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CXP] SET  MULTI_USER 
GO
ALTER DATABASE [CXP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CXP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CXP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CXP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CXP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CXP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CXP] SET QUERY_STORE = OFF
GO
USE [CXP]
GO
/****** Object:  Table [dbo].[Cargo_Abono]    Script Date: 29/10/2021 18:33:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo_Abono](
	[No_Factura] [bigint] NOT NULL,
	[Cantidad_Cargo_Abono] [decimal](38, 0) NOT NULL,
	[Fecha_Pago] [date] NULL,
	[Tipo_C_A] [varchar](10) NULL,
	[ID_Cargo_Abono] [int] IDENTITY(1,1) NOT NULL,
	[No_Boleta] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Cargo_Abono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_P]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_P](
	[ID_Detalle_P] [int] IDENTITY(1,1) NOT NULL,
	[ID_Pedido] [bigint] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Descripcion] [varchar](80) NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Detalle_P] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[No_Factura] [bigint] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[ID_Proveedor] [int] NULL,
	[Total] [float] NULL,
	[Recibido] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[No_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_P] [varchar](20) NOT NULL,
	[ID_Tipo_Producto] [int] NOT NULL,
	[Stock] [int] NOT NULL,
	[Precio] [decimal](38, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NULL,
	[Descripcion] [varchar](80) NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [int] NOT NULL,
	[Tiempo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Producto]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Producto](
	[ID_Tipo_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Producto] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Tipo_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NULL,
	[Apellido_P] [varchar](20) NULL,
	[Apellido_S] [varchar](20) NULL,
	[Correo] [varchar](50) NOT NULL,
	[Contraseña] [varchar](64) NOT NULL,
	[Tipo_Usuario] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pedido] ADD  DEFAULT ((0)) FOR [Recibido]
GO
ALTER TABLE [dbo].[Cargo_Abono]  WITH CHECK ADD  CONSTRAINT [FK_Cargo_Abono.Key_Pedido] FOREIGN KEY([No_Factura])
REFERENCES [dbo].[Pedido] ([No_Factura])
GO
ALTER TABLE [dbo].[Cargo_Abono] CHECK CONSTRAINT [FK_Cargo_Abono.Key_Pedido]
GO
ALTER TABLE [dbo].[Detalle_P]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_P.ID_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
GO
ALTER TABLE [dbo].[Detalle_P] CHECK CONSTRAINT [FK_Detalle_P.ID_Producto]
GO
ALTER TABLE [dbo].[Detalle_P]  WITH CHECK ADD  CONSTRAINT [FK_dtpedido] FOREIGN KEY([ID_Pedido])
REFERENCES [dbo].[Pedido] ([No_Factura])
GO
ALTER TABLE [dbo].[Detalle_P] CHECK CONSTRAINT [FK_dtpedido]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedor] ([ID_Proveedor])
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido.ID_Usuario] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido.ID_Usuario]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto.ID_Tipo_Producto] FOREIGN KEY([ID_Tipo_Producto])
REFERENCES [dbo].[Tipo_Producto] ([ID_Tipo_Producto])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto.ID_Tipo_Producto]
GO
/****** Object:  StoredProcedure [dbo].[cargar]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cargar] @name varchar(50), @pas varchar(64)
as
select p.* from  usuario p
where p.Correo=@name
and p.Contraseña=@pas
GO
/****** Object:  StoredProcedure [dbo].[dtlpagar]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dtlpagar] @id int 
as
delete Cargo_Abono where ID_Cargo_Abono=@id
GO
/****** Object:  StoredProcedure [dbo].[editpagar]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editpagar] @idd int ,@id bigint , @monto decimal, @fecha date , @tipo varchar(10), @boleta  varchar(15)
as
update Cargo_Abono 
set No_Factura=@id , Cantidad_Cargo_Abono=@monto ,[Fecha_Pago]=@fecha ,Tipo_C_A = @tipo, No_Boleta = @boleta
where ID_Cargo_Abono =@idd
GO
/****** Object:  StoredProcedure [dbo].[getpagar]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getpagar] @id int 
as
select * from Cargo_Abono where ID_Cargo_Abono=@id
GO
/****** Object:  StoredProcedure [dbo].[pagar]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pagar] @id bigint , @monto decimal, @fecha date , @tipo varchar(10), @boleta  varchar(15)
as
insert into Cargo_Abono (No_Factura,Cantidad_Cargo_Abono,Fecha_Pago,Tipo_C_A,No_Boleta)  values (@id,@monto,@fecha,@tipo,@boleta)
GO
/****** Object:  StoredProcedure [dbo].[pagos]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[pagos]  @id bigint 
as
select * from Cargo_Abono  ca where ca.No_Factura=@id 
GO
/****** Object:  StoredProcedure [dbo].[recepecion]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[recepecion] as
select p.No_Factura as pedido , pr.Nombre as proveedor , p.Total as deuda , p.Fecha , p.Recibido from Pedido p , Proveedor pr
where p.ID_Proveedor=pr.ID_Proveedor
GO
/****** Object:  StoredProcedure [dbo].[recibido]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[recibido] @id bigint 
as
update Pedido  
set Recibido = 1 
where No_Factura=@id
GO
/****** Object:  StoredProcedure [dbo].[verdeuda]    Script Date: 29/10/2021 18:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[verdeuda] as
select p.No_Factura as pedido , pr.Nombre as proveedor , p.Total-(select case when sum(cag.Cantidad_Cargo_Abono)is null then 0 else sum(cag.Cantidad_Cargo_Abono) end   from dbo.Cargo_Abono cag where cag.No_Factura=p.No_Factura) as deuda , DATEDIFF(DAY,GETDATE(),dateadd(day,pr.Tiempo,p.Fecha)) as dias_R , dateadd(day,pr.Tiempo,p.Fecha) as Fecha_Max from Pedido p , Proveedor pr
where p.ID_Proveedor=pr.ID_Proveedor
GO
USE [master]
GO
ALTER DATABASE [CXP] SET  READ_WRITE 
GO
