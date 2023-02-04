using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Contrato
    {
        public int IdContrato { get; set; }
        public int IdPromotor { get; set; }
        public int NumContrato { get; set; }
        public decimal? DuedaTotal { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Estado { get; set; }

        public virtual Promotor IdPromotorNavigation { get; set; } = null!;
    }
}
