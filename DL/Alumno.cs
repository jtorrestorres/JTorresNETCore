using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DL
{
    public partial class Alumno
    {
        public int IdAlumno { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public byte[]? Imagen { get; set; }                
        public string? SemestreNombre { get; set; }
        public byte? IdSemestre { get; set; }


    }
}
