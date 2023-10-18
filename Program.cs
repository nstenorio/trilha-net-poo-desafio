using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "(81) 9 9999-9999", Modelo: "Nokia SF1620", Imei: "123456789", Memoria: 64);
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(Numero: "(81) 9 8888-8888", Modelo: "Iphone SMXPro", Imei: "123456798", Memoria: 128);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Telegram");