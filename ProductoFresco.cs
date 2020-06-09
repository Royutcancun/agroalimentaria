package comidaHerencia;
public class ProductoFresco : Producto {
    
    private String fechaEnvasado;
    
    private String paisDeOrigen;
    
    public ProductoFresco(String fechaCaducidad, String numeroLote) : 
            base(fechaCaducidad, numeroLote) {
        base.(fechaCaducidad, numeroLote);
        this.fechaEnvasado = "Desconocido";
        this.paisDeOrigen = "Desconocido";
    }
    
    public void setFechaEnvasado(String fecha) {
        this.fechaEnvasado = fecha;
    }
    
    public void setPaisDeOrigen(String pais) {
        this.paisDeOrigen = pais;
    }
    
    public String getFechaEnvasado() {
        return this.fechaEnvasado;
    }
    
    public String getPaisDeOrigen() {
        return this.paisDeOrigen;
    }
    
    public void imprimirDatos() {
        imprimirInfo();
        System.out.println(("Fecha de envasado: " 
                        + (this.getFechaEnvasado() + ("\nPais de origen: " 
                        + (this.getPaisDeOrigen() + "\n")))));
    }
}