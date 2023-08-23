
package Exemplo05;


public class Poupanca extends Conta{
  private int aniversario;
    
    public Poupanca(String banco, int agencia, int conta,int aniversario){
        super(banco,agencia,conta);
        this.setAniversario(aniversario);
    }

    public int getAniversario() {
        return aniversario;
    }
    
    public void setAniversario(int aniversario) {
        this.aniversario = aniversario;
    }
    
     public void Sacar(double valor){
        double aux_saldo = getSaldo();
        if(valor>aux_saldo){
            System.out.println("Saldo insuficiente");
        } else {
            setSaldo(valor-aux_saldo);
        }
    }
    public String toString(){
        return "Banco: " + this.getBanco() + "\nAgencia: "+ this.getAgencia() + "\nConta: " + this.getConta() 
        + "\nSaldo: "  + this.getSaldo() + "\nAniversario: " + this.getAniversario();
    }
}


