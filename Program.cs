using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone iPhone");
Smartphone iPhone = new Iphone(numero: "14987654321", modelo: "14", imei: "111111", memoria: 256);
iPhone.Ligar();
iPhone.InstalarAplicativo("Genshin Impact");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "14123456789", modelo: "XE9", imei: "101010", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Grasshopper");
