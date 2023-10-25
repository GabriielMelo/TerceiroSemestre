package energia;


public class EnergiaModel {
    
    private double fornecimento;
    private double fatura;
    private double icms;
    private double cofins;
    private double pis;
    private double icms_cofins;
    private double icms_pis;
    
    public EnergiaModel(){
        
    }

    public EnergiaModel(double fornecimento, double fatura, double icms,
            double cofins, double pis, double icms_cofins, double icms_pis) {
        this.setFornecimento(fornecimento) ;
        this.setFatura(fatura);
        this.setIcms(icms);
        this.setCofins(cofins);
        this.setPis(pis);
        this.setIcms_cofins(icms_cofins);
        this.setIcms_pis(icms_pis);
    }
    
    public Double Fornecimento(double consumo){
        fornecimento =  consumo*0.28172;
        return fornecimento;
    }
    public void calcIcms(double consumo){
        if(consumo<=200){
           setIcms(fornecimento*0.136363);
        } else {
            setIcms(fornecimento*0.333333);
        }
    }
    
    public void calcCofins(double consumo){
        if(consumo<=200){
           setCofins(fornecimento*0.0614722);
        } else {
            setCofins(fornecimento*0.730751);
        }
    }
    
     public void calcPis(double consumo){
        if(consumo<=200){
           setPis(fornecimento*0.013346);
        } else {
            setPis(fornecimento*0.0158651);
        }
    }
    
     public Double calcIcmsCofins(double cofins,double icms,double fornecimento){
        icms_cofins = (cofins*icms)*fornecimento;
        return icms_cofins;
    }
     
      public Double calcIcmsPis(double pis,double icms,double fornecimento){
         icms_pis = (pis*icms)*fornecimento;
        return icms_pis;
    }
      public Double calcFatura(double fornecimento,double icms,double cofins,double pis,double icms_cofins,double icms_pis){
          fatura = fornecimento+icms+cofins+pis+icms_cofins+icms_pis;
          return fatura;
      }
    

    public double getFornecimento() {
        return fornecimento;
    }

    public void setFornecimento(double fornecimento) {
        this.fornecimento = fornecimento;
    }

    public double getFatura() {
        return fatura;
    }

    public void setFatura(double fatura) {
        this.fatura = fatura;
    }

    public double getIcms() {
        return icms;
    }

    public void setIcms(double icms) {
        this.icms = icms;
    }

    public double getCofins() {
        return cofins;
    }

    public void setCofins(double cofins) {
        this.cofins = cofins;
    }

    public double getPis() {
        return pis;
    }

    public void setPis(double pis) {
        this.pis = pis;
    }

    public double getIcms_cofins() {
        return icms_cofins;
    }

    public void setIcms_cofins(double icms_cofins) {
        this.icms_cofins = icms_cofins;
    }

    public double getIcms_pis() {
        return icms_pis;
    }

    public void setIcms_pis(double icms_pis) {
        this.icms_pis = icms_pis;
    }
    
    
    
    
}
