/**
 * 14)​Crie uma estrutura condicional switch que receba uma string com o nome de uma fruta e que possua trêscasos: 
 * Caso maçã, retorne no console: “Não vendemos esta fruta aqui”. Caso kiwi, retorne: “Estamos comescassez de kiwis”. 
 * Caso melancia, retorne: “Aqui está, são 3 reais o quilo”. Teste com estas três opções .Crietambém um default, que 
 * retornará uma mensagem de erro no console.
 */

 function fruta(fruta){
    switch(fruta){
        case("Maçã"):
            console.log('Não vendemos esta fruta aqui')
            break;
        case("Kiwi"):
            console.log('Estamos comescassez de kiwis')
            break;
        case("Melancia"):
            console.log("Aqui está, são 3 reais o quilo")
            break;
        default:
            console.log("Opção inválida")
            break;
    }
}

fruta('Maçã')
fruta('Kiwi')
fruta('Melancia')
fruta('Pera')