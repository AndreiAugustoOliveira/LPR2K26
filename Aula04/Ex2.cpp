#include <iostream>
#include <iomanip>

using namespace std;

int main() {

    int num1, num2;

    cout << "Digite um numero inteiro ";
    cin >> num1;

    cout << "Digite outro numero inteiro ";
    cin >> num2;

    if (num2 % num1 == 0 || num1 % num2 == 0) {
   cout << "Os numeros sao multiplos" << endl;  }

   else {
    cout << "Os numeros nao sao multiplos" << endl;  
   }

    system("pause");
    return 0;
}