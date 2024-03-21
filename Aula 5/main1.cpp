#include <iostream>
using namespace std;
int main()
{
    int numero;
    cout<<"Digite um número para saber se é par ou impar"<<endl;
    cin>>numero;
    if (numero%2 == 0){
        cout<<"O número é par";
    }
    else {
        cout<<"O número é ímpar";
    }
}
