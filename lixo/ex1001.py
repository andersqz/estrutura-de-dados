# código que le n numeros aleatorios entre 0-100 e guarda em uma lista dinamica
# apos, eh processado e exibido na tela a média dos numeros gerados,
# o maior e o menor valor do vetor, e a posicao desses elementos.

import random

list = []

# estrutura que verifica se a entrada eh um inteiro positivo
while True:
    n = int(input("quantos numeros inteiros quer gerar? "))
    if (n <= 0): 
        print("O numero deve ser positivo")
    else:
        break;

for i in range(n):
    numeros_sorteados = random.randint(1, 100)
    list.append(numeros_sorteados)

maior = list[0]
menor = list[0]
posicao_maior = 0
posicao_menor = 0
soma = 0

for i in range(n):
    if list[i] > maior:
        maior = list[i]
        posicao_maior = i

    if list[i] < menor:
        menor = list[i]
        posicao_menor = i
        
    soma = soma + list[i]

media = soma / n
print("a media dos numeros eh", media)
print("o maior numero da lista eh: ", maior)
print("a posicao do maior elemento no vetor: ", posicao_maior)
print("a posicao do menor elemento no vetor: ", posicao_menor)

