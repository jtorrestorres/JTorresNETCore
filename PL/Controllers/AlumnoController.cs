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

        public static byte[] ConvertToBytes(IFormFile imagen)
        {

            using var fileStream = imagen.OpenReadStream();
            
            byte[] bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, (int)fileStream.Length);

            return bytes;
        }
        [HttpPost]
        public IActionResult Form(ML.Alumno alumno)
        {      
            //IFormFile
            IFormFile imagen = Request.Form.Files["fuImagenName"];
            alumno.Imagen= ConvertToBytes(imagen);


            //{ Microsoft.AspNetCore.Http.FormFile}

            ML.Result resultAlumno = BL.Alumno.Add(alumno);

            //alumno.Alumnos = resultAlumno.Objects;

            return View(alumno);
        }


    }
}
