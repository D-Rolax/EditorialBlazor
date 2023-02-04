using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Promotor
    {
        public Promotor()
        {
            Contratos = new HashSet<Contrato>();
        }

        public int IdPromotor { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public int? Ci { get; set; }
        public int Celular { get; set; }
        public string? Direccion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string Estado { get; set; } = null!;

        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}
