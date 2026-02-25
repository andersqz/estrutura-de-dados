# código para gerar n numeros aleatorios de 0 ate 10,
# e armazenar na variavel lista apenas os numeros q 
# forem unicos, apos, ordena os numeros da lista por
# ordem crescente e imprimi a quantidade de elementos

import random

list_unique_numbers = []

while True:
    n = int(input("quantos numeros inteiros quer gerar? "))
    if (n <= 0): 
        print("O numero deve ser positivo")
    else:
        break;

for i in range(n):
    numero_sorteado = random.randint(0, 10)
    if numero_sorteado not in list_unique_numbers:
        list_unique_numbers.append(numero_sorteado)


list_unique_numbers.sort() # ordena a lista de n numeros unicos por ordem crescente
print("Total dos elementos: ", len(list_unique_numbers))
print(list_unique_numbers)