using Microsoft.EntityFrameworkCore;
using System;

using WebApplicationProjetFinal.AppData;
using WebApplicationProjetFinal.AppData.Cart;
using WebApplicationProjetFinal.AppData.Services;


namespace WebApplicationProjetFinal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MaConnexion")));

            builder.Services.AddScoped<IMeubleService, MeubleService>();

            builder.Services.AddScoped<IClientService, ClientService>();

            builder.Services.AddScoped<IOrdersService, OrdersService>();

            builder.Services.AddScoped<IContactService, ContactService>();

            //Service pour gestion du panier
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));

            //builder.Services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));


           // builder.Services.AddHttpContextAccessor();
            




            builder.Services.AddSession();


            // Add services to the container.
            builder.Services.AddControllersWithViews();

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


            app.UseSession();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Pageprincipal}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
