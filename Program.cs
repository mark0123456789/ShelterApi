using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using ShelterApi.Models;

namespace ShelterApi
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AnimalshelterContext>(options =>
                options.UseMySQL(
                    builder.Configuration.GetConnectionString("Mysql")!
                )
            );

            builder.Services.AddControllers();

            builder.Services.AddOpenApi();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}