#include <iostream>
#include <iomanip>
using namespace std;

int main() {

    short numero, horas;
    float valor, salario;

    cout << "Digite seu numero de identificacao: ";
    cin >> numero;

    cout << "Digite a quantidade de horas trabalhadas: ";
    cin >> horas;

    cout << "Digite o valor da hora trabalhada (utilize ponto '.' para separar decimais): ";
    cin >> valor;

    salario = horas * valor;

    cout << "O numero do funcionario e: " << numero << endl;
    cout << fixed << setprecision(2);
    cout << "O seu salario e: R$" << salario << endl;
   
    system("pause");
    return 0;
}