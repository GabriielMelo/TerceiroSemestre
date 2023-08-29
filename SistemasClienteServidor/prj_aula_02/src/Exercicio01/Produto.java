package Exercicio01;

public class Produto implements Imprimivel, Seguranca {
    private String descricao;
    private int quantidade;

    public Produto(String d, int q) {
        this.setDescricao(d);
        this.setQuantidade(q);
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        if (descricao.length() < 1) {
            System.out.println("Descrição do produto inválida");
        } else {
            this.descricao = descricao;
        }
    }

    public int getQuantidade() {
        return quantidade;
    }

    public void setQuantidade(int quantidade) {
        if (quantidade < 0) {
            System.out.println("Quantidade inválida");
        } else {
            this.quantidade = quantidade;
        }
    }

    @Override
    public String formatoString() {
        return null;
    }

    @Override
    public void formatoSystemOut() {

    }

    @Override
    public boolean validar() {
        return false;
    }
}

