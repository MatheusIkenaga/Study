let dobro = function(a){
    return 2 * a
}

// mesma escrita, apenas retira o "let" e "function"

dobro = (a) => {
    return 2 * a
}

dobro = a => 2 * a  // return é implícito

console.log(dobro(Math.PI))

let ola = function(){

    return 'Olá'
}

ola = () => 'Olá'

ola = _ => 'Olá' // possui um parametro, porém é possível passar com ele vazio (como no exemplo acima)

console.log(ola())
