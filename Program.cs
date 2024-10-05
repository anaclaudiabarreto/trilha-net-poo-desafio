using DesafioPOO.Models;

Nokia meuNokia = new Nokia("999888777", "G60", "000000-00-000000-0", 128);
meuNokia.Ligar();
meuNokia.ReceberLigacao();
meuNokia.InstalarAplicativo("Telegram");

Iphone meuIphone = new Iphone("999222333", "iPhone6", "000000-00-000000-2", 32);
meuIphone.Ligar();
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("Duolingo");