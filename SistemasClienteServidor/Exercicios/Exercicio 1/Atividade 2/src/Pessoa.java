public class Pessoa {
    private String nome;
    private String fone;

    public Pessoa() {

    }

    public Pessoa(String n, String f) {
        this.setNome(n);
        this.setFone(f);
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        if (nome.length() < 3) {
            System.out.println("Nome inválido");
        } else
            this.nome = nome;
    }

    public String getFone() {
        return fone;
    }

    public void setFone(String fone) {
        if (fone.length() < 8) {
            System.out.println("Telefone inválido");
        }
        this.fone = fone;
    }

    public void Print() {
        String print = "Nome : " + this.getNome()
                + "\nTelefone : " + this.getFone();
        System.out.println(print);
    }

}
