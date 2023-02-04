using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Envio
    {
        public int IdAlmacen { get; set; }
        public int IdSucursal { get; set; }
        public int Cantidad { get; set; }

        public virtual Almacen IdAlmacenNavigation { get; set; } = null!;
        public virtual Sucursal IdSucursalNavigation { get; set; } = null!;
    }
}
