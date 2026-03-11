#include <iostream>
#include <iomanip>
using namespace std;

int main() {

    int codigo, pecas, codigo2, pecas2;
    float valorU, valorU2, valorT;

    cout << "Digite o codigo da primeira peca: ";
    cin >> codigo;

    cout << "Digite a quantidade de pecas: ";
    cin >> pecas;

    cout << "Digite o valor unitario de cada peca (utilize ponto '.' para separar decimais): ";
    cin >> valorU;

    cout << "Digite o codigo da segunda peca: ";
    cin >> codigo2;

    cout << "Digite a quantidade de pecas: ";
    cin >> pecas2;

    cout << "Digite o valor unitario de cada peca (utilize ponto '.' para separar decimais): ";
    cin >> valorU2;
    valorT = (pecas * valorU) + (pecas2 * valorU2);

   cout << fixed << setprecision(2);
   cout << "O valor total da compra e: R$" << valorT << endl;  

    system("pause");
    return 0;
}