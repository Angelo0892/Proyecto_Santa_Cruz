use master
go
drop database ActivosFijosDB
go
--CREAR LA BASE DE DATOS--
create database ActivosFijosDB
go
use ActivosFijosDB
go
--CREAR LAS TABLAS--
CREATE TABLE CATEGORIA (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    NombreCategoria NVARCHAR(100) NOT NULL,
	VidaUtil INT NOT NULL
);
CREATE TABLE UBICACION (
    UbicacionID INT PRIMARY KEY IDENTITY(1,1),
    NombreUbicacion NVARCHAR(100) NOT NULL
);
CREATE TABLE UNIDAD (
    UnidadID INT PRIMARY KEY IDENTITY(1,1),
    NombreUnidad NVARCHAR(100) NOT NULL
);
CREATE TABLE UNIDAD (
    UnidadID INT PRIMARY KEY IDENTITY(1,1),
    NombreUnidad NVARCHAR(100) NOT NULL
);	
CREATE TABLE ACTIVOFIJO (
    ActivoID INT PRIMARY KEY IDENTITY(1,1),
    CodigoActivo NVARCHAR(50) NOT NULL,
    NombreActivo NVARCHAR(100) NOT NULL,
    CategoriaID INT,
    FechaAdquisicion DATE,
    ValorAdquisicion DECIMAL(18, 2),
    UbicacionID INT,
    UnidadID INT,
    EstadoBaja NVARCHAR(50) DEFAULT 'Activo',
    FOREIGN KEY (CategoriaID) REFERENCES CATEGORIA(CategoriaID),
    FOREIGN KEY (UbicacionID) REFERENCES UBICACION(UbicacionID),
    FOREIGN KEY (UnidadID) REFERENCES UNIDAD(UnidadID)
);
--CREAR LA TABLA DE BAJAS--
CREATE TABLE BAJA (
    BajaID INT PRIMARY KEY IDENTITY(1,1),
    ActivoID INT,
    FechaBaja DATE,
    Motivo NVARCHAR(255),
    Observaciones NVARCHAR(255),
    FOREIGN KEY (ActivoID) REFERENCES ACTIVOFIJO(ActivoID)
);
CREATE TABLE MANTENIMIENTO (
    MantenimientoID INT PRIMARY KEY IDENTITY(1,1),
    ActivoID INT,
    FechaMantenimiento DATE,
    Descripcion NVARCHAR(255),
    Costo DECIMAL(18, 2),
    FOREIGN KEY (ActivoID) REFERENCES ACTIVOFIJO(ActivoID)
);
CREATE TABLE CARGO (
    CargoID INT PRIMARY KEY IDENTITY(1,1),
    NombreCargo NVARCHAR(255),
);
CREATE TABLE PERSONAL (
    PersonalID INT PRIMARY KEY IDENTITY(1,1),
    NombrePersonal NVARCHAR(255),
	Apellido VARCHAR(100) NOT NULL,
	CargoID INT,
	UnidadID INT,
    Email VARCHAR(100) NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
    FOREIGN KEY (UnidadID) REFERENCES UNIDAD(UnidadID),
    FOREIGN KEY (CargoID) REFERENCES CARGO(CargoID)
);
CREATE TABLE ASIGNACION (
    AsignacionID INT PRIMARY KEY IDENTITY(1,1),
    ActivoID INT,
    PersonalID INT,
    FechaAsignacion DATE,
    Observaciones NVARCHAR(255),
    FOREIGN KEY (ActivoID) REFERENCES ACTIVOFIJO(ActivoID),
    FOREIGN KEY (PersonalID) REFERENCES PERSONAL(PersonalID)
);
CREATE TABLE RETORNO (
    RetornoID INT PRIMARY KEY IDENTITY(1,1),
    ActivoID INT,
    PersonalID INT,
    FechaRetorno DATE,
    Condicion NVARCHAR(255),
    FOREIGN KEY (ActivoID) REFERENCES ACTIVOFIJO(ActivoID),
    FOREIGN KEY (PersonalID) REFERENCES PERSONAL(PersonalID)
);
CREATE TABLE DEPRECIACION (
    DepreciacionID INT PRIMARY KEY IDENTITY(1,1),
    ActivoID INT,
    FechaDesgaste DATE,
    Valor_depreciacion_anual DECIMAL(18, 2),
	Valor_calculado DECIMAL(18, 2),
	ValorDesgaste DECIMAL(18, 2),
    Descripcion NVARCHAR(255),
    FOREIGN KEY (ActivoID) REFERENCES ACTIVOFIJO(ActivoID)
);

