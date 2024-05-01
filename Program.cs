using DesafioPOO.Models;

Console.WriteLine("Smartphone Samsung:");
Smartphone nokia = new Nokia(numero: "99887755", modelo: "N95", imei: "11111111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Nokia(numero: "56123678", modelo: "15 Pro Max", imei: "22222222222", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");


