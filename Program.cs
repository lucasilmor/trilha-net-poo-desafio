using DesafioPOO.Models;

Smartphone iphone = new Iphone(numero:"1190909090", modelo:"Iphone 8", imei:"OKOS123312", memoria:256);
Smartphone nokia = new Nokia(numero: "11545435433", modelo: "Lumia 12", imei: "OKOS123dda2", memoria: 128);

iphone.InstalarAplicativo("App store");
iphone.Ligar();
iphone.ReceberLigacao();

nokia.InstalarAplicativo("Windows store");
nokia.Ligar();
nokia.ReceberLigacao();
