using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "82987514902", modelo: "Modelo Nokia", imei: "222222", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone(numero: "7965456732", modelo: "Modelo iphone", imei: "333333", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");