using System;
using System.Collections.Generic;

namespace EditorialBlazor.Server.Models
{
    public partial class Inventario
    {
        public int IdLibros { get; set; }
        public int IdAlmacen { get; set; }
        public int Cantidad { get; set; }

        public virtual Almacen IdAlmacenNavigation { get; set; } = null!;
        public virtual Libro IdLibrosNavigation { get; set; } = null!;
    }
}
