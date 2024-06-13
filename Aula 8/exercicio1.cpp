#include <iostream>
using namespace std;
int main()
{
    int numentrada[10];
    int numpar[10];
    int numimpar[10];
    cout<<"Entre com 10 números inteiros"<<endl;
    for(int i=0; i<10; i++){
        int entrada;
        cin>>entrada;
        numentrada[i]=entrada;
    }
    for(int i=0; i<10; i++){
        if(numentrada[i]%2==0){
        numpar[i]=numentrada[i];
        }
        else{
        numimpar[i]=numentrada[i];
        }
    }
    cout<<"os numeros pares são:"<<endl;
    for(int i=0; i<10;i++){
        if(numpar[i]!=0){
        cout<<numpar[i]<<endl;
        }
    }
    cout<<"os numeros impares são:"<<endl;
    for(int i=0; i<10;i++){
        if(numimpar[i]!=0){
        cout<<numimpar[i]<<endl;
        }
    }
}