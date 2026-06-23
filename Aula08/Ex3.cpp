#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

 struct Livro
    {
      string titulo;
      string autor;
      int anoPublicacao = 0;
      int numeroPaginas = 0;
      int preco = 0;
    };

int main() {
    SetConsoleOutputCP(65001);
    SetConsoleCP(65001);

    Livro livros[3]; // vetor de structs
    int i = 0;
    int precototal = 0;
    int media = 0;

    cout << "Digite os dados de titulo, autor, ano de publicação, número de páginas e preço  de 3 livros diferentes (não utilize espaço)" << endl;

    for (i = 0;  i<3 ; i++) {
      
      cout << "Título: ";
      cin >> livros[i].titulo;
      cout << "Autor: ";
      cin >> livros[i].autor;
      cout << "Ano de publicação: ";
      cin >> livros[i].anoPublicacao;
      cout << "Número de páginas: ";
      cin >> livros[i].numeroPaginas;
      cout << "Preço: ";
      cin >> livros[i].preco;
      precototal += livros[i].preco;
      media = (livros[0].numeroPaginas + livros[1].numeroPaginas + livros[2].numeroPaginas)/3;
    }

    cout << "O preço total dos livros é: R$" << precototal  << endl;
    cout << "A média de páginas é: " << media << endl;

  system("pause");
  return 0;
}