using API_BodegasUbicaciones.BL.Models;
using Microsoft.EntityFrameworkCore;

namespace API_BodegasUbicaciones.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() { }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbContext DbContext { set; get; }

        public DbSet<CATEGORIAPRODUCTOS> CATEGORIAPRODUCTOS { get; set; }
        public DbSet<CATEGORIASEMPLEADOS> CATEGORIASEMPLEADOS { get; set; }
        public DbSet<DEPARTAMENTOS> DEPARTAMENTOS { get; set; }
        public DbSet<DETALLEDOCUMENTOENTRADA> DETALLEDOCUMENTOENTRADA { get; set; }
        public DbSet<DETALLEDOCUMENTOSALIDA> DETALLEDOCUMENTOSALIDA { get; set; }
        public DbSet<DOCUMENTOENTRADA> DOCUMENTOENTRADA { get; set; }
        public DbSet<DOCUMENTOSALIDA> DOCUMENTOSALIDA { get; set; }
        public DbSet<EMPLEADOS> EMPLEADOS { get; set; }
        public DbSet<INVENTARIOS> INVENTARIOS { get; set; }
        public DbSet<MARCASPRODUCTOS> MARCASPRODUCTOS { get; set; }
        public DbSet<MOVIMIENTOSLOG> MOVIMIENTOSLOG { get; set; }
        public DbSet<MUNICIPIOS> MUNICIPIOS { get; set; }
        public DbSet<PRODUCTOS> PRODUCTOS { get; set; }
        public DbSet<PROVEEDORES> PROVEEDORES { get; set; }
        public DbSet<TIPOSDOCUMENTOS> TIPOSDOCUMENTOS { get; set; }
        public DbSet<TIPOSMOVIMIENTOS> TIPOSMOVIMIENTOS { get; set; }
        public DbSet<UBICACIONES> UBICACIONES { get; set; }
        public DbSet<USUARIOS> USUARIOS { get; set; }

        //Aqui iran los models de los SP que retornen informacion
    }
}
