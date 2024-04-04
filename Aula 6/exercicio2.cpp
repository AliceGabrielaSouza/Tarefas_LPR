#include <iostream>
#include <iomanip>
#include <random>
using namespace std;
int main()
{
    random_device numAleatorio ;
    uniform_int_distribution<> distribuicao(1,100);
    int valorInteiro = distribuicao(numAleatorio);
    int chute, proximidade;
    int contador=0;
    cout<<"Digite um número de um a 100 para tentar adivinhar o número aleatório"<<endl;
    do{
        cin>>chute;
        proximidade = valorInteiro - chute ;
           if(proximidade>0){
            cout<<"chutou baixo"<<endl;
                            }
           else if (proximidade<0){
            cout<<"chutou alto"<<endl;
                                  }
        contador++;
      } while(proximidade!=0);
      cout<<"Parabéns, Você acertou o número em "<<contador<<" tentativas";
      
}