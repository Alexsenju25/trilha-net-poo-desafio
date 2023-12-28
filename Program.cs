using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123123", modelo: "Modelo 1", imei: "1111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "45656", modelo: "Modelo 2", imei: "2222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
