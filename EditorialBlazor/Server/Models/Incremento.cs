using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Incremento
    {
        public int IdIncremento { get; set; }
        public int NumContrato { get; set; }
        public string? Tipo { get; set; }
        public int Total { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Estado { get; set; }
    }
}
