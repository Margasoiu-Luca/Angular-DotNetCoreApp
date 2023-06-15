
using ASP.NET_Core_API.Infrastructure;
using AutoMapper;
using Iss.AvanMagazinOnline.DB.CRUD;
using Iss.AvanMagazinOnline.DB.Interfaces;
using Iss.AvanMagazinOnline.DB.Models;

namespace ASP.NET_Core_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  policy =>
                                  {
                                      policy.WithOrigins("http://localhost:4200/")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod(); ;
                                  });
            });

            builder.Services.AddScoped<IDBCrud<Produs, int>, ProdusCRUD>();
            builder.Services.AddScoped<IDBCrud<Producator, int>, ProducatorCRUD>();
            builder.Services.AddScoped<IDBCrud<CategorieProdus, int>, CategorieProdusCrud>();
            builder.Services.AddScoped<IDBCrud<Cumparator, int>, CumparatorCRUD>();
            builder.Services.AddScoped<IDBCrud<ProdusStoc, int>, ProdusStocCRUD>();
            builder.Services.AddScoped<IDBCrud<Comanda, int>, ComandaCRUD>();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperConfiguration());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            builder.Services.AddSingleton(mapper);




            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials()); // allow credentials

            app.MapControllers();

            app.Run();
        }
    }
}