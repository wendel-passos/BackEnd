
function exibeNomeEstudante(nome){
    console.log (nome)
}

function exibeInfosEstudante(nome, nota){
    console.log (`Nome:${nome} Nota:${nota}`)
}

//utilizando o return 
function exibeNomeEstudanteReturn(nome){
    return (nome)
}
function exibeInfosEstudanteReturn(nome, nota){
    return `Nome:${nome} Nota:${nota}`
}

exibeNomeEstudante('Caroline');
exibeInfosEstudante('Caroline', 7)

console.log (exibeNomeEstudanteReturn('Julia'));
console.log (exibeInfosEstudanteReturn('Julia', 7))