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
}