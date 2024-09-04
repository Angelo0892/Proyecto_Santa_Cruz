CREATE DATABASE DEMOPROY
USE DEMOPROY

CREATE TABLE POSTULANTE (
    PostulanteId INT PRIMARY KEY IDENTITY(1,1),
	Codigo_Estudiante INT NOT NULL UNIQUE,
	CI INT NOT NULL,
    PrimerNombre NVARCHAR(50) not null,
	SegundoNombre NVARCHAR(50)null,
	PrimerApellido NVARCHAR(50) not null,
	SegundoApellido NVARCHAR(50)null,
	Email NVARCHAR(50) null,
	Celular INT NOT NULL,
	Id_Carrera INT NOT NULL,
	FOREIGN KEY (Id_Carrera) REFERENCES CARRERA(Id_Carrera),
);

CREATE TABLE PROYECTO (
    Id_Proyecto INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(255) NOT NULL,
    TipoTrabajo NVARCHAR(100) NOT NULL,
	Universidad NVARCHAR(50)NOT NULL,
    FechaProyecto DATE NOT NULL,
    ACTAMDG1 BIT NOT NULL,
	ACTAMDG2 BIT NOT NULL,
	Calficacion INT NOT NULL,
	ID_DocenteMDG2 INT NOT NULL,
	ID_Tutor INT NOT NULL,
	ID_Postulante INT NOT NULL, 
	FOREIGN KEY (ID_DocenteMDG2) REFERENCES DOCENTE(Id_Docente),
	FOREIGN KEY (ID_Postulante) REFERENCES POSTULANTE(PostulanteId),
	FOREIGN KEY (ID_Tutor) REFERENCES DOCENTE(Id_Docente),
);

CREATE TABLE DEFENSA_INTERNA(
	Id_DefensaInterna INT PRIMARY KEY IDENTITY(1,1),
	FechaDefensaInterna DATE NOT NULL,
	Observaciones BIT NOT NULL,
	Aprobada BIT NOT NULL,
	Calficacion INT NOT NULL,
	Id_Tribunal1 INT not null,
	Id_Tribunal2 INT not null,
	Id_Proyecto INT not null,
	FOREIGN KEY (Id_Tribunal1) REFERENCES TRIBUNAL(Id_Tribunal),
	FOREIGN KEY (Id_Tribunal2) REFERENCES TRIBUNAL(Id_Tribunal2),
	FOREIGN KEY (Id_Proyecto) REFERENCES PROYECTO(Id_Proyecto),

);

CREATE TABLE TITULO_PROFESIONAL(
    id_titulo INT PRIMARY KEY IDENTITY(1,1),     -- Identificador único del título profesional
    nombre VARCHAR(255) NOT NULL,           -- Nombre del título profesional (ej. "Ingeniero de Sistemas")
    descripcion TEXT,                       -- Descripción breve del título
    institucion VARCHAR(255) NOT NULL,      -- Nombre de la institución que otorgó el título
    fecha_obtencion DATE NOT NULL,          -- Fecha en que se obtuvo el título                   -- País donde se otorgó el título
    nivel_academico VARCHAR(100),           -- Nivel académico (ej. "Licenciatura", "Maestría", "Doctorado")
    especializacion VARCHAR(255),           -- Especialización en caso de haberla (ej. "Redes", "IA", "Desarrollo de Software")
    registro_profesional VARCHAR(100),      -- Número o código de registro del título
    fecha_registro DATE,                    -- Fecha de registro del título profesional en una entidad
);

CREATE TABLE CARRERA(
	Id_Carrera INT PRIMARY KEY IDENTITY(1,1),
	Nombre NVARCHAR(50) not null,
	Facultad NVARCHAR(50)not null,
	Nivel_Academico NVARCHAR(50) not null,
	Universidad NVARCHAR(50)not null,
);

CREATE TABLE TRIBUNAL (
	Id_Tribunal INT PRIMARY KEY IDENTITY(1,1),
	PrimerNombre NVARCHAR(50) not null,
	SegundoNombre NVARCHAR(50)null,
	PrimerApellido NVARCHAR(50) not null,
	SegundoApellido NVARCHAR(50)null,
	Tipo NVARCHAR(50) not null,
	Institucion NVarchar(50) not null,
	Id_titulo INT NOT NULL,
	FOREIGN KEY (Id_titulo) REFERENCES TITULO_PROFESIONAL(Id_titulo),
);
CREATE TABLE PERFIL(
	Id_Perfil INT PRIMARY KEY IDENTITY(1,1),
	Titulo NVARCHAR(255) NOT NULL,
    Gestion NVARCHAR(50) NOT NULL,
	Semestre NVARCHAR(50)NOT NULL,
	Codigo_Estudiante INT NOT NULL,
	FOREIGN KEY (Codigo_Estudiante) REFERENCES POSTULANTE(Codigo_Estudiante),
	
	
);



CREATE TABLE DEFENSA_PERFIL (
    FechaDefensa DATE,
	ESTADOPERFIL BIT,
	Calficacion INT NOT NULL,
	ID_DocenteMDG1 INT NOT NULL,
	ID_Tribunal1 INT NOT NULL,
	ID_Postulante INT NOT NULL,
	ID_Perfil INT NOT NULL,
    FOREIGN KEY (ID_DocenteMDG1) REFERENCES DOCENTE(Id_Docente),
    FOREIGN KEY (ID_Tribunal1) REFERENCES TRIBUNAL(Id_Tribunal),
	FOREIGN KEY (ID_Postulante) REFERENCES POSTULANTE(PostulanteId),
	FOREIGN KEY (ID_Perfil) REFERENCES PERFIL(Id_Perfil),
);

CREATE TABLE DOCENTE (
    Id_Docente INT PRIMARY KEY IDENTITY(1,1),
	PrimerNombre NVARCHAR(50) not null,
	SegundoNombre NVARCHAR(50)null,
	PrimerApellido NVARCHAR(50) not null,
	SegundoApellido NVARCHAR(50)null,
	Email NVARCHAR(50) null,
	Id_titulo INT NOT NULL,
	FOREIGN KEY (Id_titulo) REFERENCES TITULO_PROFESIONAL(Id_titulo),
);
CREATE TABLE DEFENSA_EXTERNA (
    Id_DefensaExterna INT PRIMARY KEY IDENTITY(1,1),
    FechaDefensaExterna DATE NOT NULL,
    AProbado BIT NOT NULL,
	Calficacion INT NOT NULL,
    Id_Tribunal1 INT NOT NULL,
    Id_Tribunal2 INT NOT NULL,
    Id_Tribunal3 INT NOT NULL,
	Id_Tribunal4 INT NOT NULL,
	Id_Tribunal5 INT NOT NULL,
    Id_Proyecto INT NOT NULL,
	Id_DefensaInterna INT NOT NULL,
    FOREIGN KEY (Id_Tribunal1) REFERENCES TRIBUNAL(Id_Tribunal),
	FOREIGN KEY (Id_Tribunal2) REFERENCES TRIBUNAL(Id_Tribunal),
	FOREIGN KEY (Id_Tribunal3) REFERENCES TRIBUNAL(Id_Tribunal),
    FOREIGN KEY (Id_Tribunal4) REFERENCES TRIBUNAL(Id_Tribunal),
    FOREIGN KEY (Id_Tribunal5) REFERENCES TRIBUNAL(Id_Tribunal),
    FOREIGN KEY (Id_Proyecto) REFERENCES PROYECTO(Id_Proyecto),
	FOREIGN KEY (Id_DefensaInterna) REFERENCES DEFENSA_INTERNA(Id_DefensaInterna),
);