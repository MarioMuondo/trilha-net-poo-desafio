using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "738677387", modelo: "Modelo 5", imei: "89478378", memoria: 42);
nokia.Ligar();
nokia.InstalarAplicativo("Tik Tok");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "749388909", modelo: "Modelo 6454", imei: "8443834873", memoria: 8578);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube")
