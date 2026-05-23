
class Productos
{
    // Para que el id se cree automaticamente
    private static int Contador = 0;

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string Categoria { get; set; }
    public DateTime FechaCreacion { get; set; }

    public Productos(string nombre, string descripcion, decimal precio, int stock, string categoria, DateTime fecha)
    {
        Contador++;

        Id = Contador;
        Nombre = nombre;
        Descripcion = descripcion;
        Precio = precio;
        Stock = stock;
        Categoria = categoria;
        FechaCreacion = fecha;
    }
    
}