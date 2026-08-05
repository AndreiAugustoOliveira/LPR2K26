#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

int main() {
    SetConsoleOutputCP(65001);
    SetConsoleCP(65001);

   int matriz1 [3][3];
   int matriz2 [3][3];
   int resultado [3][3];
   int i = 0;
   int j = 0;
   int x = 0;
   int digitado = 0;



   cout << "Digite os números de uma matriz 3x3 (os valores completarão uma linha após a outra)" << endl;

   for(i = 0; i < 3; i++) {
    
   for(j = 0; j < 3; j++) {
     
    cin >> digitado;
    matriz1[i][j] = digitado; 
}
   }

    cout << "Digite os números da outra matriz 3x3 (os valores completarão uma linha após a outra)" << endl;

    for(i = 0; i < 3; i++) {
    
   for(j = 0; j < 3; j++) {
     
    cin >> digitado;
    matriz2[i][j] = digitado; 
}
   }

   for(i = 0; i < 3; i++) {

    for(j = 0; j < 3; j++) {

        resultado[i][j] = 0;

        for(x = 0; x < 3; x++) {

            resultado[i][j] += matriz1[i][x] * matriz2[x][j];

        }
    }
}

cout << "A multiplicação das matrizes é :" << endl;

for(i = 0; i < 3; i++) {

    for(j = 0; j < 3; j++) {

        cout << resultado[i][j] << " ";

    }

    cout << endl;
}

    cout << endl;

    system("pause");
    return 0;
}