import java.util.ArrayList; // ← corrigido (embora não seja usado aqui)

public class Dado {
    public int valor;
    public int lin;
    public int col;

    public Dado(int valor, int lin, int col) {
        this.valor = valor;
        this.lin = lin;
        this.col = col;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) return true;
        if (obj == null) return false;
        if (getClass() != obj.getClass()) return false;
        final Dado other = (Dado) obj;
        if (this.lin != other.lin) return false;
        return this.col == other.col;
    }

    @Override
    public String toString() { // ← String com S maiúsculo
        return "valor: " + valor + " | linhas: " + lin + " | colunas: " + col;
    }
}