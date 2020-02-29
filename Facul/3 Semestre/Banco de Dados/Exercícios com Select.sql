use lss_curso
select cd_fornec,nm_fornec,cnpj_fornec,fone_fornec from fornecedor 
where nm_fornec like '[ABXY][ABY]%' /*Cada chave se refere à respectiva coluna do campo
primeiro conj chaves = primeira 'coluna' de letras
segunto cong chaves = segunda 'coluna' de letras, etc */


select * from peca
select nm_peca,valor_peca from peca 
select cd_peca,nm_peca,valor_peca from peca where valor_peca >100.00

/* Relacionar código, nome da peca com valor superior a 100 r aquisição em julho de 2005 */
select cd_peca,nm_peca,dt_aquisicao from peca where (valor_peca > 100.00 and dt_aquisicao between '2005/07/01' and '2005/07/31')

select cd_peca,nm_peca,dt_aquisicao from peca where valor_peca > 100.00 and YEAR 
(dt_aquisicao) = 2005 and MONTH (dt_aquisicao)=07;

select cd_peca,nm_peca,dt_aquisicao from peca where valor_peca > 100.00 and 
(dt_aquisicao >= '2005/07/01' and dt_aquisicao <= '2005/07/31')