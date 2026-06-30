#include <iostream>
#include <iomanip>
#include <windows.h>
#include <list>
#include <cstdlib>

using namespace std;

int main() {
    SetConsoleOutputCP(65001);
    SetConsoleCP(65001);
  

    list<int> numeros;
    int i = 0;
    int contador = 0;
    
      for (i = 0; i < 100; i++)
    {
        numeros.push_back(rand() % 100 + 1);
    }
    
    numeros.sort();

    for (int numero : numeros) {

    cout << numero << " ";
}

 for (int i = 2; i <= 100; i += 2)
    {
        numeros.remove(i);
    }
  
   cout << "" << endl;
   cout << "Números ímpares:" << endl;

   for (int numero : numeros) {

    cout << numero << " ";

}
  cout << "" << endl;
  cout << "Números repetidos:" << endl;

for (int numero1 : numeros)
{
    int contador = 0;

    for (int numero2 : numeros)
    {
        if (numero1 == numero2)
        {
            contador++;
        }
    }

    if (contador > 1)
    {
        cout << numero1 << " ";
    }
}

    system("pause");
    return 0;
}