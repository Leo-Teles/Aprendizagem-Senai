SELECT * FROM album

SELECT * FROM estilo

SELECT * FROM estiloAlbum

SELECT * FROM permissao

SELECT * FROM usuario 

SELECT * FROM artista 

SELECT * FROM cadastro 

SELECT * FROM empresa 


SELECT nomeUsuario, email FROM usuario
WHERE permissao = 1;

SELECT * FROM usuario
WHERE email ='T.teles@email.com'

SELECT * FROM usuario 
WHERE senha = '123'

SELECT tituloAlbum, quantMusicas, nomeArtista, nomeEstilo FROM album
LEFT JOIN artista
ON artista.idArtista = album.idArtista
LEFT JOIN estilo
ON estilo.idEstilo = album.idEstilo

