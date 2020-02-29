const imprimirResultado = function (nota) {
    if(nota >= 7) {
        console.log('Aprovado')
    } else {
        console.log('Reprovado')
    }

}

imprimirResultado(10)
imprimirResultado(4)
imprimirResultado('Epa!') //String no caso vai para o else por conta de nao conseguir comparar