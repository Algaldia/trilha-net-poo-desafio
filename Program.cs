using DesafioPOO.Models;

Console.WriteLine("Implementando IPhone");
Iphone i1 = new Iphone("3333-3333", "Iphone 35", "1111111111", 64);
Console.WriteLine($"Numero: {i1.Numero}");
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("WhatsApp");


Console.WriteLine("Implementando Nokia");
Nokia n1 = new Nokia("5555-555", "Nokia PRO", "1111111112", 32);
Console.WriteLine($"Numero: {n1.Numero}");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Telegram");
