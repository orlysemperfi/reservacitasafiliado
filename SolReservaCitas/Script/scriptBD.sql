USE [BDCitas]
GO
/****** Object:  Table [dbo].[Reniec]    Script Date: 02/15/2014 10:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reniec](
	[IdPersona] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [char](8) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[APaterno] [varchar](50) NOT NULL,
	[AMaterno] [varchar](50) NOT NULL,
	[Direccion] [varchar](300) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Reniec] ON
INSERT [dbo].[Reniec] ([IdPersona], [DNI], [Nombre], [APaterno], [AMaterno], [Direccion], [FechaNacimiento], [Estado]) VALUES (1, N'44623445', N'Miguel', N'Perez', N'Diaz', N'Av. Arenales 1234', CAST(0x0000A2D2000806E9 AS DateTime), 1)
INSERT [dbo].[Reniec] ([IdPersona], [DNI], [Nombre], [APaterno], [AMaterno], [Direccion], [FechaNacimiento], [Estado]) VALUES (2, N'44623446', N'Carlos', N'Rodriguez', N'Diaz', N'Av. los heroes 1234', CAST(0x0000A2D2000806EC AS DateTime), 1)
INSERT [dbo].[Reniec] ([IdPersona], [DNI], [Nombre], [APaterno], [AMaterno], [Direccion], [FechaNacimiento], [Estado]) VALUES (3, N'44623465', N'Joauin', N'Lopez', N'Ponce', N'Av. primavera 1234', CAST(0x0000A2D2000806EC AS DateTime), 1)
INSERT [dbo].[Reniec] ([IdPersona], [DNI], [Nombre], [APaterno], [AMaterno], [Direccion], [FechaNacimiento], [Estado]) VALUES (4, N'44663445', N'Jesus', N'Perez', N'Castro', N'Av. Arequipa 1234', CAST(0x0000A2D2000806EC AS DateTime), 1)
INSERT [dbo].[Reniec] ([IdPersona], [DNI], [Nombre], [APaterno], [AMaterno], [Direccion], [FechaNacimiento], [Estado]) VALUES (5, N'44663445', N'Adrian', N'Castañeda', N'Vela', N'Av. Arenales 1234', CAST(0x0000A2D2000806EC AS DateTime), 1)
INSERT [dbo].[Reniec] ([IdPersona], [DNI], [Nombre], [APaterno], [AMaterno], [Direccion], [FechaNacimiento], [Estado]) VALUES (6, N'44633445', N'Juan', N'Perez', N'Diaz', N'Av. Arenales 1234', CAST(0x0000A2D2000806EC AS DateTime), 1)
INSERT [dbo].[Reniec] ([IdPersona], [DNI], [Nombre], [APaterno], [AMaterno], [Direccion], [FechaNacimiento], [Estado]) VALUES (7, N'44634946', N'Fernando', N'Llanos', N'Roseo', N'Av. Lima 1234', CAST(0x0000A2D2000806EC AS DateTime), 1)
INSERT [dbo].[Reniec] ([IdPersona], [DNI], [Nombre], [APaterno], [AMaterno], [Direccion], [FechaNacimiento], [Estado]) VALUES (8, N'44634944', N'Renzo', N'Nepo', N'Zolla', N'Av. thomas valle 1234', CAST(0x0000A2D2000806EC AS DateTime), 1)
INSERT [dbo].[Reniec] ([IdPersona], [DNI], [Nombre], [APaterno], [AMaterno], [Direccion], [FechaNacimiento], [Estado]) VALUES (9, N'44634949', N'Pedro', N'Perez', N'Diaz', N'Av. Arenales 1234', CAST(0x0000A2D2000806EC AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Reniec] OFF
/****** Object:  Table [dbo].[CentroAtencion]    Script Date: 02/15/2014 10:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CentroAtencion](
	[IdCentroAtencion] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_CentroAtencion] PRIMARY KEY CLUSTERED 
(
	[IdCentroAtencion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CentroAtencion] ([IdCentroAtencion], [Descripcion], [Direccion]) VALUES (1, N'Surco', N'Av. Primavera 1220')
INSERT [dbo].[CentroAtencion] ([IdCentroAtencion], [Descripcion], [Direccion]) VALUES (2, N'San Isidro', N'Av Camino Rela')
/****** Object:  Table [dbo].[Afiliado]    Script Date: 02/15/2014 10:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Afiliado](
	[IdAfiliado] [int] NOT NULL,
	[DNI] [char](8) NULL,
	[Nombre] [varchar](50) NULL,
	[APaterno] [varchar](50) NULL,
	[AMaterno] [varchar](50) NULL,
	[Direccion] [varchar](80) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Afiliado] PRIMARY KEY CLUSTERED 
(
	[IdAfiliado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Afiliado] ([IdAfiliado], [DNI], [Nombre], [APaterno], [AMaterno], [Direccion], [FechaNacimiento], [Estado]) VALUES (1, N'09392641', N'Victor', N'Huatuco', N'Huatuco', N'Av. El Polo 332', CAST(0x000065B300000000 AS DateTime), 1)
INSERT [dbo].[Afiliado] ([IdAfiliado], [DNI], [Nombre], [APaterno], [AMaterno], [Direccion], [FechaNacimiento], [Estado]) VALUES (2, N'44634946', N'Fernando', N'Roseo', N'Roseo', N'Av. Lima 1234', CAST(0x0000A2C400000000 AS DateTime), 1)
/****** Object:  Table [dbo].[Especialidad]    Script Date: 02/15/2014 10:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Especialidad](
	[IdEspecialidad] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Especialidad] PRIMARY KEY CLUSTERED 
(
	[IdEspecialidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Especialidad] ([IdEspecialidad], [Descripcion]) VALUES (1, N'Dentista')
INSERT [dbo].[Especialidad] ([IdEspecialidad], [Descripcion]) VALUES (2, N'Cirujano')
/****** Object:  Table [dbo].[Consultorio]    Script Date: 02/15/2014 10:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Consultorio](
	[IdConsultorio] [int] NOT NULL,
	[IdCentroAtencion] [int] NOT NULL,
	[NroConsultorio] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Consultorio] PRIMARY KEY CLUSTERED 
(
	[IdConsultorio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Consultorio] ([IdConsultorio], [IdCentroAtencion], [NroConsultorio], [Descripcion], [Estado]) VALUES (1, 1, N'SU 101', N'Consultorio 101', 1)
INSERT [dbo].[Consultorio] ([IdConsultorio], [IdCentroAtencion], [NroConsultorio], [Descripcion], [Estado]) VALUES (2, 2, N'SI 101', N'Consultorio 101', 1)
/****** Object:  Table [dbo].[Medico]    Script Date: 02/15/2014 10:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medico](
	[IdMedico] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[APaterno] [varchar](50) NOT NULL,
	[AMaterno] [varchar](50) NOT NULL,
	[IdCentroAtencion] [int] NOT NULL,
	[IdEspecialidad] [int] NOT NULL,
 CONSTRAINT [PK_Medico] PRIMARY KEY CLUSTERED 
(
	[IdMedico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Medico] ([IdMedico], [Nombre], [APaterno], [AMaterno], [IdCentroAtencion], [IdEspecialidad]) VALUES (1, N'Jose', N'Olaya', N'Perez', 1, 1)
INSERT [dbo].[Medico] ([IdMedico], [Nombre], [APaterno], [AMaterno], [IdCentroAtencion], [IdEspecialidad]) VALUES (2, N'Juan', N'Parodi', N'Buendia', 1, 2)
/****** Object:  StoredProcedure [dbo].[Usp_ValidadDNIExistenteReniec]    Script Date: 02/15/2014 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[Usp_ValidadDNIExistenteReniec]
@DNI Char(8)
As
If(Exists(Select dni from Reniec Where DNI=@DNI))
	Begin
		Select 'SI'
	End
Else
	Begin
		Select 'NO'
	End
GO
/****** Object:  StoredProcedure [dbo].[Usp_ValidadDNIExistente]    Script Date: 02/15/2014 10:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[Usp_ValidadDNIExistente]
@DNI Char(8)
As
If(Exists(Select dni from Afiliado Where DNI=@DNI))
	Begin
		Select 'SI'
	End
Else
	Begin
		Select 'NO'
	End
GO
/****** Object:  Table [dbo].[ReservaCita]    Script Date: 02/15/2014 10:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReservaCita](
	[IdReservaCita] [int] NOT NULL,
	[IdAfiliado] [int] NOT NULL,
	[IdCentroAtencion] [int] NOT NULL,
	[IdMedico] [int] NOT NULL,
	[IdConsultorio] [int] NOT NULL,
	[FechaAsignada] [datetime] NOT NULL,
	[Observacion] [varchar](200) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_ReservaCita] PRIMARY KEY CLUSTERED 
(
	[IdReservaCita] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ReservaCita] ([IdReservaCita], [IdAfiliado], [IdCentroAtencion], [IdMedico], [IdConsultorio], [FechaAsignada], [Observacion], [Estado]) VALUES (1, 1, 1, 1, 1, CAST(0x0000A2A600000000 AS DateTime), N'OK', 1)
INSERT [dbo].[ReservaCita] ([IdReservaCita], [IdAfiliado], [IdCentroAtencion], [IdMedico], [IdConsultorio], [FechaAsignada], [Observacion], [Estado]) VALUES (2, 1, 1, 2, 1, CAST(0x0000A2B900000000 AS DateTime), N'OK', 1)
INSERT [dbo].[ReservaCita] ([IdReservaCita], [IdAfiliado], [IdCentroAtencion], [IdMedico], [IdConsultorio], [FechaAsignada], [Observacion], [Estado]) VALUES (3, 1, 1, 1, 1, CAST(0x0000A2D3007FB750 AS DateTime), N'''88''', 0)
INSERT [dbo].[ReservaCita] ([IdReservaCita], [IdAfiliado], [IdCentroAtencion], [IdMedico], [IdConsultorio], [FechaAsignada], [Observacion], [Estado]) VALUES (4, 1, 1, 1, 1, CAST(0x0000A2CB00000000 AS DateTime), N'', 0)
INSERT [dbo].[ReservaCita] ([IdReservaCita], [IdAfiliado], [IdCentroAtencion], [IdMedico], [IdConsultorio], [FechaAsignada], [Observacion], [Estado]) VALUES (5, 1, 1, 1, 1, CAST(0x0000A2CB00000000 AS DateTime), N'', 0)
INSERT [dbo].[ReservaCita] ([IdReservaCita], [IdAfiliado], [IdCentroAtencion], [IdMedico], [IdConsultorio], [FechaAsignada], [Observacion], [Estado]) VALUES (6, 1, 1, 1, 1, CAST(0x0000A2CA00000000 AS DateTime), N'9090', 0)
INSERT [dbo].[ReservaCita] ([IdReservaCita], [IdAfiliado], [IdCentroAtencion], [IdMedico], [IdConsultorio], [FechaAsignada], [Observacion], [Estado]) VALUES (7, 1, 1, 1, 1, CAST(0x0000A2CB00000000 AS DateTime), N'Dolor de Cabeza', 0)
INSERT [dbo].[ReservaCita] ([IdReservaCita], [IdAfiliado], [IdCentroAtencion], [IdMedico], [IdConsultorio], [FechaAsignada], [Observacion], [Estado]) VALUES (8, 1, 1, 1, 1, CAST(0x0000A2CB00000000 AS DateTime), N'Dolor de Espalda', 0)
INSERT [dbo].[ReservaCita] ([IdReservaCita], [IdAfiliado], [IdCentroAtencion], [IdMedico], [IdConsultorio], [FechaAsignada], [Observacion], [Estado]) VALUES (9, 1, 2, 2, 2, CAST(0x0000A2C500000000 AS DateTime), N'Dolor de Cabeza', 0)
INSERT [dbo].[ReservaCita] ([IdReservaCita], [IdAfiliado], [IdCentroAtencion], [IdMedico], [IdConsultorio], [FechaAsignada], [Observacion], [Estado]) VALUES (10, 1, 1, 1, 1, CAST(0x0000A14200000000 AS DateTime), N'Prueba', 0)
/****** Object:  Table [dbo].[Horario]    Script Date: 02/15/2014 10:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario](
	[IdHorario] [int] NOT NULL,
	[IdConsultorio] [int] NOT NULL,
	[dia] [int] NOT NULL,
	[HoraInicio] [datetime] NOT NULL,
	[HoraFin] [datetime] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Horario] PRIMARY KEY CLUSTERED 
(
	[IdHorario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Consultorio_CentroAtencion]    Script Date: 02/15/2014 10:19:24 ******/
