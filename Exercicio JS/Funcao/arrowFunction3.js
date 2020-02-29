let comparaComThis = function(param) {
    console.log(this=== param)
}

comparaComThis(global)

const obj = {}
comparaComThis = comparaComThis.bind(obj)

comparaComThis(global)
comparaComThis(obj)

console.log('------------------------------------')
console.log('Arrow')

let comparaComThisArrow = param => console.log(this===param) // o this é o arquivo do módulo do JS (?)
comparaComThisArrow (global)
comparaComThisArrow (module.exports)


comparaComThisArrow = comparaComThisArrow.bind(obj)

comparaComThisArrow(obj) // arrow function é mais forte que o bind
comparaComThisArrow(module.exports)
