#include <iostream>
#include <array>
using namespace std;
struct Livro{
      string Titulo;
      string Autor;
      int AnoPublicado;
      int numerodepaginas;
      double preco;
};

int main()
{
    int media=0;
    cout<<"Escreva o titulo, o autor, o ano publicado, numero de paginas e preço"<<endl;
    array<Livro,3> biblioteca;
    for(int i=0; i<3; i++){
     string titulo, autor;
     int ano, paginas;
     double preco;
     cin>>titulo;
     cin>>autor;
     cin>>ano;
     cin>>paginas;
     cin>>preco;
     biblioteca[i]={titulo, autor, ano, paginas, preco};
    }
    cout<<"O livro "<< biblioteca[0].Titulo<< " custa: "<< biblioteca[0].preco <<endl;
    cout<<"O livro "<< biblioteca[1].Titulo<< " custa: "<< biblioteca[1].preco <<endl;
    cout<<"O livro "<< biblioteca[2].Titulo<< " custa: "<< biblioteca[2].preco <<endl;
    for (Livro pagina : biblioteca){
    media+=pagina.preco;
    }
    cout<<"A média de páginas é "<< media<<endl;
}