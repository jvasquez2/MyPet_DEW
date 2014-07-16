create database  mypet
go
use mypet

/**************CIUDAD , DISTRITO , PAIS, , SEXO, TIPO_USER****************/
create table distrito (
id_distrito char(5) primary key,
descripcion_dist varchar(50)
);
select * from distrito;

INSERT INTO distrito
VALUES(1,'Surco');


create table ciudad (
id_ciudad char(5) primary key,
descripcion_ciu varchar(50)
);
select * from ciudad;

INSERT INTO ciudad
VALUES(1,'Lima');

create table tipo_usuario(
tipo_usuario char(5) primary key,
descrip_usuario varchar(50),
);
select * from tipo_usuario;
INSERT INTO tipo_usuario
VALUES(1,'Recepcionista');
INSERT INTO tipo_usuario
VALUES(2,'Usuario');

create table pais(
id_pais char(5) primary key,
descrip_pais varchar(50),
);

select * from pais;

INSERT INTO pais
VALUES(1,'Peru');
INSERT INTO pais
VALUES(2,'Argentina'); 

create table sexo(
id_sexo char(5) primary key,
descrip_sexo varchar(50),
);

INSERT INTO sexo
VALUES(1,'Masculino');
INSERT INTO sexo
VALUES(2,'Femenino');

select * from sexo;


create table cliente (
id_cliente char(5) primary key,
email varchar(50) not null,
contrasena varchar(50) not null,
nombre varchar(50),
apellidoPat varchar(50),
apellidoMat varchar(50),
dni varchar(50),
id_sexo char(5) not null,
foreign key (id_sexo) references sexo(id_sexo),
id_pais char(5) not null,
foreign key (id_pais) references pais(id_pais),
id_ciudad char(5) not null,
foreign key (id_ciudad) references ciudad(id_ciudad),
id_distrito char(5) not null,
foreign key (id_distrito) references distrito(id_distrito),
direccion varchar(50),
referencia_direccion varchar(50), 
telefono varchar(50),
tipo_usuario char(5) not null,
foreign key (tipo_usuario) references tipo_usuario(tipo_usuario),
);

select * from cliente;

INSERT INTO cliente
VALUES(223,'juan@hotmail.com','123','juan','perez','perez','dni',1,1,1,1,'direccion','referencia','7777777',1);

/*********************RAZA - TAMAÑO - MASCOTA*/
create table raza (
id_raza char(5) primary key,
descripcion_raza varchar(50)
);

INSERT INTO raza
VALUES(1,'Pastor Aleman');

select * from raza;


create table tamaño (
id_tamaño char(5) primary key,
descripcion_tamaño varchar(50)
);

INSERT INTO tamaño
VALUES(1,'Pequeño');

select * from tamaño;

create table mascota (
id_mascota char(5) primary key,
nombre_mascota varchar(50),
fecha_nac varchar(50),
id_raza char(5) not null,
foreign key (id_raza) references raza(id_raza),
id_tamaño char(5) not null,
foreign key (id_tamaño) references tamaño(id_tamaño),
id_cliente char(5) not null,
foreign key (id_cliente) references cliente(id_cliente),
);

INSERT INTO mascota
VALUES(100,'FIDO','12/12/2012',1,1,223);

select * from mascota;