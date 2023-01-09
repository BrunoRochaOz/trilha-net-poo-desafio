using DesafioPOO.Models;

Console.WriteLine("Usando Smartphone Iphone");
Iphone iphone = new Iphone("2", "teste", "5151",120);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("GitHub");


Console.WriteLine("=============");

Console.WriteLine("Usando Smartphone Nokia");
Nokia nokia = new Nokia("3", "teste2","1515" , 120);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("LinkedIn");


