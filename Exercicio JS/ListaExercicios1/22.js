/**
 * 22)​ Criar uma função para calcular o valor a ser pago de anuidade de uma associação. 
 * A função recebe comoparâmetro um inteiro que representa o mês (1 - janeiro, 2 - fevereiro...) 
 * que foi paga e o valor da anuidade. A anuidade deve ser paga no mês de janeiro. Por mês, é cobrado 5% de juros 
 * (sob o regime de juros compostos). O retorno deve ser o valor a ser pago para o respectivo mês escolhido.
 */


 /* 
M: montante
C: capital
i: taxa de juros
t: tempo de aplicação

JUROS COMPOSTOS:   M = C * (1 + i)t
*/

 function anuidade(mes, valor){
    if(mes > 12 && mes< 0){
        return `Mês inválido`
    }else{
        let atraso = mes - 1
        return `Valor a ser pago de anuidade: R$ ${ (valor * ((1+ (5/100))**atraso)).toFixed(2)}`
    }
 }

 console.log(anuidade(4, 100))