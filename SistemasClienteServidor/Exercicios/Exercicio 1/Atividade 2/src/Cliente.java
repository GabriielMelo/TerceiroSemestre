public class Cliente extends Pessoa {
    private float valorDivida;

    public Cliente(){

    }
    public Cliente(String n, String f, float v){
        super(n,f);
        this.setValorDivida(v);
    }

    public float getValorDivida() {
        return valorDivida;
    }

    public void setValorDivida(float valorDivida) {
        if(valorDivida <=0 ){
            System.out.println("Valor de divida inválida");
        } else
        this.valorDivida = valorDivida;
    }
    public float calculaJuros(Float tx){
        return this.getValorDivida() + tx;
    }

    public void Print(){
        System.out.println("Cliente : " + this.getNome() + "\nTelefone : " + this.getFone() +
                "\nValor da Divida : " + this.valorDivida);
    }
}


