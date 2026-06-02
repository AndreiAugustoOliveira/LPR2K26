#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

int main() {
    SetConsoleOutputCP(65001);
    SetConsoleCP(65001);

    int numeros[10];
    int pares [10] = {0};
    int impares [10] = {0};
    int i = 0;

    cout << "Digite 10 números inteiros:" << endl;

    for(i = 0; i < 10; i++) {

        cin >> numeros[i];

        if (numeros[i] % 2 == 0) {
            pares[i] = numeros[i];
        } else {
            impares[i] = numeros[i];
        }
    }
 
    cout << "Numeros pares:" << endl;
    for(i = 0; i < 10; i++) {
        if(pares[i] != 0) {
            cout << pares[i] << " ";
        }
    }
    cout << endl;

    cout << "Numeros impares:" << endl;
    for(i = 0; i < 10; i++) {
        if(impares[i] != 0) {
            cout << impares[i] << " ";
        }
    }
    cout << endl;

    system("pause");
    return 0;
}