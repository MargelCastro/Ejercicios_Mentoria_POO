/*1. Margel Castro: Gestión de Productos Descripción: Implementar un sistema que permita 
  -- registrar    --modificar   
  --eliminar   y  --listar productos de una tienda. 
Cada producto debe tener código, nombre, precio y cantidad en stock. */
namespace app;
public class Program
{
  public static void Main(string[] args)
  {
    // Creación de un nuevo objeto Usuario
    Usuario usuario = new Usuario();
    // Asignación de valores a las propiedades del objeto usuario
    usuario.IdUsuario = 1;
    usuario.NombreCompleto = "Margel Castro";
    usuario.Correo = "margelgabriel@gmail.com";
    usuario.Login = "RekeDomina";

    // Impresión de las propiedades del objeto Usuario
    Console.WriteLine($" Id: {usuario.IdUsuario}\n Nombre: {usuario.NombreCompleto}\n Correo: {usuario.Correo}\n Login: {usuario.Login}");
  }
}

