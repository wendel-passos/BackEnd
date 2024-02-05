const estaAprovado = true;


if (estaAprovado === true){
    console.log ('Aprovado');
} else {
    console.log ('Reprovado');
}

if ('0' == 0){
    console.log ('Passou na comparação')
} else {
    console.log ('Não passou')
}

const idadeMinima = 18;
const idadeEstudante = 16;

if (idadeEstudante >= idadeMinima){
    console.log ('Liberado')
}else {
    console.log ('Barrado')
}


let valor1 = '5';
let valor2 = 5;

let resultado1 = valor1 + valor2;
let resultado2;

if (valor1 === valor2) {
 resultado2 = 'Os valores são iguais.';
} else {
 resultado2 = 'Os valores são diferentes.';
}

console.log('Resultado 1:', resultado1);
console.log('Resultado 2:', resultado2);
