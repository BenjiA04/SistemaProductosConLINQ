# 📦 Proyecto LINQ en C# - Gestión de Productos

## 📌 Descripción del proyecto

Este proyecto consiste en una aplicación de consola desarrollada en **C#** que utiliza **LINQ (Language Integrated Query)** para realizar diferentes operaciones sobre una colección de productos.
La aplicación trabaja con una lista de objetos de la clase `Productos`, la cual contiene información como nombre, descripción, precio, stock, categoría y fecha de creación.

A través de LINQ se implementan múltiples consultas que permiten filtrar, ordenar, agrupar y analizar datos de la colección, simulando escenarios reales de manejo de información en aplicaciones.

---

## ⚙️ Funcionalidades principales

El proyecto permite:

- Crear una colección de más de `50` productos
- Mostrar todos los productos
- Filtrar productos por `precio`, `stock` y `categoría`
- Ordenar productos de diferentes formas
- Realizar agrupaciones por categoría
- Calcular estadísticas como suma, promedio y conteo
- Verificar condiciones usando `Any` y `All`

---

## 📚 Estructura del proyecto

El proyecto está dividido en diferentes clases para mantener una organización clara:

- **Productos.cs**: Modelo de datos
- **CreadorProductos.cs**: Genera la colección de productos
- **ConsultarProductos.cs**: Contiene todas las consultas LINQ
- **ProductoPrinter.cs**: Se encarga de mostrar la información en consola
- **Program**: Donde se inicializan las clases y se ejecuta el flujo principal del programa
