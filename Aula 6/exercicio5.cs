using System; 
class HelloWorld {
  static void Main() {
       int contador=5;
       float horaspordia;
       Console.WriteLine("Olá jedi seja bem vindo(a)");
       do{
           Console.WriteLine("Escreva quantas horas você treinou nesse dia");
           horaspordia = float.Parse(Console.ReadLine());
           float horasporsemana =+ horaspordia;
           contador--;
       } while (contador>0);
        float semanas = horasporsemana * 4.5;
        float meses = 1000/semanas;
        float dias = semanas/5;
        Console.WriteLine("dias: " + dias + ",semanas: " + semanas + " e meses" + meses);
// andery não consgeui fazer esse desculpa:(
  }
}
