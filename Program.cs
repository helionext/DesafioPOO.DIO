using DesafioPOO.Models;
using DesafioPOO.Enum;

Nokia nokia = new Nokia("62985343636", "C1", "1234441223", Memoria.Basico);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Iphone iphone = new Iphone("628978999", "3GS", "12345342", Memoria.Intermediario);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();
