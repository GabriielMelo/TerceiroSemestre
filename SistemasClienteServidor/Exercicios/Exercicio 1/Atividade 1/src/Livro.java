public class Livro extends Publicacao {
    private String editora;

    public Livro(String t, String d, String e) {
        super(t, d);
        this.setEditora(e);
    }

    public String getEditora() {
        return editora;
    }

    public void setEditora(String editora) {
        if (editora.length() <= 4) {
            System.out.println("Nome da editora " +
                    "deve conter mais de 4 caracteres");
        } else
            this.editora = editora;
    }

    @Override
    public void imprimir() {
        System.out.println("Publicação Livro\n" +
                "Titulo : " + this.getTitulo() + "\nData da Publicação : " +
                this.getDataPublicacao() + "\nEditora : " + this.editora );
    }
}
