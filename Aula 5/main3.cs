using System;
class RpgDoAndery {
  static void Main() {
      int escolha;
      string habilidades = "";
    Console.WriteLine("Bem vindo(a) ao rpg");
    Console.WriteLine("Digite 1 para ver as habilidades especiais da Guerreira");
    Console.WriteLine("Digite 2 para ver as habilidades especiais do Mago");
    Console.WriteLine("Digite 3 para ver as habilidades especiais da Arqueira");
    escolha = int.Parse(Console.ReadLine());
    
    switch (escolha)
    {
        case 1:
        habilidades = "Ataque Pesado, Defesa Total";
        break;
        
        case 2:
        habilidades = "Bola de Fogo, Escudo de Gelo";
        break;
        
        case 3:
        habilidades = "Flecha Precisa, Disparo Triplo";
        break;
        
    }
    
     Console.WriteLine("As habilidades são: " + habilidades);

  }
}