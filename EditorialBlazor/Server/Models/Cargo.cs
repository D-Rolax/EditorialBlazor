using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Cargo
    {
        public Cargo()
        {
            Encargados = new HashSet<Encargado>();
        }

        public int IdCargo { get; set; }
        public string Puesto { get; set; } = null!;
        public string? Funciones { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Encargado> Encargados { get; set; }
    }
}
