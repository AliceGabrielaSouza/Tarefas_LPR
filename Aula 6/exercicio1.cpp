#include <iostream>
using namespace std;
int main()
{
    int numdigitado, numeroanalisado;
    int soma = 0;
    double quantidade =0;
    double media;
    int contador =0;
    cout<<"quantos números vc irá digitar";
    cin>>numdigitado;
    
    while(contador<numdigitado){
    cout<<"digite um numero";
    cin>>numeroanalisado;
    if(numeroanalisado%2==0){
        soma+=numeroanalisado;
        quantidade++;
    }
    contador++;
  }
     media = soma/quantidade;
    cout<<"A média é igual: "<< media;
}