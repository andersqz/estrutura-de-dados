
class Glicemia:
    def __init__(self, valor, data, hora):
        """constutor básico com os 3 atributos da classe
        
        Args: 
            valor (int): de glicemia de sangue
            data (string): data da medição
            hora (string): hora da medição
        """
        self.valor = valor
        self.data = data
        self.hora = hora

        def __eq__(self, outro):
            if not isinstance(outro, Glicemia):
                return False
            return self.data == outro.data and self.hora == outro.hora

    def __str__(self):
        return f'valor: {self.valor} | Data: {self.data} | Hora: {self.hora}'
    
