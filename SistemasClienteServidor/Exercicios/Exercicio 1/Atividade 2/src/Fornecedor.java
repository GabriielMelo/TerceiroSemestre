public class Fornecedor extends Pessoa implements Seguranca {

    private float valorCompra;

    public Fornecedor() {

    }

    public Fornecedor(String n, String f, float vc) {
        super(n, f);
        this.setValorCompra(vc);
    }

    public float getValorCompra() {
        return valorCompra;
    }

    public void setValorCompra(Float valorCompra) {
        if (valorCompra <= 0) {
            System.out.println("Valor inválido");
        } else {
            this.valorCompra = valorCompra;
        }
    }

    public void Print() {
        System.out.println("Fornecedor : " + this.getNome() + "\nTelefone : " + this.getFone()
                + "\nValor da Compra : " + this.valorCompra);
    }

    public float calculaImpostos(float imposto){
        return valorCompra + imposto;
    }

    @Override
    public boolean validar() {
        if(valorCompra <= 0) {
            return false;
        } else {
            return true;
        }
    }
}
