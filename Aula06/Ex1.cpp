#include <iostream>
#include <iomanip>

using namespace std;


int funcaoInverte(int num) 
{
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

   cout << "Digite um numero inteiro: ";
   cin >> num;

    resultado = funcaoInverte(num);

    cout << "O numero invertido e: " << resultado << endl;

    system("pause");
    return 0;
}