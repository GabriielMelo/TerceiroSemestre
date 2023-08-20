package exemplo01;

public class Principal {

    public static void main(String[] args) {
        Pessoa p1 = new Pessoa();
        p1.setNome("");
        p1.setIdade(31);

        System.out.println(p1.getNome() + " " + p1.getIdade());

    }
}
