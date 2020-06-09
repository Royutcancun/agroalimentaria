package comidaHerencia;
public class ProductoCongelado : Producto {
    
    private double tempCongelacionRecomendada;
    
    public ProductoCongelado(String fechaCaducidad, String numeroLote) : 
            base(fechaCaducidad, numeroLote) {
        base.(fechaCaducidad, numeroLote);
        this.tempCongelacionRecomendada = 0;
    }
    
    public void setTemperaturaRecomendada(double temperatura) {
        this.tempCongelacionRecomendada = temperatura;
    }
    
    public double getTemperaturaRecomendada() {
        return this.tempCongelacionRecomendada;
    }
    
    public void imprimirDatos() {
        imprimirInfo();
        System.out.println(("Temperatura Recomendada: " 
                        + (this.getTemperaturaRecomendada() + "\n")));
    }
}