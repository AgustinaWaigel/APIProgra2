public interface IActividadService
{
  public IEnumerable<Actividad> GetAll();
  public Actividad? GetById(int id);
  public Actividad Create(Actividad a);
  public bool Delete(int id);
  public Actividad? Update(int id, Actividad a);
  
}