//Closure é o escopo criado quando uma função é declarada
//Ese escopo permite a função acessar e manupular variáveis externas à função

//Contexto lécixo em ação!

const x = 'Global'

function fora(){
    const x = 'Local'
    function dentro (){
        return x
    }
    return dentro
}

const minhaFuncao = fora()
console.log(minhaFuncao())