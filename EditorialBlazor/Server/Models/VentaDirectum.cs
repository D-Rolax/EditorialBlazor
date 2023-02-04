using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class VentaDirectum
    {
        public int IdVenta { get; set; }
        public int IdAlmacen { get; set; }
        public int? NroRecibo { get; set; }
        public int? Total { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Estado { get; set; }
    }
}
