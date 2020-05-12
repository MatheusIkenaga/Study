const soma = function (x,y) {
    return x + y
}

const imprimirResultato = function (a, b, operacao = soma){
    console.log(operacao(a,b))
}

imprimirResultato(3,4)
imprimirResultato(3,4,soma)

imprimirResultato(3,4,function (x,y){
    return x-y
})

imprimirResultato (3,4,(x,y) => x * y) // toda arrow Function é anonima

const pessoa = {
    falar: function (){
        console.log('Opa')
    }
}

pessoa.falar()