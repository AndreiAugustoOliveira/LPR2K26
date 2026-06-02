#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

void Ex1() {

    int quantidade = 0;
    int numero = 0;
    double media = 0;
    int acumulador = 0;
    int contador = 0;
    double contadorPar = 0;

    cout << "Digite a quantidade de números que voce vai digitar: " << endl;
    cin >> quantidade;
    cout << "Digite um número inteiro qualquer: " << endl;
    cin >> numero;
    contador++;
    
    if (numero % 2 == 0) {
    acumulador += numero; 
    contadorPar++;
     }

    while(quantidade != contador) {
    cout << "Digite um número inteiro qualquer: " << endl;
    cin >> numero;
    contador++;

     if(numero % 2 == 0) {
     acumulador += numero; 
     contadorPar++;
     }
    }
    
    media = acumulador/contadorPar;

    cout << "A média dos números é: " << media << endl;
    system("pause");
    return;
}

void Ex2() {
   int i;
   int acumulador = 0;

   for(i = 50; i < 500; i++) {

    if(i % 2 != 0 && i % 3 == 0) {
    acumulador += i;
    }
     
    if(i != 499) {
    }

    else {
    
  cout << "A soma de todos os números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 a 500 é: " << acumulador << endl;
  system("pause");
  return;
   } 
}

}
void Ex3 () {
    int num = 0;
    int soma = 0;
    int digito = 0;

    cout << "Digite um número: ";
    cin >> num;

    int quadrado = num * num;

    while (quadrado > 0) {
        digito = quadrado % 10;
        soma += digito;
        quadrado /= 10;
    }

    cout << "A soma dos dígitos do quadrado é: " << soma << endl;
    system("pause");
    return;

}

int main() {

      SetConsoleOutputCP(65001);
      SetConsoleCP(65001);

int escolha = 0;

  cout << "Bem vindo!" << endl;
  cout << "Digite o número do exercício que você deseja executar: " << endl;
  cout << "1 - Exercício 1" << endl;
  cout << "2 - Exercício 2" << endl;        
  cout << "3 - Exercício 3" << endl;

  cin >> escolha;

  switch (escolha) {
    case 1:
        Ex1();
        break;
    case 2:
        Ex2();
        break;
    case 3:
        Ex3();
        break;
    default:
        cout << "Opção inválida!" << endl;

    system("pause");
    return 0;
  }
}