package imc;

public class ModeloImc {

    private Double peso, altura, imc;
    private String classificacao;
        
    
    public ModeloImc(double peso, double altura) {
        this.setPeso(peso);
        this.setAltura(altura);
    }

    public void calcularIMC(double peso, double altura) {
        this.setImc(peso / (altura * altura));
    }

    public void classificarIMC(double imc) {

        if (imc < 18.5) {
            this.setClassificacao("Estado de desnutrição");
        } else if (imc >= 18.5 && imc < 25) {
            this.setClassificacao("Peso Normal");
        } else if(imc >= 25 && imc < 30){
            this.setClassificacao("Acima do Peso");
        } else if(imc >= 30 && imc < 35){
            this.setClassificacao("Obesidade I");
        } else {
             this.setClassificacao("Obesidade II severa");
        }

    }

    public Double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        if (peso < 0) {
            System.out.println("Peso inválido");
        } else {
            this.peso = peso;
        }
    }

    public Double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        if (altura < 0 || altura > 3) {
            System.out.println("Altura inválida");
        } else {
            this.altura = altura;
        }
    }

    public Double getImc() {
        return imc;
    }

    public void setImc(double imc) {
        this.imc = imc;
    }

    public String getClassificacao() {
        return classificacao;
    }

    public void setClassificacao(String classificacao) {
        if (classificacao.length() <= 0) {
            System.out.println("Classificação inválida");
        } else {
            this.classificacao = classificacao;
        }
    }

}
