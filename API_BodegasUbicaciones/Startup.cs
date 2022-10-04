using API_BodegasUbicaciones.BL.DAO;
using API_BodegasUbicaciones.BL.Implements;
using API_BodegasUbicaciones.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API_BodegasUbicaciones
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //Este metodo lo he editado yo, para poder acceder al DbContext
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddHttpContextAccessor();
            //services.AddDbContext<ApplicationDBContext>(opts => opts.UseMySQL(Configuration["ConnectionStrings:MOLSAL_COMPRAS"]));
            services.AddDbContext<ApplicationDBContext>(opts => opts.UseSqlServer(Configuration["ConnectionStrings:GESTIONUBICACIONES"]));

            //Todo esto pertenece a la Inyeccion de dependencias
            services.AddScoped<CategoriaProductosDAO, CategoriaProductosImplement>();
            services.AddScoped<CategoriasEmpleadosDAO, CategoriasEmpleadosImplement>();
            services.AddScoped<DepartamentosDAO, DepartamentosImplement>();
            services.AddScoped<DetalleDocumentoEntradaDAO, DetalleDocumentoEntradaImplement>();
            services.AddScoped<DetalleDocumentoSalidaDAO, DetalleDocumentosSalidaImplement>();
            services.AddScoped<DocumentoEntradaDAO, DocumentoEntradaImplement>();
            services.AddScoped<DocumentoSalidaDAO, DocumentoSalidaImplement>();
            services.AddScoped<EmpleadosDAO, EmpleadosImplement>();
            services.AddScoped<InventariosDAO, InventariosImplement>();
            services.AddScoped<MarcasProductosDAO, MarcasProductosImplement>();
            services.AddScoped<MovimientosLogDAO, MovimientosLogImplement>();
            services.AddScoped<MunicipiosDAO, MunicipiosImplement>();
            services.AddScoped<ProductosDAO, ProductosImplement>();
            services.AddScoped<ProveedoresDAO, ProveedoresImplement>();
            services.AddScoped<TiposDocumentosDAO, TiposDocumentosImplement>();
            services.AddScoped<TiposMovimientosDAO, TiposMovimientosImplement>();
            services.AddScoped<UbicacionesDAO, UbicacionesImplement>();
            services.AddScoped<UsuariosDAO, UsuariosImplement>();

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
            });
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("AllowOrigin");

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
