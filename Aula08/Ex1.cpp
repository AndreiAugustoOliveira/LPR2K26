#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

int main() {
    SetConsoleOutputCP(65001);
    SetConsoleCP(65001);

    struct Filme 
    {
      string titulo;
      string diretor;
      int AnoLancamento = 0;
      int DuracaoMinutos = 0;
    };

    Filme filmes[3]; // vetor de structs
    int i = 0;

    cout << "Digite os dados de título, diretor, ano de lançamento, e duração em minutos de um filme" << endl;

    for (i = 0;  i<3 ; i++) {
       
      cin >> filmes[i].titulo;
      cin >> filmes[i].diretor;
      cin >> filmes[i].AnoLancamento;
      cin >> filmes[i].DuracaoMinutos;

    }
    
    cout << "Os filmes cadastrados são:" << endl;

    for (i = 0; i<3; i++) {
        cout << filmes[i].titulo << endl;
        cout << filmes[i].diretor << endl;
        cout << filmes[i].AnoLancamento << endl;
        cout << filmes[i].DuracaoMinutos << endl;
    }  

    system("pause");
    return 0;
}