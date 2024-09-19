/*1. Margel Castro: Gestión de Productos Descripción: Implementar un sistema que permita 
  -- registrar    --modificar   
  --eliminar   y  --listar productos de una tienda. 
Cada producto debe tener código, nombre, precio y cantidad en stock. */
using System.Runtime;

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
          string nombreProducto = Console.ReadLine();

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
          Producto nuevoProducto = new Producto
          {
            NombreProducto = nombreProducto,
            Precio = precio,
            Stock = stock
          };

          if (dAL_Producto.Insertar(nuevoProducto) > 0)
          {
            Console.WriteLine("Producto agregado con éxito !!!");
          }
          break;


        case 2: //Actualizar
        /*if (registros == 0)
        {
          Console.WriteLine("No hay registros para actualizar");
          Console.ReadKey();
          continue;
        }

        Console.WriteLine("Ingrese el índice del gasto que desea actualizar (0-{0}):", registros - 1);
        if (!int.TryParse(Console.ReadLine(), out int updateRegistro) || updateRegistro < 0 || updateRegistro >= registros)
        {
          Console.WriteLine("Índice no es válido");
          Console.ReadKey();
          continue;
        }

        Console.WriteLine("Ingrese la nueva descripción del gasto:");
        string? nuevaDescripcion = Console.ReadLine();
        if (string.IsNullOrEmpty(nuevaDescripcion) || string.IsNullOrWhiteSpace(nuevaDescripcion))
        {
          Console.WriteLine("La descripción no puede estar vacía");
          Console.ReadKey();
          continue;
        }

        Console.WriteLine("Ingrese el nuevo monto del gasto");
        double nuevoMonto = 0;
        if (!double.TryParse(Console.ReadLine(), out nuevoMonto) || nuevoMonto <= 0)
        {
          Console.WriteLine("Ingrese un monto válido y mayor que cero");
          Console.ReadKey();
          continue;
        }
        descripciones[updateRegistro] = nuevaDescripcion;
        montos[updateRegistro] = nuevoMonto;

        Console.WriteLine("Gasto actualizado exitosamente");
        Console.ReadLine();
        break;*/
        case 3: //Eliminar
        /*if (registros == 0)
        {
          Console.WriteLine("No hay registros para eliminar");
          Console.ReadKey();
          continue;
        }

        Console.WriteLine("Ingrese el índice del gasto que desea eliminar (0-{0}):", registros - 1);
        if (!int.TryParse(Console.ReadLine(), out int deleteRegistro) || deleteRegistro < 0 || deleteRegistro >= registros)
        {
          Console.WriteLine("Índice no es válido");
          Console.ReadKey();
          continue;
        }

        for (int i = deleteRegistro; i < registros - 1; i++)
        {
          descripciones[i] = descripciones[i + 1];
          montos[i] = montos[i + 1];
        }

        descripciones[registros - 1] = string.Empty;
        montos[registros - 1] = 0;

        registros--;
        Console.WriteLine("Gasto eliminado con exito!!!");
        Console.ReadKey();
        break;*/
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




