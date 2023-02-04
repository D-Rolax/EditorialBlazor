using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class DetallePedido
    {
        public int? IdAlmacen { get; set; }
        public int? IdPromotor { get; set; }
        public int? Cantidad { get; set; }

        public virtual Almacen? IdAlmacenNavigation { get; set; }
        public virtual Promotor? IdPromotorNavigation { get; set; }
    }
}
