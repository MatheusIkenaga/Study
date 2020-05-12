const peso1 = 1.0
const peso2 = Number('2.0') //as duas formas o valor fica como inteiro

console.log(peso1, peso2)
console.log(Number.isInteger(peso1))
console.log(Number.isInteger(peso2))

const avaliacao1 = 9.871
const avaliacao2 = 6.871

const total = avaliacao1 * peso1 + avaliacao2 * peso2
const media = total/(peso1 + peso2)

console.log(media.toFixed(2))  //esse (2) serve para definir quantas casas decimais irão aparecer
console.log(media.toString(2))  // esse (2) serve para converter para binário, assim como (16) para hexadecimal
console.log(typeof media)  // essas operações são todas possíveis por ser um tipo number
console.log(typeof Number) // Number maiúsculo é Função