--DISPARADORES
CREATE TRIGGER trg_Asignacion_Activo
ON ASIGNACION
AFTER INSERT
AS
BEGIN
    UPDATE ACTIVOFIJO
    SET EstadoBaja = 'Activo'
    FROM ACTIVOFIJO AF
    INNER JOIN inserted i ON AF.ActivoID = i.ActivoID
    WHERE AF.EstadoBaja = 'Inactivo';
END;



-- Insertar datos de prueba en la tabla CATEGORIA
INSERT INTO CATEGORIA (NombreCategoria) VALUES 
('Electrónica'), 
('Mobiliario'), 
('Informática'), 
('Vehículos'), 
('Laboratorio'), 
('Biblioteca'), 
('Deportes'), 
('Oficina'), 
('Seguridad'), 
('Mantenimiento');

-- Insertar datos de prueba en la tabla UBICACION
INSERT INTO UBICACION (NombreUbicacion) VALUES 
('Edificio A'), 
('Edificio B'), 
('Edificio C'), 
('Edificio D'), 
('Edificio E'), 
('Edificio F'), 
('Edificio G'), 
('Edificio H'), 
('Edificio I'), 
('Edificio J');

-- Insertar datos de prueba en la tabla UNIDAD
INSERT INTO UNIDAD (NombreUnidad) VALUES 
('Recursos Humanos'), 
('Finanzas'), 
('Tecnología'), 
('Investigación'), 
('Biblioteca'), 
('Deportes'), 
('Mantenimiento'), 
('Seguridad'), 
('Administración'), 
('Docencia');

-- Insertar datos de prueba en la tabla ACTIVOFIJO
INSERT INTO ACTIVOFIJO (CodigoActivo, NombreActivo, CategoriaID, FechaAdquisicion, ValorAdquisicion, UbicacionID, UnidadID, EstadoBaja) VALUES 
('A001', 'Computadora Dell', 3, '2022-01-15', 1200.00, 1, 3, 'Activo'),
('A002', 'Proyector Epson', 1, '2021-03-22', 800.00, 2, 4, 'Activo'),
('A003', 'Silla Ergonómica', 2, '2020-07-30', 150.00, 3, 1, 'Activo'),
('A004', 'Microscopio', 5, '2019-11-10', 2500.00, 4, 4, 'Activo'),
('A005', 'Auto Toyota', 4, '2018-05-05', 20000.00, 5, 7, 'Activo'),
('A006', 'Libros de Ingeniería', 6, '2023-02-14', 500.00, 6, 5, 'Activo'),
('A007', 'Equipo de Gimnasio', 7, '2021-09-18', 3000.00, 7, 6, 'Activo'),
('A008', 'Escritorio de Oficina', 8, '2020-12-25', 250.00, 8, 9, 'Activo'),
('A009', 'Cámara de Seguridad', 9, '2022-06-01', 400.00, 9, 8, 'Activo'),
('A010', 'Herramientas de Mantenimiento', 10, '2019-08-20', 600.00, 10, 7, 'Activo');
INSERT INTO ACTIVOFIJO (CodigoActivo, NombreActivo, CategoriaID, FechaAdquisicion, ValorAdquisicion, UbicacionID, UnidadID, EstadoBaja) VALUES 
('A0011', 'Monitor', 1, '2022-02-01', 250.00, 1, 1, 'Inactivo'),
('A0012', 'Teclado', 1, '2022-02-02', 50.00, 1, 1, 'Inactivo'),
('A0013', 'Ratón', 1, '2022-02-03', 25.00, 1, 1, 'Inactivo'),
('A0014', 'Silla de Oficina', 2, '2022-02-04', 100.00, 2, 1, 'Inactivo'),
('A0015', 'Mesa de Reuniones', 2, '2022-02-05', 300.00, 2, 1, 'Inactivo'),
('A0016', 'Proyector', 3, '2022-02-06', 500.00, 3, 1, 'Inactivo'),
('A0017', 'Teléfono', 3, '2022-02-07', 150.00, 3, 1, 'Inactivo'),
('A0018', 'Servidor', 4, '2022-02-08', 2000.00, 4, 1, 'Inactivo'),
('A0019', 'Router', 4, '2022-02-09', 100.00, 4, 1, 'Inactivo'),
('A0020', 'Switch', 4, '2022-02-10', 200.00, 4, 1, 'Inactivo'),
('A0021', 'Impresora 3D', 5, '2022-02-11', 1500.00, 5, 1, 'Inactivo'),
('A0022', 'Escáner', 5, '2022-02-12', 300.00, 5, 1, 'Inactivo'),
('A0023', 'Cámara de Seguridad', 6, '2022-02-13', 400.00, 6, 1, 'Inactivo'),
('A0024', 'Panel Solar', 6, '2022-02-14', 1000.00, 6, 1, 'Inactivo'),
('A0025', 'Batería de Respaldo', 6, '2022-02-15', 500.00, 6, 1, 'Inactivo'),
('A0026', 'Aire Acondicionado', 7, '2022-02-16', 800.00, 7, 1, 'Inactivo'),
('A0027', 'Calefactor', 7, '2022-02-17', 200.00, 7, 1, 'Inactivo'),
('A0028', 'Ventilador', 7, '2022-02-18', 100.00, 7, 1, 'Inactivo'),
('A0029', 'Lámpara de Escritorio', 8, '2022-02-19', 50.00, 8, 1, 'Inactivo'),
('A0030', 'Estante', 8, '2022-02-20', 150.00, 8, 1, 'Inactivo');


