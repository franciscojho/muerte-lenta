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

-- rol 
-- eliminamos la tabla si existe
create table rol(
codrol int primary key identity(1,1),
nomrol varchar(40)  not null,
estrol bit not null
)
go

-- insertamos valores a la tabla categoria
insert into rol(nomrol,estrol) values('administrador',1);
insert into rol(nomrol,estrol) values('usuario',1);
insert into rol(nomrol,estrol) values('invitado',1);

select * from rol
go

-- distrito
-- creamos la tabla distrito
create table distrito(
coddis int primary key identity(1,1),
nomdis varchar(30)  not null,
estdis bit not null
)
go

-- insertando datos a la tabla distrito
insert into distrito(nomdis,estdis) values('Ancón',1);
insert into distrito(nomdis,estdis) values('Ate Vitarte',1);
insert into distrito(nomdis,estdis) values('Barranco',1);
insert into distrito(nomdis,estdis) values('Breña',1);
insert into distrito(nomdis,estdis) values('Carabayllo',1);
insert into distrito(nomdis,estdis) values('Chaclacayo',1);
insert into distrito(nomdis,estdis) values('Chorrillos',1);
insert into distrito(nomdis,estdis) values('Cieneguilla',1);
insert into distrito(nomdis,estdis) values('Comas',1);
insert into distrito(nomdis,estdis) values('El Agustino',1);
insert into distrito(nomdis,estdis) values('Independencia',1);
insert into distrito(nomdis,estdis) values('Jesús María',1);
insert into distrito(nomdis,estdis) values('La Molina',1);
insert into distrito(nomdis,estdis) values('La Victoria',1);
insert into distrito(nomdis,estdis) values('Lima',1);
insert into distrito(nomdis,estdis) values('Lince',1);
insert into distrito(nomdis,estdis) values('Los Olivos',1);
insert into distrito(nomdis,estdis) values('Lurigancho',1);
insert into distrito(nomdis,estdis) values('Lurín',1);
insert into distrito(nomdis,estdis) values('Magdalena del Mar',1);
insert into distrito(nomdis,estdis) values('Miraflores',1);
insert into distrito(nomdis,estdis) values('Pachacamac',1);
insert into distrito(nomdis,estdis) values('Pucusana',1);
insert into distrito(nomdis,estdis) values('Pueblo Libre',1);
insert into distrito(nomdis,estdis) values('Puente Piedra',1);
insert into distrito(nomdis,estdis) values('Punta Hermosa',1);
insert into distrito(nomdis,estdis) values('Punta Negra',1);
insert into distrito(nomdis,estdis) values('Rímac',1);
insert into distrito(nomdis,estdis) values('San Bartolo',1);
insert into distrito(nomdis,estdis) values('San Borja',1);
insert into distrito(nomdis,estdis) values('San Isidro',1);
insert into distrito(nomdis,estdis) values('San Juan de Lurigancho',1);
insert into distrito(nomdis,estdis) values('San Juan de Miraflores',1);
insert into distrito(nomdis,estdis) values('San Luis',1);
insert into distrito(nomdis,estdis) values('San Martín de Porres',1);
insert into distrito(nomdis,estdis) values('San Miguel',1);
insert into distrito(nomdis,estdis) values('Santa Anita',1);
insert into distrito(nomdis,estdis) values('Santa María del Mar',1);
insert into distrito(nomdis,estdis) values('Santa Rosa',1);
insert into distrito(nomdis,estdis) values('Santiago de Surco',1);
insert into distrito(nomdis,estdis) values('Surquillo',1);
insert into distrito(nomdis,estdis) values('Villa El Salvador',1);
insert into distrito(nomdis,estdis) values('Villa María del Triunfo',1);
go

-- mostrando los datos de distrito
select * from distrito
go

--tipodocumento
create table tipodocumento(
codtipd integer primary key identity(1,1),
nomtipd varchar(40) not null,
esttipd bit not null
)
go

