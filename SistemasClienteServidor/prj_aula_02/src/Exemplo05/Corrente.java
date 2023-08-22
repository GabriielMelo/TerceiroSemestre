
package Exemplo05;


public class Corrente extends Conta{
    
    
    private double limite;

    public Corrente(String banco, int agencia, int conta, double limite) {
        super(banco, agencia,conta);
        this.setLimite(limite);
    }

    public double getLimite() {
        return limite;
    }

    public void setLimite(double limite) {
        this.limite = limite;
    }
    
    public void Sacar(double valor){
        if(valor > (this.getSaldo()+ limite)){
            System.out.println("Saldo insuficiente");
        } else {
            this.setSaldo(valor-getSaldo());
        }
    }
    public String toString(){
return "Banco: " + this.getBanco() + "\nAgencia: "+ this.getAgencia() + "\nConta: " + this.getConta() 
        + "\nSaldo: "  + this.getSaldo() + "\nLimite: " + this.getLimite();
    }
}
