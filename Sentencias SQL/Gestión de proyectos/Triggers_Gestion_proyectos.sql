CREATE TRIGGER trg_logInsertarPostulante
ON POSTULANTE
AFTER INSERT 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'POSTULANTE', 'insertar',
    CAST(PostulanteId as NVARCHAR(MAX)) + ', ' +
    CAST(Codigo_Estudiante as NVARCHAR(MAX)) + ', ' +
    CAST(CI as NVARCHAR(MAX)) + ', ' +
    PrimerNombre + ', ' +
    ISNULL(SegundoNombre, '') + ', ' +
    PrimerApellido + ', ' +
    ISNULL(SegundoApellido, '') + ', ' +
    Email + ', ' +
    CAST(Celular as NVARCHAR(MAX)) + ', ' +
    CAST(Id_Carrera as NVARCHAR(MAX))
    FROM INSERTED;
END;
GO

CREATE TRIGGER trg_logModificarPostulante
ON POSTULANTE
AFTER UPDATE 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'POSTULANTE', 'actualizar',
    CAST(PostulanteId as NVARCHAR(MAX)) + ', ' +
    CAST(Codigo_Estudiante as NVARCHAR(MAX)) + ', ' +
    CAST(CI as NVARCHAR(MAX)) + ', ' +
    PrimerNombre + ', ' +
    ISNULL(SegundoNombre, '') + ', ' +
    PrimerApellido + ', ' +
    ISNULL(SegundoApellido, '') + ', ' +
    Email + ', ' +
    CAST(Celular as NVARCHAR(MAX)) + ', ' +
    CAST(Id_Carrera as NVARCHAR(MAX))
    FROM INSERTED;
END;
GO

CREATE TRIGGER trg_logEliminarPostulante
ON POSTULANTE
AFTER DELETE 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'POSTULANTE', 'eliminar',
    CAST(PostulanteId as NVARCHAR(MAX)) + ', ' +
    CAST(Codigo_Estudiante as NVARCHAR(MAX)) + ', ' +
    CAST(CI as NVARCHAR(MAX)) + ', ' +
    PrimerNombre + ', ' +
    ISNULL(SegundoNombre, '') + ', ' +
    PrimerApellido + ', ' +
    ISNULL(SegundoApellido, '') + ', ' +
    Email + ', ' +
    CAST(Celular as NVARCHAR(MAX)) + ', ' +
    CAST(Id_Carrera as NVARCHAR(MAX))
    FROM DELETED;
END;
GO

CREATE TRIGGER trg_logInsertarTribunal
ON TRIBUNAL
AFTER INSERT 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'TRIBUNAL', 'insertar',
    CAST(Id_Tribunal as NVARCHAR(MAX)) + ', ' +
    PrimerNombre + ', ' +
    ISNULL(SegundoNombre, '') + ', ' +
    PrimerApellido + ', ' +
    ISNULL(SegundoApellido, '') + ', ' +
    Tipo + ', ' +
    Institucion + ', ' +
    CAST(Id_titulo as NVARCHAR(MAX))
    FROM INSERTED;
END;
GO

CREATE TRIGGER trg_logModificarTribunal
ON TRIBUNAL
AFTER UPDATE 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'TRIBUNAL', 'actualizar',
    CAST(Id_Tribunal as NVARCHAR(MAX)) + ', ' +
    PrimerNombre + ', ' +
    ISNULL(SegundoNombre, '') + ', ' +
    PrimerApellido + ', ' +
    ISNULL(SegundoApellido, '') + ', ' +
    Tipo + ', ' +
    Institucion + ', ' +
    CAST(Id_titulo as NVARCHAR(MAX))
    FROM INSERTED;
END;
GO

CREATE TRIGGER trg_logEliminarTribunal
ON TRIBUNAL
AFTER DELETE 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'TRIBUNAL', 'eliminar',
    CAST(Id_Tribunal as NVARCHAR(MAX)) + ', ' +
    PrimerNombre + ', ' +
    ISNULL(SegundoNombre, '') + ', ' +
    PrimerApellido + ', ' +
    ISNULL(SegundoApellido, '') + ', ' +
    Tipo + ', ' +
    Institucion + ', ' +
    CAST(Id_titulo as NVARCHAR(MAX))
    FROM DELETED;
END;
GO

CREATE TRIGGER trg_logInsertarDocente
ON DOCENTE
AFTER INSERT 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'DOCENTE', 'insertar',
    CAST(Id_Docente as NVARCHAR(MAX)) + ', ' +
    PrimerNombre + ', ' +
    ISNULL(SegundoNombre, '') + ', ' +
    PrimerApellido + ', ' +
    ISNULL(SegundoApellido, '') + ', ' +
    Email + ', ' +
    CAST(Id_titulo as NVARCHAR(MAX))
    FROM INSERTED;
