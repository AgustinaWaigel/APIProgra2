
public class RegistroDbService : IRegistroService {

  private readonly RegistroContext _context;

  public RegistroDbService(RegistroContext context)
  {
    _context = context;
  }

    public Registro Create(Registro r)
    {
        Registro registros = new(){
            Id = r.Id,
            Actividad = r.Actividad,
            Fecha = r.Fecha,
            Duracion = r.Duracion,
            Distancia = r.Distancia



        };
        _context.Add(registros);
        _context.SaveChanges();
        return registros;
        
    }

    public bool Delete(int id)
    {
        Registro? a = _context.Registros.Find(id);
        if (a == null){
            return false;
        }
        _context.Registros.Remove(a);
        _context.SaveChanges();
        return true;
    }

    public IEnumerable<Registro> GetAll()
    {
        return _context.Registros;
    }

    public Registro? GetById(int id)
    {
        return _context.Registros.Find(id);
    }

    public Registro? Update(int id, Registro r)
    {
        var registroUpdate = _context.Registros.FirstOrDefault(l => r.Id == id);
        Console.WriteLine(registroUpdate.Id);
        registroUpdate.Actividad = r.Actividad;
        registroUpdate.Fecha = r.Fecha;
        registroUpdate.Duracion = r.Duracion;
        registroUpdate.Distancia = r.Distancia;
        _context.Registros.Update(registroUpdate);
        _context.SaveChanges();
        return registroUpdate;
    }


}