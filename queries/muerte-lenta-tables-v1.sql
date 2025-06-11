-- cerrar todas las conexiones a la base de datos
use master
go
IF EXISTS(SELECT * from sys.databases WHERE name='bdmuertelenta2025')  
BEGIN 
alter database bdmuertelenta2025 set single_user 
with rollback immediate
END 
go

-- buscamos si existe la base de datos
IF EXISTS(SELECT * from sys.databases WHERE name='bdmuertelenta2025')  
BEGIN 
	-- seleccionamos el master 
	use master
	--eliminamos la base de datos 
    drop DATABASE bdmuertelenta2025
END 
go

-- creacion de la base de datos
create database bdmuertelenta2025
go

-- seleccionamos la base de datos
use bdmuertelenta2025
go

-- simples
create table tipoplato(
codtipp integer primary key identity(1,1),
nomtipp varchar(30) not null,
esttipp bit not null
)
go

-- cruzadas
create table plato(
codplat int primary key identity(1,1),
nomplat varchar(40) not null,
desplat varchar(300) not null,
preplat money not null,
canplat int not null,
estplat bit,
codtipp int not null,
foreign key (codtipp) references tipoplato(codtipp)
)
go

-- insertar datos
-- simples
-- tipoplato
insert into tipoplato values ('Entrada',1)
insert into tipoplato values ('Sopa',1)
insert into tipoplato values ('Segundo',1)
insert into tipoplato values ('Refresco',1)
insert into tipoplato values ('Postre',1)
insert into tipoplato values ('Carta',1)
go

-- cruzadas
-- plato
insert into plato values('Aguadito','Sopa de aguadito de pollo y 
menundencias, con espinaca, albaca y culantro',3.5,20,1,2)
insert into plato values('Caldo de Gallina','Caldo de gallina con huevo y
papas,con fideos gruesos',4,15,1,2)
insert into plato values('Papa a la huancaina','Crema de papa a la huancaina
 con aji amrillo, queso, leche y galletas',2,20,1,1)
 insert into plato values('Arroz con pollo','Arroz con pollo acompañado de 
crema de huancaina y ensalada fesca',9,20,1,3)
go

-- mostran informacion
-- simples
select * from tipoplato
select * from plato
go
-- cruzada
select p.codplat,p.nomplat,p.desplat,p.preplat,p.canplat,
p.estplat,ct.nomtipp from plato p inner join tipoplato ct 
on p.codtipp=ct.codtipp
go