using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo:"tipe 1", imei: "777", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "789", modelo:"tipe 2", imei: "333", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
