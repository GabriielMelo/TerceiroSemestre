
package Exemplo04;


public class OperadorCaixa extends Pessoa{
    private double bonus;
    
    public OperadorCaixa(String nome, int idade, double salario, double bonus){
        super(nome,idade,salario);
        this.setBonus(bonus);
    }

    public double getBonus() {
        return bonus;
    }

    public void setBonus(double bonus) {
        if(this.bonus<0){
            System.out.println("Valor inválido");
        } else {
        this.bonus = bonus;
        }
    }
    @Override
    public void calcularSalario(){
      double aux_salario = getSalario() + getBonus();
        System.out.println("O Salario total do Caixa é: " + aux_salario);
    }
}
