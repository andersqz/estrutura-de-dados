import java.util.ArrayList; // ← A e L maiúsculos

public class Principal {
    public static void main(String[] args) { // ← String com S maiúsculo
        int dimensao = 10;
        int matriz[][] = new int[dimensao][dimensao];
        Matriz.inicializarMatriz(matriz, dimensao, dimensao);
        matriz[0][3] = 1;
        matriz[2][5] = 1;
        matriz[5][7] = 1;
        matriz[6][8] = 1;
        Matriz.exibirMatriz(matriz, dimensao, dimensao);

        ArrayList<Dado> lista = new ArrayList<>();
        Matriz.converterMatrizLista(matriz, dimensao, dimensao, lista);
    }
}