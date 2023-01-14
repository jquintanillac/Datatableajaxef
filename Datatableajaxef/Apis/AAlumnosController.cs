using Datatableajaxef.Data.Entities;
using Datatableajaxef.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Datatableajaxef.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class AAlumnosController : ControllerBase
    {
        IAlumnoServices _alumnos;
        public AAlumnosController(IAlumnoServices alumnos)
        {
            _alumnos = alumnos;
        }

        // GET: api/<AAlumnosController>
        [HttpGet]
        public async Task<List<AlumnosEnty>> GetAll()
        {
            return await _alumnos.GetAll();
        }

        // POST api/<AAlumnosController>
        [HttpPost]
        public void Post([FromForm] AlumnosEnty oAlumno)
        {
            if(oAlumno.id_alumno == 0)
            {
                _alumnos.Save(oAlumno);
            }
            else
            {
                _alumnos.Update(oAlumno);
            }
        }

        // DELETE api/<AAlumnosController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return await _alumnos.Delete(id);
        }
    }
}
