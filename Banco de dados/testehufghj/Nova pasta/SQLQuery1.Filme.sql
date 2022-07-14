CREATE DATABASE CATALOGO;
GO

USE CATALOGO;
GO

CREATE TABLE GENERO(
idGenero TINYINT PRIMARY KEY IDENTITY(1,1),
nomeGenero VARCHAR(30)
);
GO
---Comando para analizar a tabela 
--- ALT+F1 Com a tabela selecionada 

CREATE TABLE Filme(
idFilme SMALLINT PRIMARY KEY IDENTITY (1,1),
idGenero TINYINT FOREIGN KEY REFERENCES GENERO (idGenero),
tituloFilme VARCHAR(70)
);
GO

