#include <iostream>
#include <vector>
#include <algorithm> // sort()
#include <cstdlib>   // rand(), srand()
#include <ctime>     // time ()
#include <string>    
#include <fstream>   // ofstream - para escrita em arquivo

void popularListaArquivo(const std::vector<std::string>& lista, const std::string& nomeArquivo) {

    std::ofstream arquivo(nomeArquivo, std::ios::app);

    if (!arquivo.is_open()) {
        std::cout << "Erro ao abrir o arquivo!" << std::endl;
    } else {
        for (int i = 0; i < lista.size(); i++) {
            arquivo << lista[i] << "\n";
        }
        arquivo.close();
        std::cout << "Lista salva em: " << nomeArquivo << std::endl;
    }


}

int main() {

    srand(time(0));

    std::string letras = "abcdefghijklmnopqrstuvwxyz";
    std::vector<std::string> lista; // lista de strings acessadas por indice (tipo um vetor)

    int n, tamanhoPalavra;
    std::cout << "Quantos nomes quer gerar? ";
    std::cin >> n;
    std::cout << "Qual tamanho da palavra a ser sorteada? ";
    std::cin >> tamanhoPalavra;

    int i = 0;
    std::string palavra = "";

    while (i < n) {

        palavra = "";

        for (int j = 0; j < tamanhoPalavra; j++) {
            int posicaoLetras = rand() % letras.size();
            palavra += letras[posicaoLetras];
        }

        bool jaExiste = false;
        for (int k = 0; k < lista.size(); k++) {
            if (lista[k] == palavra) {
                jaExiste = true;
                break;
            }
        }

        if (!jaExiste) {
            lista.push_back(palavra);
            i++;
        }
    }

    std::sort(lista.begin(), lista.end());

    std::cout << "[";
    for (int i = 0; i < lista.size(); i++) {
        std::cout << "'" << lista[i] << "'";
        if (i < lista.size() - 1) std::cout << ", ";
    }
    std::cout << "]" << std::endl;

    popularListaArquivo(lista, "nomes.txt");

    std::cout << "Palavra sorteada: " << palavra << std::endl;

    return 0;
}