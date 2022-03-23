using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public class Alumno
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JTorresProgramacionNCapas08122021Context context = new DL.JTorresProgramacionNCapas08122021Context())
                {
                    var query = context.Alumnos.FromSqlRaw("AlumnoGetAll").ToList();

                    result.Objects = new List<object>();
                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Alumno alumno = new ML.Alumno();
                            alumno.IdAlumno = obj.IdAlumno;
                            alumno.Nombre = obj.Nombre;
                            alumno.ApellidoPaterno = obj.ApellidoPaterno;
                            alumno.ApellidoMaterno = obj.ApellidoMaterno;

                            result.Objects.Add(alumno);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se ha podido realizar la consulta";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
        public static ML.Result GetById(int IdAlumno)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.JTorresProgramacionNCapas08122021Context context = new DL.JTorresProgramacionNCapas08122021Context())
                {
                    var query = context.Alumnos.FromSqlRaw($"AlumnoGetById {IdAlumno}").AsEnumerable().FirstOrDefault();
                    result.Object = new List<object>();

                    if (query != null)
                    {
                        //foreach (var obj in query)
                        //{
                        //    ML.Alumno alumno = new ML.Alumno();
                        //    alumno.IdAlumno = obj.IdAlumno;
                        //    alumno.Nombre = obj.Nombre;
                        //    alumno.ApellidoPaterno = obj.ApellidoPaterno;
                        //    alumno.ApellidoMaterno = obj.ApellidoMaterno;

                        //    result.Object = alumno;
                        //    result.Correct = true;
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }
        public static ML.Result Add(ML.Alumno alumno)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DL.JTorresProgramacionNCapas08122021Context context = new DL.JTorresProgramacionNCapas08122021Context())
                {

                    var query = context.Database.ExecuteSqlRaw($"AlumnoAdd {alumno.Nombre},  {alumno.ApellidoPaterno}, {alumno.ApellidoMaterno}");


                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se ha podido realizar el insert";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}