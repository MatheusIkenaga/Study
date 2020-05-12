/**
 * 20)​ Crie um programa para informar quais e quantas notas são necessárias para entregar o mínimo de cédulas 
 * para um determinado valor informado pelo usuário considerando notas de R$ 100, R$ 50, R$ 10 e R$ 5 e R$ 1. 
 * Seu programa deve mostrar apenas as notas utilizadas. Por exemplo, ao solicitar R$18, o programa deve informar 
 * apenas a seguinte informação (note que não foram exibidas informações sobre as demais cédulas): 
 * 1 nota(s) de R$ 10. 1 nota(s) de R$ 5. 3 nota(s) de R$ 1.
 */

 function saque(valorSaque){

     let notas100 = 0
     let notas50 = 0
     let notas10 = 0
     let notas5 = 0
     let notas1 = 0
     let valorNota = retornaNota(valorSaque)
     while(valorSaque >= valorNota){
         switch(valorNota){
             case 100:
                 valorSaque -=100
                 notas100 ++
                 break
             case 50:
                 valorSaque -=50
                 notas50++
                 break
             case 10:
                 valorSaque-=10
                 notas10++
                 break
             case 5:
                 valorSaque-=5
                 notas5++
                 break
             case 1:
                 valorSaque-=1
                 notas1++
                 break
         }
         valorNota = retornaNota(valorSaque)
     }
     return elaborarResultado(notas100,notas50,notas10,notas5,notas1)
 }

 function retornaNota(valorSaque){
     if(valorSaque >= 100){
         return 100
     }else if(valorSaque >= 50){
         return 50
     }else if(valorSaque >= 10){
         return 10
     }else if(valorSaque >=5){
         return 5
     }else if (valorSaque >= 1){
         return 1
     }

 }

 function elaborarResultado(notas100, notas50, notas10, notas5, notas1){
    let resultadoFinal= ''
    if(notas100 > 0){
        resultadoFinal += `${notas100} nota(s) de R$100,00. `
    }
    if(notas50 > 0){
        resultadoFinal += `${notas50} nota(s) de R$50,00. `
    }
    if(notas10 > 0){
        resultadoFinal += `${notas10} nota(s) de R$10,00. `
    }
    if(notas5 > 0){
        resultadoFinal += `${notas5} nota(s) de R$5,00. `
    }
    if(notas1 > 0){
        resultadoFinal += `${notas1} nota(s) de R$1,00. `
    }
    return resultadoFinal
 }

console.log(saque(158))