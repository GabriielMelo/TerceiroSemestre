
package Exemplo05;


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
        double aux_limite = getLimite();
        double aux_saldo = getSaldo();
        double saldoAtual = aux_saldo+aux_limite;

        if(valor > saldoAtual){
            System.out.println("Saldo indisponível");
        } else if (valor > aux_saldo){
            double valorExcedente = aux_saldo - valor;
            if(valorExcedente <= aux_limite){
                setSaldo(0);
                setLimite(valorExcedente-aux_limite);
                System.out.println("Saque realizado com sucesso");
            } else {
                System.out.println("Limite insuficiente");
            }
        } else {
            aux_saldo -= valor;
            setSaldo(aux_saldo);
        }

    }
    public String toString(){
return "Banco: " + this.getBanco() + "\nAgencia: "+ this.getAgencia() + "\nConta: " + this.getConta()
        + "\nSaldo: "  + this.getSaldo() + "\nLimite: " + this.getLimite();
    }
}
