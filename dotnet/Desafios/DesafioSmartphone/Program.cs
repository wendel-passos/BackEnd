using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nk = new(numero:"1111-1111", modelo:"K 25",imei: "AAA1", memoria:256);
Iphone ip = new(numero: "2222-2222", modelo: "Iphone 15", imei: "BBB2", memoria: 120);

nk.InstalarAplicativo("Instagram");
ip.InstalarAplicativo("Instagram");