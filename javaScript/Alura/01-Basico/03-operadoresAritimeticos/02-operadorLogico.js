const notaFinal = 7;
const faltas = 3;
const advertencias = 0;

if (notaFinal < 7 || faltas >= 4){
    console.log ('Reprovado');
} else {
    console.log ('Aprovado');
}

if (faltas <=4 && !advertencias){
    console.log ('Recebeu bônus');
} else {
    console.log ('Não recebeu bônus');
}
