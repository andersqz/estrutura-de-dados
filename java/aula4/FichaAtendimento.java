import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;

public class FichaAtendimento {

    /**
     * método de classe que gera ficha normal
     * @param filaNormal - fila contendo as fichas ditas não prioritárias
     * @param contadorNormal - controla o número das fichas normais
     * @return
     */
    public static int geraFichaNormal(Queue<Integer> filaNormal, int contadorNormal) {
        System.out.print("Imprimindo ficha normal....");
        System.out.println(contadorNormal);
        filaNormal.offer(contadorNormal);
        contadorNormal++;
        return contadorNormal;
    }

    /**
     * método de classe que gera ficha prioritária
     * @param filaPrioritaria - fila contendo as fichas ditas prioritárias
     * @param contadorPrioritario - controla o número das fichas prioritárias
     * @return
     */
    public static int geraFichaPrioritaria(Queue<Integer> filaPrioritaria, int contadorPrioritario) {
        System.out.print("Imprimindo ficha prioritaria.... ");
        System.out.println(contadorPrioritario);
        filaPrioritaria.offer(contadorPrioritario);
        contadorPrioritario++;
        return contadorPrioritario;
    }

    /**
     * método de classe que gera um atendimento, ou seja, chama uma ficha
     * @param filaNormal - contém as fichas ditas não prioritárias
     * @param filaPrioritaria - contém as fichas prioritárias
     * @param contadorAtendimentos - controla a quantidade de atendimentos no geral
     * @return
     */
    public static int geraAtendimentos(Queue<Integer> filaNormal, Queue<Integer> filaPrioritaria, int contadorAtendimentos) {
        if (filaNormal.isEmpty() && filaPrioritaria.isEmpty()) {
            System.out.println("Não há fichas para chamar");
            return contadorAtendimentos;
        }
        System.out.print("Chamando ficha....");
        int ficha;
        if (contadorAtendimentos % 3 == 0 || filaNormal.isEmpty()) {
            // chamar o prioritario
            if (!filaPrioritaria.isEmpty()) {
                ficha = filaPrioritaria.poll();
                System.out.println("PRIORITARIA...." + ficha);
                contadorAtendimentos++;
                return contadorAtendimentos;
            }
        }
        if (!filaNormal.isEmpty()) {
            ficha = filaNormal.poll();
            System.out.println("NORMAL...." + ficha);
            contadorAtendimentos++;
        }
        return contadorAtendimentos;
    }

    /**
     * método de classe que mostra as fichas faltantes nas filas normal e prioritária
     * @param filaNormal - fila contendo as fichas não prioritárias
     * @param filaPrioritaria - fila contendo as fichas prioritárias
     */
    public static void mostraFichasFaltantes(Queue<Integer> filaNormal, Queue<Integer> filaPrioritaria) {
        if (filaNormal.isEmpty() && filaPrioritaria.isEmpty()) {
            System.out.println("Não há fichas para chamar");
            return;
        }
        System.out.println("IMostrando fichas faltantes....");
        if (!filaNormal.isEmpty()) {
            System.out.println("Total de fichas faltantes NORMAL...." + filaNormal.size() + " - " + filaNormal);
        }
        if (!filaPrioritaria.isEmpty()) {
            System.out.println("Total de fichas faltantes PRIORITARIAS...." + filaNormal.size() + " - " + filaPrioritaria);
        }
    }

    /**
     * método de classe que gerencia o menu de opções para a gestão de fichas
     * @param filaNormal - contém as fichas não prioritárias
     * @param filaPrioritaria - contém as fichas prioritárias
     */
    public static void menu(Queue<Integer> filaNormal, Queue<Integer> filaPrioritaria) {
        String opcao;
        Scanner in = new Scanner(System.in);
        int contadorNormal = 1;
        int contadorPrioritario = 501;
        int contadorAtendimentos = 0;

        do {
            
            System.out.println("M E N U");
            System.out.println("1 - Ficha normal");
            System.out.println("2 - Ficha Prioritária");
            System.out.println("3 - Chamar ficha");
            System.out.println("4 - Mostrar fichas faltantes");
            System.out.println("5 - Sair");
            System.out.println("Opção: ");
            opcao = in.nextLine();

            switch (opcao) {

                case "1":
                    contadorNormal = FichaAtendimento.geraFichaNormal(filaNormal, contadorNormal);
                    break;
                case "2":
                    contadorPrioritario = FichaAtendimento.geraFichaPrioritaria(filaPrioritaria, contadorPrioritario);
                    break;
                case "3":
                    contadorAtendimentos = FichaAtendimento.geraAtendimentos(filaNormal, filaPrioritaria, contadorAtendimentos);
                    break;
                case "4":
                    FichaAtendimento.mostraFichasFaltantes(filaNormal, filaPrioritaria);
                    break;
                case "5":
                    System.out.println("Saindo....");
                    break;
                default:
                    System.out.println("Entrada invalida!");
                    break;
            }

        } while (!opcao.equals("5"));

    }
    public static void main(String[] args) {
        Queue<Integer> filaNormal = new LinkedList<>();
        Queue<Integer> filaPrioritaria = new LinkedList<>();
        FichaAtendimento.menu(filaNormal, filaPrioritaria); 
    }
}
