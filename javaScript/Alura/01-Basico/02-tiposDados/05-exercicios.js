// Crie uma variável contendo uma frase. Em seguida, exiba no console o comprimento da frase e a mesma frase em letras maiúsculas.
    console.log ('Exercicio 1')
    let frase = 'Nenhum sonho é grande demais';

    console.log (frase.length);
    console.log (frase.toUpperCase());
    console.log ('========================================')

// Declare duas variáveis, uma inicializada com valor null e outra que não recebe atribuição (resultando em undefined). Exiba os valores no console.
    console.log ('Exercicio 2')
    let valorNull = null;
    let semAtribuicao;

    console.log (valorNull);
    console.log (semAtribuicao);
    console.log ('========================================');

// Crie 3 variáveis de tipos diferentes, utilize template strings para combinar os diferentes tipos de dados (number, string, boolean) em uma única string e exiba o resultado no console.
    console.log ('Exercicio 3')
    let number = 7;
    let string = 'Texto';
    let bool = true;

    let templateString = `Número:${number} , String:${string}, Booleano:${bool}`;
    console.log (templateString);
    console.log ('========================================');

// Crie uma variável numérica e uma string. Faça a conversão da variável numérica para string e da string para número. Exiba os tipos de dados resultantes no console.
    console.log ('Exercicio 4')
    let numero = 7;
    let texto = '7';

    numero = numero.toString();
    texto = parseInt(texto);
    console.log (typeof numero);
    console.log (typeof texto);
    console.log ('========================================');

// Crie uma variável com uma string e utilize métodos de manipulação de strings, como toUpperCase, toLowerCase, slice ou outros, para modificar a string original. Exiba os resultados finais no console.
    console.log ('Exercicio 5')
    let textoOriginal = 'Texto sem modificação'

    console.log ('UpperCase: ', textoOriginal.toUpperCase());
    console.log ('LowerCase: ', textoOriginal.toLowerCase());
    console.log ('Slice: ', textoOriginal.slice(0,5));
    console.log ('========================================');
