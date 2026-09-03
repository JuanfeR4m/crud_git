namespace UsuarioApi.Entities;

public class Usuario
{
    public int Id { get; set;}
    public String Nombre { get; set;} = string.Empty;
    public String Correo { get; set;} = string.Empty;
    public String Telefono { get; set;} = string.Empty;
    public bool Activo { get; set;} = true;
    public DateTime FechaCreacion {get; set; } = DateTime.UYcNow;
}