using System; // andery eu não consegui entender muito bem como construar essa lógica dentro do for então deixei só com a lógica sem ser em forma de código
class HelloWorld {
  static void Main() {
      int soma;
    for (int i; i>=50 && i<=500; i++){
        if((i%2==0) && (i%3==0)){
            soma++;
        }
        Console.WriteLine("A soma de todos os números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 a 500 é de: " + soma);
    }
  }
}