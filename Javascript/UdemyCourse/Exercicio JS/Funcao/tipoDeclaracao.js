console.log(soma(3,4)) // chamando function antes de ser declarada - WORKS

console.log(sub(3,4)) // não temos como chamar function expression antes de declarar - FAIL

console.log(mult(3,4)) // mesma coisa do function expreession - FAIL

// function declaration
function soma(x,y){
    return x + y
}

//function expression
const sub = function (x,y){
    return x - y 
}

//named function expression
const mult = function mult(x,y){
    return x * y
}

