
USE GER_FROTAS;
GO

CREATE TABLE MOTORISTA
(	CD_MOTORISTA INT NOT NULL,
	NM_MOTORISTA CHAR (80),
	DT_NASC_MOTORISTA DATETIME,
	CPF_MOTORISTA CHAR(11),
	RG_MOTORISTA CHAR(10),
	CNH_MOTORISTA CHAR (12) NOT NULL,
	VAL_CNH_MOTORISTA DATETIME NOT NULL,
	OBS_MOTORISTA varchar(120),
PRIMARY KEY (CD_MOTORISTA))
GO


CREATE TABLE VEICULO
(	CD_VEICULO INT NOT NULL,
	MARCA_VEICULO varchar (15),
	COR_VEICULO varchar (20),
	ANO_VEICULO int,
	MODELO_VEICULO int,
	TIPO_VEICULO varchar (20),
	HODOM_VEICULO NUMERIC(8),
	PLACA_VEICULO varchar (8),
	STATUS_VEICULO int,
	MANUTENCAO_VEICULO int,
	OBS_VEICULO varchar (120),
	SEGURO_VEICULO int,
PRIMARY KEY (CD_VEICULO))
GO

CREATE TABLE SEGURO
(	CD_SEGURO INT NOT NULL,
	CD_VEICULO_SEGURO INT NOT NULL,
	VALOR_SEGURO NUMERIC (7,2),
PRIMARY KEY (CD_SEGURO),
CONSTRAINT VEICULO_SEGURO FOREIGN KEY (CD_VEICULO_SEGURO) REFERENCES VEICULO (CD_VEICULO))
GO

CREATE TABLE FORNECEDOR
(	CD_FORNEC int NOT NULL,
	END_FORNEC varchar (120),
	OBS_FORNEC varchar (120),
PRIMARY KEY (CD_FORNEC))
GO

CREATE TABLE PECAS
(	CD_PECA int NOT NULL,
	NOME_PECA varchar (40),
	QTD_PECA int,
	VALOR_PECA NUMERIC (7,2),
 	CD_FORNEC_PECA INT NOT NULL,
PRIMARY KEY (CD_PECA),
CONSTRAINT FORNEC_PECA FOREIGN KEY (CD_FORNEC_PECA) REFERENCES FORNECEDOR (CD_FORNEC))
GO

CREATE TABLE GER_FROTA_VIAGEM
(	CD_VIAGEM int NOT NULL,
	ORIGEM_VIAGEM varchar (150),
	EST_ORIGEM_VIAGEM varchar (50),
	DEST_VIAGEM varchar (150),
	EST_DEST_VIAGEM varchar (50),
	KM_VIAGEM NUMERIC (5),
	TIPO_VIAGEM varchar (50),
	MOTIVO_VIAGEM varchar (20),
	VALOR_VIAGEM NUMERIC (7,2),
	OBS_VIAGEM varchar (120),
	CD_MOTORISTA_VIAGEM INT NOT NULL,
	CD_VEICULO_VIAGEM INT NOT NULL,
PRIMARY KEY (CD_VIAGEM),
CONSTRAINT MOTORISTA_VIAGEM FOREIGN KEY (CD_MOTORISTA_VIAGEM) REFERENCES MOTORISTA (CD_MOTORISTA),
CONSTRAINT VEICULO_VIAGEM FOREIGN KEY (CD_VEICULO_VIAGEM) REFERENCES VEICULO (CD_VEICULO))
GO


CREATE TABLE ALUG_VEIC_VIAGEM
(	CD_VIAGEM int NOT NULL,
	KM_VIAGEM NUMERIC (5),
	MOTIVO_VIAGEM varchar (20),
	VALOR_VIAGEM NUMERIC (7,2),
	OBS_VIAGEM varchar (120),
	CD_MOTORISTA_VIAGEM INT NOT NULL,
	CD_VEICULO_VIAGEM INT NOT NULL,
PRIMARY KEY (CD_VIAGEM),
CONSTRAINT MOTORISTA_VIAGEM_ALUG FOREIGN KEY (CD_MOTORISTA_VIAGEM) REFERENCES MOTORISTA (CD_MOTORISTA),
CONSTRAINT VEICULO_VIAGEM_ALUG FOREIGN KEY (CD_VEICULO_VIAGEM) REFERENCES VEICULO (CD_VEICULO))
GO

CREATE TABLE GER_FROTA_ABASTE
(	CD_ABASTE INT NOT NULL, 
	CD_VEICULO_ABASTE INT NOT NULL,
	VALOR_ABASTE NUMERIC (7,2),
	TIPO_COMBUSTIVEL varchar (40),
PRIMARY KEY (CD_ABASTE),
CONSTRAINT VEICULO_ABASTE FOREIGN KEY (CD_VEICULO_ABASTE) REFERENCES VEICULO (CD_VEICULO))
GO

