/* AULA SOBRE "JOIN" QUE � PARA RELACIONAR TABELAS

INNER JOIN = INTERSEC��O DE A COM B
LEFT OUTER JOIN = A + INTERSEC��O DE A COM B
RIGHT OUTER JOIN = B + INTERSEC��O DE A COM B
FULL OUTER JOIN = A + B + INTERSEC��O DE A COM B*/

/* 1 -QUAIS S�O OS PROJETOS ENCOMENDADOS PELOS CLIENTES?*/

select * from cliente c inner join projeto 
		   on cd_cliente = cd_cliente_encom
		   
		   
/*----------------------------------------------------------
2- QUAIS S�O OS PROJETOS ENCOMENDADOS PELO CLIENTE "ANTONIO"*/
select * from cliente inner join projeto 
		   on cd_cliente = cd_cliente_encom 
		where nm_cliente like 'Antonio%'
		
/*  OU   */

select * from cliente inner join projeto
		   on cd_cliente = cd_cliente_encom
		   and nm_cliente like 'Antonio%'
		
/*----------------------------------------------------------
3- QUAIS S�O OS PROJETOS ENCOMENDADOS PELO CLIENTE "ANTONIO"
    E RELACIONAR AS PE�S DE CADA PROJETO
DESENHO = CLIENTE -{ PROJETO -{ UTILIZACAO }-PECA  */

SELECT * FROM CLIENTE 
INNER JOIN projeto
ON cd_cliente = cd_cliente_encom
INNER JOIN utilizacao 
ON cd_proj = cd_proj_usa
INNER JOIN peca 
ON cd_peca_usa = cd_peca
WHERE nm_cliente LIKE 'Antonio%'

/*----------------------------------------------------------
   4- RELACIONAR AS PE�AS UTILIZADAS NOS PROJETOS*/

SELECT * FROM projeto
INNER JOIN utilizacao
ON cd_proj = cd_proj_usa
INNER JOIN peca
ON cd_peca_usa = cd_peca

/*----------------------------------------------------------

------------------------------------------------------------
					UNION
------------------------------------------------------------*/

/*UNION SERVE PARA UNIR DUAS TABELAS NO MESMO RESULTADO*/

SELECT * FROM CLIENTE;
SELECT * FROM FORNECEDOR;

/*COM UNION*/

SELECT * FROM CLIENTE
UNION
SELECT * FROM fornecedor
