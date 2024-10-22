public interface IRegistroService
{
  public IEnumerable<Registro> GetAll();
  public Registro? GetById(int id);
  public Registro Create(Registro r);
  public bool Delete(int id);
  public Registro? Update(int id, Registro r);
  
}