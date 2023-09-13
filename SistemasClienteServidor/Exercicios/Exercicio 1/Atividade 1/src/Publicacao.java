public abstract class Publicacao {
    private String titulo;
    private String dataPublicacao;

    public Publicacao(String t, String d) {
        this.setTitulo(t);
        this.setDataPublicacao(d);
    }

    public abstract void imprimir();

    public String getDataPublicacao() {
        return dataPublicacao;
    }

    public void setDataPublicacao(String dataPublicacao) {
        if (dataPublicacao.length() < 10) {
            System.out.println("Favor inserir no formato " +
                    "data dd/mm/aaaa");
        } else
            this.dataPublicacao = dataPublicacao;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        if (titulo.length() <3) {
            System.out.println("Titulo do livro" +
                    " não pode estar vazio");
        } else
            this.titulo = titulo;
    }

}
