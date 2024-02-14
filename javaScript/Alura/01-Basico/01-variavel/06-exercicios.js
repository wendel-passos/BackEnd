
// Declare três variáveis diferentes (uma para cada tipo: string, número e booleano) e atribua valores a elas.
//  Em seguida, exiba o tipo de cada variável no console.

console.log ('Exercicio 1')

let string = 'NomePessoa';
let numero = 10;
let booleano = false;

// console.log ( 'string: ' + string+  '  | numero: '+ numero + ' | booleano: ' + booleano);
console.log ( 'string: ' + string+  ' | tipo: ' + typeof string);
console.log ( 'numero: ' + numero+  ' | tipo: ' + typeof numero);
console.log ( 'booleano: ' + booleano+  ' | tipo: ' + typeof booleano);
console.log ('=========================================');

// Crie duas variáveis, uma contendo seu primeiro nome e outra contendo seu último nome. 
// Em seguida, combine-as em uma terceira variável usando o operador + e em uma quarta variável usando template strings.
// Por fim, imprima os resultados obtidos no console.

console.log ('Exercicio 2')
let primeiroNome = 'Wendel';
let ultimoNome = 'Passos';
let concatenaNome = primeiroNome +' '+ ultimoNome;

console.log ('Nome completo: ' + concatenaNome);
console.log ('=========================================');

// Declare duas variáveis, uma contendo um número e outra contendo uma string. Em seguida, 
//combine-as em uma terceira variável usando template strings para montar uma frase e exiba o resultado no console.
console.log ('Exercicio 3')
let num = 10;
let numNome = 'Dez'
let concatNumNome = num +' '+ numNome;
console.log ('Concatena numero com string: ',concatNumNome);
console.log ('=========================================');


// Crie uma variável inicializada com um valor de qualquer tipo e, em seguida, reatribua um novo valor a essa variável. 
//Imprima ambos os valores no console após atribuí-los.
console.log ('Exercicio 4')
let iniciaValor = 7;
console.log ('Antes: ' + iniciaValor);
iniciaValor = 10;
console.log ('Depois: ' + iniciaValor);
console.log ('=========================================');

// Declare uma variável usando var fora de um bloco de código (por exemplo, if) e outra dentro desse bloco. 
//Tente acessar essas variáveis dentro do bloc e fora dele utilizando console.log e analise os resultados.
// Faça o mesmo processo utilizando let e compare com os resultados anteriores.
console.log ('Exercicio 5')
var varForaEscopo = 'Var fora do escopo'
if (1>0){
    var varDentroEscopo = 'Var dentro do escopo'
    console.log (varDentroEscopo, varForaEscopo)
}
console.log ("Acessando var fora do bloco: " + varDentroEscopo + varForaEscopo)

let letForaEscopo = 'Let fora do escopo'
if (1>0){
    let letDentroEscopo = 'Let dentro do escopo'
    console.log (letDentroEscopo);
    console.log (letForaEscopo);
}
console.log ("Acessando let fora do bloco: " + letForaEscopo);
//console.log ("Acessando let fora do bloco: " + letDentroEscopo); //let não existe fora do bloco
console.log ('=========================================');

// Declare uma variável booleana que informa se está chovendo 
// e utilize-a em uma estrutura condicional (if) para exibir uma mensagem informando se
// é preciso levar um guarda-chuva ou não dependendo do valor da variável.
console.log ('Exercicio 6')

let estaChovendo = true;

if (estaChovendo === true){
    console.log ('Leve o guarda chuva');
} else {
    console.log ('Não leve o guarda chuva');
}
console.log ('=========================================');