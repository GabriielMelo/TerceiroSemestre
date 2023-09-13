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
        if (descricao.isEmpty()) {
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
        return  "Descrição do Produto : " + this.descricao + nlin +
                "Quantidade : " + this.quantidade;
    }

    @Override
    public void formatoSystemOut() {
        System.out.println(this.formatoString());
    }

    @Override
    public boolean validar() {
        if (!this.descricao.isEmpty() && this.quantidade > 0) {
            return true;
        } else {
            return false;
        }
    }
}

