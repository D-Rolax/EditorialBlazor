using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public int? Ci { get; set; }
        public string? Curso { get; set; }
        public string? Nivel { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Estado { get; set; }
    }
}
