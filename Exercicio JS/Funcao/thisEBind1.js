const pessoa= {
    saudacao: 'Bom dia',
    falar(){
        console.log(this.saudacao)
    }
}

pessoa.falar() // Exibe na tela "Bom dia", pois o this está apontando para pessoa

const falar = pessoa.falar
falar() 

// gera conflito entre paradigmas: funcional e OO
// O This está apontando para as funcoes dentro do console, por isso retorna "undefined" 
//(Não existe essa funcao no escopo global)

const falarDePessoa = pessoa.falar.bind(pessoa)
// o Bind "Amarra o This" com o que ele foi declarado na criacao da funcao
falarDePessoa()