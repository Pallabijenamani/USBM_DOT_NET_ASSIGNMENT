using assignment_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace assignment_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<LibraryDbContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Data Source=ABHI\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Book}/{action=Showdata}/{id?}");

            app.Run();
        }
    }
}
