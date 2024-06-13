#include <iostream>
using namespace std;
int main()
{
    int numentrada[10];
    int numpesquisado[10];
    int pesquisa;
    int vezes;
    cout<<"Entre com 10 números inteiros"<<endl;
    for(int i=0; i<10; i++){
        int entrada;
        cin>>entrada;
        numentrada[i]=entrada;
    }
    cout<<"digite um número que você quer pesquisar"<<endl;
    cin>>pesquisa;
    for(int i=0; i<10; i++){
        if(numentrada[i]==pesquisa){
        numpesquisado[i]=i;
        vezes++;
        }
    }
    for(int i=0; i<10; i++){
        if(numpesquisado[i]!=0){
        cout<<"o numero aparece na posição: ";
        cout<<numpesquisado[i]<<endl;
        }
    }
    cout<<"e esse número aparece "<<vezes<<" vezes"<<endl;
    }