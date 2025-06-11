-- seleccionamos la BD
use bdmuertelenta2025
go
-- procedimiento tipoplato
-- Mostrar
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrarTipoPlato') 
DROP PROCEDURE SP_MostrarTipoPlato 
go
CREATE PROC	SP_MostrarTipoPlato
as
begin
select * from tipoplato where esttipp = 1
end
go
exec SP_MostrarTipoPlato
go

-- Mostrar Todo
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrarTipoPlatoTodo') 
DROP PROCEDURE SP_MostrarTipoPlatoTodo  
go
CREATE PROC	SP_MostrarTipoPlatoTodo
as
begin
select * from tipoplato
end
go
exec SP_MostrarTipoPlatoTodo
go

-- Registrar
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_RegistrarTipoPlato') 
DROP PROCEDURE SP_RegistrarTipoPlato  
go
CREATE PROC	SP_RegistrarTipoPlato
@nombre varchar(30),
@estado bit
as
begin
begin tran SP_RegistrarTipoPlato
begin try
insert into tipoplato values(@nombre,@estado)
commit tran SP_RegistrarTipoPlato
end try
begin catch
	rollback tran SP_RegistrarTipoPlato
end catch
end
go

-- Buscar
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_BuscarTipoPlatoXCodigo') 
DROP PROCEDURE SP_BuscarTipoPlatoXCodigo  
go
CREATE PROC	SP_BuscarTipoPlatoXCodigo
@codigo int
as
begin
select * from tipoplato where codtipp=@codigo
end
go
exec SP_BuscarTipoPlatoXCodigo 1
go

-- actualizar
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_ActualizarTipoPlato') 
DROP PROCEDURE SP_ActualizarTipoPlato  
go
CREATE PROC	SP_ActualizarTipoPlato
@codigo int,
@nombre varchar(30),
@estado bit
as
begin
begin tran SP_ActualizarTipoPlato
begin try
update tipoplato set  nomtipp=@nombre, esttipp=@estado where codtipp=@codigo
commit tran SP_ActualizarTipoPlato
end try
begin catch
	rollback tran SP_ActualizarTipoPlato
end catch
end
go

-- eliminar
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_EliminarTipoPlato') 
DROP PROCEDURE SP_EliminarTipoPlato  
go
CREATE PROC	SP_EliminarTipoPlato
@codigo int
as
begin
begin tran SP_EliminarTipoPlato
begin try
update tipoplato set esttipp=0 where codtipp=@codigo
commit tran SP_Eliminarplato
end try
begin catch
	rollback tran SP_EliminarTipoPlato
end catch
end
go


-- habilitar
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_HabilitarTipPlato') 
DROP PROCEDURE SP_HabilitarTipPlato  
go
CREATE PROC	SP_HabilitarTipPlato
@codigo int
as
begin
begin tran SP_HabilitarTipPlato
begin try
update tipoplato set esttipp=1 where codtipp=@codigo
commit tran SP_HabilitarTipPlato
end try
begin catch
	rollback tran SP_HabilitarTipPlato
end catch
end
go

-- plato
-- Mostrar plato
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrarPlato') 
DROP PROCEDURE SP_MostrarPlato
go
CREATE PROC	SP_MostrarPlato
as
begin
select p.codplat, p.nomplat, p.desplat,p.preplat,p.canplat,p.estplat, 
tp.codtipp,tp.nomtipp from plato p  inner join tipoplato tp 
on p.codtipp=tp.codtipp where p.estplat = 1
end
go
exec SP_MostrarPlato
go

-- Mostrar Todos los plato
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_MostrarPlatoTodo') 
DROP PROCEDURE SP_MostrarPlatoTodo
go
CREATE PROC	SP_MostrarPlatoTodo
as
begin
select p.codplat, p.nomplat, p.desplat,p.preplat,p.canplat,p.estplat, 
tp.codtipp,tp.nomtipp from plato p  inner join tipoplato tp 
on p.codtipp=tp.codtipp
end
go
exec SP_MostrarPlatoTodo
go

-- Registrar plato
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_RegistrarPlato') 
DROP PROCEDURE SP_RegistrarPlato
go
CREATE PROC	SP_RegistrarPlato
	@nombre VARCHAR(40),
    @descripcion VARCHAR(300),
    @precio MONEY,
    @cantidad INT,
    @estado BIT,
    @codtipp INT
as
begin
	begin tran SP_RegistrarPlato
	begin try
		insert into plato 
		values(@nombre,@descripcion,@precio,@cantidad,@estado,@codtipp)
		commit tran SP_RegistrarProducto
	end try
	begin catch
		rollback tran SP_RegistrarPlato
	end catch
end
go

-- Buscar plato por codigo
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_BuscarPlatoXCodigo') 
DROP PROCEDURE SP_BuscarPlatoXCodigo 
go
CREATE PROC	SP_BuscarPlatoXCodigo
@codigo int
as
begin
select p.codplat, p.nomplat, p.desplat,p.preplat,p.canplat,p.estplat, 
tp.codtipp,tp.nomtipp from plato p  inner join tipoplato tp 
on p.codplat=tp.codtipp where codplat=@codigo
end
go
exec SP_BuscarPlatoXCodigo 1
go

-- Actualizar Plato
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_ActualizarPlato') 
DROP PROCEDURE SP_ActualizarPlato
go
CREATE PROC	SP_ActualizarPlato
	@codigo int,
	@nombre varchar(40),
	@descripcion varchar(300),
	@precio money,
	@cantidad int,
	@estado bit,
	@codtipp int
as
begin
	begin tran SP_ActualizarPlato
	begin try
		update plato 
		set nomplat=@nombre,
			desplat=@descripcion,
			preplat=@precio,
			canplat=@cantidad,
			estplat=@estado,
			codtipp=@codtipp
			where codplat=@codigo
			commit tran SP_ActualizarPlato
	end try
	begin catch
		rollback tran SP_ActualizarPlato
	end catch
end
go

-- Eliminar Plato
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_EliminarPlato') 
DROP PROCEDURE SP_EliminarPlato
go
CREATE PROC	SP_EliminarPlato
@codigo int
as
begin
begin tran SP_EliminarPlato
begin try
update plato set estplat=0 where codplat=@codigo
commit tran SP_EliminarProducto
end try
begin catch
	rollback tran SP_EliminarProducto
end catch
end
go

-- habilitar Plato
IF EXISTS(SELECT * FROM sys.procedures WHERE NAME='SP_HabilitarPlato') 
DROP PROCEDURE SP_HabilitarPlato  
go
CREATE PROC	SP_HabilitarPlato
@codigo int
as
begin
begin tran SP_HabilitarPlato
begin try
update plato set estplat=1 where codplat=@codigo
commit tran SP_HabilitarProducto
end try
begin catch
	rollback tran SP_HabilitarPlato
end catch
end
go