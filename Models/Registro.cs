public class Registro{
   public int? Id { get; set; }
  public Actividad Actividad { get; set; }
  public float Duracion { get; set; }
  public float Distancia { get; set; }

  public DateTime Fecha{ get; set; }
  

  public Registro(int id, Actividad actividad,DateTime fecha,float duracion,float distancia)
  {
    Id = id;
    Actividad = actividad;
    Fecha = fecha;
    Duracion = duracion;
    Distancia = distancia;
  }

    public Registro()
    {
    }

    override public string ToString()
  {
    return $"Id:{Id}, {Actividad.Id} {Fecha} {Duracion}(h) {Distancia}(Km)";
  }
}
