
using Microsoft.EntityFrameworkCore;
using task.Data;

namespace task
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Services.BuildServiceProvider().GetService<IConfiguration>();
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(x => {
            x.AddPolicy("cors",c => {
                c.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });
            });

            builder.Services.AddDbContext<ApplicationContext>(conf =>
            {
                conf.UseSqlServer(builder.Configuration.GetConnectionString("default"));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.UseCors("cors");

            app.Run();
        }
    }
}
