// Dominar o uso de arrays é fundamental em programação e uma base essencial na manipulação de dados. Praticar regularmente é a chave para se tornar mais confiante!

// Para isso criamos uma lista de exercícios que não apenas ajudam a explorar os métodos de manipulação de arrays, 
// mas também vão te preparar para lidar eficientemente com dados em aplicações reais.

//Um array esparso é um tipo de array no qual a maioria dos elementos tem valores indefinidos. Crie um array esparso e atribua valores a alguns elementos do array (por exemplo, defina valores nos índices 1, 3 e 7). Imprima no console o array e também a informação de comprimento do array.

console.log ('------------------------------Exercício1------------------------------')
const arrayEsparso = [];
arrayEsparso [1] = 1;
arrayEsparso [3] = 2;
arrayEsparso [7] = 3;

console.log (arrayEsparso)
console.log (arrayEsparso.length);


// Crie um programa em Node.js que inicie com um array cinco elementos e atribua um novo valor para a primeira posição (índice 0) desse array. Em seguida, exiba o array antes e depois da alteração.

console.log ('------------------------------Exercício2------------------------------')
const array2 = [1,2,3,4,5];
console.log (array2);
array2 [0] = 10;
console.log (array2);

// Crie um array vazio chamado meuArray e adicione 3 números inteiros de sua escolha utilizando o método push(). Imprima no console os itens presentes no array para verificar se os números foram adicionados. Em seguida, substitua o primeiro elemento do array (índice 0) pelo dobro do seu valor atual. Imprima no console o array atualizado para verificar a mudança.
console.log ('------------------------------Exercício3------------------------------')
meuArray =[];
meuArray.push (2,4,6);
console.log (meuArray);
meuArray [0] = meuArray [0] * 2;
console.log (meuArray);

// Desenvolva um programa; em Node.js que crie um array vazio e atribua valores a ele utilizando o método push(). Adicione três números inteiros ao array e, em seguida, exiba o array resultante.
console.log ('------------------------------Exercício4------------------------------')
arrayVazio =[];
arrayVazio.push (10,20,30);
console.log (arrayVazio);

// Desenvolva um programa em Node.js que simule uma clínica veterinária. Crie um array vazio chamado clinica que representará a fila de animais na clínica. Em um primeiro momento, simule a chegada de três animais diferentes e exiba a lista de animais no console. Após a exibição, remova os animais da lista um por vez e, por fim, exiba no console o estado final da lista.

console.log ('------------------------------Exercício5------------------------------')
clinica = [];
clinica.push ('Gato', 'Cachorro', 'Papagaio');
while (clinica.length > 0) {
    console.log (clinica);
    clinica.pop ();
}