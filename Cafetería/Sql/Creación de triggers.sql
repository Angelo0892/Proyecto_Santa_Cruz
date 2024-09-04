USE Almacen
GO

CREATE TRIGGER trg_logInsertarUsuario
ON Usuario
AFTER INSERT 
AS
BEGIN
	
	DECLARE @idTemporal INT;

	SELECT @idTemporal = idTemporal
    FROM IdTemporal
    WHERE id = 1;

	INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
	SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'Usuario', 'insertar',

	CAST(idUsuario as NVARCHAR(MAX)) + ', ' +
	nombreU + ', ' +
	CAST(codigo as NVARCHAR(MAX)) + ', ' +
	CAST(celular as NVARCHAR(MAX)) + ', ' +
	rol + ', ' +
	estado

	FROM INSERTED;
 END;
 GO

CREATE TRIGGER trg_logModificarUsuario
ON Usuario
AFTER UPDATE 
AS
BEGIN
	
	DECLARE @idTemporal INT;

	SELECT @idTemporal = idTemporal
    FROM IdTemporal
    WHERE id = 1;

	INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
	SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'Usuario', 'actualizar',

	CAST(idUsuario as NVARCHAR(MAX)) + ', ' +
	nombreU + ', ' +
	CAST(codigo as NVARCHAR(MAX)) + ', ' +
	CAST(celular as NVARCHAR(MAX)) + ', ' +
	rol + ', ' +
	estado

	FROM INSERTED;
 END;
 GO

CREATE TRIGGER trg_logEliminarUsuario
ON Usuario
AFTER DELETE 
AS
BEGIN
	
	DECLARE @idTemporal INT;

	SELECT @idTemporal = idTemporal
    FROM IdTemporal
    WHERE id = 1;

	INSERT INTO Logs (idUsuario, fecha, hora, tabla, operacion, logO)
	SELECT @idTemporal, CAST(GETDATE() AS DATE), FORMAT(GETDATE(), 'HH:mm:ss'), 'Usuario', 'eliminar',

	CAST(idUsuario as NVARCHAR(MAX)) + ', ' +
	nombreU + ', ' +
	CAST(codigo as NVARCHAR(MAX)) + ', ' +
	CAST(celular as NVARCHAR(MAX)) + ', ' +
	rol + ', ' +
	estado

	FROM DELETED;
 END;
 GO

DROP TRIGGER IF EXISTS trg_logEliminarUsuario;
GO