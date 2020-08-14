create database sindicatoPF;
use sindicatoPF;


create table Rol (
id_rol int identity (1,1) primary key,
nombre varchar (50) not null unique
);

create table Usuario(
id_usuario int identity (1,1) primary key,
nombre varchar (100) not null,
clave varchar (100)not null,
id_rol int not null,
foreign key (id_rol) references Rol (id_rol)
);
create table Categoria(
id_categoria int identity (1,1) primary key,
numero_categoria int not null
);
create table Planta(
id_planta int identity (1,1) primary key,
nombre varchar (100) not null
);

create table Socio (
rut_socio varchar (100) primary key,
imagen image not null,
nombre_socio varchar (500) not null,
fecha_ingreso datetime Default Getdate(),
id_categoria int not null,
tipo_contrato varchar (100) not null,
id_planta int not null,
fecha_nacimiento datetime Default Getdate(),
edad int not null,
domicilio varchar (500) not null,
estado_civil varchar (500) not null,
telefono int not null,
nacionalidad varchar (100) not null,
correo varchar (200) not null,
datos_papa varchar (500) not null,
datos_mama varchar (500) not null,
foreign key (id_categoria) references Categoria (id_categoria),
foreign key (id_planta) references Planta (id_planta)
);

create table socioEliminado (
rut varchar (500) primary key not null,
nombre varchar (500) not null,
categoria int not null,
fechaIngreso datetime not null,
planta varchar (100) not null
);

create table Conyuge (
id_conyuge int identity (1,1) primary key,
nombre varchar (500) not null,
conviviente varchar (50) not null,
rut varchar (100) not null,
nacimiento datetime Default Getdate(),
edad int not null,
rut_socio varchar (100) not null,
foreign key (rut_socio) references Socio (rut_socio)
);

create table Hijo (
id_hijo int identity (1,1) primary key,
nombre varchar (500) not null,
rut_hijo varchar (100) not null,
sexo varchar (100) not null,
nacimiento datetime Default Getdate(),
rut_socio varchar (100) not null,
foreign key (rut_socio) references Socio (rut_socio)
);

insert Rol(nombre) values ('Administrador');
insert Rol(nombre) values ('Visita');
insert Usuario (nombre,clave,id_rol) values ('Dario','1234',1);
insert Usuario (nombre,clave,id_rol) values ('PapaDario','1234',2);

insert Categoria(numero_categoria) values (1);
insert Categoria(numero_categoria) values (2);
insert Categoria(numero_categoria) values (3);
insert Categoria(numero_categoria) values (4);
insert Categoria(numero_categoria) values (5);
insert Categoria(numero_categoria) values (6);

insert Planta (nombre) values ('planta 1');
insert Planta (nombre) values ('planta 2');
insert Planta (nombre) values ('planta 3');
insert Planta (nombre) values ('planta 4');
insert Planta (nombre) values ('CDT');
insert Planta (nombre) values ('planta pizza');
insert Planta (nombre) values ('planta carnico');

create procedure user_listar as select * from Usuario;
exec user_listar;

select imagen from Socio where;
select * from Conyuge;
select * from Socio;
select * from Hijo;