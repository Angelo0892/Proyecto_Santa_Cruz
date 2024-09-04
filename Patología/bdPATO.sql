USE [master]
GO
/****** Object:  Database [PatologiaDB]    Script Date: 01/09/2024 22:45:54 ******/
CREATE DATABASE [PatologiaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PatologiaDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PatologiaDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PatologiaDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PatologiaDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PatologiaDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PatologiaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PatologiaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PatologiaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PatologiaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PatologiaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PatologiaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PatologiaDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PatologiaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PatologiaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PatologiaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PatologiaDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PatologiaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PatologiaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PatologiaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PatologiaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PatologiaDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PatologiaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PatologiaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PatologiaDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PatologiaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PatologiaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PatologiaDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PatologiaDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PatologiaDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PatologiaDB] SET  MULTI_USER 
GO
ALTER DATABASE [PatologiaDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PatologiaDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PatologiaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PatologiaDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PatologiaDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PatologiaDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PatologiaDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [PatologiaDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PatologiaDB]
GO
/****** Object:  Table [dbo].[Diagnosticos]    Script Date: 01/09/2024 22:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnosticos](
	[DiagnosticoID] [int] IDENTITY(1,1) NOT NULL,
	[PacienteID] [int] NULL,
	[DoctorID] [int] NULL,
	[FechaDiagnostico] [date] NOT NULL,
	[Resultado] [nvarchar](255) NOT NULL,
	[AnomaliaDetectada] [bit] NOT NULL,
	[Pregunta1] [nvarchar](255) NULL,
	[Pregunta2] [nvarchar](255) NULL,
	[Pregunta3] [nvarchar](255) NULL,
	[Respuesta1] [nvarchar](255) NULL,
	[Respuesta2] [nvarchar](255) NULL,
	[Respuesta3] [nvarchar](255) NULL,
	[ImagenAnomalia] [varbinary](max) NULL,
	[ResultadoIA] [nvarchar](255) NULL,
	[Comentarios] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[DiagnosticoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctores]    Script Date: 01/09/2024 22:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctores](
	[DoctorID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[Especialidad] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
	[NumeroLicenciaMedica] [nvarchar](50) NOT NULL,
	[FechaExpiracionLicencia] [date] NOT NULL,
	[TurnoAsignado] [nvarchar](50) NOT NULL,
	[InstitucionGraduacion] [nvarchar](100) NOT NULL,
	[AnioGraduacion] [int] NOT NULL,
	[DisponibilidadAsignacionPaciente] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialMedico]    Script Date: 01/09/2024 22:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialMedico](
	[IdHistorial] [int] IDENTITY(1,1) NOT NULL,
	[PacienteID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
	[FechaConsulta] [datetime] NOT NULL,
	[Sintomas] [nvarchar](255) NOT NULL,
	[Diagnostico] [nvarchar](255) NOT NULL,
	[Tratamiento] [nvarchar](255) NOT NULL,
	[Observaciones] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHistorial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 01/09/2024 22:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[PacienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Genero] [nvarchar](10) NOT NULL,
	[FechaRegistro] [date] NOT NULL,
	[DoctorID] [int] NULL,
	[Direccion] [nvarchar](200) NULL,
	[NumeroContacto] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[PacienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reportes]    Script Date: 01/09/2024 22:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reportes](
	[ReporteID] [int] IDENTITY(1,1) NOT NULL,
	[PacienteID] [int] NULL,
	[DiagnosticoID] [int] NULL,
	[FechaReporte] [date] NOT NULL,
	[Descripcion] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReporteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 01/09/2024 22:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[NombreRol] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 01/09/2024 22:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Contraseña] [nvarchar](255) NOT NULL,
	[IdRol] [int] NULL,
	[FechaCreacion] [datetime] NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Doctores] ON 

INSERT [dbo].[Doctores] ([DoctorID], [Nombre], [Apellido], [Especialidad], [Email], [Estado], [NumeroLicenciaMedica], [FechaExpiracionLicencia], [TurnoAsignado], [InstitucionGraduacion], [AnioGraduacion], [DisponibilidadAsignacionPaciente]) VALUES (1, N'Israel', N'Mariaca', N'Patologo', N'ismari@gmail.com', 1, N'4558D4Y', CAST(N'2020-02-12' AS Date), N'Mañana', N'UMSA', 2019, 1)
INSERT [dbo].[Doctores] ([DoctorID], [Nombre], [Apellido], [Especialidad], [Email], [Estado], [NumeroLicenciaMedica], [FechaExpiracionLicencia], [TurnoAsignado], [InstitucionGraduacion], [AnioGraduacion], [DisponibilidadAsignacionPaciente]) VALUES (2, N'Daniela', N'Soto', N'Patologo', N'danisot@gmail.com', 1, N'5558D4Y', CAST(N'2020-02-12' AS Date), N'Mañana', N'UMSA', 2019, 1)
SET IDENTITY_INSERT [dbo].[Doctores] OFF
GO
SET IDENTITY_INSERT [dbo].[HistorialMedico] ON 

INSERT [dbo].[HistorialMedico] ([IdHistorial], [PacienteID], [DoctorID], [FechaConsulta], [Sintomas], [Diagnostico], [Tratamiento], [Observaciones]) VALUES (1, 7, 1, CAST(N'2024-08-26T09:59:13.697' AS DateTime), N'Dolor estomacal, bomitos', N'Salmonelosis', N'Con comida hiposodica', N'continua decaimiento')
INSERT [dbo].[HistorialMedico] ([IdHistorial], [PacienteID], [DoctorID], [FechaConsulta], [Sintomas], [Diagnostico], [Tratamiento], [Observaciones]) VALUES (2, 8, 2, CAST(N'2024-08-28T10:17:38.970' AS DateTime), N'Doloro de cabeza, Migraña fuerte, punzones en los ojos', N'Posible caso de tumor', N'Analisis previos de radiografias y radio frecuencias', N'ninguna')
INSERT [dbo].[HistorialMedico] ([IdHistorial], [PacienteID], [DoctorID], [FechaConsulta], [Sintomas], [Diagnostico], [Tratamiento], [Observaciones]) VALUES (3, 9, 2, CAST(N'2024-08-28T11:15:20.037' AS DateTime), N'Vomitos, mareos', N'Posible embarazo', N'Analisis de Sangre', N'Se encuentra palida y delgada')
SET IDENTITY_INSERT [dbo].[HistorialMedico] OFF
GO
SET IDENTITY_INSERT [dbo].[Pacientes] ON 

INSERT [dbo].[Pacientes] ([PacienteID], [Nombre], [Apellido], [FechaNacimiento], [Genero], [FechaRegistro], [DoctorID], [Direccion], [NumeroContacto], [Email], [Activo]) VALUES (7, N'Carlos', N'Mariaca', CAST(N'1993-05-06' AS Date), N'Masculino', CAST(N'2024-08-26' AS Date), 2, N'Zona Libertad Paz Zamora', N'6111452', N'car@gmail.com', 1)
INSERT [dbo].[Pacientes] ([PacienteID], [Nombre], [Apellido], [FechaNacimiento], [Genero], [FechaRegistro], [DoctorID], [Direccion], [NumeroContacto], [Email], [Activo]) VALUES (8, N'Daniela', N'Soto', CAST(N'1995-05-17' AS Date), N'Femenino', CAST(N'2024-08-28' AS Date), 2, N'Obrajes calle 3', N'7854693', N'danisoto@gmail.com', 1)
INSERT [dbo].[Pacientes] ([PacienteID], [Nombre], [Apellido], [FechaNacimiento], [Genero], [FechaRegistro], [DoctorID], [Direccion], [NumeroContacto], [Email], [Activo]) VALUES (9, N'Marva', N'De Arce', CAST(N'2002-10-16' AS Date), N'Femenino', CAST(N'2024-08-28' AS Date), 2, N'Sopocachi,calle ecuador n 1732', N'78545213', N'marva@gmail.com', 1)
INSERT [dbo].[Pacientes] ([PacienteID], [Nombre], [Apellido], [FechaNacimiento], [Genero], [FechaRegistro], [DoctorID], [Direccion], [NumeroContacto], [Email], [Activo]) VALUES (10, N'Jorge', N'Manrriquez', CAST(N'2024-08-29' AS Date), N'Masculino', CAST(N'2024-08-29' AS Date), 1, N'Obrajes', N'7854632', N'jorgman@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[Pacientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([IdRol], [NombreRol]) VALUES (1, N'Admin')
INSERT [dbo].[Rol] ([IdRol], [NombreRol]) VALUES (2, N'Usuario')
INSERT [dbo].[Rol] ([IdRol], [NombreRol]) VALUES (3, N'Doctor')
INSERT [dbo].[Rol] ([IdRol], [NombreRol]) VALUES (4, N'Enfermero')
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellido], [Email], [Contraseña], [IdRol], [FechaCreacion], [Activo]) VALUES (1, N'Israel', N'Mariaca', N'admin@issdan', N'admin', 1, CAST(N'2024-08-28T10:38:03.150' AS DateTime), 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellido], [Email], [Contraseña], [IdRol], [FechaCreacion], [Activo]) VALUES (2, N'Daniela', N'Soto', N'daniso@issdan', N'admin', 1, CAST(N'2024-08-28T11:06:34.150' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Doctores__A9D1053495E63E09]    Script Date: 01/09/2024 22:45:54 ******/
ALTER TABLE [dbo].[Doctores] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuario__A9D10534451A21C2]    Script Date: 01/09/2024 22:45:54 ******/
ALTER TABLE [dbo].[Usuario] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Doctores] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Doctores] ADD  DEFAULT ((1)) FOR [DisponibilidadAsignacionPaciente]
GO
ALTER TABLE [dbo].[Pacientes] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Diagnosticos]  WITH CHECK ADD FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctores] ([DoctorID])
GO
ALTER TABLE [dbo].[Diagnosticos]  WITH CHECK ADD FOREIGN KEY([PacienteID])
REFERENCES [dbo].[Pacientes] ([PacienteID])
GO
ALTER TABLE [dbo].[HistorialMedico]  WITH CHECK ADD  CONSTRAINT [FK_HistorialMedico_Doctor] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctores] ([DoctorID])
GO
ALTER TABLE [dbo].[HistorialMedico] CHECK CONSTRAINT [FK_HistorialMedico_Doctor]
GO
ALTER TABLE [dbo].[HistorialMedico]  WITH CHECK ADD  CONSTRAINT [FK_HistorialMedico_Paciente] FOREIGN KEY([PacienteID])
REFERENCES [dbo].[Pacientes] ([PacienteID])
GO
ALTER TABLE [dbo].[HistorialMedico] CHECK CONSTRAINT [FK_HistorialMedico_Paciente]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctores] ([DoctorID])
GO
ALTER TABLE [dbo].[Reportes]  WITH CHECK ADD FOREIGN KEY([DiagnosticoID])
REFERENCES [dbo].[Diagnosticos] ([DiagnosticoID])
GO
ALTER TABLE [dbo].[Reportes]  WITH CHECK ADD FOREIGN KEY([PacienteID])
REFERENCES [dbo].[Pacientes] ([PacienteID])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
USE [master]
GO
ALTER DATABASE [PatologiaDB] SET  READ_WRITE 
GO
