package Exercicio01;

public class Usuario extends Pessoa implements Imprimivel, Seguranca {

    private String nomeusuario;
    private String senha;

    public Usuario() {

    }

    public Usuario(String nu, String s) {
        this.setNomeusuario(nu);
        this.setSenha(s);
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


    public String getNomeusuario() {
        return nomeusuario;
    }

    public void setNomeusuario(String nomeusuario) {
        if (nomeusuario.length() < 3) {
            System.out.println("Nome de usuario" + " deve conter pelo menos 3 caracteres");
        } else {
            this.nomeusuario = nomeusuario;
        }
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        if (senha.length() != 6) {
            System.out.println("senha deve conter pelo menos 6 " + "caracteres ");
        } else {
            this.senha = senha;
        }
    }


}

