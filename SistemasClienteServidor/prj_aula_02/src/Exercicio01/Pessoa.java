package Exercicio01;

public abstract class Pessoa {
    protected String nomeCompleto;
    protected int idade;

    public Pessoa(){

    }

    public Pessoa(String nc,int i){
        this.setnomeCompleto(nc);
        this.setIdade(i);
    }

    public String getnomeCompleto() {
        return nomeCompleto;
    }

    public void setnomeCompleto(String nomeCompleto) {
        if(this.nomeCompleto.isEmpty()){
            System.out.println("Nome inválido");
        } else {
            this.nomeCompleto = nomeCompleto;
        }
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        if(idade<=0 || idade >=110){
            System.out.println("Idade inválida");
        } else {
        this.idade = idade;
        }
    }
}