ALTER TABLE [dbo].[Consultorio]  WITH CHECK ADD  CONSTRAINT [FK_Consultorio_CentroAtencion] FOREIGN KEY([IdCentroAtencion])
REFERENCES [dbo].[CentroAtencion] ([IdCentroAtencion])
GO
ALTER TABLE [dbo].[Consultorio] CHECK CONSTRAINT [FK_Consultorio_CentroAtencion]
GO
/****** Object:  ForeignKey [FK_Horario_Consultorio]    Script Date: 02/15/2014 10:19:24 ******/
ALTER TABLE [dbo].[Horario]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Consultorio] FOREIGN KEY([IdConsultorio])
REFERENCES [dbo].[Consultorio] ([IdConsultorio])
GO
ALTER TABLE [dbo].[Horario] CHECK CONSTRAINT [FK_Horario_Consultorio]
GO
/****** Object:  ForeignKey [FK_Medico_CentroAtencion]    Script Date: 02/15/2014 10:19:24 ******/
ALTER TABLE [dbo].[Medico]  WITH CHECK ADD  CONSTRAINT [FK_Medico_CentroAtencion] FOREIGN KEY([IdCentroAtencion])
REFERENCES [dbo].[CentroAtencion] ([IdCentroAtencion])
GO
ALTER TABLE [dbo].[Medico] CHECK CONSTRAINT [FK_Medico_CentroAtencion]
GO
/****** Object:  ForeignKey [FK_Medico_Especialidad]    Script Date: 02/15/2014 10:19:24 ******/
ALTER TABLE [dbo].[Medico]  WITH CHECK ADD  CONSTRAINT [FK_Medico_Especialidad] FOREIGN KEY([IdEspecialidad])
REFERENCES [dbo].[Especialidad] ([IdEspecialidad])
GO
ALTER TABLE [dbo].[Medico] CHECK CONSTRAINT [FK_Medico_Especialidad]
GO
/****** Object:  ForeignKey [FK_ReservaCita_Afiliado]    Script Date: 02/15/2014 10:19:24 ******/
ALTER TABLE [dbo].[ReservaCita]  WITH CHECK ADD  CONSTRAINT [FK_ReservaCita_Afiliado] FOREIGN KEY([IdAfiliado])
REFERENCES [dbo].[Afiliado] ([IdAfiliado])
GO
ALTER TABLE [dbo].[ReservaCita] CHECK CONSTRAINT [FK_ReservaCita_Afiliado]
GO
/****** Object:  ForeignKey [FK_ReservaCita_CentroAtencion]    Script Date: 02/15/2014 10:19:24 ******/
ALTER TABLE [dbo].[ReservaCita]  WITH CHECK ADD  CONSTRAINT [FK_ReservaCita_CentroAtencion] FOREIGN KEY([IdCentroAtencion])
REFERENCES [dbo].[CentroAtencion] ([IdCentroAtencion])
GO
ALTER TABLE [dbo].[ReservaCita] CHECK CONSTRAINT [FK_ReservaCita_CentroAtencion]
GO
/****** Object:  ForeignKey [FK_ReservaCita_Consultorio]    Script Date: 02/15/2014 10:19:24 ******/
ALTER TABLE [dbo].[ReservaCita]  WITH CHECK ADD  CONSTRAINT [FK_ReservaCita_Consultorio] FOREIGN KEY([IdConsultorio])
REFERENCES [dbo].[Consultorio] ([IdConsultorio])
GO
ALTER TABLE [dbo].[ReservaCita] CHECK CONSTRAINT [FK_ReservaCita_Consultorio]
GO
/****** Object:  ForeignKey [FK_ReservaCita_Medico]    Script Date: 02/15/2014 10:19:24 ******/
ALTER TABLE [dbo].[ReservaCita]  WITH CHECK ADD  CONSTRAINT [FK_ReservaCita_Medico] FOREIGN KEY([IdMedico])
REFERENCES [dbo].[Medico] ([IdMedico])
GO
ALTER TABLE [dbo].[ReservaCita] CHECK CONSTRAINT [FK_ReservaCita_Medico]
GO
