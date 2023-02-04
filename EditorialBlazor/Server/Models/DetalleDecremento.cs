using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class DetalleDecremento
    {
        public int? IdProfesor { get; set; }
        public int? IdIncremento { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Estado { get; set; }

        public virtual Incremento? IdIncrementoNavigation { get; set; }
        public virtual Profesor? IdProfesorNavigation { get; set; }
    }
}
