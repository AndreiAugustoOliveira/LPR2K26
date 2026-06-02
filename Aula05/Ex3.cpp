#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

int main() {

    SetConsoleOutputCP(65001);
    SetConsoleCP(65001);

   int i;
   int acumulador = 0;

   for(i = 50; i < 500; i++) {

    if(i % 2 != 0 && i % 3 == 0) {
    acumulador += i;
    }
     
    if(i != 499) {
    }

    else {
    
  cout << "A soma de todos os números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 a 500 é: " << acumulador << endl;

   } 
}
    system("pause");
    return 0;
}