/**
 * 26)​ Fazer um programa para encontrar todos os pares entre 1 e 100.
 */

 function pares(){
     let numero = 100
     while(numero >= 0){
         if(numero%2 == 0){
             console.log(numero)
         }
         numero--
     }
 }

 pares()