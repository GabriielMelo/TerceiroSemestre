package Exemplo05;

public class Principal {
    public static void main(String[] args) {
        
        Corrente c1 = new Corrente("Banco do Brasil",5151,1411,1000);
        Poupanca p1 = new Poupanca("Bradesco",123,1010,31);
        
        c1.Depositar(5000);
        c1.setLimite(1000);
        p1.Depositar(500);
        System.out.println(c1);
        System.out.println("------------");
        System.out.println(p1);
        c1.Sacar(299);
        p1.Sacar(300);
        System.out.println(c1);
        System.out.println("------------");
        System.out.println(p1);
        
    }
}
