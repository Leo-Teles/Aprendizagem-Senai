INSERT INTO PESSOA (nomePessoa)
VALUES ('LEONARDO'), ('TELES')

SELECT * FROM PESSOA

INSERT INTO TELEFONE (idPessoa,numeroTelefone)
VALUES (1,'9356'), (1,'9848'), (2,'9736') 

SELECT * FROM TELEFONE

INSERT INTO EMAIL (idPessoa,end_email)
VALUES (1,'L.leonardo@email.com'),
       (2,'T.teles@email.com')

SELECT * FROM EMAIL

INSERT INTO CNH (idPessoa,descricao)
VALUES (1, '1234'), (2,'4321')

SELECT * FROM CNH