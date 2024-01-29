const estudante = 'Lucianna';
const docente = 'Ana';
const cumprimento = "Nosso lema é 'Jamais desistir'";
const citacao = "Leman diz: 'Foco força e fé'";

console.log (cumprimento);
console.log (citacao);
console.log (`a estudante chama  ${estudante}`); //Template String

const senha = 'SenhaSegura123' + estudante.toUpperCase()//Função para deixar string em caixa Alta;
console.log(senha);

// ----------------------------

let valor1 = 0
let abacate
let valor2 = "10"

console.log("valor1 é do tipo:", typeof valor1)
console.log("abacate é do tipo:", typeof abacate)
console.log("valor2 é do tipo:", typeof valor2)
