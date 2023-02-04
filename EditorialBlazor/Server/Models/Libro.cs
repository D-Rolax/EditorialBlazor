using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Libro
    {
        public int IdLibros { get; set; }
        public string NombreTexto { get; set; } = null!;
        public string Curso { get; set; } = null!;
        public string Nivel { get; set; } = null!;
        public int? AñoEdicion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string Estado { get; set; } = null!;
    }
}
