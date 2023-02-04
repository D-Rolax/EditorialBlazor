using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Colegio
    {
        public Colegio()
        {
            Profesors = new HashSet<Profesor>();
        }

        public int IdColegio { get; set; }
        public string? Establecimiento { get; set; }
        public string? Tipo { get; set; }
        public string? Niveles { get; set; }
        public string? Turno { get; set; }
        public string? Direccion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<Profesor> Profesors { get; set; }
    }
}
