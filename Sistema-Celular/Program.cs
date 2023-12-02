using Sistema_Celular.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia cell = new Nokia("81998681689","Nokia C01 Plus","000000000000000",40);
cell.Ligar();
cell.ReceberLigacao();
cell.InstalarAplicativo("WhatsApp");

Console.WriteLine("---------------------------------------------------");

Iphone cell2 = new Iphone("8199999999","Iphone XR","111111111111111",64);
cell2.Ligar();
cell2.ReceberLigacao();
cell2.InstalarAplicativo("TikTok");
