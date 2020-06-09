package comidaHerencia;
public class Producto {
    
    String fechaCaducidad;
    
    String numeroLote;
    
    public Producto(String fechaCaducidad, String numeroLote) {
        this.fechaCaducidad = this.fechaCaducidad;
        this.numeroLote = this.numeroLote;
    }
    
    public void setFechaCaducidad(String fecha) {
        this.fechaCaducidad = fecha;
    }
    
    public void setNumeroLote(String num) {
        this.numeroLote = num;
    }
    
    public String getFechaCaducidad() {
        return this.fechaCaducidad;
    }
    
    public String getNumeroLote() {
        return this.numeroLote;
    }
    
    public void imprimirInfo() {
        System.out.println(("Fecha Caducidad: " 
                        + (this.getFechaCaducidad() + ("\nNumero de Lote: " + this.getNumeroLote()))));
    }
}