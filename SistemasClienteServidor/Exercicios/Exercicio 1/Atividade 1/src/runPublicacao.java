public class runPublicacao {
    public static void main(String[] args) {

        Livro l1 = new Livro("Harry Potter e o Enigma do Principe", "26/11/2005","Bloomsbury");


        l1.imprimir();
        System.out.println("--------------------------------------");
        Revista r1 = new Revista("Super Interessante","11/09/2023","Abril","São Paulo, SP");

        r1.imprimir();

    }
}
