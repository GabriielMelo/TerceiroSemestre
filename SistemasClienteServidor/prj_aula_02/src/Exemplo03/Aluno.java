package Exemplo03;

public class Aluno extends Pessoa {

    private String rgm;
    
    public Aluno(String nome, int idade, String rgm) {
        super(nome, idade);
        // this.rgm = rgm;
        this.setRgm(rgm);
    }
    
    @Override
    public String toString(){
        return "Nome: " + getNome() + "\nIdade: " + getIdade() + "\nRGM: " + getRgm();
    };
    
    public String getRgm() {
        return rgm;
    }
    
    public void setRgm(String rgm) {
        if (rgm.equals("")){
            System.out.println("RGM inválido");
        } else {
          this.rgm = rgm;
        }
    }
    
}
