using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class DetallePromotor
    {
        public int IdVenta { get; set; }
        public int IdPromotor { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public virtual Promotor IdPromotorNavigation { get; set; } = null!;
        public virtual VentaDirectum IdVentaNavigation { get; set; } = null!;
    }
}
