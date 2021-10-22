--solo si ya existe en su sistema descomenten la linea de abajo
--drop database CXP
go
USE [CXP]
GO
/****** Object:  Table [dbo].[Cargo_Abono]    Script Date: 1/09/2021 17:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo_Abono](
	[No_Factura] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[ID_Tipo_C_A] [int] NOT NULL,
	[Descripcion] [varchar](80) NOT NULL,
	[Monto_Total] [int] NOT NULL,
	[Cantidad_Cargo_Abono] [decimal](38, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_P]    Script Date: 1/09/2021 17:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_P](
	[ID_Detalle_P] [int] IDENTITY(1,1) NOT NULL,
	[ID_Pedido] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Descripcion] [varchar](80) NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Detalle_P] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 1/09/2021 17:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[No_Factura] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[ID_Proveedor] [int] NULL,
	[Total] [Float] 
PRIMARY KEY CLUSTERED 
(
	[No_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 1/09/2021 17:22:24 ******/
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
/****** Object:  Table [dbo].[Proveedor]    Script Date: 1/09/2021 17:22:24 ******/
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
/****** Object:  Table [dbo].[Tipo_C_A]    Script Date: 1/09/2021 17:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_C_A](
	[ID_Tipo_C_A] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_C_A] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Tipo_C_A] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Producto]    Script Date: 1/09/2021 17:22:24 ******/
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
/****** Object:  Table [dbo].[Tipo_Usuario]    Script Date: 1/09/2021 17:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Usuario](
	[ID_Tipo_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Usuario] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Tipo_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 1/09/2021 17:22:24 ******/
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
	[ID_Tipo _Usuario] [int] NOT NULL,
	[Contraseña] [varchar](64) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cargo_Abono]  WITH CHECK ADD  CONSTRAINT [FK_Cargo_Abono.ID_Tipo_C_A] FOREIGN KEY([ID_Tipo_C_A])
REFERENCES [dbo].[Tipo_C_A] ([ID_Tipo_C_A])
GO
ALTER TABLE [dbo].[Cargo_Abono] CHECK CONSTRAINT [FK_Cargo_Abono.ID_Tipo_C_A]
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
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario.ID_Tipo _Usuario] FOREIGN KEY([ID_Tipo _Usuario])
REFERENCES [dbo].[Tipo_Usuario] ([ID_Tipo_Usuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario.ID_Tipo _Usuario]
GO
