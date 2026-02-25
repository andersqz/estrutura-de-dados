# código para gerar n numeros aleatorios de 0 ate 10,
# e armazenar na variavel lista apenas os numeros q 
# forem unicos, apos, ordena os numeros da lista por
# ordem crescente e imprimi a quantidade de elementos



import random

listUniqueNumbers = []

n = int(input("quantos numeros inteiros quer gerar? "))

for i in range(n):
    numero_sorteado = random.randint(0, 10)
    if numero_sorteado not in listUniqueNumbers:
        listUniqueNumbers.append(numero_sorteado)


listUniqueNumbers.sort()
print("Total dos elementos: ", len(listUniqueNumbers))
print(listUniqueNumbers)