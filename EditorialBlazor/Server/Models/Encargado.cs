using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Encargado
    {
        public int IdEncargado { get; set; }
        public int IdSucursal { get; set; }
        public int IdCargo { get; set; }
        public string Nombres { get; set; } = null!;
        public string? Apellidos { get; set; }
        public int? Ci { get; set; }
        public string? DocumentosGarantes { get; set; }
        public string? Direccion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Estado { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; } = null!;
        public virtual Sucursal IdSucursalNavigation { get; set; } = null!;
    }
}
