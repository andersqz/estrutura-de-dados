#include <iostream>
#include <vector>
#include <algorithm>
#include <cstdlib>
#include <ctime>

using na

int main() {
    
    std::vector<int> listUniqueNumbers;

    int n;
    std::cout << "Quantos numeros quer gerar? ";
    std::cin >> n;

    if (n > 11) {
        std::cout << "So existe 11 valores unicos possiveis (0-10).";
        return 1;
    }

    srand(time(0));

    while (listUniqueNumbers.size() < n) {
        int numeroSorteado = rand() % 11;

        bool jaExiste = false;
        for (int i = 0; i < listUniqueNumbers.size(); i++) {
            if (listUniqueNumbers[i] == numeroSorteado) {
                jaExiste = true;
                break;
            }
        }

        if (!jaExiste) {
            listUniqueNumbers.push_back(numeroSorteado);
        }
    }

    std::sort(listUniqueNumbers.begin(), listUniqueNumbers.end());

    std::cout << "Total de elementos: " << listUniqueNumbers.size() << std::endl;

    std::cout << "[";
    for (int i = 0; i < listUniqueNumbers.size(); i++) {
        std::cout << listUniqueNumbers[i];
        if (i < listUniqueNumbers.size() -1) std::cout << ", ";
    }
    std::cout << "]" << std::endl;

    return 0;
}