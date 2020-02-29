select * from CLIENTE

insert into CLIENTE values(2,'Matheus', 389547520,'434339228-70',null,null,'SP')

select nm_cli, cd_cli, cpf_cli, rg_cli from CLIENTE where NM_CLI like 'M%'


select nm_cli, cd_cli, cpf_cli,rg_cli from CLIENTE where CONVERT(varchar, CD_CLI) like '1%'

select top 0 nm_cli, cd_cli from CLIENTE