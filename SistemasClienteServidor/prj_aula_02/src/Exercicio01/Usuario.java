package Exercicio01;

public class Usuario extends Pessoa implements Imprimivel, Seguranca {

    private String nomeUsuario;
    private String senha;

    public Usuario() {

    }

    public Usuario(String nu, String s) {
        this.setnomeUsuario(nu);
        this.setSenha(s);
    }

    @Override
    public String formatoString() {
        return "Nome de usuário : " + this.nomeUsuario + nlin +
                "Senha : " + this.senha;
    }
    @Override
    public void formatoSystemOut() {
        System.out.println(this.formatoString());
    }

    @Override
    public boolean validar() {
        return false;
    }


    public String getnomeUsuario() {
        return nomeUsuario;
    }

    public void setnomeUsuario(String nomeUsuario) {
        if (nomeUsuario.isEmpty()) {
            System.out.println("Nome de usuario deve conter pelo menos 3 caracteres");
        } else {
            this.nomeUsuario = nomeUsuario;
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

