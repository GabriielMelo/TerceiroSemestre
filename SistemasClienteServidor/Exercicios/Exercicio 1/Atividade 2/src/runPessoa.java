public class runPessoa {
    public static void main(String[] args) {

        Cliente c1 = new Cliente();
        Cliente c2 = new Cliente("Fernanda", "11932323212",500f);

        c1.setNome("Carlos");
        c1.setFone("11923332103");
        c1.setValorDivida(1000f);
        c1.setValorDivida(c1.calculaJuros(200f));
        c1.Print();
        System.out.println("--------------------------------");
        c2.setValorDivida(c2.calculaJuros(500f));
        c2.Print();
        System.out.println("--------------------------------");

        Fornecedor f1 = new Fornecedor();
        Fornecedor f2 = new Fornecedor("Casas Bahia","1131349923",50000f);
        f1.setNome("Magazine Luiza");
        f1.setFone("1233452332");
        f1.setValorCompra(1000f);
        f1.setValorCompra(f1.calculaImpostos(200f));
        f1.Print();
        System.out.println("--------------------------------");
        f2.setValorCompra(f2.calculaImpostos(1000));
        f2.Print();





    }
}
