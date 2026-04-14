

class Dado:
    def __init__(self, valor: int, lin: int, col: int):
        self.valor = valor
        self.lin = lin
        self.col = col

    def __eq__(self, outro):
        if not isinstance(outro, Dado):
            return False
        return self.lin == outro.lin and self.col == outro.col
    
    def __str__(self):
        return f"valor: {self.valor} | linhas: {self.lin} | colunas: {self.col}";
 
    