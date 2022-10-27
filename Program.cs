using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia(numero: "17 98106-1979", modelo: "Modelo 1", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Iphone iphone = new Iphone(numero: "17 98227-7708", modelo: "iPhone 12 pro", imei: "987654321", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp Messager");