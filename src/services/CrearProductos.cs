

interface ICrearProductos
{
    public void Crear();
}

class CreadorProductos:ICrearProductos
{   
    private readonly List<Productos> _Productos;

    public CreadorProductos(List<Productos> p)
    {
        _Productos = p;
    }

    public void Crear()
    {
        _Productos.Add(new Productos("Laptop Pro", "Laptop con pantalla 15 pulgadas", 1200.99m, 8, "Electrónica", new DateTime(2022, 12, 20)));
        _Productos.Add(new Productos("Mouse Gamer", "Mouse RGB de alta precisión", 45.50m, 25, "Accesorios", new DateTime(2023, 1, 10)));
        _Productos.Add(new Productos("Teclado Mecánico", "Teclado con switches azules", 89.99m, 12, "Accesorios", new DateTime(2023, 2, 5)));
        _Productos.Add(new Productos("Monitor UltraWide", "Monitor curvo pantalla grande", 450.75m, 6, "Electrónica", new DateTime(2022, 11, 18)));
        _Productos.Add(new Productos("Disco SSD", "Almacenamiento rápido SSD", 150.00m, 18, "Almacenamiento", new DateTime(2023, 3, 12)));
        _Productos.Add(new Productos("Memoria RAM", "Memoria DDR5 16GB", 95.99m, 9, "Hardware", new DateTime(2023, 4, 2)));
        _Productos.Add(new Productos("Laptop Air", "Laptop ligera y portátil", 980.40m, 5, "Electrónica", new DateTime(2022, 12, 20)));
        _Productos.Add(new Productos("Auriculares Pro", "Audio envolvente premium", 220.30m, 15, "Audio", new DateTime(2023, 5, 9)));
        _Productos.Add(new Productos("Parlante Bluetooth", "Audio portátil resistente al agua", 130.99m, 30, "Audio", new DateTime(2023, 6, 14)));
        _Productos.Add(new Productos("Smartphone Max", "Pantalla OLED y cámara avanzada", 999.99m, 7, "Electrónica", new DateTime(2023, 7, 20)));

        _Productos.Add(new Productos("Tablet Mini", "Tablet compacta para estudio", 350.25m, 14, "Electrónica", new DateTime(2022, 9, 1)));
        _Productos.Add(new Productos("Webcam HD", "Cámara web con micrófono", 75.80m, 11, "Accesorios", new DateTime(2023, 8, 8)));
        _Productos.Add(new Productos("Impresora Laser", "Impresora rápida oficina", 280.60m, 4, "Oficina", new DateTime(2023, 9, 3)));
        _Productos.Add(new Productos("Silla Gamer", "Silla ergonómica reclinable", 320.00m, 10, "Muebles", new DateTime(2023, 10, 19)));
        _Productos.Add(new Productos("Router WiFi", "Internet alta velocidad", 110.45m, 22, "Redes", new DateTime(2023, 1, 25)));
        _Productos.Add(new Productos("Cable HDMI", "Cable pantalla 4K", 15.99m, 50, "Accesorios", new DateTime(2022, 12, 20)));
        _Productos.Add(new Productos("Disco Externo", "Almacenamiento portátil 2TB", 175.35m, 13, "Almacenamiento", new DateTime(2023, 2, 11)));
        _Productos.Add(new Productos("Microfono Pro", "Micrófono profesional estudio", 199.99m, 8, "Audio", new DateTime(2023, 3, 30)));
        _Productos.Add(new Productos("Laptop Studio", "Laptop para diseño gráfico", 1500.00m, 3, "Electrónica", new DateTime(2023, 4, 15)));
        _Productos.Add(new Productos("Mouse Pad", "Superficie gamer antideslizante", 12.50m, 40, "Accesorios", new DateTime(2023, 5, 18)));

        _Productos.Add(new Productos("Camara Pro", "Cámara profesional pantalla táctil", 2100.75m, 2, "Fotografía", new DateTime(2023, 6, 6)));
        _Productos.Add(new Productos("Tripode Flexible", "Soporte ajustable portátil", 35.20m, 19, "Fotografía", new DateTime(2023, 7, 1)));
        _Productos.Add(new Productos("Smartwatch Fit", "Reloj inteligente deportivo", 250.99m, 16, "Wearables", new DateTime(2023, 8, 12)));
        _Productos.Add(new Productos("Power Bank", "Batería portátil carga rápida", 65.49m, 27, "Accesorios", new DateTime(2023, 9, 9)));
        _Productos.Add(new Productos("Consola GameBox", "Consola videojuegos nueva generación", 780.00m, 5, "Gaming", new DateTime(2022, 12, 20)));
        _Productos.Add(new Productos("Control Inalambrico", "Control ergonómico bluetooth", 59.99m, 17, "Gaming", new DateTime(2023, 10, 5)));
        _Productos.Add(new Productos("Laptop Basic", "Laptop económica estudiantes", 550.50m, 20, "Electrónica", new DateTime(2023, 11, 11)));
        _Productos.Add(new Productos("Ventilador RGB", "Ventilador silencioso PC", 25.00m, 35, "Hardware", new DateTime(2023, 1, 14)));
        _Productos.Add(new Productos("Fuente Poder", "Fuente certificada 750W", 140.70m, 9, "Hardware", new DateTime(2023, 2, 17)));
        _Productos.Add(new Productos("Tarjeta Grafica", "GPU alto rendimiento", 1800.99m, 4, "Hardware", new DateTime(2023, 3, 22)));

        _Productos.Add(new Productos("Monitor Pro", "Pantalla IPS 144Hz", 600.99m, 6, "Electrónica", new DateTime(2023, 4, 28)));
        _Productos.Add(new Productos("Altavoz Mini", "Audio compacto portátil", 49.90m, 24, "Audio", new DateTime(2023, 5, 30)));
        _Productos.Add(new Productos("Disco NVMe", "Almacenamiento ultra rápido", 210.10m, 12, "Almacenamiento", new DateTime(2023, 6, 2)));
        _Productos.Add(new Productos("Laptop Creator", "Laptop pantalla OLED profesional", 1700.45m, 5, "Electrónica", new DateTime(2023, 7, 7)));
        _Productos.Add(new Productos("Camara Web Pro", "Cámara streaming FullHD", 125.55m, 14, "Accesorios", new DateTime(2023, 8, 19)));
        _Productos.Add(new Productos("Teclado Slim", "Teclado inalámbrico elegante", 70.00m, 28, "Accesorios", new DateTime(2023, 9, 27)));
        _Productos.Add(new Productos("Laptop X", "Laptop potente para gaming", 2200.80m, 3, "Electrónica", new DateTime(2023, 10, 13)));
        _Productos.Add(new Productos("Servidor NAS", "Almacenamiento en red empresarial", 950.00m, 7, "Almacenamiento", new DateTime(2023, 11, 21)));
        _Productos.Add(new Productos("Bocinas Pro", "Audio estéreo alta calidad", 340.65m, 18, "Audio", new DateTime(2022, 12, 20)));
        _Productos.Add(new Productos("Mesa Oficina", "Mesa amplia color negro", 275.99m, 11, "Muebles", new DateTime(2023, 12, 1)));

        _Productos.Add(new Productos("Luces LED", "Iluminación RGB habitación", 40.40m, 33, "General", new DateTime(2023, 1, 9)));
        _Productos.Add(new Productos("Laptop Office", "Laptop oficina batería duradera", 870.99m, 8, "Electrónica", new DateTime(2023, 2, 23)));
        _Productos.Add(new Productos("Memoria USB", "Almacenamiento portátil 128GB", 22.75m, 45, "Almacenamiento", new DateTime(2023, 3, 5)));
        _Productos.Add(new Productos("Pantalla Portatil", "Pantalla secundaria USB-C", 310.15m, 6, "Electrónica", new DateTime(2023, 4, 17)));
        _Productos.Add(new Productos("Auriculares Lite", "Audio básico económico", 35.99m, 26, "Audio", new DateTime(2023, 5, 29)));
        _Productos.Add(new Productos("Laptop Prime", "Laptop premium aluminio", 1999.99m, 4, "Electrónica", new DateTime(2023, 6, 16)));
        _Productos.Add(new Productos("Cargador Rapido", "Carga rápida universal", 18.99m, 38, "Accesorios", new DateTime(2023, 7, 24)));
        _Productos.Add(new Productos("Proyector Smart", "Pantalla gigante portátil", 720.70m, 5, "Electrónica", new DateTime(2023, 8, 31)));
        _Productos.Add(new Productos("Laptop Neo", "Laptop moderna pantalla táctil", 1340.50m, 7, "Electrónica", new DateTime(2023, 9, 14)));
        _Productos.Add(new Productos("Hub USB", "Adaptador múltiples puertos", 29.99m, 21, "General", new DateTime(2023, 10, 8)));
    }
}