CREATE TABLE GER_FROTA_BO
(	CD_BO INT NOT NULL,
	CD_VEICULO_BO INT NOT NULL,
	CD_MOTORISTA_BO INT NOT NULL,
	EST_BO varchar (50),
	CIDADE_BO varchar (50),
PRIMARY KEY (CD_BO),
CONSTRAINT VEICULO_BO FOREIGN KEY (CD_VEICULO_BO) REFERENCES VEICULO (CD_VEICULO),
CONSTRAINT MOTORISTA_BO FOREIGN KEY (CD_MOTORISTA_BO) REFERENCES MOTORISTA (CD_MOTORISTA))
GO

CREATE TABLE ALUG_VEIC_BO
(	CD_BO INT NOT NULL,
	CD_VEICULO_BO INT NOT NULL,
	CD_MOTORISTA_BO INT NOT NULL,
	EST_BO varchar (50),
	CIDADE_BO varchar (50),
PRIMARY KEY (CD_BO),
CONSTRAINT VEICULO_BO_ALUG FOREIGN KEY (CD_VEICULO_BO) REFERENCES VEICULO (CD_VEICULO),
CONSTRAINT MOTORISTA_BO_ALUG FOREIGN KEY (CD_MOTORISTA_BO) REFERENCES MOTORISTA (CD_MOTORISTA))
GO

CREATE TABLE GER_FROTA_MANUTE
(	CD_MANUTE INT NOT NULL,
	CD_VEICULO_MANUTE INT NOT NULL,
	TP_MANUTE varchar (30),
	VALOR_MANUTE NUMERIC (7,2),
PRIMARY KEY (CD_MANUTE),
CONSTRAINT VEICULO_MANUTE FOREIGN KEY (CD_VEICULO_MANUTE) REFERENCES VEICULO (CD_VEICULO))
GO

CREATE TABLE ALUG_VEIC_MANUTE
(	CD_MANUTE INT NOT NULL,
	CD_VEICULO_MANUTE INT NOT NULL,
	TP_MANUTE varchar (30),
	VALOR_MANUTE NUMERIC (7,2),
PRIMARY KEY (CD_MANUTE),
CONSTRAINT VEICULO_MANUTE_ALUG FOREIGN KEY (CD_VEICULO_MANUTE) REFERENCES VEICULO (CD_VEICULO))
GO

CREATE TABLE GER_FROTA_MULTAS
(	CD_MULTA INT NOT NULL,
	CD_VEICULO_MULTA INT NOT NULL,
	CD_MOTORISTA_MULTA INT NOT NULL,
	DT_MULTA datetime,
	LOCAL_MULTA varchar (120),
	VALOR_MULTA NUMERIC (7,2),
PRIMARY KEY (CD_MULTA),
CONSTRAINT VEICULO_MULTA FOREIGN KEY (CD_VEICULO_MULTA) REFERENCES VEICULO (CD_VEICULO),
CONSTRAINT MOTORISTA_MULTA FOREIGN KEY (CD_MOTORISTA_MULTA) REFERENCES MOTORISTA (CD_MOTORISTA))
GO

CREATE TABLE ALUG_VEIC_MULTAS
(	CD_MULTA INT NOT NULL,
	CD_VEICULO_MULTA INT NOT NULL,
	CD_MOTORISTA_MULTA INT NOT NULL,
	DT_MULTA datetime,
	LOCAL_MULTA varchar (120),
	VALOR_MULTA NUMERIC (7,2),
PRIMARY KEY (CD_MULTA),
CONSTRAINT VEICULO_MULTA_ALUG FOREIGN KEY (CD_VEICULO_MULTA) REFERENCES VEICULO (CD_VEICULO),
CONSTRAINT MOTORISTA_MULTA_ALUG FOREIGN KEY (CD_MOTORISTA_MULTA) REFERENCES MOTORISTA (CD_MOTORISTA))
GO

CREATE TABLE GER_FROTA_FINANCAS
(	CD_FINANCA INT NOT NULL,
	VALOR_MULTA NUMERIC (7,2) NOT NULL,
	VALOR_MANUTE NUMERIC (7,2) NOT NULL,
	VALOR_VIAGEM NUMERIC (7,2) NOT NULL,
	CD_SEGURO_FINANCA INT NOT NULL,
	CD_PECA_FINANCA INT NOT NULL,
	CD_VIAGEM_FINANCA INT NOT NULL,
	CD_ABASTE_FINANCA INT NOT NULL,
	CD_MANUTE_FINANCA INT NOT NULL,
	CD_MULTA_FINANCA INT NOT NULL,
PRIMARY KEY (CD_FINANCA),
CONSTRAINT VLR_SEG FOREIGN KEY (CD_SEGURO_FINANCA) REFERENCES SEGURO (CD_SEGURO),
CONSTRAINT VLR_PECA FOREIGN KEY (CD_PECA_FINANCA) REFERENCES PECAS (CD_PECA),
CONSTRAINT VLR_VIAGEM FOREIGN KEY (CD_VIAGEM_FINANCA) REFERENCES GER_FROTA_VIAGEM (CD_VIAGEM),
CONSTRAINT VLR_MANUT FOREIGN KEY (CD_MANUTE_FINANCA) REFERENCES GER_FROTA_MANUTE(CD_MANUTE),
CONSTRAINT VLR_MULTA FOREIGN KEY (CD_MULTA_FINANCA) REFERENCES GER_FROTA_MULTAS (CD_MULTA),
CONSTRAINT VLR_ABASTE FOREIGN KEY (CD_ABASTE_FINANCA) REFERENCES GER_FROTA_ABASTE(CD_ABASTE))
GO

