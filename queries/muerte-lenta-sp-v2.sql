
USE bdmuertelenta2025
GO


-- BEGIN STORE PROCEDURES FOR DISTRITO TABLE

-- SP_MostrarDistrito
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrarDistrito') 
	DROP PROCEDURE SP_MostrarDistrito
GO
CREATE PROC	SP_MostrarDistrito
AS
BEGIN
	SELECT * FROM distrito WHERE estdis = 1
END
GO
	EXEC SP_MostrarDistrito
GO

-- SP_MostrartTodoDistrito
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrartTodoDistrito') 
	DROP PROCEDURE SP_MostrartTodoDistrito
GO
CREATE PROC	SP_MostrartTodoDistrito
AS
BEGIN
	SELECT * FROM distrito
END
GO
	EXEC SP_MostrartTodoDistrito
GO

-- SP_RegistrarDistrito
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_RegistrarDistrito') 
	DROP PROCEDURE SP_RegistrarDistrito  
GO
CREATE PROC	SP_RegistrarDistrito
	@nombre varchar(30),
	@estado bit
AS
BEGIN
	BEGIN TRAN SP_RegistrarDistrito
	BEGIN TRY
		INSERT INTO distrito values(@nombre,@estado)
		COMMIT TRAN SP_RegistrarDistrito
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_RegistrarDistrito
	END CATCH
END
GO

-- SP_ActualizarDistrito
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_ActualizarDistrito') 
	DROP PROCEDURE SP_ActualizarDistrito  
GO
CREATE PROC	SP_ActualizarDistrito
	@codigo int,
	@nombre varchar(30),
	@estado bit
AS
BEGIN
	BEGIN TRAN SP_ActualizarDistrito
	BEGIN TRY
		UPDATE distrito SET  nomdis=@nombre, estdis=@estado WHERE coddis=@codigo
		COMMIT TRAN SP_ActualizarDistrito
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_ActualizarDistrito
	END CATCH
END
GO

-- SP_EliminarDistrito
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_EliminarDistrito') 
	DROP PROCEDURE SP_EliminarDistrito  
GO
CREATE PROC	SP_EliminarDistrito
@codigo int
AS
BEGIN
	BEGIN TRAN SP_EliminarDistrito
	BEGIN TRY
		UPDATE distrito SET estdis=0 where coddis=@codigo
		COMMIT TRAN SP_EliminarDistrito
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_EliminarDistrito
	END CATCH
END
GO

-- SP_HabilitarDistrito
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_HabilitarDistrito') 
	DROP PROCEDURE SP_HabilitarDistrito  
GO
CREATE PROC	SP_HabilitarDistrito
@codigo int
AS
BEGIN
	BEGIN TRAN SP_HabilitarDistrito
	BEGIN TRY
		UPDATE distrito SET estdis=1 where coddis=@codigo
		COMMIT TRAN SP_HabilitarDistrito
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_HabilitarDistrito
	END CATCH
END
GO

-- END STORE PROCEDURES FOR DISTRITO TABLE

-- BEGIN STORE PROCEDURES FOR ROL TABLE

-- SP_MostrarRol
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrarRol') 
	DROP PROCEDURE SP_MostrarRol
GO
CREATE PROC	SP_MostrarRol
AS
BEGIN
	SELECT * FROM rol WHERE estrol = 1
END
GO
	EXEC SP_MostrarRol
GO

-- SP_MostrarTodoRol
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrarTodoRol') 
	DROP PROCEDURE SP_MostrarTodoRol
GO
CREATE PROC	SP_MostrarTodoRol
AS
BEGIN
	SELECT * FROM rol
END
GO
	EXEC SP_MostrarTodoRol
GO

-- SP_RegistrarRol
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_RegistrarRol') 
	DROP PROCEDURE SP_RegistrarRol  
GO
CREATE PROC	SP_RegistrarRol
	@nombre varchar(40),
	@estado bit
