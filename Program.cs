using DesafioPOO.Models;

Console.WriteLine("Testes do smartphone Iphone:");
Console.WriteLine("\n");
Smartphone iphone = new Iphone(numero: "111111", modelo: "1", imei: "54321", memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Pokemon Go");

Console.WriteLine("\n");

Console.WriteLine("Testes do smartphone Nokia:");
Console.WriteLine("\n");
Smartphone nokia = new Nokia(numero: "111111", modelo: "1", imei: "54321", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Duolingo");
