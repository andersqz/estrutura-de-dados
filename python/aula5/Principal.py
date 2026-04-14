from Matriz import Matriz

def main():
    dimensao = 10
    matriz = Matriz.inicializar(dimensao)  # retorna a matriz, não precisa passar como parâmetro

    # definindo os elementos não nulos
    matriz[0][3] = 1
    matriz[2][5] = 1
    matriz[5][7] = 1
    matriz[6][8] = 1

    Matriz.exibir(matriz)

    lista = Matriz.converter_para_lista(matriz)
    Matriz.exibir_lista(lista)

# Equivalente ao if __name__ == "__main__" é a forma Python de definir o ponto de entrada,
# igual ao public static void main() do Java
if __name__ == "__main__":
    main()