CREATE TABLE ALUG_VEIC_FINANCAS
(	CD_FINANCA INT NOT NULL,
	VALOR_MULTA NUMERIC (7,2) NOT NULL,
	VALOR_MANUTE NUMERIC (7,2) NOT NULL,
	VALOR_VIAGEM NUMERIC (7,2) NOT NULL,
	CD_SEGURO_FINANCA INT NOT NULL,
	CD_PECA_FINANCA INT NOT NULL,
	CD_VIAGEM_FINANCA INT NOT NULL,
	CD_MANUTE_FINANCA INT NOT NULL,
	CD_MULTA_FINANCA INT NOT NULL,
PRIMARY KEY (CD_FINANCA),
CONSTRAINT VLR_SEG_ALUG FOREIGN KEY (CD_SEGURO_FINANCA) REFERENCES SEGURO (CD_SEGURO),
CONSTRAINT VLR_PECA_ALUG FOREIGN KEY (CD_PECA_FINANCA) REFERENCES PECAS (CD_PECA),
CONSTRAINT VLR_VIAGEM_ALUG FOREIGN KEY (CD_VIAGEM_FINANCA) REFERENCES ALUG_VEIC_VIAGEM(CD_VIAGEM),
CONSTRAINT VLR_MULTA_ALUG FOREIGN KEY (CD_MULTA_FINANCA) REFERENCES ALUG_VEIC_MULTAS (CD_MULTA),
CONSTRAINT VLR_MANUT_ALUG FOREIGN KEY (CD_MANUTE_FINANCA) REFERENCES GER_FROTA_MANUTE(CD_MANUTE))
GO

CREATE TABLE GER_FROTA_SINISTRO
(	CD_SINISTRO INT NOT NULL, 
	CD_VEICULO_SINISTRO INT NOT NULL, 
	CD_MOTORISTA_SINISTRO INT NOT NULL, 
	CD_SEGURO_SINISTRO INT NOT NULL,
PRIMARY KEY (CD_SINISTRO),
CONSTRAINT VEICULO_SINISTRO FOREIGN KEY (CD_VEICULO_SINISTRO) REFERENCES VEICULO (CD_VEICULO),
CONSTRAINT MOTORISTA_SINISTRO FOREIGN KEY (CD_MOTORISTA_SINISTRO) REFERENCES MOTORISTA (CD_MOTORISTA),
CONSTRAINT SEGURO_SINISTRO FOREIGN KEY (CD_SEGURO_SINISTRO) REFERENCES SEGURO (CD_SEGURO))
GO

CREATE TABLE ALUG_VEIC_SINISTRO
(	CD_SINISTRO INT NOT NULL, 
	CD_VEICULO_SINISTRO INT NOT NULL, 
	CD_MOTORISTA_SINISTRO INT NOT NULL, 
	CD_SEGURO_SINISTRO INT NOT NULL,
PRIMARY KEY (CD_SINISTRO),
CONSTRAINT VEICULO_SINISTRO_ALUG FOREIGN KEY (CD_VEICULO_SINISTRO) REFERENCES VEICULO (CD_VEICULO),
CONSTRAINT MOTORISTA_SINISTRO_ALUG FOREIGN KEY (CD_MOTORISTA_SINISTRO) REFERENCES MOTORISTA (CD_MOTORISTA),
CONSTRAINT SEGURO_SINISTRO_ALUG FOREIGN KEY (CD_SEGURO_SINISTRO) REFERENCES SEGURO (CD_SEGURO))
GO

CREATE TABLE COMPRAS
(	CD_COMPRA INT NOT NULL,
	DT_COMPRA DATETIME,
	NF_COMPRA NUMERIC (30),
	CHAVE_ACESSO_COMPRA VARCHAR (120),
	VALOR_COMPRA NUMERIC (7,2),
	CD_PECA_COMPRA INT NOT NULL,
PRIMARY KEY (CD_COMPRA),
CONSTRAINT COMPRA FOREIGN KEY (CD_PECA_COMPRA) REFERENCES PECAS (CD_PECA))
GO