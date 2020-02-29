//funcao sem retorno

function imprimirSoma(a, b){
    console.log(a + b)
}

imprimirSoma(2,3)
imprimirSoma(2) // 2 + undefined
imprimirSoma(2,3,4,5,6,7,8) // soma os 2 primeiros e ignora o resto
imprimirSoma() // undefined + undefined

function soma (a, b=0){
    return a + b
}
console.log(soma(2,3))
console.log(soma(2)) // 2 + 0 (predefinido na funcao)

