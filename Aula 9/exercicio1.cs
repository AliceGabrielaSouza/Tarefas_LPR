using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System;
class HelloWorld
{

    public struct Produto
    {
        public string nome;
        public int codigo;
        public double preco;
        public int quantidade;
    }

    static void Main()
    {
        Produto p1;
        Produto p3;
        Produto p2;
        Console.WriteLine("Escreva o nome, o codigo, o preço e a quantidade nessa ordem");
        p1.nome = Console.ReadLine();
        p1.codigo = int.Parse(Console.ReadLine());
        p1.preco = double.Parse(Console.ReadLine());
        p1.quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Escreva o nome, o codigo, o preço e a quantidade nessa ordem");
        p2.nome = Console.ReadLine();
        p2.codigo = int.Parse(Console.ReadLine());
        p2.preco = double.Parse(Console.ReadLine());
        p2.quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Escreva o nome, o codigo, o preço e a quantidade nessa ordem");
        p3.nome = Console.ReadLine();
        p3.codigo = int.Parse(Console.ReadLine());
        p3.preco = double.Parse(Console.ReadLine());
        p3.quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("o produto: " + p1.nome + " tem essa quantidade no estoque: " + p1.quantidade);
        Console.WriteLine("o produto: " + p2.nome + " tem essa quantidade no estoque: " + p2.quantidade);
        Console.WriteLine("o produto: " + p3.nome + " tem essa quantidade no estoque: " + p3.quantidade);

    }
}