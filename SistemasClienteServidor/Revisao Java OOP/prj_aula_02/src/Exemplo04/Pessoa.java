package Exemplo04;

public abstract class Pessoa {

    private String nome;
    private int idade;
    private double salario;

    public Pessoa(String nome, int idade, double salario) {
        this.setNome(nome);
        this.setIdade(idade);
        this.setSalario(salario);
    }

    public void setSalario(double salario) {
        if (salario <= 0) {
            System.out.println("Valor inválido");
        } else {
            this.salario = salario;
        }
    }

    public double getSalario() {
        return salario;
    }

    public String getNome() {
        return nome;
    }

    public int getIdade() {
        return idade;
    }

    public void setNome(String nome) {
        if (nome.equals("")) {
            System.out.println("Nome inválido");
        } else {
            this.nome = nome;
        }
    }

    public void setIdade(int idade) {
        if (idade <= 0 || idade > 120) {
            System.out.println("Idade inválida");
        } else {
            this.idade = idade;
        }
    }
    
    public abstract void calcularSalario();

}
