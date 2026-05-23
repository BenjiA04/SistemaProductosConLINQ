


class ConsultarProductos
{
    private readonly ListaProductos _Productos;
    private readonly ProductoPrinter _Mostrar;

    public ConsultarProductos(ListaProductos p, ProductoPrinter m)
    {
        _Productos = p;
        _Mostrar = m;
    }


    // 1. Obtener todos los productos de la lista.
    public void Ejercicio1()
    {
        var ListaProductosCompleta = (from p in _Productos.Lproductos
                                      select p).ToList(); 

        _Mostrar.MostrarProductos(ListaProductosCompleta);
    }


    // 2. Obtener los nombres de todos los productos.
    public void Ejercicio2()
    {
        var ProductosPorNombre = (from p in _Productos.Lproductos
                                  select p).ToList(); 

        Console.WriteLine("Productos:");
        foreach(Productos i in ProductosPorNombre)
        {
            Console.WriteLine($"Nombre: {i.Nombre}");
        }
    }


    // 3. Obtener los productos cuyo precio sea mayor a 500.
    public void Ejercicio3()
    {
        var ProductosPrecioMayor500 = (from p in _Productos.Lproductos
                                       where p.Precio > 500
                                       select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosPrecioMayor500);
    }


    // 4. Obtener los productos con stock menor a 10.
    public void Ejercicio4()
    {
        
        var ProductosStockMenor10 = (from p in _Productos.Lproductos
                                     where p.Stock < 10
                                     select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosStockMenor10);
    }


    // 5. Obtener los productos de la categoría "Electrónica".
    public void Ejercicio5()
    {
        var ProductosCategoriaElectronica = (from p in _Productos.Lproductos
                                             where p.Categoria == "Electrónica"
                                             select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosCategoriaElectronica);
    }


    // 6. Obtener los productos cuyo nombre comience con la letra 'L'.
    public void Ejercicio6()
    {
        var ProductosNombreIniciaL = (from p in _Productos.Lproductos
                                      where p.Nombre.StartsWith("L")
                                      select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosNombreIniciaL);
    }


    // 7. Obtener los productos cuyo precio esté entre 100 y 500.
    public void Ejercicio7()
    {
        var ProductosPrecioEntre100y500 = (from p in _Productos.Lproductos
                                           where p.Precio >= 100 && p.Precio <= 500
                                           select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosPrecioEntre100y500);
    }


    // 8. Obtener los productos ordenados por precio ascendente.
    public void Ejercicio8()
    {
        var ListaProductosPorPrecioAscendente = (from p in _Productos.Lproductos
                                                 orderby p.Precio ascending
                                                 select p).ToList(); 

        _Mostrar.MostrarProductos(ListaProductosPorPrecioAscendente);
    }

    // 9. Obtener los productos ordenados por precio descendente.
    public void Ejercicio9()
    {
        var ListaProductosPorPrecioDescendente = (from p in _Productos.Lproductos
                                                  orderby p.Precio descending
                                                  select p).ToList(); 

        _Mostrar.MostrarProductos(ListaProductosPorPrecioDescendente);
    }

    // 10. Obtener los productos ordenados por nombre en orden alfabético.
    public void Ejercicio10()
    {
        var ProductosOrdenadosNombre = (from p in _Productos.Lproductos
                                       orderby p.Nombre
                                       select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosOrdenadosNombre);
    }


    // 11. Obtener los productos ordenados por stock de mayor a menor.
    public void Ejercicio11()
    {
        var ListaProductosPorStockDescendente = (from p in _Productos.Lproductos
                                                 orderby p.Stock descending
                                                 select p).ToList(); 

        _Mostrar.MostrarProductos(ListaProductosPorStockDescendente);
    }

 
    // 12. Obtener los primeros 5 productos más caros.
    public void Ejercicio12()
    {
        var ListaProductosMasCaros = (from p in _Productos.Lproductos
                                      orderby p.Precio descending
                                      select p).Take(5).ToList(); 

        _Mostrar.MostrarProductos(ListaProductosMasCaros);
    }


    // 13. Obtener los 10 productos con menor stock.
    public void Ejercicio13()
    {
        var ListaProductosMenorStock = (from p in _Productos.Lproductos
                                        orderby p.Stock ascending
                                        select p).Take(10).ToList(); 

        _Mostrar.MostrarProductos(ListaProductosMenorStock);
    }


    // 14. Obtener la cantidad total de productos en la lista.
    public void Ejercicio14()
    {
        var CantidadTotalProductos = (from p in _Productos.Lproductos
                                      select p).Count(); 

        Console.WriteLine($"Cantidad total de productos: {CantidadTotalProductos}\n");
    }


