public class Registro
{
    public int Id { get; set; }
    public int ActividadId { get; set; }
    public Actividad Actividad { get; set; }
    public float Duracion { get; set; }
    public float Distancia { get; set; }
    public DateTime Fecha { get; set; }

    // Constructor que asigna valores
    /*public Registro(int actividadId, Actividad actividad, DateTime fecha, float duracion, float distancia)
    {
        ActividadId = actividadId; // Usa actividadId directamente, ya que no tiene sentido usar Id aquí
        Actividad = actividad ?? throw new ArgumentNullException(nameof(actividad)); // Asegúrate de que no sea nulo
        Fecha = fecha;
        Duracion = duracion;
        Distancia = distancia;
    }
*/
    // Constructor por defecto
    /*public Registro() {}

    // Override para representar el objeto como cadena
    public override string ToString()
    {
        return $"Id: {Id}, ActividadId: {ActividadId}, Fecha: {Fecha}, Duración: {Duracion}(h), Distancia: {Distancia}(Km)";
    }*/
}
