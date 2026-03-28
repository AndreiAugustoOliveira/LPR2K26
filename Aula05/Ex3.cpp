#include <iostream>
#include <iomanip>

using namespace std;

int main() {

   int i;
   int acumulador = 0;

   for(i = 50; i < 500; i++) {

    if(i % 2 != 0 && i % 3 == 0) {
    acumulador += i;
    }
     
    if(i != 499) {
    cout << "Processando..." << endl;
    }

    else {
    
  cout << "A soma de todos os numeros impares multiplos de 3 que se encontrem no conjunto dos numeros de 50 a 500 e: " << acumulador << endl;

   } 
}

    system("pause");
    return 0;
}