    // 15. Obtener la suma de todos los precios de los productos.
    public void Ejercicio15()
    {
        var SumaTotal_Precios = (from p in _Productos.Lproductos
                                 select p.Precio).Sum(); 

        Console.WriteLine($"Sumatoria total de precios: {SumaTotal_Precios}\n");
    }


    // 16. Obtener el precio promedio de los productos.
    public void Ejercicio16()
    {
        var Promedio_Precios = (from p in _Productos.Lproductos
                                select p.Precio).Average(); 

        Console.WriteLine($"Promedio total de precios: {Promedio_Precios}\n");
    }


    // 17. Obtener el producto más caro.
    public void Ejercicio17()
    {
        var ProductoMasCaro = (from p in _Productos.Lproductos
                               orderby p.Precio descending
                               select p).Take(1).ToList(); 

        _Mostrar.MostrarProductos(ProductoMasCaro);
    }


    // 18. Obtener el producto más barato.
    public void Ejercicio18()
    {
        var ProductoMasBarato = (from p in _Productos.Lproductos
                                 orderby p.Precio ascending
                                 select p).Take(1).ToList(); 

        _Mostrar.MostrarProductos(ProductoMasBarato);
    }


    // 19. Verificar si hay algún producto con precio mayor a 1000.
    public void Ejercicio19()
    {
        bool todos = _Productos.Lproductos.Any(p => p.Precio > 1000);

        Console.WriteLine(todos ? "Hay productos con precio mayor a 1000." : "No hay productos con precio mayor a 1000.");
    }


    // 20. Verificar si todos los productos tienen stock mayor a 5.
    public void Ejercicio20()
    {
        bool todos = _Productos.Lproductos.All(p => p.Stock > 5);

        Console.WriteLine(todos ? "Todos los productos tienen su stock por encima de 5." : "No todos los productos tienen su stocks por encima de 5.");
    }


    // 21. Contar cuántos productos hay en la categoría "Audio".
    public void Ejercicio21()
    {
        var CantidadProductosAudio = (from p in _Productos.Lproductos
                                      where p.Categoria == "Audio"
                                      select p).Count(); 

        Console.WriteLine($"Cantidad total de productos con la categoría 'Audio': {CantidadProductosAudio}\n");
    }


    // 22. Agrupar los productos por categoría.
    public void Ejercicio22()
    {
        var ProductosPorCategoria =  from p in _Productos.Lproductos
                                     group p by p.Categoria;                                   
                                
        foreach(var grupos in ProductosPorCategoria)
        {
            Console.WriteLine($"\n========== {grupos.Key.ToUpper()} ==========\n");

            foreach(Productos i in grupos)
            {
                Console.WriteLine($"[{i.Id}] {i.Nombre}");
                Console.WriteLine($"Descripcion : {i.Descripcion}");
                Console.WriteLine($"Precio      : RD${i.Precio}");
                Console.WriteLine($"Stock       : {i.Stock}");
                Console.WriteLine($"Fecha       : {i.FechaCreacion:dd/MM/yyyy}");

                Console.WriteLine("-----------------------------------");
            }
        }
    }


    // 23. Obtener la categoría con más productos.
    public void Ejercicio23()
    {
        var CategoriaConMasProductos =  (from p in _Productos.Lproductos
                                         group p by p.Categoria into g
                                         orderby g.Count() descending
                                         select g).First();                                   
                                
        Console.WriteLine($"La categoria con mas productos es: {CategoriaConMasProductos.Key}.");
    }


    // 24. Obtener el stock total de todos los productos.
    public void Ejercicio24()
    {
        var TotalStockProductos = (from p in _Productos.Lproductos
                                   select p.Stock).Sum(); 

        Console.WriteLine($"Total de stock de todos los productos: {TotalStockProductos}\n");
    }


    // 25. Obtener el producto con el nombre más largo.
    public void Ejercicio25()
    {
        var ProductoConNombreMasLargo = (from p in _Productos.Lproductos
                                         orderby p.Nombre.Length descending
                                         select p).Take(1).ToList(); 

        _Mostrar.MostrarProductos(ProductoConNombreMasLargo);
    }


    // 26. Obtener el producto con la descripción más corta.
    public void Ejercicio26()
    {
        var ProductoConNombreMasCorto = (from p in _Productos.Lproductos
                                         orderby p.Descripcion.Length ascending
                                         select p).Take(1).ToList(); 

        _Mostrar.MostrarProductos(ProductoConNombreMasCorto);
    }


