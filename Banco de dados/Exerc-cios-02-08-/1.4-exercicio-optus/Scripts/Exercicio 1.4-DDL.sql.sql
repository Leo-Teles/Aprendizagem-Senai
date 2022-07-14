create database optus
go

use optus
go

ALTER TABLE album 
ADD quantidadeMusica TINYINT NOT NULL

create table album(
idAlbum SMALLINT PRIMARY KEY IDENTITY (1,1),
tituloAlbum VARCHAR(20) NOT NULL
quantidadeMusica TINYINT NOT NULL
);

create table estilo
idEstilo TINYINT PRIMARY KEY IDENTITY (1,1),
nomeEstilo VARCHAR (20) NOT NULL UNIQUE
);

create table estiloalbum(
idEstiloalbum INT PRIMARY KEY IDENTITY(1,1)
idEstilo TINYINT FOREIGN REFERENCES estilo(idEstilo),
idAlbum SMALLINT FOREIGN REFERENCES album(idAlbum)
);

create table permissao(
idPermissao SMALLINT PRIMARY KEY IDENTITY (1,1),
nomePermissao VARCHAR(30) NOT NULL UNIQUE
);

create table usuario (
idUsuario INT PRIMARY KEY IDENTITY(1,1),
idPermissao SMALLINT FOREIGN KEY REFERENCES permissao(idPermissao),
nomeUsuario VARCHAR(15) NOT NULL UNIQUE,
email VARCHAR(30) NOT NULL UNIQUE,
senha VARCHAR(15)
);

create table artista(
idArtista INT PRIMARY KEY IDENTITY(1,1),
idEstiloalbum INT FOREIGN KEY REFERENCES estilo(idEstiloalbum),
idPermissao SMALLINT FOREIGN KEY REFERENCES permissao(idPermissao),
nomeArtista VARCHAR(30) NOT NULL UNIQUE
);

create table cadastro(
idCadastro INT PRIMARY KEY IDENTITY(1,1),
idArtista INT FOREIGN KEY REFERENCES artista(idArtista),
idUsuario INT FOREIGN KEY REFERENCES usuario(idUsuario),
);

create table empresa(
idEmpresa TINYINT PRIMARY KEY IDENTITY(1,1)
idCadastro INT FOREIGN KEY REFERENCES cadastro(idCadastro)
);