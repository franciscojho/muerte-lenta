
-- distrito
-- rol
-- sexo
-- tipodocumento

-- Mostrar, MostrarTodo, Registrar, actualizar, eliminar, habilitar

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

USE bdmuertelenta2025
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

-- END STORE PROCEDURES FOR DISTRITO TABLE
