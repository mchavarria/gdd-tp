USE [GD2C2014]
GO
/****** Object:  User [gd]    Script Date: 11/08/2014 17:13:30 ******/
CREATE USER [gd] FOR LOGIN [gd] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Schema [GESTION_DE_INFARTOS]    Script Date: 11/08/2014 17:13:27 ******/
CREATE SCHEMA [GESTION_DE_INFARTOS] AUTHORIZATION [dbo]
GO
/****** Object:  Table [GESTION_DE_INFARTOS].[tipos_documento]    Script Date: 11/08/2014 17:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [GESTION_DE_INFARTOS].[tipos_documento](
	[codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tipos_documento] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [GESTION_DE_INFARTOS].[roles]    Script Date: 11/08/2014 17:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [GESTION_DE_INFARTOS].[roles](
	[codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [GESTION_DE_INFARTOS].[funcionalidad]    Script Date: 11/08/2014 17:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [GESTION_DE_INFARTOS].[funcionalidad](
	[codigo] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_funcionalidad] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [GESTION_DE_INFARTOS].[direcciones]    Script Date: 11/08/2014 17:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [GESTION_DE_INFARTOS].[direcciones](
	[codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[calle] [varchar](50) NOT NULL,
	[numero] [int] NOT NULL,
	[localidad] [varchar](20) NULL,
	[pais] [varchar](30) NULL,
	[piso] [varchar](10) NULL,
	[depto] [varchar](10) NULL,
 CONSTRAINT [PK_direcciones] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [GESTION_DE_INFARTOS].[rol_funcionalidad]    Script Date: 11/08/2014 17:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [GESTION_DE_INFARTOS].[rol_funcionalidad](
	[rol] [numeric](18, 0) NOT NULL,
	[funcionalidad] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [GESTION_DE_INFARTOS].[personas]    Script Date: 11/08/2014 17:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [GESTION_DE_INFARTOS].[personas](
	[codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[tipo_doc] [numeric](18, 0) NULL,
	[num_doc] [int] NULL,
	[mail] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [numeric](18, 0) NULL,
 CONSTRAINT [PK_personas] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [GESTION_DE_INFARTOS].[usuarios]    Script Date: 11/08/2014 17:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [GESTION_DE_INFARTOS].[usuarios](
	[codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[logueado] [bit] NULL,
	[estado] [bit] NULL,
	[intentos_fallidos] [bit] NULL,
	[persona] [numeric](18, 0) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [GESTION_DE_INFARTOS].[rol_usuario]    Script Date: 11/08/2014 17:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GESTION_DE_INFARTOS].[rol_usuario](
	[rol] [numeric](18, 0) NOT NULL,
	[usuario] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [GESTION_DE_INFARTOS].[getFuncionalidades]    Script Date: 11/08/2014 17:13:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [GESTION_DE_INFARTOS].[getFuncionalidades](@Usuario varchar(50))
RETURNS table
AS
return SELECT f.codigo 
FROM GESTION_DE_INFARTOS.funcionalidad f, 
GESTION_DE_INFARTOS.rol_funcionalidad rf,
GESTION_DE_INFARTOS.roles r,
GESTION_DE_INFARTOS.rol_usuario ru,
GESTION_DE_INFARTOS.usuarios u
WHERE 
f.codigo = rf.funcionalidad AND
rf.rol = r.codigo AND
r.codigo = ru.rol AND
ru.usuario = u.codigo AND
u.nombre = @Usuario
GO
/****** Object:  Default [DF_roles_estado]    Script Date: 11/08/2014 17:13:29 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[roles] ADD  CONSTRAINT [DF_roles_estado]  DEFAULT ((1)) FOR [estado]
GO
/****** Object:  Default [DF_usuarios_0000]    Script Date: 11/08/2014 17:13:29 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[usuarios] ADD  CONSTRAINT [DF_usuarios_0000]  DEFAULT ((0)) FOR [logueado]
GO
/****** Object:  Default [DF_usuarios_estado]    Script Date: 11/08/2014 17:13:29 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[usuarios] ADD  CONSTRAINT [DF_usuarios_estado]  DEFAULT ((1)) FOR [estado]
GO
/****** Object:  Default [DF_usuarios_intentos_fallidos]    Script Date: 11/08/2014 17:13:29 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[usuarios] ADD  CONSTRAINT [DF_usuarios_intentos_fallidos]  DEFAULT ((0)) FOR [intentos_fallidos]
GO
/****** Object:  ForeignKey [FK_personas_direccion]    Script Date: 11/08/2014 17:13:29 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[personas]  WITH CHECK ADD  CONSTRAINT [FK_personas_direccion] FOREIGN KEY([direccion])
REFERENCES [GESTION_DE_INFARTOS].[direcciones] ([codigo])
GO
ALTER TABLE [GESTION_DE_INFARTOS].[personas] CHECK CONSTRAINT [FK_personas_direccion]
GO
/****** Object:  ForeignKey [FK_personas_tipo_doc]    Script Date: 11/08/2014 17:13:29 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[personas]  WITH CHECK ADD  CONSTRAINT [FK_personas_tipo_doc] FOREIGN KEY([tipo_doc])
REFERENCES [GESTION_DE_INFARTOS].[tipos_documento] ([codigo])
GO
ALTER TABLE [GESTION_DE_INFARTOS].[personas] CHECK CONSTRAINT [FK_personas_tipo_doc]
GO
/****** Object:  ForeignKey [FK_rol_funcionalidad_funcionalidad]    Script Date: 11/08/2014 17:13:29 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[rol_funcionalidad]  WITH CHECK ADD  CONSTRAINT [FK_rol_funcionalidad_funcionalidad] FOREIGN KEY([funcionalidad])
REFERENCES [GESTION_DE_INFARTOS].[funcionalidad] ([codigo])
GO
ALTER TABLE [GESTION_DE_INFARTOS].[rol_funcionalidad] CHECK CONSTRAINT [FK_rol_funcionalidad_funcionalidad]
GO
/****** Object:  ForeignKey [FK_rol_funcionalidad_rol]    Script Date: 11/08/2014 17:13:29 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[rol_funcionalidad]  WITH CHECK ADD  CONSTRAINT [FK_rol_funcionalidad_rol] FOREIGN KEY([rol])
REFERENCES [GESTION_DE_INFARTOS].[roles] ([codigo])
GO
ALTER TABLE [GESTION_DE_INFARTOS].[rol_funcionalidad] CHECK CONSTRAINT [FK_rol_funcionalidad_rol]
GO
/****** Object:  ForeignKey [FK_rol_usuario_rol]    Script Date: 11/08/2014 17:13:29 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[rol_usuario]  WITH CHECK ADD  CONSTRAINT [FK_rol_usuario_rol] FOREIGN KEY([rol])
REFERENCES [GESTION_DE_INFARTOS].[roles] ([codigo])
GO
ALTER TABLE [GESTION_DE_INFARTOS].[rol_usuario] CHECK CONSTRAINT [FK_rol_usuario_rol]
GO
/****** Object:  ForeignKey [FK_rol_usuario_usuario]    Script Date: 11/08/2014 17:13:29 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[rol_usuario]  WITH CHECK ADD  CONSTRAINT [FK_rol_usuario_usuario] FOREIGN KEY([usuario])
REFERENCES [GESTION_DE_INFARTOS].[usuarios] ([codigo])
GO
ALTER TABLE [GESTION_DE_INFARTOS].[rol_usuario] CHECK CONSTRAINT [FK_rol_usuario_usuario]
GO
/****** Object:  ForeignKey [FK_usuarios_persona]    Script Date: 11/08/2014 17:13:29 ******/
ALTER TABLE [GESTION_DE_INFARTOS].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_persona] FOREIGN KEY([persona])
REFERENCES [GESTION_DE_INFARTOS].[personas] ([codigo])
GO
ALTER TABLE [GESTION_DE_INFARTOS].[usuarios] CHECK CONSTRAINT [FK_usuarios_persona]
GO
