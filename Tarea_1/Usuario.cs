namespace app;

// creacion de la clase Usuario, siempre vas en mayusculas los nombres de las clases
public class Usuario
{
    // propiedades de la clase Usuario 
    public int IdUsuario { get; set; } = 0;
    public string NombreCompleto { get; set; }
    public string Correo { get; set; }
    public string Login { get; set; } = string.Empty;// de esta manera tambien se le puede decir a la propiedad que acepte valores nulos o vacios.

    // El constructor: Tiene el mismo nombre de la clase, No regresa ningun tipo de dato y puede recibir parametros
    public Usuario()
    {// recibiendo el parametro login mediante la variable login
        NombreCompleto = string.Empty;
        Correo = string.Empty;
        Login = string.Empty;
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