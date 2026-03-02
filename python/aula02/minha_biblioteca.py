from random import randint

def popular_aleatorio(lista: int, quantidade: int):
    """_summary_
    metodo que recebe uma lista e a popula com números aleatórios

    Args:
        lista (int): lista de números
        quantidade (int): quantidade de números a serem gerados aleatoriamente na lista
    """
    for i in range(quantidade):
        lista.append( randint(0,100) )

def popular_de_arquivo(lista, nome_arquivo):
    """_summary_
    metodo que recebe uma lista e a popula com dados vindo de um arquivo
    Args:
        lista (_type_): lista genérica
        nome_arquivo (string): nome do arquivo fonte que contém os dados
    """
    with open(nome_arquivo, 'r', encoding='utf8') as leitor:
        for linha in leitor:
            lista.append(linha.strip())
    

def exibir(lista):
    """_summary_
    metodo que recebe uma lista genérica, exibe todos os seus elementos na tela (um abaixo do outro)
    e no final exiba quantidade de elementos da lista

    Args:
        lista (_type_): lista genérica
    """
    for i in lista:
        print(i)

    print("----------------")
    print("Total de registros: ", len(lista))

def copiar_lista_sem_replicados(lista_origem, lista_destino):
    """_summary_
    método que recebe uma lista origem e copia seus elementos para a lista destino, retirando os replicados
    Args:
        lista_origem (_type_): lista com os dados de origem
        lista_destino (_type_): lista para receber os dados tratados
    """

