package comidaHerencia;
public class ProductoRefrigerado : Producto {
    
    private String codigoSupervisionAlimentaria;
    
    public ProductoRefrigerado(String fechaCaducidad, String numeroLote) : 
            base(fechaCaducidad, numeroLote) {
        base.(fechaCaducidad, numeroLote);
        this.codigoSupervisionAlimentaria = "Desconocido";
    }
    
    public void setCodigoSupervisionAlimentaria(String codigo) {
        this.codigoSupervisionAlimentaria = codigo;
    }
    
    public String getCodigoSupervisionAlimentaria() {
        return this.codigoSupervisionAlimentaria;
    }
    
    public void imprimirDatos() {
        imprimirInfo();
        System.out.println(("Codigo de Supervision Alimentaria: " + this.getCodigoSupervisionAlimentaria()));
    }
}