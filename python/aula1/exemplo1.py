import random
from python.util import popularListaArquivo

listUniqueNumbers = []

n = int(input("quantos numeros inteiro quer gerar? "))

for i in range(n):
    numero_sorteado = random.randint(0, 10)
    if numero_sorteado not in listUniqueNumbers:
        listUniqueNumbers.append(numero_sorteado)


listUniqueNumbers.sort()
print("Total de elementos:", len(listUniqueNumbers))
print(listUniqueNumbers)

