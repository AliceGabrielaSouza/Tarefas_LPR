using System;
class HelloWorld {
  static void Main() {
      int primeiro, segundo;
    Console.WriteLine("Digite o primeiro número: ");
    primeiro = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    segundo = int.Parse(Console.ReadLine());
    if ((primeiro%segundo == 0) || (segundo%primeiro==0)){
            Console.WriteLine("São Multiplos");
    }
     else  {
            Console.WriteLine("Não são Multiplos");
    }
  }
}
