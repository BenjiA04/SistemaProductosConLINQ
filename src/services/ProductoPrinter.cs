

class ProductoPrinter
{
    public void MostrarProductos(List<Productos> Lproductos)
    {
        Console.WriteLine("\n=========== LISTA DE PRODUCTOS ===========\n");

        foreach(Productos i in Lproductos)
        {
            Console.WriteLine($"[{i.Id}] {i.Nombre}");
            Console.WriteLine($"Descripcion : {i.Descripcion}");
            Console.WriteLine($"Precio      : RD${i.Precio}");
            Console.WriteLine($"Stock       : {i.Stock}");
            Console.WriteLine($"Categoria   : {i.Categoria}");
            Console.WriteLine($"Fecha       : {i.FechaCreacion:dd/MM/yyyy}");

            Console.WriteLine("--------------------------------------------------");
        }
    }
}