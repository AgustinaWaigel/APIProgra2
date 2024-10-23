
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/registros")]
public class RegistroController : ControllerBase
{
    private readonly IRegistroService _registroService;
    private readonly IActividadService _actividadService;

    public RegistroController(IRegistroService registroService, IActividadService actividadService)
    {
      _registroService = registroService;
      _actividadService = actividadService;
    }

    [HttpGet]
    public ActionResult<List<Registro>> GetAll()
    {
      try
      {
        return Ok(_registroService.GetAll());
      }
      catch (System.Exception e)
      {
        Console.WriteLine(e.Message);
        return Problem(detail: e.Message, statusCode: 500);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Registro> GetById(int id)
    {
      Registro? registro = _registroService.GetById(id);
      if ( registro is null ) return NotFound();
      return Ok(registro);
    }

    [HttpPost]
    public ActionResult<Registro> NuevoRegistro(RegistroDTO r)
    {
      Registro registro = _registroService.Create(r);
      return CreatedAtAction(nameof(GetById), new { id = registro.Id}, registro);
    }

    [HttpPut("{id}")]
    public ActionResult<Registro> Update(int id, RegistroDTO r)
    {
      try
      {
        Registro registro = _registroService.Update(id, r);
        if ( registro is null ) return NotFound(new {Message = $"No se pudo actualizar el registro con id: {id}"});
        return CreatedAtAction(nameof(GetById), new { id = registro.Id}, registro);
      }
      catch (System.Exception e)
      {
        Console.WriteLine(e.Message);
        return Problem(detail: e.Message, statusCode: 500);
      }
    }

    [HttpDelete]
    public ActionResult Delete(int id)
    {
      bool deleted = _registroService.Delete(id);
      if (deleted) return NoContent();
      return NotFound();
    }
}
