from Dado import Dado

class Matriz:
    @staticmethod
    def inicializar(dimensao: int) -> list[list[int]]:
        # Em Python não precisamos inicializar com zeros manualmente:
        # list comprehension cria a matriz já preenchida
        return [[0] * dimensao for _ in range(dimensao)]


    @staticmethod
    def exibir(matriz: list[list[int]]):
        for linha in matriz:
            # join transforma a lista de inteiros em string separada por tab
            print("\t".join(str(v) for v in linha))
        print()

    @staticmethod
    def converter_para_lista(matriz: list[list[int]]) -> list[Dado]:
        # Em Python, listas são dinâmicas — não precisamos passar como parâmetro
        lista = []
        for i, linha in enumerate(matriz):      # enumerate dá o índice + valor
            for j, valor in enumerate(linha):
                if valor != 0:
                    lista.append(Dado(valor, i, j))
        return lista

    @staticmethod
    def exibir_lista(lista: list[Dado]):
        for item in lista:
            print(item)  # chama __str__ automaticamente
        print("-------------------------")
        print(f"Total de elementos não nulos: {len(lista)}")