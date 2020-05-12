/**
 * 17)​ Um funcionário irá receber um aumento de acordo com o seu plano de trabalho, de acordo com a tabela abaixo:
 * __________________________
 * |   Plano   |  Aumento   |
 * ==========================
 * |     A     |     10%    |
 * --------------------------
 * |     B     |     15%    |
 * --------------------------
 * |     C     |     20%    |
 * __________________________ 
 * 
 * Faça uma função que leia o plano de trabalho e o salário atual de um funcionário e calcula e imprime o seunovo salário. 
 * Use a estrutura switch e faça um caso default que indique que o plano é inválido.
 */

function calcSalario(plano, salario){
    switch(plano){
        case 'A':
            console.log(`Plano: ${plano}; Novo salário: ${salario* 1.10}`)
            break
        case 'B':
            console.log(`Plano: ${plano}; Novo salário: ${salario * 1.15}`)
            break
        case 'C':    
            console.log(`Plano: ${plano}; Novo salário: ${salario * 1.20}`)
            break
        default:
            console.log('Plano inválido')
    }
}

calcSalario('A',1000)
calcSalario('B', 10000)
calcSalario('C',100)
calcSalario('Z',987)