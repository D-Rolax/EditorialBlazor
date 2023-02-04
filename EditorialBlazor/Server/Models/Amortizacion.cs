using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Amortizacion
    {
        public int IdAmortizacion { get; set; }
        public int? IdProfesor { get; set; }
        public int NumContrato { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Estado { get; set; }

        public virtual Profesor? IdProfesorNavigation { get; set; }
    }
}
