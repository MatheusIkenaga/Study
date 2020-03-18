function pedido (cod,quant){
    switch(cod){
        case 100:
            console.log(`Cachorro Quente - ${quant} unidade(s) = R$ ${(quant * 3).toFixed(2).toString().replace('.',',')}`)
            break
        case 200:
            console.log(`Hambúrguer Simples - ${quant} unidade(s) = R$ ${(quant * 4).toFixed(2).toString().replace('.',',')}`)
            break
        case 300:
            console.log(`Cheeseburguer - ${quant} unidade(s) = R$ ${(quant * 5.5).toFixed(2).toString().replace('.',',')}`)
            break
        case 400: 
            console.log(`Bauru - ${quant} unidade(s) = R$ ${(quant * 7.5).toFixed(2).toString().replace('.',',')}`)
            break
        case 500:
            console.log(`Refrigerante - ${quant} unidade(s) = R$ ${(quant * 3.5).toFixed(2).toString().replace('.',',')}`)
            break
        case 600:
            console.log(`Suco - ${quant} unidade(s) = R$ ${(quant * 2.8).toFixed(2).toString().replace('.',',')}`)
            break
        default:
            console.log(`Código Inválido`)
    }
}

pedido(100,1)
pedido(200,1)
pedido(300,1)
pedido(400,1)
pedido(500,1)
pedido(600,1)
pedido(700,1)

