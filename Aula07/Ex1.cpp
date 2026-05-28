#include <iostream>
#include <iomanip>

using namespace std;

int main() {

    int numeros[10];
    int pares [10] = {0};
    int impares [10] = {0};
    int i = 0;

    cout << "Digite 10 numeros inteiros:" << endl;

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