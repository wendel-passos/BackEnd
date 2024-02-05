// Crie uma função que receba o nome de uma pessoa como argumento e retorne uma saudação personalizada. 
// Em seguida, chame a função e exiba a saudação no console.

console.log ('==================Exercício1==================')
const saudacao = function (nome){
    return `Olá ${nome}`
}
console.log (saudacao('Solange'));


// Crie uma função que receba a idade de uma pessoa e 
// retorne se ela é maior de idade (idade >= 18). Imprima o resultado no console.
console.log ('==================Exercício2==================')
const maiorDeIdade = function (idade){
    if (idade >= 18){
        return `Maior`;
    } else {
        return `Menor`;
    }
}
console.log (maiorDeIdade(16));
// Crie uma função que receba uma string e verifique se é um palíndromo 
// (uma palavra que é lida da mesma forma de trás para frente) utilizando o
//  método de string reverse(). Retorne true se for um palíndromo e false caso contrário. Imprima o resultado no console.
console.log ('==================Exercício3==================')
const palavra = function (palavra){
    if (palavra.split("").reduce((acc, char) => char + acc, "") === palavra){
        return `É um palíndromo`;
    } else {
        return `Não é um palíndromo`;
    }
}
console.log (palavra('anilina'));
// Crie uma função que receba três números como parâmetros e determine qual é o maior entre eles. 
// Utilize estruturas condicionais (if, else) para comparar os valores e determinar o maior.
// Imprima o maior valor no console.
console.log ('==================Exercício4==================')
const numeros = function (n1,n2,n3){
    if (n1 > n2 && n1 >n3){
        return `Maior número é: ${n1}`;
    } else if (n2 > n1 && n2 >n3) {
        return `Maior número é: ${n2}`;
    } else {
        return `Maior número é: ${n3}`;
    }
}
console.log (numeros(1,5,3));
// Crie uma arrow function chamada calculaPotencia que receba dois parâmetros: a base e o expoente. 
// A função deve calcular a potência da base elevada ao expoente e retornar o resultado.
console.log ('==================Exercício5==================')
const calculaPotencia =  (base,expoente) => {
    const resultado = base ** expoente
    return `Potência de ${base} elevado a ${expoente} é igual a: ${resultado}` 
}
console.log (calculaPotencia (10,2));