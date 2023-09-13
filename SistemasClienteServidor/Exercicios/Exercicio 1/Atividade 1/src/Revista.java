public class Revista extends Publicacao {
    private String editor;
    private String local;

    public Revista(String t, String d, String e, String l) {
        super(t, d);
        this.setEditor(e);
        this.setLocal(l);
    }

    public String getEditor() {
        return editor;
    }

    public void setEditor(String editor) {
        if (editor.length() < 3) {
            System.out.println("Nome inválido");
        } else
            this.editor = editor;
    }

    public String getLocal() {
        return local;
    }

    public void setLocal(String local) {
        if (local.length() < 2) {
            System.out.println("Local inválido");
        } else
            this.local = local;
    }

    @Override
    public void imprimir() {
        System.out.println("Publicação Revista\n" + "Titulo : " + this.getTitulo()
        + "\nData da publicação : " + this.getDataPublicacao()+
                "\nEditor : " + this.editor +
                "\nLocal : " + this.local);
    }
}

