using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Direccion
    {
        public Direccion()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdDireccion { get; set; }
        public string Calle { get; set; } = null!;
        public string NumeroExterior { get; set; } = null!;
        public string? NumeroInterior { get; set; }
        public int? IdColonia { get; set; }

        public virtual Colonium? IdColoniaNavigation { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
