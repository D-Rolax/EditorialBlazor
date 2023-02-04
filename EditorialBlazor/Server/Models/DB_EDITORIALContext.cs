using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EditorialBlazor.Server.Models
{
    public partial class DB_EDITORIALContext : DbContext
    {
        public DB_EDITORIALContext()
        {
        }

        public DB_EDITORIALContext(DbContextOptions<DB_EDITORIALContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Almacen> Almacens { get; set; } = null!;
        public virtual DbSet<Amortizacion> Amortizacions { get; set; } = null!;
        public virtual DbSet<Cargo> Cargos { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Colegio> Colegios { get; set; } = null!;
        public virtual DbSet<Contrato> Contratos { get; set; } = null!;
        public virtual DbSet<DetalleCliente> DetalleClientes { get; set; } = null!;
        public virtual DbSet<DetalleContrato> DetalleContratos { get; set; } = null!;
        public virtual DbSet<DetalleDecremento> DetalleDecrementos { get; set; } = null!;
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; } = null!;
        public virtual DbSet<DetallePromotor> DetallePromotors { get; set; } = null!;
        public virtual DbSet<Encargado> Encargados { get; set; } = null!;
        public virtual DbSet<Envio> Envios { get; set; } = null!;
        public virtual DbSet<Incremento> Incrementos { get; set; } = null!;
        public virtual DbSet<Inventario> Inventarios { get; set; } = null!;
        public virtual DbSet<Libro> Libros { get; set; } = null!;
        public virtual DbSet<Profesor> Profesors { get; set; } = null!;
        public virtual DbSet<Promotor> Promotors { get; set; } = null!;
        public virtual DbSet<Sucursal> Sucursals { get; set; } = null!;
        public virtual DbSet<VentaDirectum> VentaDirecta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
  //              optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=DB_EDITORIAL; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacen>(entity =>
            {
                entity.HasKey(e => e.IdAlmacen)
                    .HasName("PK__ALMACEN__7339837BB181E07C");

                entity.ToTable("ALMACEN");

                entity.Property(e => e.Capacidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreAlmacen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_almacen");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Amortizacion>(entity =>
            {
                entity.HasKey(e => e.IdAmortizacion)
                    .HasName("PK__AMORTIZA__8D928C9883B53E1A");

                entity.ToTable("AMORTIZACION");

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Monto).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.IdProfesorNavigation)
                    .WithMany(p => p.Amortizacions)
                    .HasForeignKey(d => d.IdProfesor)
                    .HasConstraintName("FK__AMORTIZAC__IdPro__628FA481");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.IdCargo)
                    .HasName("PK__CARGO__6C985625983EEE6E");

                entity.ToTable("CARGO");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Funciones)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Puesto)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__CLIENTE__D5946642A6112BAD");

                entity.ToTable("CLIENTE");

                entity.Property(e => e.Curso)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nivel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_completo");
            });

            modelBuilder.Entity<Colegio>(entity =>
            {
                entity.HasKey(e => e.IdColegio)
                    .HasName("PK__COLEGIO__BECA3289F71F893C");

                entity.ToTable("COLEGIO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Establecimiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Niveles)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Turno)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contrato>(entity =>
            {
                entity.HasKey(e => e.IdContrato)
                    .HasName("PK__CONTRATO__8569F05AF98484A4");

                entity.ToTable("CONTRATO");

                entity.HasIndex(e => e.NumContrato, "UQ__CONTRATO__3DFFCA2B2859ECF5")
                    .IsUnique();

                entity.Property(e => e.DuedaTotal)
                    .HasColumnType("decimal(7, 4)")
                    .HasColumnName("Dueda_total");

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdPromotorNavigation)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.IdPromotor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONTRATO__IdProm__4D94879B");
            });

            modelBuilder.Entity<DetalleCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DETALLE_CLIENTE");

                entity.Property(e => e.Precio).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Total).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DETALLE_C__IdCli__403A8C7D");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DETALLE_C__IdVen__3F466844");
            });

            modelBuilder.Entity<DetalleContrato>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DETALLE_CONTRATO");

                entity.Property(e => e.Precio).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Total).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdContrato)
                    .HasConstraintName("FK__DETALLE_C__Total__571DF1D5");

                entity.HasOne(d => d.IdProfesorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProfesor)
                    .HasConstraintName("FK__DETALLE_C__IdPro__5812160E");
            });

            modelBuilder.Entity<DetalleDecremento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DETALLE_DECREMENTO");

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdIncrementoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdIncremento)
                    .HasConstraintName("FK__DETALLE_D__IdInc__5EBF139D");

                entity.HasOne(d => d.IdProfesorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProfesor)
                    .HasConstraintName("FK__DETALLE_D__IdPro__5DCAEF64");
            });

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DETALLE_PEDIDO");

                entity.HasOne(d => d.IdAlmacenNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdAlmacen)
                    .HasConstraintName("FK__DETALLE_P__IdAlm__44FF419A");

                entity.HasOne(d => d.IdPromotorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPromotor)
                    .HasConstraintName("FK__DETALLE_P__IdPro__45F365D3");
            });

            modelBuilder.Entity<DetallePromotor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DETALLE_PROMOTOR");

                entity.Property(e => e.Precio).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Total).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.IdPromotorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPromotor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DETALLE_P__IdPro__48CFD27E");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DETALLE_P__IdVen__47DBAE45");
            });

            modelBuilder.Entity<Encargado>(entity =>
            {
                entity.HasKey(e => e.IdEncargado)
                    .HasName("PK__ENCARGAD__EDCB90EA26233DCF");

                entity.ToTable("ENCARGADOS");

                entity.HasIndex(e => e.Ci, "UQ__ENCARGAD__32149A5A3C6E2500")
                    .IsUnique();

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentosGarantes)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Documentos_garantes");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Encargados)
                    .HasForeignKey(d => d.IdCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENCARGADO__IdCar__37A5467C");

                entity.HasOne(d => d.IdSucursalNavigation)
                    .WithMany(p => p.Encargados)
                    .HasForeignKey(d => d.IdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENCARGADO__Estad__36B12243");
            });

            modelBuilder.Entity<Envio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ENVIOS");

                entity.HasOne(d => d.IdAlmacenNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENVIOS__Cantidad__2E1BDC42");

                entity.HasOne(d => d.IdSucursalNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENVIOS__IdSucurs__2F10007B");
            });

            modelBuilder.Entity<Incremento>(entity =>
            {
                entity.HasKey(e => e.IdIncremento)
                    .HasName("PK__INCREMEN__EC4C07DA2F542A76");

                entity.ToTable("INCREMENTO");

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INVENTARIO");

                entity.HasOne(d => d.IdAlmacenNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INVENTARI__IdAlm__29572725");

                entity.HasOne(d => d.IdLibrosNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdLibros)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INVENTARI__IdLib__286302EC");
            });

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(e => e.IdLibros)
                    .HasName("PK__LIBROS__153221F3DD875953");

                entity.ToTable("LIBROS");

                entity.Property(e => e.AñoEdicion).HasColumnName("Año_edicion");

                entity.Property(e => e.Curso)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nivel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTexto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_texto");
            });

            modelBuilder.Entity<Profesor>(entity =>
            {
                entity.HasKey(e => e.IdProfesor)
                    .HasName("PK__PROFESOR__C377C3A10A895676");

                entity.ToTable("PROFESOR");

                entity.HasIndex(e => e.Ci, "UQ__PROFESOR__32149A5A2A4F29E6")
                    .IsUnique();

                entity.Property(e => e.ApellidoProf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Asignatura)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreProf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdColegioNavigation)
                    .WithMany(p => p.Profesors)
                    .HasForeignKey(d => d.IdColegio)
                    .HasConstraintName("FK__PROFESOR__IdCole__5535A963");
            });

            modelBuilder.Entity<Promotor>(entity =>
            {
                entity.HasKey(e => e.IdPromotor)
                    .HasName("PK__PROMOTOR__31FDF22F48A78E14");

                entity.ToTable("PROMOTOR");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.HasKey(e => e.IdSucursal)
                    .HasName("PK__SUCURSAL__BFB6CD993ABEE839");

                entity.ToTable("SUCURSAL");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreSucursal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_sucursal");
            });

            modelBuilder.Entity<VentaDirectum>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PK__VENTA_DI__BC1240BD032FB0CE");

                entity.ToTable("VENTA_DIRECTA");

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NroRecibo).HasColumnName("Nro_recibo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
