// TODO: Realizar os testes com as classes Nokia e Iphone

using DesafioPOO.Models;

Nokia nokia = new Nokia();
nokia.Numero = "994841089";
nokia.addModelo("Nokia1100");
nokia.addMemoria(500);
nokia.addImei("1522");

Console.WriteLine($"Numero do aparelho {nokia.Numero} e modelo {nokia.Modelo}");
Console.WriteLine($"Memoria {nokia.Memoria} e Numero Imei {nokia.Imei}");
nokia.InstalarAplicativo("Nokia rastreador");
nokia.Ligar();
nokia.ReceberLigacao();
/*---------------------------*/
Console.WriteLine();

Iphone iphone = new Iphone();
iphone.Numero = "986399510";
iphone.addModelo("iphone 11");
iphone.addMemoria(800);
iphone.addImei("1852");

Console.WriteLine($"Numero do aparelho {iphone.Numero} e modelo {iphone.Modelo}");
Console.WriteLine($"Memoria {iphone.Memoria} e Numero Imei {iphone.Imei}");
iphone.InstalarAplicativo("Nokia rastreador");
iphone.Ligar();
iphone.ReceberLigacao();
