using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult GetAll()
        {
            ML.Alumno alumno = new ML.Alumno();

            ML.Result resultAlumno = BL.Alumno.GetAll();

            alumno.Alumnos = resultAlumno.Objects;

            return View(alumno);
        }

        public IActionResult Form(int? IdAlumno)
        {
            ML.Alumno alumno = new ML.Alumno();

                ML.Result resultAlumno = BL.Alumno.GetById(1);

            //alumno.Alumnos = resultAlumno.Objects;

            return View(alumno);
        }


    }
}