--INSERTAR DATOS DE PRUEBA EN LA TABLA BAJA--
INSERT INTO BAJA (ActivoID, FechaBaja, Motivo, Observaciones)
VALUES 
(1, '2024-01-15', 'Obsoleto', 'Reemplazado por un modelo más nuevo'),
(2, '2024-02-20', 'Daño irreparable', 'No se pudo reparar el daño'),
(3, '2024-03-10', 'Pérdida', 'El activo se perdió durante el traslado'),
(4, '2024-04-05', 'Venta', 'Vendido a un tercero'),
(5, '2024-05-18', 'Obsoleto', 'Reemplazado por un modelo más eficiente'),
(6, '2024-06-22', 'Robo', 'El activo fue robado'),
(7, '2024-07-30', 'Daño irreparable', 'El costo de reparación es muy alto'),
(8, '2024-08-15', 'Obsoleto', 'El activo ya no cumple con los requisitos actuales'),
(9, '2024-09-10', 'Venta', 'Vendido en una subasta'),
(10, '2024-10-25', 'Pérdida', 'No se pudo localizar el activo');
-- Insertar datos de prueba en la tabla MANTENIMIENTO
INSERT INTO MANTENIMIENTO (ActivoID, FechaMantenimiento, Descripcion, Costo) VALUES 
(1, '2023-01-10',  'Reparación de pantalla', 150.00),
(2, '2022-12-05',  'Cambio de lámpara', 100.00),
(3, '2023-03-15',  'Reemplazo de ruedas', 50.00),
(4, '2021-11-20',  'Calibración de lentes', 200.00),
(5, '2022-07-25',  'Cambio de aceite', 80.00),
(6, '2023-04-10',  'Reencuadernación', 30.00),
(7, '2022-09-30',  'Lubricación de máquinas', 120.00),
(8, '2023-02-05',  'Reparación de cajones', 40.00),
(9, '2022-11-15',  'Actualización de software', 60.00),
(10, '2023-05-20', 'Reemplazo de herramientas', 90.00);

-- Insertar datos de prueba en la tabla CARGO
INSERT INTO CARGO (NombreCargo) VALUES 
('Profesor'), 
('Administrador'), 
('Secretario'), 
('Técnico'), 
('Investigador'), 
('Bibliotecario'), 
('Entrenador'), 
('Mantenimiento'), 
('Guardia'), 
('Gerente');

