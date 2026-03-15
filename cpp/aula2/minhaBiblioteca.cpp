#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include <ctime>
#include <cctype>
#include <cstdlib>

void popularAleatorio(std::vector<int>& lista, int quantidade) {
    for (int i = 0; i < quantidade; i++) {
        //int numeroSorteado = rand() % 101; 
        //lista.push_back(numeroSorteado)
        lista.push_back(rand() % 101);
    }
}

void popularDeArquivo(std::vector<std::string>& lista, const std::string nomeArquivo) {

    std::ifstream fin(nomeArquivo, std::ios::app);

    std::string linha = "";
    
    if (!fin.is_open()) {
        std::cout << "Erro ao abrir o arquivo!" << std::endl;
        return;
    } else {
        while(std::getline(fin, linha)) {
        lista.push_back(linha);
        }
    }
    fin.close();
}

void exibir(std::vector<std::string>& lista) {
    
    for (int i = 0; i < lista.size(); i++) {
        std::cout << lista[i] << "\n";
    }
    std::cout << "--------------";
    std::cout << "Total de registros: " << lista.size() << std::endl;
}


void copiarListaSemReplicados(const std::vector<int>& lista_origem, std::vector<int>& lista_destino) {

    
    for (int i = 0; i < lista_origem.size(); i++) {

        bool jaExiste = false;
        for (int j = 0; j < lista_destino.size(); j++) {
            if (lista_origem[i] == lista_destino[i]) {
            jaExiste = true;
            break;
            }
        }
        if (!jaExiste) {
            lista_destino.push_back(lista_origem[i]);
        }
    }
}
