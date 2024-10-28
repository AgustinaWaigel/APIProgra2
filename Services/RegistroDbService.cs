
using Microsoft.EntityFrameworkCore;

public class RegistroDbService : IRegistroService {

  private readonly RegistroContext _context;

  public RegistroDbService(RegistroContext context)
  {
    _context = context;
  }

    public Registro Create(RegistroDTO r)
    {
        var nuevoRegistro = new Registro
        {
            Actividad = r.Actividad,
            Fecha = (DateTime)r.Fecha,
            Duracion = (float)r.Duracion,
            Distancia = (float)r.Distancia



        };
        _context.Add(nuevoRegistro);
        _context.SaveChanges();
        return nuevoRegistro;
        
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

    public Registro? Update(int id, RegistroDTO r)
    {
        var registroUpdate = _context.Registros.FirstOrDefault(l => r.Id == id);
        Console.WriteLine(registroUpdate.Id);
        registroUpdate.Actividad = r.Actividad;
        registroUpdate.Fecha = (DateTime)r.Fecha;
        registroUpdate.Duracion = (float)r.Duracion;
        registroUpdate.Distancia = (float)r.Distancia;
        
        //_context.Registros.Update(registroUpdate);
        _context.Entry(registroUpdate).State = EntityState.Modified;
        _context.SaveChanges();
        return registroUpdate;
    }


}