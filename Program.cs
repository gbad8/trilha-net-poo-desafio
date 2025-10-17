using DesafioPOO.Models;

Iphone celularEsposa = new(numero: "9999-8888", modelo: "Iphone X", imei: "123456789012345", memoria: 64);
Nokia celularMarido = new(numero: "7777-6666", modelo: "Nokia 8", imei: "987654321098765", memoria: 128);

Console.WriteLine("Celular da Esposa:");
celularEsposa.Ligar();
celularEsposa.ReceberLigacao();
celularEsposa.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Celular do Marido:");
celularMarido.Ligar();
celularMarido.ReceberLigacao();
celularMarido.InstalarAplicativo("WhatsApp");