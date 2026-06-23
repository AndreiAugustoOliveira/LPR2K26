#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

 struct Produto 
    {
      string nome;
      int codigo = 0;
      int preco = 0;
      int quantidade = 0;
    };

int main() {
    SetConsoleOutputCP(65001);
    SetConsoleCP(65001);

    Produto produtos[3]; // vetor de structs
    int i = 0;
    int soma = 0;

    cout << "Digite os dados de nome, código, preço e quantidade de 3 produtos diferentes (não utilize espaço)" << endl;

    for (i = 0;  i<3 ; i++) {
      
      cout << "Nome: ";
      cin >> produtos[i].nome;
      cout << "Código: ";
      cin >> produtos[i].codigo;
      cout << "Preço: ";
      cin >> produtos[i].preco;
      cout << "Quantidade: ";
      cin >> produtos[i].quantidade;
      soma += produtos[i].preco*produtos[i].quantidade;
    }

    cout << "O valor da compra é: " << soma  << endl;
  system("pause");
  return 0;
}