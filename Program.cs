using marlin_challenge_back_end.Data;
using marlin_challenge_back_end.Repositories;
using marlin_challenge_back_end.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace marlin_challenge_back_end
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

            builder.Services.AddEntityFrameworkSqlServer().AddDbContext<MarlinDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")
            ));

            builder.Services.AddScoped<IPostRepository, PostRepository>();

            builder.Services.AddCors();

            var app = builder.Build();

          
            app.UseCors(options =>
            {
                options.WithOrigins("https://marlin-challenge-npeemqyzx-silassousadejesus.vercel.app").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            });

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}