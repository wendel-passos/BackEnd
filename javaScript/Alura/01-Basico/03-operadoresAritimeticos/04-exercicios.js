// Crie variáveis que armazenem o valor do saldo, de depósito e de um saque de uma conta bancária, 
// depois realize operações de adição e subtração entre eles utilizando uma variável chamada operacao, 
// considerando a função de cada variável criada anteriormente. Exiba os resultados finais no console.
console.log ('====================== Exercício 1 ======================')
const saldo = 1000;
const deposito = 100;
const saque = 50;

let operacao = (saldo + deposito) - saque
console.log (`Saldo após operacao: : ${operacao}`);
// Crie uma variável numérica com um valor. 
// Utilize um operador ternário para verificar se esse valor é par ou ímpar. 
// Exiba o resultado no console.
console.log ('====================== Exercício 2 ======================')
const numero = 10;

if (numero % 2 == 0){
    console.log ('Par')
} else {
    console.log ('Impar')
}
// Considere uma situação em que você está verificando se um usuário está logado
//  e tem permissão de administrador para acessar determinada funcionalidade.
// Utilize variáveis booleanas para simular essas condições e use o operador AND para verificar se ambas são verdadeiras.

console.log ('====================== Exercício 3 ======================')
const usuarioLogado = true;
const adm = true;

if (usuarioLogado && adm ){
    console.log ('Acesso liberado')
} else {
    console.log ('Não possui acesso')
}
// Declare duas variáveis booleanas e use o operador OR para verificar
// se pelo menos uma delas é verdadeira. Exiba o resultado no console.

console.log ('====================== Exercício 4 ======================')
const bool1 = true;
const bool2 = false;

if (bool1 || bool2 ){
    console.log ('Uma das veriaveis é verdadeira')
} else {
    console.log ('Variaveis são falsas')
}

// Imagine um sistema que determina se um usuário tem idade suficiente para comprar
// o ingresso para um show. Declare duas variáveis que determinem 
// a idade mínima e qual a idade do usuário e utilize estruturas 
// condicionais (if, else) para determinar se o usuário pode realizar a compra.

console.log ('====================== Exercício 5 ======================')
const idadeMinima = 18;
const idade = 32;

if (idade >= idadeMinima ){
    console.log ('Liberado')
} else {
    console.log ('Não liberado')
}