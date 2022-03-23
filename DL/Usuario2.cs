using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Usuario2
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string ApellidoPaterno { get; set; } = null!;
        public string ApellidoMaterno { get; set; } = null!;
        public string? Username { get; set; }
        public int? IdRol { get; set; }
    }
}
