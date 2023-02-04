using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Almacen
    {
        public int IdAlmacen { get; set; }
        public string NombreAlmacen { get; set; } = null!;
        public string? Ubicacion { get; set; }
        public string? Capacidad { get; set; }
        public int? Total { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string Estado { get; set; } = null!;
    }
}
