#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

int main() {

    SetConsoleOutputCP(65001);
    SetConsoleCP(65001);

    short numero, horas;
    float valor, salario;

    cout << "Digite seu número de identificação: ";
    cin >> numero;

    cout << "Digite a quantidade de horas trabalhadas: ";
    cin >> horas;

    cout << "Digite o valor da hora trabalhada (utilize ponto '.' para separar decimais): ";
    cin >> valor;

    salario = horas * valor;

    cout << "O número do funcionário é: " << numero << endl;
    cout << fixed << setprecision(2);
    cout << "O seu salário é: R$" << salario << endl;
   
    system("pause");
    return 0;
}