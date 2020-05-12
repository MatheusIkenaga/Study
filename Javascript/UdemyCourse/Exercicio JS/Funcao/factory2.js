// Minha tentativa de fazer o exercicio

/*Criar uma funcao factory que retorna um produto
Passando os parametros de nome e preco
O produto deve ter um desconto fixo */

function criarMeuProduto(nomeProd,precoProd){
    return{
        nome: nomeProd,
        preco: precoProd,
        desconto: (precoProd/100)*5
    }
}
console.log(criarMeuProduto('MacBook',2500))

//FUNCIONOU!!!!

/*----------------------------------------- */

function criarProduto(nome,preco){
    return{
        nome,
        preco,
        desconto: 0.1
    }
}

console.log(criarProduto('Notebook',2199.49))
console.log(criarProduto('iPad',1199.49))