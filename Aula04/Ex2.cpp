#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

int main() {

    SetConsoleOutputCP(65001);
    SetConsoleCP(65001);

    int num1, num2;

    cout << "Digite um número inteiro ";
    cin >> num1;

    cout << "Digite outro número inteiro ";
    cin >> num2;

    if (num2 % num1 == 0 || num1 % num2 == 0) {
   cout << "Os números sao múltiplos" << endl;  }

   else {
    cout << "Os números não são múltiplos" << endl;  
   }

    system("pause");
    return 0;
}