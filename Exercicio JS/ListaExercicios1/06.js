/*
06) Elabore duas funções que recebem três parâmetros: capital inicial, taxa de juros e tempo de aplicação. A
primeira função retornará o montante da aplicação financeira sob o regime de juros simples e a segunda
retornará o valor da aplicação sob o regime de juros compostos

M: montante
C: capital
i: taxa de juros
t: tempo de aplicação

JUROS SIMPLES:     M = C + (C * i * t)

JUROS COMPOSTOS:   M = C * (1 + i)t
*/

function jurosSimples(capital, txJuros,tmpAplic){
    console.log(`Inicial: R$${capital.toFixed(2).toString().replace('.',',')}`)
    console.log(`Taxa de Juros: ${txJuros}`)
    console.log(`Tempo de Aplicação(Mês): ${tmpAplic}`)
    console.log(`Total no Fim (SIMPLES): `+ (capital + (capital * txJuros * tmpAplic)))
}
function jurosComp(capital, txJuros,tmpAplic){
    console.log(`Inicial: R$${capital.toFixed(2).toString().replace('.',',')}`)
    console.log(`Taxa de Juros: ${txJuros}`)
    console.log(`Tempo de Aplicação(Mês): ${tmpAplic}`)
    console.log(`Total no Fim (COMPOSTO): ` + (capital * (Math.pow((1 + txJuros), tmpAplic))))
}

jurosSimples(100,5/100,2)
console.log("------------------------------------")
jurosComp(100,5/100,2)