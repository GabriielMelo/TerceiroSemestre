package Exemplo05;

// implementar metodo saca
public abstract class Conta {

    String banco;
    int agencia;
    int conta;
    double saldo;
    
    public Conta(String banco, int agencia,int conta){
        this.setBanco(banco);
        this.setAgencia(agencia);
        this.setConta(conta);
        this.setSaldo(0);
    }

    public void Depositar(double valor){
        if(valor>0){
            this.saldo += valor;
        } else {
            System.out.println("Valor inválido");
        }
    };
    
    public void setBanco(String banco) {
        if (banco.length() >= 3) {
            this.banco = banco;
        } else {
            System.out.println("Nome do banco inválido");
        }
    }

    public void setAgencia(int agencia) {
        if (agencia > 0) {
            this.agencia = agencia;
        } else {
            System.out.println("Agencia Inválida");
        }

    }

    public void setConta(int conta) {
        if (conta > 0) {
            this.conta = conta;
        } else {
            System.out.println("Conta inválida");
        }

    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }
    
    public abstract void Sacar(double valor);
    
    public  String toString(){
        return    "Banco: " + this.banco
                + "\nAgencia: "+ this.agencia
                + "\nConta: " + this.conta
                + "\nSaldo: "  + this.saldo;
    }

    public double getSaldo() {
        return saldo;
    }

    public int getConta() {
        return conta;
    }

    public int getAgencia() {
        return agencia;
    }

    public String getBanco() {
        return banco;
    }
}
