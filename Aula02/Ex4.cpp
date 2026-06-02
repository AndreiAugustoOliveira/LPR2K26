#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

int main() {

    SetConsoleOutputCP(65001);
    SetConsoleCP(65001);
    
    int codigo, pecas, codigo2, pecas2;
    float valorU, valorU2, valorT;

    cout << "Digite o código da primeira peça: ";
    cin >> codigo;

    cout << "Digite a quantidade de peças: ";
    cin >> pecas;

    cout << "Digite o valor unitário de cada peça (utilize ponto '.' para separar decimais): ";
    cin >> valorU;

    cout << "Digite o código da segunda peça: ";
    cin >> codigo2;

    cout << "Digite a quantidade de peças: ";
    cin >> pecas2;

    cout << "Digite o valor unitário de cada peçaa (utilize ponto '.' para separar decimais): ";
    cin >> valorU2;
    valorT = (pecas * valorU) + (pecas2 * valorU2);

   cout << fixed << setprecision(2);
   cout << "O valor total da compra é: R$" << valorT << endl;  

    system("pause");
    return 0;
}