
create database ProyectoFinal

use ProyectoFinal

Select * from Empleado
Select * from Departamento
Select * from Cargo 
Select * from Nomina
Select * from Salida
Select * from Vacaciones  
Select * from Permisos
Select * from Licencia

drop table Empleado
drop table Departamento
drop table Cargo 
drop table Nomina
drop table Salida
drop table Vacaciones  
drop table Permisos
drop table Licencia

create table Empleado(

id int not null identity primary key,
Codigo_Empleado int,
Nombre varchar(20),
Apellido varchar(20),
Deparamento varchar(20),
telefono varchar(10),
Cargo varchar(20),
Fecha_de_ingreso date,
salario money,
Estado char (1) check (estado in('A','I'))
)

create table Nomina (

id int not null identity primary key,
Año char(4),
Mes char(2),
Monto_total money,
--CodigoEmpleado int
--constraint fk_Nomina_Codigo_Empleado foreign key(CodigoEmpleado) references Empleado(id)
)

--select * from Nomina
--Delete from Nomina

create view Activos as
SELECT id ,Nombre,Apellido,Fecha_de_ingreso, salario,Estado FROM Empleado WHERE Estado = 'a' ;

create view Inactivos as
SELECT id ,Nombre,Apellido,Fecha_de_ingreso, salario,Estado  FROM Empleado WHERE Estado = 'i' ;

Select * From Activos
Select * From Inactivos


--drop view Activos
--select * from Empleado
select * from calnomina

--insert into Nomina ( Monto_total)
--select  sum (salario)
--from Empleado

--insert into Nomina ( Año, mes)
--select DATEPART  (YEAR, Fecha_de_ingreso), datepart (MONTH, Fecha_de_ingreso)
--from Empleado 



--SELECT e.nombre +' '+e.apellido  
--FROM Nomina N JOIN Empleado e ON (s.idEmpleado = e.id)

create table Salida (

id int not null identity primary key,
Empleado varchar(20),
TipoDesalida char(9) check (TipoDesalida in('Renuncia','Despido','Desahucio')),
motivo varchar(50),
fechaDesalida date,
Codigo_Empleado int
CONSTRAINT FK_Salida_Codigo_Empleado FOREIGN KEY (Codigo_Empleado) REFERENCES Empleado (id)

)

--create trigger tr_Salida on Salida
--for insert as
--declare @Empleado varchar(20)
--select @Empleado=Empleado = from inserted

--insert into Empleado values (@Empleado,  )


--select * from Empleado
--Update Empleado set Estado='i' 
drop table Departamento
create table Departamento (

id int not null identity primary key,
CodigoDepatamento int,
Nombre varchar(20)
)

create table Cargo (

id int not null identity primary key,
Cargo varchar(20)
)


create table Vacaciones (

id int not null identity primary key,
Empleado varchar(20),
Desde date,
Hasta date,
correspondiente date,
Comentario varchar(20),
Codigo_Empleado int
CONSTRAINT FK_vacaciones_Codigo_Empleado FOREIGN KEY (Codigo_Empleado) REFERENCES Empleado (id)

)

create table  Permisos (

id int not null identity primary key,
Empleado varchar(20),
Desde date,
Hasta date,
Comentario varchar(50),
Codigo_Empleado int,
CONSTRAINT FK_Permisos_Codigo_Empleado FOREIGN KEY (Codigo_Empleado) REFERENCES Empleado (id)
)

create table Licencia (

id int not null identity primary key,
Empleado varchar(20),
Desde date,
Hasta date,
Motivo varchar(20),
Comentario varchar(20),
Codigo_Empleado int
CONSTRAINT FK_Licencias_Codigo_Empleado FOREIGN KEY (Codigo_Empleado) REFERENCES Empleado (id)

)