-- Insertar datos de prueba en la tabla PERSONAL
INSERT INTO PERSONAL (NombrePersonal, Apellido, CargoID, UnidadID, Email, Telefono) VALUES 
('Juan', 'Pérez', 1, 1, 'juan.perez@universidad.edu', '123456789'),
('Ana', 'García', 2, 2, 'ana.garcia@universidad.edu', '987654321'),
('Luis', 'Martínez', 3, 3, 'luis.martinez@universidad.edu', '456789123'),
('María', 'Rodríguez', 4, 4, 'maria.rodriguez@universidad.edu', '789123456'),
('Carlos', 'López', 5, 5, 'carlos.lopez@universidad.edu', '321654987'),
('Laura', 'González', 6, 6, 'laura.gonzalez@universidad.edu', '654987321'),
('Pedro', 'Hernández', 7, 7, 'pedro.hernandez@universidad.edu', '987321654'),
('Sofía', 'Martín', 8, 8, 'sofia.martin@universidad.edu', '321987654'),
('Miguel', 'Torres', 9, 9, 'miguel.torres@universidad.edu', '654321987'),
('Lucía', 'Sánchez', 10, 10, 'lucia.sanchez@universidad.edu', '789654123');

-- Insertar datos de prueba en la tabla ASIGNACION
INSERT INTO ASIGNACION (ActivoID, PersonalID, FechaAsignacion, Observaciones) VALUES 
(1, 1, '2023-01-15', 'Asignado para uso en oficina'),
(2, 2, '2022-03-22', 'Asignado para presentaciones'),
(3, 3, '2020-07-30', 'Asignado para uso personal'),
(4, 4, '2019-11-10', 'Asignado para laboratorio'),
(5, 5, '2018-05-05', 'Asignado para transporte'),
(6, 6, '2023-02-14', 'Asignado para biblioteca'),
(7, 7, '2021-09-18', 'Asignado para gimnasio'),
(8, 8, '2020-12-25', 'Asignado para oficina'),
(9, 9, '2022-06-01', 'Asignado para seguridad'),
(10, 10, '2019-08-20', 'Asignado para mantenimiento');

-- Insertar datos de prueba en la tabla RETORNO
INSERT INTO RETORNO (ActivoID, PersonalID, FechaRetorno, Condicion) VALUES 
(1, 1, '2023-06-15', 'Buen estado'),
(2, 2, '2022-09-22', 'Buen estado'),
(3, 3, '2021-01-30', 'Desgastado'),
(4, 4, '2020-03-10', 'Buen estado'),
(5, 5, '2019-12-05', 'Buen estado'),
(6, 6, '2023-07-14', 'Buen estado'),
(7, 7, '2022-11-18', 'Buen estado'),
(8, 8, '2021-02-25', 'Desgastado'),
(9, 9, '2023-01-01', 'Buen estado'),
(10, 10, '2020-10-20', 'Buen estado');

-- Insertar datos de prueba en la tabla DEPRECIACION
INSERT INTO DEPRECIACION (ActivoID, FechaDesgaste, ValorDesgaste_A, ValorDesgaste_D, Descripcion) VALUES 
(1, '2023-01-10', 100.00, 50.00, 'Desgaste por uso'),
(2, '2022-12-05', 80.00, 40.00, 'Desgaste por uso'),
(3, '2023-03-15', 50.00, 25.00, 'Desgaste por uso'),
(4, '2021-11-20', 200.00, 100.00, 'Desgaste por uso'),
(5, '2022-07-25', 80.00, 40.00, 'Desgaste por uso'),
(6, '2023-04-10', 30.00, 15.00, 'Desgaste por uso'),
(7, '2022-09-30', 120.00, 60.00, 'Desgaste por uso'),
(8, '2023-02-05', 40.00, 20.00, 'Desgaste por uso'),
(9, '2022-07-25', 80.00, 40.00, 'Desgaste por uso'),
(10, '2023-04-10', 30.00, 15.00, 'Desgaste por uso');

select *from CATEGORIA
select *from UBICACION
select *from UNIDAD
select *from MANTENIMIENTO
select *from CARGO
select *from PERSONAL
select *from ASIGNACION
select *from RETORNO
select *from DEPRECIACION
select *from ACTIVOFIJO