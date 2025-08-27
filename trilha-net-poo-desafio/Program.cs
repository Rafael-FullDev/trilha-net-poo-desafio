using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone Nokia = new Nokia(numero: "123456",modelo: "modelo 1",iMEI: "11111111111",memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Shoppe");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone Iphone = new Iphone(numero: "987654321", modelo: "modelo 2", iMEI: "2222222222", memoria: 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");