END;
GO

CREATE TRIGGER trg_logModificarDocente
ON DOCENTE
AFTER UPDATE 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'DOCENTE', 'actualizar',
    CAST(Id_Docente as NVARCHAR(MAX)) + ', ' +
    PrimerNombre + ', ' +
    ISNULL(SegundoNombre, '') + ', ' +
    PrimerApellido + ', ' +
    ISNULL(SegundoApellido, '') + ', ' +
    Email + ', ' +
    CAST(Id_titulo as NVARCHAR(MAX))
    FROM INSERTED;
END;
GO

CREATE TRIGGER trg_logEliminarDocente
ON DOCENTE
AFTER DELETE 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'DOCENTE', 'eliminar',
    CAST(Id_Docente as NVARCHAR(MAX)) + ', ' +
    PrimerNombre + ', ' +
    ISNULL(SegundoNombre, '') + ', ' +
    PrimerApellido + ', ' +
    ISNULL(SegundoApellido, '') + ', ' +
    Email + ', ' +
    CAST(Id_titulo as NVARCHAR(MAX))
    FROM DELETED;
END;
GO

CREATE TRIGGER trg_logInsertarDefensaInterna
ON DEFENSA_INTERNA
AFTER INSERT 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'DEFENSA_INTERNA', 'insertar',
    CAST(Id_DefensaInterna as NVARCHAR(MAX)) + ', ' +
    CAST(FechaDefensaInterna as NVARCHAR(MAX)) + ', ' +
    CAST(Observaciones as NVARCHAR(MAX))
    FROM INSERTED;
END;
GO

CREATE TRIGGER trg_logModificarDefensaInterna
ON DEFENSA_INTERNA
AFTER UPDATE 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'DEFENSA_INTERNA', 'actualizar',
    CAST(Id_DefensaInterna as NVARCHAR(MAX)) + ', ' +
    CAST(FechaDefensaInterna as NVARCHAR(MAX)) + ', ' +
    CAST(Observaciones as NVARCHAR(MAX))
    FROM INSERTED;
END;
GO

CREATE TRIGGER trg_logEliminarDefensaInterna
ON DEFENSA_INTERNA
AFTER DELETE 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'DEFENSA_INTERNA', 'eliminar',
    CAST(Id_DefensaInterna as NVARCHAR(MAX)) + ', ' +
    CAST(FechaDefensaInterna as NVARCHAR(MAX)) + ', ' +
    CAST(Observaciones as NVARCHAR(MAX))
    FROM DELETED;
END;
GO

CREATE TRIGGER trg_logInsertarDefensaExterna
ON DEFENSA_EXTERNA
AFTER INSERT 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'DEFENSA_EXTERNA', 'insertar',
    CAST(Id_DefensaExterna as NVARCHAR(MAX)) + ', ' +
    CAST(FechaDefensaExterna as NVARCHAR(MAX)) + ', ' +
    CAST(Calificacion as NVARCHAR(MAX)) + ', ' +
    CAST(Observaciones as NVARCHAR(MAX))
    FROM INSERTED;
END;
GO

CREATE TRIGGER trg_logModificarDefensaExterna
ON DEFENSA_EXTERNA
AFTER UPDATE 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'DEFENSA_EXTERNA', 'actualizar',
    CAST(Id_DefensaExterna as NVARCHAR(MAX)) + ', ' +
    CAST(FechaDefensaExterna as NVARCHAR(MAX)) + ', ' +
    CAST(Calificacion as NVARCHAR(MAX)) + ', ' +
    CAST(Observaciones as NVARCHAR(MAX))
    FROM INSERTED;
END;
GO

CREATE TRIGGER trg_logEliminarDefensaExterna
ON DEFENSA_EXTERNA
AFTER DELETE 
AS
BEGIN
    DECLARE @idTemporal INT;
    SELECT @idTemporal = idTemporal FROM IdTemporal WHERE id = 1;

    INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
    SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'DEFENSA_EXTERNA', 'eliminar',
    CAST(Id_DefensaExterna as NVARCHAR(MAX)) + ', ' +
    CAST(FechaDefensaExterna as NVARCHAR(MAX)) + ', ' +
    CAST(Calificacion as NVARCHAR(MAX)) + ', ' +
    CAST(Observaciones as NVARCHAR(MAX))
    FROM DELETED;
END;
GO