AS
BEGIN
	BEGIN TRAN SP_RegistrarRol
	BEGIN TRY
		INSERT INTO rol values(@nombre,@estado)
		COMMIT TRAN SP_RegistrarRol
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_RegistrarRol
	END CATCH
END
GO

-- SP_ActualizarRol
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_ActualizarRol') 
	DROP PROCEDURE SP_ActualizarRol  
GO
CREATE PROC	SP_ActualizarRol
	@codigo int,
	@nombre varchar(40),
	@estado bit
AS
BEGIN
	BEGIN TRAN SP_ActualizarRol
	BEGIN TRY
		UPDATE rol SET  nomrol=@nombre, estrol=@estado WHERE codrol=@codigo
		COMMIT TRAN SP_ActualizarRol
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_ActualizarRol
	END CATCH
END
GO

-- SP_EliminarRol
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_EliminarRol') 
	DROP PROCEDURE SP_EliminarRol  
GO
CREATE PROC	SP_EliminarRol
@codigo int
AS
BEGIN
	BEGIN TRAN SP_EliminarRol
	BEGIN TRY
		UPDATE rol SET estrol=0 where codrol=@codigo
		COMMIT TRAN SP_EliminarRol
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_EliminarRol
	END CATCH
END
GO

-- SP_HabilitarRol
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_HabilitarRol') 
	DROP PROCEDURE SP_HabilitarRol
GO
CREATE PROC	SP_HabilitarRol
@codigo int
AS
BEGIN
	BEGIN TRAN SP_HabilitarRol
	BEGIN TRY
		UPDATE rol SET estrol=1 where codrol=@codigo
		COMMIT TRAN SP_HabilitarRol
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_HabilitarRol
	END CATCH
END
GO

-- END STORE PROCEDURES FOR ROL TABLE

-- BEGIN STORE PROCEDURES FOR SEXO TABLE

-- SP_MostrarSexo
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrarSexo') 
	DROP PROCEDURE SP_MostrarSexo
GO
CREATE PROC	SP_MostrarSexo
AS
BEGIN
	SELECT * FROM sexo WHERE estsex = 1
END
GO
	EXEC SP_MostrarSexo
GO

-- SP_MostrarTodoSexo
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrarTodoSexo') 
	DROP PROCEDURE SP_MostrarTodoSexo
GO
CREATE PROC	SP_MostrarTodoSexo
AS
BEGIN
	SELECT * FROM sexo
END
GO
	EXEC SP_MostrarTodoSexo
GO

-- SP_RegistrarSexo
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_RegistrarSexo') 
	DROP PROCEDURE SP_RegistrarSexo  
GO
CREATE PROC	SP_RegistrarSexo
	@nombre varchar(20),
	@estado bit
AS
BEGIN
	BEGIN TRAN SP_RegistrarSexo
	BEGIN TRY
		INSERT INTO sexo values(@nombre,@estado)
		COMMIT TRAN SP_RegistrarSexo
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_RegistrarSexo
	END CATCH
END
GO

-- SP_ActualizarSexo
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_ActualizarSexo') 
	DROP PROCEDURE SP_ActualizarSexo  
GO
CREATE PROC	SP_ActualizarSexo
	@codigo int,
	@nombre varchar(20),
	@estado bit
AS
BEGIN
	BEGIN TRAN SP_ActualizarSexo
	BEGIN TRY
		UPDATE sexo SET  nomsex=@nombre, estsex=@estado WHERE codsex=@codigo
		COMMIT TRAN SP_ActualizarSexo
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_ActualizarSexo
	END CATCH
END
GO

-- SP_EliminarSexo
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_EliminarSexo') 
	DROP PROCEDURE SP_EliminarSexo  
GO
CREATE PROC	SP_EliminarSexo
@codigo int
AS
BEGIN
	BEGIN TRAN SP_EliminarSexo
	BEGIN TRY
		UPDATE sexo SET estsex=0 where codsex=@codigo
		COMMIT TRAN SP_EliminarSexo
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_EliminarSexo
	END CATCH
