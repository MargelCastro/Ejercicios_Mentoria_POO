/*1. Margel Castro: Gestión de Productos Descripción: Implementar un sistema que permita 
  -- registrar    --modificar   
  --eliminar   y  --listar productos de una tienda. 
Cada producto debe tener código, nombre, precio y cantidad en stock. */
using System.Data.Common;

namespace app;
public class Program
{
  public static void Main(string[] args)
  {
    DAL_Producto dAL_Producto = new DAL_Producto();
    Producto producto = new Producto();
    int menu = 0;

    do
    {
      Console.Clear();
      if (dAL_Producto.CantidadRegistros() == 0)
      {
        Console.WriteLine("Seleccione la operación a ejecutar: ");
        Console.WriteLine("1.Registrar");
        Console.WriteLine("5.Salir");
      }
      else
      {
        Console.WriteLine("Seleccione la operación a ejecutar: ");
        Console.WriteLine("1.Registrar");
        Console.WriteLine("2.Actualizar");
        Console.WriteLine("3.Eliminar");
        Console.WriteLine("4.Consultar");
        Console.WriteLine("5.Salir");
      }

      string? opcionesMenu = Console.ReadLine();
      if (!int.TryParse(opcionesMenu, out menu))
      {
        Console.WriteLine("Ingrese una opción válida.");
        Console.ReadKey();
        continue;
      }

      switch (menu)
      {
        case 1: //Registrar
          Console.WriteLine("Ingrese el Nombre del Producto:");
          string nombreProducto = Console.ReadLine() ?? string.Empty;// ??string.Empty si viene nulo agregar un vacio

          Console.WriteLine("Ingrese el Precio del Producto:");
          if (!double.TryParse(Console.ReadLine(), out double precio))
          {
            Console.WriteLine("El precio debe ser un número válido.");
            continue;
          }

          Console.WriteLine("Ingrese el Stock del Producto:");
          if (!int.TryParse(Console.ReadLine(), out int stock))
          {
            Console.WriteLine("El stock debe ser un número entero positivo.");
            continue;
          }

          // Crear un nuevo objeto Producto y asignar los valores
          Producto newProducto = new();
          newProducto.NombreProducto = nombreProducto;
          newProducto.Precio = precio;
          newProducto.Stock = stock;


          if (dAL_Producto.Insertar(newProducto) > 0)
          {
            Console.WriteLine("Producto agregado con éxito !!!");
          }
          break;


        case 2: //Actualizar
          int registro = dAL_Producto.Listar().Count();
          int idUpdate;
          if (registro == 0)

          {
            Console.WriteLine("No hay registros para actualizar");
            Console.ReadKey();
            continue;
          }

          Console.WriteLine("Ingrese el Id del producto a Actualizar (1-{0}):", registro);
          if (!int.TryParse(Console.ReadLine(), out idUpdate) || idUpdate < 0)
          {
            Console.WriteLine("Índice no es válido");
            Console.ReadKey();
            continue;
          }

          Console.WriteLine("Ingrese el Nombre del Producto:");
          string? nuevoNombre = Console.ReadLine();
          if (string.IsNullOrEmpty(nuevoNombre) || string.IsNullOrWhiteSpace(nuevoNombre))
          {
            Console.WriteLine("El Nombre no puede estar vacío");
            Console.ReadKey();
            continue;
          }

          Console.WriteLine("Ingrese el nuevo Precio");
          double nuevoPrecio = 0;
          if (!double.TryParse(Console.ReadLine(), out nuevoPrecio) || nuevoPrecio <= 0)
          {
            Console.WriteLine("Ingrese un Precio válido y mayor que cero");
            Console.ReadKey();
            continue;
          }

          Console.WriteLine("Ingrese el nuevo Stock");
          int nuevoStock = 0;
          if (!int.TryParse(Console.ReadLine(), out nuevoStock) || nuevoStock <= 0)
          {
            Console.WriteLine("Ingrese un Precio válido y mayor que cero");
            Console.ReadKey();
            continue;
          }

          Producto Actualizado = new();
          Actualizado.IdCodigo = idUpdate;
          Actualizado.NombreProducto = nuevoNombre;
          Actualizado.Precio = nuevoPrecio;
          Actualizado.Stock = nuevoStock;

          if (dAL_Producto.Actualizar(Actualizado))
          {
            Console.WriteLine("Producto actualizado exitosamente");
            Console.ReadLine();
          }
          break;
        case 3: //Eliminar
          if (dAL_Producto.CantidadRegistros() == 0)
          {
            Console.WriteLine("No hay productos para eliminar.");
          }
          else
          {
            dAL_Producto.Listar(); // Mostrar la lista de productos para que el usuario seleccione
            Console.WriteLine("Ingrese el ID del producto a eliminar:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
              // Buscar el producto por ID y eliminarlo
              if (dAL_Producto.Eliminar(id))
              {
                Console.WriteLine("Producto eliminado con éxito.");
              }
              else
              {
                Console.WriteLine("Producto no encontrado.");
              }
            }
            else
            {
              Console.WriteLine("ID inválido.");
            }
          }
          break;
        case 4: //Consultar
          if (dAL_Producto.CantidadRegistros() == 0)
          {
            Console.WriteLine("No hay registros para consultar");
            Console.ReadKey();
            continue;
          }

          Console.WriteLine("Producto registrado: ");

          foreach (var item in dAL_Producto.Listar())
          {
            Console.WriteLine($"ID: {item.IdCodigo};\t Nombre Producto: {item.NombreProducto};\t\tPrecio: {item.Precio}\t Stock: {item.Stock}");

          }
          Console.ReadKey();
          break;
        case 5: //Salir
          Console.WriteLine("Saliendo del sistema");
          break;

        default:
          Console.WriteLine("Opción no válida");
          Console.ReadKey();
          break;
      }

    }
    while (menu != 5);

  }
}




