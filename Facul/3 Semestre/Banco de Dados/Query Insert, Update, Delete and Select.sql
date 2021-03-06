USE DS23N;

CREATE TABLE CLIENTE
(CD_CLI INT NOT NULL UNIQUE,
NM_CLI VARCHAR(40),
RG_CLI CHAR(11),
CPF_CLI CHAR(12),
CEP_RES_CLI CHAR (9),
NUM_RES_CLI NUMERIC(6),
UF_RES_CLI CHAR (2),
PRIMARY KEY(CD_CLI));

CREATE TABLE PROJETO
(CD_PROJ INT NOT NULL UNIQUE,
NM_PROJ VARCHAR (50),
DT_ENCOM DATE,
DT_ENTREGA DATE,
VL_PROJ NUMERIC(9,2), /*7 numeros inteiros e 2 decimais(9 ao todo, reservando 2 para decimais)*/
CD_CLI_ENC INT,
PRIMARY KEY(CD_PROJ),
CONSTRAINT ENCOMENDA FOREIGN KEY(CD_CLI_ENC)REFERENCES CLIENTE (CD_CLI));


/*----------<<<<<<<<<<APRENDENDO INSERT>>>>>>>>>>-----------*/


USE DS23N
INSERT INTO CLIENTE(CD_CLI,NM_CLI,CPF_CLI) VALUES


(1,'Mauro canet�o no boga',123456789-00),
(2,'Luiz',098765432-11),
(3,'Willans', 111222333-44);
(4,'Juliana',098765432-11);


/* FIZ MERDA AQUI, DEI UPDATE PRA CONCERTAR 

UPDATE CLIENTE
SET NM_CLI = 'Mauro canet�o no boga', CPF_CLI='123456789-00'
WHERE CD_CLI = 2
SET NM_CLI = 'Luiz', CPF_CLI='098765432-11'
WHERE CD_CLI = 2
SET CPF_CLI='098765432-11'
WHERE CD_CLI = 4

--(2,'Luiz','098765432-11'),
--(3,'Willans', '111222333-44');

SELECT *FROM CLIENTE */




/*----------<<<<<<<<<<APRENDENDO DELETE>>>>>>>>>>-----------*/

DELETE FROM CLIENTE WHERE CD_CLI = 2;

SELECT * FROM CLIENTE;



/*----------<<<<<<<<<<APRENDENDO UPDATE>>>>>>>>>>-----------*/

UPDATE CLIENTE SET RG_CLI = '123456789-0',CEP_RES_CLI='01001-001',UF_RES_CLI='SP'
WHERE CD_CLI = 1;

SELECT * FROM CLIENTE WHERE CD_CLI <> 1