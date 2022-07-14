INSERT INTO album(tituloAlbum, quantMusicas)
VALUES ('Mil tretas,mil fitas','14'),('Perpose','13')

INSERT INTO estilo(nomeEstilo)
VALUES ('rap'),('Pop')

INSERT INTO estiloAlbum(idEstilo,idAlbum)
VALUES (1,1),(2,2)

INSERT INTO permissao(nomePermissao)
VALUES ('Usuário comum'),('Usuário administrador')

INSERT INTO usuario(nomeUsuario,email,senha,idPermissao)
VALUES ('Teles','T.teles@email.com','123',2),('Leonardo','L.leonarod@email.com','321',2)

INSERT INTO artista(idEstiloalbum,nomeArtista,idUsuario)
VALUES (1,'Racionais',1),(2,'Justin Bieber'2)

INSERT INTO cadastro(idArtista,idUsuario)
VALUES (1,NULL),(2,NULL),(NULL,1),(NULL,2)

INSERT INTO empresa(idCadastro)
VALUES (1),(2),(3),(4)





