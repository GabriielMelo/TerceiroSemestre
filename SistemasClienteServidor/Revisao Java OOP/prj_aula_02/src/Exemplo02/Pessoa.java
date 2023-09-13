package Exemplo02;

public class Pessoa {

    private String nome;
    private int idade;
    
    public Pessoa(String nome,int idade){
        this.setNome(nome);
        this.setIdade(idade);
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

}
