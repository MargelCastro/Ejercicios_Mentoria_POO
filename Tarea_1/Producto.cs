/*1. Margel Castro: Gestión de Productos Descripción: Implementar un sistema que permita 
  -- registrar    --modificar   
  --eliminar   y  --listar productos de una tienda. 
Cada producto debe tener código, nombre, precio y cantidad en stock. */
namespace app;

public class Producto
{
  public int IdCodigo { get; set; }
  public string NombreProducto { get; set; } = string.Empty;
  public double Precio { get; set; } // Cambio a double para representar el precio
  public int Stock { get; set; } // Cambio a int para representar la cantidad en stock
}