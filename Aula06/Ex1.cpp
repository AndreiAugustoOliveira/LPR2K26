#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;


int funcaoInverte(int num) 
{
      SetConsoleOutputCP(65001);
      SetConsoleCP(65001);


        int invertido = 0;
        int digito = 0;

        while(num > 0) {    
            digito = num % 10;
            invertido = invertido * 10 + digito;
            num /= 10;
        }
        return invertido;
    }

int main() {

  int num = 0;
  int resultado = 0;

   cout << "Digite um número inteiro: ";
   cin >> num;

    resultado = funcaoInverte(num);

    cout << "O número invertido é: " << resultado << endl;

    system("pause");
    return 0;
}