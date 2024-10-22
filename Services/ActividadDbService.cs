using Microsoft.EntityFrameworkCore;
public class ActividadDbService : IActividadService
{

    private readonly RegistroContext _context;

    public ActividadDbService(RegistroContext context)
    {
        _context = context;
    }


    public Actividad Create(Actividad a)
    {
        Actividad actividad = new()
        {
            Id = a.Id,
            Nombre = a.Nombre
        };
        _context.Actividades.Add(actividad);
        _context.SaveChanges();
       return actividad;
        
    }

    public bool Delete(int id)
    {
        Actividad? a = _context.Actividades.Find(id);
        if (a is null) return false;

        _context.Actividades.Remove(a);
        _context.SaveChanges();
        return true;
    }

    public IEnumerable<Actividad> GetAll()
    {
         return _context.Actividades;
    }

    public Actividad? GetById(int id)
    {
        return _context.Actividades.Find(id);
    }

    public Actividad? Update(int id, ActividadDTO a)
    {
        var actividadUpdate = _context.Actividades.FirstOrDefault(l => a.Id == id);
        Console.WriteLine(actividadUpdate.Id);
        actividadUpdate.Nombre = a.Nombre;

        _context.Entry(actividadUpdate).State = EntityState.Modified;
        _context.SaveChanges();
        return actividadUpdate;       
    }

    public Actividad? Update(int id, Actividad a)
    {
        throw new NotImplementedException();
    }

    
}