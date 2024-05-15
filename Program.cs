using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Nokia celular1 = new Nokia(numero:"8399256495",modelo:"Nokia C1-01",imei:"8394DJSHCB",memoria: 128);
Console.WriteLine("\n");
celular1.Especificacoes();
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("DIO");

Console.WriteLine("\n");
Nokia celular2 = new Nokia(numero:"8399254595",modelo:"Nokia C2-01",imei:"8344DJSHCB",memoria: 64);
celular2.Especificacoes();

Console.WriteLine("\n");

Iphone celular3 = new Iphone(numero:"8395461235",modelo:"Iphone 6s",imei:"78dsfFCSF", memoria: 16);
celular3.Especificacoes();
celular3.Ligar();
celular3.ReceberLigacao();
celular3.InstalarAplicativo("Discord");
