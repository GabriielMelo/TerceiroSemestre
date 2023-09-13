
package Exemplo04;

public class Vendedor extends Pessoa{
    private double comissao;

    public Vendedor(String nome, int idade, double salario, double comissao){
        super(nome,idade,salario);
        this.setComissao(comissao);
    }
    
    public double getComissao() {
        return comissao;
    }

    public void setComissao(double comissao) {
        this.comissao = comissao;
    }
    @Override
    public void calcularSalario(){
      double aux_salario = getSalario() + getComissao();
        System.out.println("O Salario total do vendedor é: " + aux_salario);
    }
}
