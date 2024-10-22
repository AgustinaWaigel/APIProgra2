
using Microsoft.AspNetCore.Mvc;
    


[ApiController]
[Route("api/actividades")]
public class ActividadController : ControllerBase {
    private readonly IActividadService _actividadService;

  public ActividadController(IActividadService actividadService)
  {
    _actividadService = actividadService;
  }

  [HttpGet]
  public ActionResult<List<Actividad>> GetAllAutores(){

    return Ok(_actividadService.GetAll());
  }
  



}