    // 27. Filtrar los productos cuya descripción contenga la palabra "pantalla".
    public void Ejercicio27()
    {
        var ProductosDescripcionEspecifica = (from p in _Productos.Lproductos
                                              where p.Descripcion.Contains("pantalla") || p.Descripcion.Contains("Pantalla")
                                              select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosDescripcionEspecifica);
    }


    // 28. Obtener el promedio de stock de los productos de la categoría "Almacenamiento".
    public void Ejercicio28()
    {
        var PromedioStockAlmacenamiento = (from p in _Productos.Lproductos
                                           where p.Categoria == "Almacenamiento"
                                           select p.Stock).Average(); 

        Console.WriteLine($"Promedio de stock de productos en categoria 'Almacenamiento': {PromedioStockAlmacenamiento}\n");
    }


    // 29. Obtener los productos creados en una fecha específica (20/12/2022).
    public void Ejercicio29()
    {
        var ProductosFechaEspecifica = (from p in _Productos.Lproductos
                                        where p.FechaCreacion == new DateTime(2022, 12, 20)
                                        select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosFechaEspecifica);
    }


    // 30. Obtener los productos cuya ID sea par.
    public void Ejercicio30()
    {
        var ListaProductos_IdPar = (from p in _Productos.Lproductos
                                    where p.Id % 2 == 0
                                    select p).ToList(); 

        _Mostrar.MostrarProductos(ListaProductos_IdPar);
    }


    // 31. Obtener los productos cuya ID sea impar.
    public void Ejercicio31()
    {
        var ListaProductos_IdImpar = (from p in _Productos.Lproductos
                                      where p.Id % 2 == 1
                                      select p).ToList(); 

        _Mostrar.MostrarProductos(ListaProductos_IdImpar);
    }


    // 32. Obtener los productos cuyo precio tenga un decimal mayor a .50.
    public void Ejercicio32()
    {
        var productosConDecimalMayor50 = (from p in _Productos.Lproductos
                                      where p.Precio % 1 > 0.50m
                                      select p).ToList(); 

        _Mostrar.MostrarProductos(productosConDecimalMayor50);
    }


    // 33. Obtener los productos cuyo nombre tenga más de 10 caracteres.
    public void Ejercicio33()
    {
        var ProductosNombreMayorA10 = (from p in _Productos.Lproductos
                                       where p.Nombre.Length > 10
                                       select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosNombreMayorA10);
    }


    // 34. Obtener los productos cuyo stock sea un número primo.
    public void Ejercicio34()
    {
        var ProductosConStockPrimo = (from p in _Productos.Lproductos
                                      where EsPrimo(p.Stock)
                                      select p).ToList();
        bool EsPrimo(int numero){
            
            if(numero < 2) return false;
            
            for(int i = 2; i < numero; i++)
            {
               if(numero % i == 0)
               return false;
            }

           return true;
        }

        _Mostrar.MostrarProductos(ProductosConStockPrimo);
    }


    // 35. Obtener los productos cuyo nombre contenga la palabra "Pro".
    public void Ejercicio35()
    {
        var ProductosNombreContienePro = (from p in _Productos.Lproductos
                                         where p.Nombre.Contains("Pro") || p.Nombre.Contains("pro")
                                         select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosNombreContienePro);
    }


    // 36. Obtener los productos cuyo stock sea un múltiplo de 5.
    public void Ejercicio36()
    {
        var ProductosStockMultiplo5 = (from p in _Productos.Lproductos
                                       where p.Stock % 5 == 0
                                       select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosStockMultiplo5);
    }


    // 37. Obtener los productos que tengan una descripción con más de 20 caracteres.
    public void Ejercicio37()
    {
        var ProductosDescripcionLarga = (from p in _Productos.Lproductos
                                         where p.Descripcion.Length > 10
                                         select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosDescripcionLarga);
    }


    // 38. Obtener los productos cuyo precio sea un número redondo (sin decimales).
    public void Ejercicio38()
    {
        var ProductosPrecioRedondo = (from p in _Productos.Lproductos
                                      where p.Precio % 1 == 0
                                      select p).ToList(); 

        _Mostrar.MostrarProductos(ProductosPrecioRedondo);
    }


    // 40. Obtener la cantidad de productos que no pertenecen a la categoría "General".
    public void Ejercicio40()
    {
        var CantidadProductosNoGeneral =  (from p in _Productos.Lproductos
                                           where p.Categoria != "General"
                                           select p).Count();                                   
                                
        Console.WriteLine($"La cantidad de productos que no pertenecen a la categoría 'General': {CantidadProductosNoGeneral}.\n");
    }
}