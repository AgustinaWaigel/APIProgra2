public class Actividad{
   public int Id { get; set; }
  public string? Nombre { get; set; }

  public virtual List<Registro> Registros {get;set;}
  

    public Actividad()
    {
    }

    public Actividad(int id, string nombre)
    {
    Id = id;
    Nombre = nombre;
    }

    override public string ToString()
  {
    return $"Id:{Id},  {Nombre}";
  }
}