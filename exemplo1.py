import random

lista = []

n = int(input("quantos numeros inteiro quer gerar? "))

for i in range(n):
    numero_sorteado = random.randint(0, 10)
    if numero_sorteado not in lista:
        lista.append(numero_sorteado)


lista.sort()
print("Total de elementos:", len(lista))
print(lista)