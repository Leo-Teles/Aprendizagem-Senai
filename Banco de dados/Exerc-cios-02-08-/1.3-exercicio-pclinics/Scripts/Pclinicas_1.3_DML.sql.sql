INSERT INTO CLINICA(nomeClinica, endereco, cnpj, razaoSocial)
VALUES ('Loko por Pets', 'Av. Barão de Limeira, 539','1235678901234', 'error')
GO

SELECT * FROM CLINICA

INSERT INTO TIPOPET(nomeTipopet)
VALUES ('Cachorro'), ('Gato')
GO

SELECT * FROM TIPOPET

INSERT INTO RACA (nomeRaca, idTipopet)
VALUES ('Poodle',1),('Labrador',1),('SRD',1),('Siamês',1);
GO

SELECT * FROM RACA

INSERT INTO DONO(nomeDono)
VALUES ('Teles'),('Leonardo');
GO

SELECT * FROM DONO

INSERT INTO PET (nomePet,dataNascimento,idRaca,idDono)
VALUES ('Paçoca','10/10/2018',1,1), ('Loli', '18/05/2017',4,1), ('Sammy',('16/06/2016'),1,2);
GO

SELECT * FROM PET

INSERT INTO VETERINARIO(nomeVeterinario,crmv,idClinica)
VALUES('Thaigo','123456',2),('Marcaum','654321',2)
GO

SELECT * FROM VETERINARIO

INSERT INTO ATENDIMENTO (descriAtendimento,dataAtendimento,idVeterinario,idPet)
VALUES('Restam 10 dias de vida',GETDATE(),5,1),
      ('Paciente ta está bem',GETDATE(),6,2),
	  ('Paciente está otimo', GETDATE(),5,1);
GO

SELECT * FROM ATENDIMENTO
      


