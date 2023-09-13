

package Exemplo04;



public class Principal {
    public static void main(String[] args) {
        Vendedor v1 = new Vendedor("Gabriel",34,5000,100);
        OperadorCaixa c1 = new OperadorCaixa("Jose",22,8000,300);
        
        v1.calcularSalario();
        System.out.println("-------------------------------------");
        c1.calcularSalario();
    }
}
