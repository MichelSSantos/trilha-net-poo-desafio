using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei:"12121212", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"12345", modelo: "Modelo 2", imei:"131313", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");