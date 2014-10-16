USE [GD2C2014]
GO
/****** Object:  User [gd]    Script Date: 10/16/2014 00:21:16 ******/
CREATE USER [gd] FOR LOGIN [gd] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Schema [gd_esquema]    Script Date: 10/16/2014 00:21:13 ******/
CREATE SCHEMA [gd_esquema] AUTHORIZATION [gd]
GO
/****** Object:  Schema [GESTION_DE_INFARTOS]    Script Date: 10/16/2014 00:21:14 ******/
CREATE SCHEMA [GESTION_DE_INFARTOS] AUTHORIZATION [dbo]
GO
/****** Object:  Table [gd_esquema].[Maestra]    Script Date: 10/16/2014 00:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [gd_esquema].[Maestra](
	[Hotel_Ciudad] [nvarchar](255) NULL,
	[Hotel_Calle] [nvarchar](255) NULL,
	[Hotel_Nro_Calle] [numeric](18, 0) NULL,
	[Hotel_CantEstrella] [numeric](18, 0) NULL,
	[Hotel_Recarga_Estrella] [numeric](18, 0) NULL,
	[Habitacion_Numero] [numeric](18, 0) NULL,
	[Habitacion_Piso] [numeric](18, 0) NULL,
	[Habitacion_Frente] [nvarchar](50) NULL,
	[Habitacion_Tipo_Codigo] [numeric](18, 0) NULL,
	[Habitacion_Tipo_Descripcion] [nvarchar](255) NULL,
	[Habitacion_Tipo_Porcentual] [numeric](18, 2) NULL,
	[Regimen_Descripcion] [nvarchar](255) NULL,
	[Regimen_Precio] [numeric](18, 2) NULL,
	[Reserva_Fecha_Inicio] [datetime] NULL,
	[Reserva_Codigo] [numeric](18, 0) NULL,
	[Reserva_Cant_Noches] [numeric](18, 0) NULL,
	[Estadia_Fecha_Inicio] [datetime] NULL,
	[Estadia_Cant_Noches] [numeric](18, 0) NULL,
	[Consumible_Codigo] [numeric](18, 0) NULL,
	[Consumible_Descripcion] [nvarchar](255) NULL,
	[Consumible_Precio] [numeric](18, 2) NULL,
	[Item_Factura_Cantidad] [numeric](18, 0) NULL,
	[Item_Factura_Monto] [numeric](18, 2) NULL,
	[Factura_Nro] [numeric](18, 0) NULL,
	[Factura_Fecha] [datetime] NULL,
	[Factura_Total] [numeric](18, 2) NULL,
	[Cliente_Pasaporte_Nro] [numeric](18, 0) NULL,
	[Cliente_Apellido] [nvarchar](255) NULL,
	[Cliente_Nombre] [nvarchar](255) NULL,
	[Cliente_Fecha_Nac] [datetime] NULL,
	[Cliente_Mail] [nvarchar](255) NULL,
	[Cliente_Dom_Calle] [nvarchar](255) NULL,
	[Cliente_Nro_Calle] [numeric](18, 0) NULL,
	[Cliente_Piso] [numeric](18, 0) NULL,
	[Cliente_Depto] [nvarchar](50) NULL,
	[Cliente_Nacionalidad] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [GESTION_DE_INFARTOS].[usuarios]    Script Date: 10/16/2014 00:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GESTION_DE_INFARTOS].[usuarios](
	[id_usuario] [numeric](18, 0) NOT NULL,
	[nombre_usuario] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[fecha_creacion] [date] NOT NULL,
	[fecha_modificacion] [date] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GESTION_DE_INFARTOS].[roles]    Script Date: 10/16/2014 00:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GESTION_DE_INFARTOS].[roles](
	[id_rol] [numeric](18, 0) NOT NULL,
	[id_usuario] [numeric](18, 0) NOT NULL,
	[descripcion_rol] [nvarchar](50) NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[fecha_modificacion] [date] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GESTION_DE_INFARTOS].[roles_funcionalidad]    Script Date: 10/16/2014 00:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GESTION_DE_INFARTOS].[roles_funcionalidad](
	[id_rol] [numeric](18, 0) NOT NULL,
	[id_funcionalidad] [numeric](18, 0) NOT NULL,
	[descripcion] [nchar](50) NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[fecha_modificacion] [date] NULL,
 CONSTRAINT [PK_roles_funcionalidad] PRIMARY KEY CLUSTERED 
(
	[id_funcionalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_usuario]    Script Date: 10/16/2014 00:21:16 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[roles]  WITH CHECK ADD  CONSTRAINT [FK_usuario] FOREIGN KEY([id_usuario])
REFERENCES [GESTION_DE_INFARTOS].[usuarios] ([id_usuario])
GO
ALTER TABLE [GESTION_DE_INFARTOS].[roles] CHECK CONSTRAINT [FK_usuario]
GO
/****** Object:  ForeignKey [fk_roles]    Script Date: 10/16/2014 00:21:16 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[roles_funcionalidad]  WITH CHECK ADD  CONSTRAINT [fk_roles] FOREIGN KEY([id_rol])
REFERENCES [GESTION_DE_INFARTOS].[roles] ([id_rol])
GO
ALTER TABLE [GESTION_DE_INFARTOS].[roles_funcionalidad] CHECK CONSTRAINT [fk_roles]
GO
