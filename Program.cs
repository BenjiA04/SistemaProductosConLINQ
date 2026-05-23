
class Program
{
    static void Main()
    {
        List<Productos> lista_Productos = new List<Productos>();

        CreadorProductos creador = new(lista_Productos);
        ProductoPrinter printer = new();
        ConsultarProductos consultar = new(lista_Productos, printer);

         creador.Crear();
         consultar.Ejercicio39();
    }
}
