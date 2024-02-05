const notaPrimeiroBi = 8;
const notaSegundoBi = 6.3;
const notaTerceiroBi =7;
const notaQuartoBi = 9.4

let media = (notaPrimeiroBi + notaSegundoBi + notaTerceiroBi + notaQuartoBi)/4;
// console.log ('A média é ' + total.toFixed(2));//função para considerar quantidade de casas decimais

if (media >= 7) {
    media += media *0.1;
}

console.log (`a media igual: ${media.toFixed(2)} `);



const salarioMensal = 3500; 
const despesasFixas = 1200; 
const despesasVariaveis = 500; 
const economiasMensais = 800;
const bonusAnual = 3000;

const resultado = (salarioMensal - despesasFixas - despesasVariaveis) * 12 + (economiasMensais * 12) + bonusAnual;
console.log (`resultado igual: ${resultado.toFixed(2)} `);