namespace app;

// creacion de la clase Usuario, siempre vas en mayusculas los nombres de las clases
public class Usuario
{

    /* El constructor: * Tiene el mismo nombre de la clase, * No regresa ningun tipo de dato y * puede recibir parametros */
    // Constructor
    public Usuario()
    {
        NombreCompleto = string.Empty;
        Correo = string.Empty;
        Login = string.Empty;
    }


    // propiedades de la clase Usuario 
    public int IdUsuario { get; set; } = 0;
    public string NombreCompleto { get; set; }
    public string Correo { get; set; }
    public string Login { get; set; } = string.Empty;// de esta manera tambien se le puede decir a la propiedad que acepte valores nulos o vacios.


    /*
    CREACION DE Metodo no estatico:
     >Indicador de acceso public, tipo de dato devuelto es void = vacio --obligatorio
     >Nombre del metodo --obligatorio
     >prentesis --obligatorio
     >parametros que pueden usarse (parametros opcionales o parametros obligatorios )
     > {Cuerpo del metodo = lo que uno desee} 
    */
    public void Saludo(string Saludo){
        Console.WriteLine(Saludo);
    }

    //Metodo estatico
    public static void Hola(string Saludo){
        Console.WriteLine("Hola desde la clase con metodo estatico");
    }

}

/*
COMO FUNCIONAn LAS PROPIEDADES POR DENTRO CON EL GET Y SET POR DENTRO
EJEMPLO:

public string Correo;

public string Correo {
get { return _Correo;}
set {_Correo = value;}
}
*/