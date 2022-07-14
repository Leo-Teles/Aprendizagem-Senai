 INSERT INTO GENERO (nomeGenero)
 VALUES ('AÇÃO'),('ROMANCE');
 GO

 INSERT INTO GENERO (nomeGenero)
 VALUES ('COMÉDIA');
 GO

 INSERT INTO Filme (idGenero,tituloFilme)
 VALUES (1,'TOMB RAIDER'), (1,'VELOZES E FURIOSOS'),
        (3,'HITCH'), (3,'TITANIC')

INSERT INTO Filme (idGenero,tituloFilme)
VALUES (4,'FILME NOVO')

UPDATE Filme
SET tituloFilme = 'GENTE GRANDE 2'
WHERE idFilme = 5


 SELECT * FROM GENERO
 SELECT * FROM Filme

 --DELETE FROM GENERO 
 --WHERE idGenero = 2

 --UPDATE GENERO SET idGenero = 2
 --WHERE idGenero = 3