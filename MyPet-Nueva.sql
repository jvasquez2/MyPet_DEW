
drop database mypet
CREATE DATABASE mypet
GO
USE mypet
GO

CREATE TABLE tabla_postal (
  CODIGO VARCHAR(100) NOT NULL,
  DESCRIPCION VARCHAR(100) NULL,
  PRIMARY KEY (CODIGO)
);

CREATE TABLE sexo (
  ID INT NOT NULL IDENTITY(1,1),
  DESCRIPCION VARCHAR(45) NULL,
  PRIMARY KEY (ID)
);

CREATE TABLE estado (
  ID INT NOT NULL IDENTITY(1,1),
  DESCRIPCION VARCHAR(30) NULL,
  PRIMARY KEY (ID)
);


CREATE TABLE tipo_usuario (
  ID INT NOT NULL IDENTITY(1,1),
  DESCRIPCION VARCHAR(45) NULL,
  PRIMARY KEY (ID)
);

CREATE TABLE usuario (
  CODIGO VARCHAR(8) NOT NULL,
  NOMBRE VARCHAR(100) NULL,
  APELLIDO_PATERNO VARCHAR(100) NULL,
  APELLIDO_MATERNO VARCHAR(100) NULL,
  EMAIL VARCHAR(100) NULL,
  FECHA_INGRESO DATETIME NULL,
  ESTADO INT NULL,
  TIPO_USUARIOS INT NULL,
  PRIMARY KEY (CODIGO),
	FOREIGN KEY (ESTADO) REFERENCES estado(ID),
	FOREIGN KEY (TIPO_USUARIOS) REFERENCES tipo_usuario(ID)
);

CREATE TABLE cliente (
  DNI VARCHAR(8) NOT NULL,
  NOMBRE VARCHAR(100) NULL,
  APELLIDO_PATERNO VARCHAR(100) NULL,
  APELLIDO_MATERNO VARCHAR(100) NULL,
  DIRECCION VARCHAR(100) NULL,
  CODIGO_POSTAL VARCHAR(100) NULL,
  ID_SEXO INT NULL,
  EMAIL VARCHAR(100) NULL,
  TELEFONO VARCHAR(15) NULL,
  PRIMARY KEY (DNI),
	FOREIGN KEY (CODIGO_POSTAL) REFERENCES tabla_postal(CODIGO),
	FOREIGN KEY (ID_SEXO) REFERENCES sexo(ID),
	FOREIGN KEY (DNI) REFERENCES usuario(CODIGO)
);

CREATE TABLE especie (
  ID INT NOT NULL IDENTITY(1,1),
  DESCRIPCION VARCHAR(45) NULL,
  PRIMARY KEY (ID)
);


CREATE TABLE raza (
  ID_ESPECIE INT NOT NULL,
  ID INT NOT NULL,
  DESCRIPCION VARCHAR(45) NULL,
  PRIMARY KEY (ID_ESPECIE, ID),
  FOREIGN KEY (ID_ESPECIE) REFERENCES especie(ID)
);


CREATE TABLE mascota (
  DNI VARCHAR(8) NOT NULL,
  ID INT NOT NULL,
  NOMBRE VARCHAR(45) NULL,
  ID_ESPECIE INT NULL,
  ID_RAZA INT NULL,
  FECHA_NACIMIENTO DATETIME NULL,
  PRIMARY KEY (DNI, ID),
	FOREIGN KEY (ID_ESPECIE) REFERENCES Especie(ID),
	FOREIGN KEY (ID_ESPECIE , ID_RAZA) REFERENCES Raza(ID_ESPECIE , ID),
	FOREIGN KEY (DNI) REFERENCES Cliente(DNI)
);

CREATE TABLE producto (
  CODIGO VARCHAR(20) NOT NULL,
  DESCRIPCION VARCHAR(100) NULL,
  STOCK_ACTUAL INT NULL,
  STOCK_DISPONIBLE INT NULL,
  PRECIO DECIMAL(10,2) NULL,
  PRIMARY KEY (CODIGO)
);


CREATE TABLE boleta (
  NUMERO INT NOT NULL IDENTITY(1,1),
  DNI VARCHAR(8) NULL,
  RAZON_SOCIAL VARCHAR(150) NULL,
  BRUTOS DECIMAL(10,2) NULL,
  DESCUENTO DECIMAL(10,2) NULL,
  IGV DECIMAL(10,2) NULL,
  VALOR_VENTA DECIMAL(10,2) NULL,
  PRIMARY KEY (NUMERO),
  FOREIGN KEY (DNI) REFERENCES Cliente(DNI)
);

CREATE TABLE detalle_boleta (
  NUMERO INT NOT NULL,
  ID INT NOT NULL,
  CODIGO VARCHAR(20) NULL,
  DESCRIPCION VARCHAR(100) NULL,
  CANTIDAD INT NULL,
  BRUTO DECIMAL(10,2) NULL,
  DESCUENTO DECIMAL(10,2) NULL,
  IGV DECIMAL(10,2) NULL,
  VALOR_VENTA DECIMAL(10,2) NULL,
  PRIMARY KEY (NUMERO, ID),
  FOREIGN KEY (NUMERO) REFERENCES boleta(NUMERO),
  FOREIGN KEY (CODIGO) REFERENCES producto(CODIGO)
);

CREATE TABLE especialidad (
  ID INT NOT NULL IDENTITY(1,1),
  DESCRIPCION VARCHAR(100) NULL,
  PRIMARY KEY (ID)
);

CREATE TABLE medico (
  CODIGO VARCHAR(8) NOT NULL,
  NOMBRE VARCHAR(100) NULL,
  APELLIDO_PATERNO VARCHAR(100) NULL,
  APELLIDO_MATERNO VARCHAR(100) NULL,
  ID_ESPECIALIDAD INT NULL,
  FECHA_NACIMIENTO DATETIME NULL,
  PRIMARY KEY (CODIGO),
  FOREIGN KEY (ID_ESPECIALIDAD) REFERENCES especialidad(ID),
  FOREIGN KEY (CODIGO) REFERENCES usuario(CODIGO)
);

CREATE TABLE variables (
  ID INT NOT NULL,
  RAZON_SOCIAL VARCHAR(100) NULL,
  PORCENTAJE_IGV DECIMAL(3,2) NULL,
  PRIMARY KEY (ID)
);

CREATE TABLE historia_clinica (
  DNI_CLIENTE VARCHAR(8) NOT NULL,
  ID_MASCOTA INT NOT NULL,
  ID INT NOT NULL,
  CITA INT NULL,
  RECETA INT NULL,
  DESCRIPCION VARCHAR(200) NULL,
  PRIMARY KEY (ID_MASCOTA, ID),
  FOREIGN KEY (DNI_CLIENTE, ID_MASCOTA) REFERENCES mascota(DNI, ID)
);

CREATE TABLE cita (
  ID INT NOT NULL IDENTITY(1,1),
  CODIGO_MEDICO VARCHAR(8) NULL,
  DNI_CLIENTE VARCHAR(8) NULL,
  ID_MASCOTA INT NULL,
  FECHA DATETIME NULL,
  HORA VARCHAR(5) NULL,
  ESTADO INT NULL,
  PRIMARY KEY (ID),
  FOREIGN KEY (CODIGO_MEDICO) REFERENCES medico(CODIGO),
  FOREIGN KEY (DNI_CLIENTE, ID_MASCOTA) REFERENCES mascota(DNI, ID),
  FOREIGN KEY (DNI_CLIENTE) REFERENCES cliente(DNI)
);