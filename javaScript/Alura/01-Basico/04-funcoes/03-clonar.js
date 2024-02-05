const notas = [7,7,8,9];
//spread operator 
const novaListaNotas = [...notas, 10];


//novaListaNotas.push (10);
console.log (notas);
console.log (novaListaNotas);

const calculadoraSimples = (a, b, operacao) => {
    if (operacao === 'soma') {
        return a + b;
    } else if (operacao === 'subtracao') {
        return a - b;
    } else if (operacao === 'multiplicacao') {
        return a * b;
    } else if (operacao === 'divisao') {
        return a / b;
    } else {
        return 'Operação não reconhecida';
    }
};

console.log (calculadoraSimples (2,3,'soma'));

