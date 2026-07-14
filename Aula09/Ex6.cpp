#include <iostream>
#include <iomanip>
#include <windows.h>
#include <map>
#include <cstdlib>
#include <list>


using namespace std;

int main() {

    SetConsoleOutputCP(65001);
    SetConsoleCP(65001);

    int soma = 0;
    int media = 0;
    int i = 0;
    int x = 0;
    string nome;
    int idade = 0;
    int ImaisVelho = 0;
    int ImaisNovo = 1000;
    string maisVelho;
    string maisNovo;
    int y = 0;

     list<string> remover;
  
     map<string, int> pessoas;


     cout << "Quantas pessoas serão cadastradas?" << endl;
     cin >> x;
    cout << "Agora digite o nome e a idade das pessoas: " << endl;

     for(i; i < x ; i++)  {
  
        cout << "Nome: ";
        cin >> nome;

        cout << "Idade: ";
        cin >> idade;

      pessoas.insert({nome, idade});
        
     }

     i = 0;

      for (auto pessoa : pessoas)
    {
        soma += pessoa.second;
    }

    media = soma/pessoas.size();

    cout << "" << endl;
    cout << "Pessoas como idade acima da média :" << endl;

     for (auto pessoa : pessoas)
    {
        if (pessoa.second > media)
        {
            cout << pessoa.first << endl;
        }
    }

    cout << "" << endl;

    for (auto pessoa : pessoas) {

        if (pessoa.second > ImaisVelho) {

            ImaisVelho = pessoa.second;
            maisVelho = pessoa.first;
        } 

        if (pessoa.second < ImaisNovo) {

            ImaisNovo = pessoa.second;
            maisNovo = pessoa.first;
        } 
    }

    cout << "Pessoa mais velha: " << maisVelho << endl;
    cout << "Pessoa mais nova: " << maisNovo << endl;


      cout << "Digite a idade que deseja remover" << endl;
      cin >> y;

    
      for (auto pessoa : pessoas)  {

            if (pessoa.second == y)   {
        remover.push_back(pessoa.first);
            }
        }

        for (auto nome : remover) {

           pessoas.erase(nome);
            }

      cout << "Dicionário atualizado: "<< endl;

       for (auto pessoa : pessoas)
    {
        cout << "Nome: " << pessoa.first << " Idade: " << pessoa.second << endl;
    }


    system("pause");
    return 0;
}