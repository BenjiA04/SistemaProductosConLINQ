
class Program
{
    static void Main()
    {
        ListaProductos lista = new ListaProductos
        {
            Lproductos = new List<Productos>()
        };

        CreadorProductos crear = new CreadorProductos(lista);
        ProductoPrinter mostrar = new ProductoPrinter();
        ConsultarProductos consultas = new ConsultarProductos(lista, mostrar);

         crear.Crear();
         consultas.Ejercicio1();
    }
}
