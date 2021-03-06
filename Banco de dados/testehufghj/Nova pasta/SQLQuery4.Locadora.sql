CREATE DATABASE LOCALIZA;
GO

USE LOCALIZA;  
GO 

CREATE TABLE EMPRESA(
idEmpresa TINYINT PRIMARY KEY IDENTITY (1,1),
nomeEmpresa VARCHAR(40) NOT NULL
);
GO

DROP TABLE VEICULO
CREATE TABLE VEICULO (
idVeiculo SMALLINT PRIMARY KEY IDENTITY (1,1),
idEmpresa TINYINT FOREIGN KEY REFERENCES EMPRESA(idEmpresa),
idModelo INT FOREIGN KEY REFERENCES MODELO(idModelo),
nomeVeiculo VARCHAR(20) NOT NULL
);
GO 

CREATE TABLE MODELO(
idModelo INT PRIMARY KEY IDENTITY (1,1),
idMarca SMALLINT FOREIGN KEY REFERENCES MARCA(idMarca),
modeloVeiculo VARCHAR(1000) NOT NULL
);
GO 

CREATE TABLE MARCA(
idMarca SMALLINT PRIMARY KEY IDENTITY (1,1),
marcaVeiculo VARCHAR(50) NOT NULL
);
GO 