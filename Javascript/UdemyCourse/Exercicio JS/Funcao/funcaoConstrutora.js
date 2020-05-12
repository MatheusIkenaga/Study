function Carro (velocidadeMaxima = 200, delta = 5){
    //atributo privado
    let velocidadeAtual = 0 // "let" é como se fosse um "private var"

    //metodo publico
    this.acelerar = function(){
        if (velocidadeAtual + delta <= velocidadeMaxima){
            velocidadeAtual += delta
        } else {
            velocidadeAtual = velocidadeMaxima
        }
    }

    //metodo publico
    this.getVelocidadeAtual = function(){  //"this" faz o método ficar publico
        return velocidadeAtual
    }
}

const uno = new Carro()
uno.acelerar()
console.log('Carro: UNO - Velocidade: ' + uno.getVelocidadeAtual())

const ferrari = new Carro (350, 20)
ferrari.acelerar()
ferrari.acelerar()
ferrari.acelerar()
console.log('Carro: FERRARI - Velocidade: ' + ferrari.getVelocidadeAtual())

console.log(typeof Carro)
console.log(typeof ferrari)