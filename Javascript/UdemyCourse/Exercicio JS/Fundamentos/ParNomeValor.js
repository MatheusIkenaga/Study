//par nome/valor
const saudacao = 'Opa' // contexto léxico 1

function exec(){
    const saudacao = 'Faaala'// contexto leéico 2
    return saudacao
}

//Objetos são grupos aninhados de pares
//             nome / Valor
const Cliente = {
    nome: 'Pedro',
    idade: 32,
    peso:50,
    endereco:{
        logradouro: 'Rua Muito Legal',
        numero: 123
    }
}

console.log(saudacao)
console.log(exec())
console.log(Cliente)
