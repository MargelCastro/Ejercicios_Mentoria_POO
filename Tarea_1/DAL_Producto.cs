using System.Runtime;

namespace app;

public class DAL_Producto
{
    private List<Producto> Listado = new List<Producto>();

    public int Insertar(Producto producto)
    {
        producto.IdCodigo = Listado.Count() + 1;
        Listado.Add(producto);
        return producto.IdCodigo;
    }

    public int CantidadRegistros()
    {
        return Listado.Count();
    }

    public List<Producto> Listar()
    {
        return Listado;
    }

    public List<Producto> ObtenerTodosLosProductos()
    {
        return Listado;
    }
    public bool Eliminar(int id)
    {
        var productoEliminar = Listado.FirstOrDefault(p => p.IdCodigo == id);
        if (productoEliminar != null)
        {
            Listado.Remove(productoEliminar);
            return true;
        }
        return false;
    }

    public bool Actualizar(Producto Entidad)
    {
        var productoActualizar = Listado.FirstOrDefault(a => a.IdCodigo == Entidad.IdCodigo);
        if (productoActualizar != null)
        {
            productoActualizar.NombreProducto = Entidad.NombreProducto;
            productoActualizar.Precio = Entidad.Precio;
            productoActualizar.Stock = Entidad.Stock;
            return true;
        }
        return false;
    }
}