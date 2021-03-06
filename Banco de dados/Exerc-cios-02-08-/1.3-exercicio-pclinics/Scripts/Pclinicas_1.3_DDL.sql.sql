CREATE DATABASE PETSHOP;
GO

USE PETSHOP;
GO


CREATE TABLE CLINICA(
idClinica TINYINT PRIMARY KEY IDENTITY (1,1),
nomeClinica VARCHAR(30) NOT NULL,
endereco VARCHAR(200) NOT NULL UNIQUE,
cnpj CHAR(14) NOT NULL UNIQUE,
razaoSocial VARCHAR(200) NOT NULL UNIQUE
);
GO

DROP TABLE razaoSocial

SELECT *FROM CLINICA

ALTER TABLE CLINICA
ADD razaoSocial VARCHAR(200) NOT NULL UNIQUE



CREATE TABLE VETERINARIO(
idVeterinario TINYINT PRIMARY KEY IDENTITY (1,1),
idClinica TINYINT FOREIGN KEY REFERENCES CLINICA(idClinica), 
nomeVeterinario VARCHAR(20) NOT NULL,
crmv CHAR(6) UNIQUE
);
GO
ALTER TABLE VETERINARIO
ADD crmv CHAR(6) UNIQUE

SELECT*FROM VETERINARIO


CREATE TABLE ATENDIMENTO(
idAtendimento SMALLINT PRIMARY KEY IDENTITY (1,1),
idVeterinario TINYINT FOREIGN KEY REFERENCES VETERINARIO(idVeterinario),
idPet SMALLINT FOREIGN KEY REFERENCES PET(idPet),
descriAtendimento VARCHAR(3000) NOT NULL,
dataAtendimento DATE NOT NULL
);
GO

SELECT * FROM PET

CREATE TABLE PET(
idPet SMALLINT PRIMARY KEY IDENTITY (1,1),
idDono TINYINT FOREIGN KEY REFERENCES DONO(idDono),
idRaca TINYINT FOREIGN KEY REFERENCES RACA(idRaca),
nomePet VARCHAR(25) NOT NULL,
dataNascimento DATE
);
GO


SELECT * FROM PET

ALTER TABLE PET 
ADD dataNascimeto DATE

CREATE TABLE DONO(
idDono TINYINT PRIMARY KEY IDENTITY (1,1),
nomeDono VARCHAR(20) NOT NULL
);
GO

CREATE TABLE RACA(
idRaca TINYINT PRIMARY KEY IDENTITY (1,1),
idTipopet TINYINT FOREIGN KEY REFERENCES TIPOPET(idTipopet),
nomeRaca VARCHAR(25) NOT NULL
);
GO

CREATE TABLE TIPOPET(
idTipopet TINYINT PRIMARY KEY IDENTITY (1,1),
nomeTipopet VARCHAR(25) NOT NULL
);
GO