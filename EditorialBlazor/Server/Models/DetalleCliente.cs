using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class DetalleCliente
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual VentaDirectum IdVentaNavigation { get; set; } = null!;
    }
}
