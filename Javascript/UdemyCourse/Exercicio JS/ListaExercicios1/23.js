/**
 * 23)​ Escreva um algoritmo que leia o código de um aluno e suas três notas. 
 * Calcule a média ponderada do aluno, considerando que o peso para a maior nota 
 * seja 4 e para as duas restantes, 3. Mostre o código do aluno, suas três notas, 
 * a média calculada e uma mensagem "APROVADO" se a média for maior ou igual a 5 e "REPROVADO" 
 * se a média for menor que 5. Repita a operação até que o código lido seja negativo.
 */

function media(cod,nota1,nota2,nota3){
    let maiorNota = 0
    let media = 0
    let situacao

    if(nota1 > maiorNota){
        maiorNota = nota1
        media = (nota1/4) + (nota2/3) + (nota3/3) 
    }
    if(nota2 > maiorNota){
        maiorNota = nota2
        media = (nota1/3) + (nota2/4) + (nota3/3)
    }
    if(nota3>maiorNota){
        maiorNota = nota3
        media = (nota1/3) + (nota2/3) + (nota3/4)
    }
    if(media >= 5){
        situacao = 'APROVADO'
    }else{
        situacao = 'REPROVADO'
    }

    console.log(`Código do Aluno: ${cod}`)
    console.log(`Nota 1 : ${nota1}`)
    console.log(`Nota 2 : ${nota2}`)
    console.log(`Nota 3 : ${nota3}`)
    console.log(`Média : ${media}`)
    console.log(`Situação : ${situacao}`)
}

media(123, 2.8, 6, 3.5)