INSERT INTO tipodocumento VALUES
('DNI',1),
('Pasaporte',1),
('Carnet de Extranjería',1),
('RUC',1),
('Licencia de Conducir',1),
('Tarjeta de Identidad',1),
('Cedula',1),
('Otro',1)
GO

select * from tipodocumento
go


--sexo
create table sexo(
codsex int primary key identity(1,1),
nomsex varchar(20) not null,
estsex bit not null
)
go

insert into sexo(nomsex,estsex) values('Masculino',1);
insert into sexo(nomsex,estsex) values('Femenino',1);
insert into sexo(nomsex,estsex) values('Otros',1);
insert into sexo(nomsex,estsex) values('Sin especificar',1);

select * from sexo
go

-- empleado
create table empleado(
codemp int primary key identity(1,1),
nomemp varchar(40)  not null,
apepemp varchar(30)  not null,
apememp varchar(30)  not null,
dniemp varchar(8) not null,
fecemp date not null,
diremp varchar(50)  not null,
telemp varchar(7) not null,
celemp varchar(9) not null,
coremp varchar(40)  not null,
sexemp varchar(9) not null,
usuemp varchar(40)  not null,
claemp varchar(40)  not null,
estemp bit not null,
coddis int not null,
codrol int not null,
codsex int not null,
codtipd int not null,
foreign key (coddis) references distrito(coddis),
foreign key (codsex) references sexo(codsex),
foreign key (codtipd) references tipodocumento(codtipd),
foreign key (codrol) references rol(codrol)
)
go


insert into empleado(nomemp,apepemp,apememp,dniemp,fecemp,diremp,telemp,celemp,coremp,sexemp,usuemp,claemp,estemp,coddis,codrol,codsex,codtipd)
values ('Mario Antonio', 'Huapalla','Morales','41526332','1982-02-17','Av. Luis Braille 1450','4253524','963258741',
'mhuapalla@gmail.com','Masculino','mhuapalla','123456',1,15,1,1,1);
go

select * from empleado
go

-- cliente
-- creamos la tabla cliente
create table cliente(
codcli int primary key identity(1,1),
nomcli varchar(40)  not null,
apepcli varchar(30)  not null,
apemcli varchar(30)  not null,
dnicli varchar(8) not null,
feccli date not null,
dircli varchar(50)  not null,
telcli varchar(7) not null,
celcli varchar(9) not null,
corcli varchar(40)  not null,
sexcli varchar(9) not null,
estcli bit not null,
coddis int not null,
codsex int not null,
codtipd int not null,
foreign key (coddis) references distrito(coddis),
foreign key (codsex) references sexo(codsex),
foreign key (codtipd) references tipodocumento(codtipd)
)
go

select * from cliente
go

CREATE TABLE orden (
    codord INT PRIMARY KEY identity(1,1),
    fechaord DATETIME NOT NULL,                  -- Fecha y hora de la orden
    codcli INT NOT NULL,                         -- Cliente que realizó la orden (relación con cliente)
    codemp INT NOT NULL,                         -- Empleado que tomó la orden (relación con empleado)
    total DECIMAL(10, 2) NOT NULL DEFAULT 0.00,  -- Total de la orden
    estord BIT NOT NULL DEFAULT 1,               -- estdis de la orden (1 = Activo, 0 = Cancelada)
    FOREIGN KEY (codcli) REFERENCES cliente(codcli),
    FOREIGN KEY (codemp) REFERENCES empleado(codemp)
)
go

CREATE TABLE detalleorden (
    coddetord INT PRIMARY KEY identity(1,1),
    codord INT NOT NULL,                         -- Relación con la tabla Orden
    codplat INT NOT NULL,                        -- Relación con la tabla Plato
    cantidad INT NOT NULL,                       -- Cantidad de platos solicitados
    precio DECIMAL(10, 2) NOT NULL,            -- Subtotal por la cantidad de platos
    FOREIGN KEY (codord) REFERENCES orden(codord),
    FOREIGN KEY (codplat) REFERENCES plato(codplat)
)
go



