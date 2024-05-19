using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia(numero: "12233546", _modelo: "Modelo 1", _imei: "123218111", _memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("ChatGPt");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");

Smartphone iphone = new Iphone(numero: "090933546", _modelo: "Modelo 10", _imei: "001113333", _memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");