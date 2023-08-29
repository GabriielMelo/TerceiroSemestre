
package Exemplo06;


public class Corrente extends Conta{
    
    
    private double limite;

    public Corrente(String banco, int agencia, int conta, double limite) {
        super(banco,agencia,conta);
        this.setLimite(limite);
    }

    public double getLimite() {
        return limite;
    }

    public void setLimite(double limite) {
        this.limite = limite;
    }
    
    public void Sacar(double valor) {
       if(valor > (this.getSaldo()+this.getLimite())){
            System.out.println("Saldo insuficiente");
        } else {
           this.setSaldo((this.getSaldo()+this.getLimite())-valor);
       }

    }
    public String toString(){
    return super.toString() + "\nLimite " + this.limite;
    }
}
