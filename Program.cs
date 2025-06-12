using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone celular1 = new Nokia(numero: "11999999999", modelo: "Nokia 3310", imei: "123456789012345", memoria: 64);
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo(nomeApp: "WhatsApp");

Smartphone celular2 = new Iphone(numero: "11999999999", modelo: "Iphone 14", imei: "123456789012345", memoria: 64);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo(nomeApp: "WhatsApp");

