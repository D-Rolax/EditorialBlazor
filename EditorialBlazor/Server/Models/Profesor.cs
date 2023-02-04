using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Profesor
    {
        public Profesor()
        {
            Amortizacions = new HashSet<Amortizacion>();
        }

        public int IdProfesor { get; set; }
        public int? IdColegio { get; set; }
        public string NombreProf { get; set; } = null!;
        public string? ApellidoProf { get; set; }
        public int? Ci { get; set; }
        public string? Asignatura { get; set; }
        public int Celular { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Estado { get; set; }

        public virtual Colegio? IdColegioNavigation { get; set; }
        public virtual ICollection<Amortizacion> Amortizacions { get; set; }
    }
}
