using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class DetalleContrato
    {
        public int? IdContrato { get; set; }
        public int? IdProfesor { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Total { get; set; }

        public virtual Contrato? IdContratoNavigation { get; set; }
        public virtual Profesor? IdProfesorNavigation { get; set; }
    }
}
