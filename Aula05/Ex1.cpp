#include <iostream>
#include <iomanip>

using namespace std;

int main() {

    int quantidade = 0;
    int numero = 0;
    double media = 0;
    int acumulador = 0;
    int contador = 0;
    double contadorPar = 0;

    cout << "Digite a quantidade de numeros que voce vai digitar: " << endl;
    cin >> quantidade;
    cout << "Digite um numero inteiro qualquer: " << endl;
    cin >> numero;
    contador++;
    
    if (numero % 2 == 0) {
    acumulador += numero; 
    contadorPar++;
     }

    while(quantidade != contador) {
    cout << "Digite um numero inteiro qualquer: " << endl;
    cin >> numero;
    contador++;

     if(numero % 2 == 0) {
     acumulador += numero; 
     contadorPar++;
     }
    }
    
    media = acumulador/contadorPar;

    cout << "A media dos numeros e: " << media << endl;
    
    system("pause");
    return 0;
}