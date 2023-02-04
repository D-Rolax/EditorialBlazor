using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            Encargados = new HashSet<Encargado>();
        }

        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string? Direccion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<Encargado> Encargados { get; set; }
    }
}