END
GO

-- SP_HabilitarSexo
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_HabilitarSexo') 
	DROP PROCEDURE SP_HabilitarSexo  
GO
CREATE PROC	SP_HabilitarSexo
@codigo int
AS
BEGIN
	BEGIN TRAN SP_HabilitarSexo
	BEGIN TRY
		UPDATE sexo SET estsex=1 where codsex=@codigo
		COMMIT TRAN SP_HabilitarSexo
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_HabilitarSexo
	END CATCH
END
GO

-- END STORE PROCEDURES FOR SEXO TABLE

-- BEGIN STORE PROCEDURES FOR TIPODOCUMENTO TABLE

-- SP_MostrartTipoDocumento
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrartTipoDocumento') 
	DROP PROCEDURE SP_MostrartTipoDocumento
GO
CREATE PROC	SP_MostrartTipoDocumento
AS
BEGIN
	SELECT * FROM tipodocumento WHERE esttipd = 1
END
GO
	EXEC SP_MostrartTipoDocumento
GO

-- SP_MostrartTodoTipoDocumento
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrartTodoTipoDocumento') 
	DROP PROCEDURE SP_MostrartTodoTipoDocumento
GO
CREATE PROC	SP_MostrartTodoTipoDocumento
AS
BEGIN
	SELECT * FROM tipodocumento
END
GO
	EXEC SP_MostrartTodoTipoDocumento
GO

-- SP_RegistrarTipoDocumento
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_RegistrarTipoDocumento') 
	DROP PROCEDURE SP_RegistrarTipoDocumento  
GO
CREATE PROC	SP_RegistrarTipoDocumento
	@nombre varchar(40),
	@estado bit
AS
BEGIN
	BEGIN TRAN SP_RegistrarTipoDocumento
	BEGIN TRY
		INSERT INTO tipodocumento values(@nombre,@estado)
		COMMIT TRAN SP_RegistrarTipoDocumento
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_RegistrarTipoDocumento
	END CATCH
END
GO

-- SP_ActualizarTipoDocumento
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_ActualizarTipoDocumento') 
	DROP PROCEDURE SP_ActualizarTipoDocumento  
GO
CREATE PROC	SP_ActualizarTipoDocumento
	@codigo int,
	@nombre varchar(40),
	@estado bit
AS
BEGIN
	BEGIN TRAN SP_ActualizarTipoDocumento
	BEGIN TRY
		UPDATE tipodocumento SET  nomtipd=@nombre, esttipd=@estado WHERE codtipd=@codigo
		COMMIT TRAN SP_ActualizarTipoDocumento
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_ActualizarTipoDocumento
	END CATCH
END
GO

-- SP_EliminarTipoDocumento
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_EliminarTipoDocumento') 
	DROP PROCEDURE SP_EliminarTipoDocumento  
GO
CREATE PROC	SP_EliminarTipoDocumento
@codigo int
AS
BEGIN
	BEGIN TRAN SP_EliminarTipoDocumento
	BEGIN TRY
		UPDATE tipodocumento SET esttipd=0 where codtipd=@codigo
		COMMIT TRAN SP_EliminarTipoDocumento
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_EliminarTipoDocumento
	END CATCH
END
GO

-- SP_HabilitarTipoDocumento
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_HabilitarTipoDocumento') 
	DROP PROCEDURE SP_HabilitarTipoDocumento  
GO
CREATE PROC	SP_HabilitarTipoDocumento
@codigo int
AS
BEGIN
	BEGIN TRAN SP_HabilitarTipoDocumento
	BEGIN TRY
		UPDATE tipodocumento SET esttipd=1 where codtipd=@codigo
		COMMIT TRAN SP_HabilitarTipoDocumento
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN SP_HabilitarTipoDocumento
	END CATCH
END
GO

-- END STORE PROCEDURES FOR TIPODOCUMENTO TABLE