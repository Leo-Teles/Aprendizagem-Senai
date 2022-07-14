INSERT INTO EMPRESA(nomeEmpresa)
VALUES ('LOCALIZA'), ('MOVIDA')

SELECT * FROM EMPRESA

INSERT INTO CLIENTE(nomeCliente, cpfCliente)
VALUES ('LEONARDO', '234'), ('TELES', '432')

INSERT INTO MARCA (marcaVeiculo)
VALUES ('TOYOTA'), ('NISSAN'), ('MAZDA')

SELECT * FROM MARCA

INSERT INTO MODELO (modeloVeiculo,idMarca)
VALUES ('SUPRA MK4', '1'), ('SKYLINE R34', '2'), ('MADZA R7','3')

SELECT * FROM MODELO

INSERT INTO VEICULO (idVeiculo, placaVeiculo, idModelo, idMarca, idEmpresa)
VALUES ('1','123','2','1','3'), ('2','321','1','2','1'), ('3','312','3','3','2')

SELECT * FROM VEICULO
 
INSERT INTO ALUGUEL (idVeiculo, dataAluguel, idCliente)
VALUES ('2', '2021-09-10','7'), ('1', '2021-09-15','6')

SELECT * FROM ALUGUEL
